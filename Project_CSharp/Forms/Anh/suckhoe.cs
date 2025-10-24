using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Anh
{
    public partial class suckhoe: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public suckhoe()
        {
            InitializeComponent();
            loadsinhvien();
            loadhososuckhoe();
        }
        private void loadsinhvien()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "select idsinhvien, masinhvien, hoten from sinhvien"; // chọn rõ ràng
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            // Tạo dòng trống để làm dòng "Chọn sinh viên"
            DataRow r = tb.NewRow();
            r["idsinhvien"] = DBNull.Value; // hoặc DBNull.Value
            r["masinhvien"] = "<-- Chọn id -->";

            tb.Rows.InsertAt(r, 0);

            // Gán dữ liệu cho ComboBox
            cbmasv.DataSource = tb;
            cbmasv.ValueMember = "idsinhvien";
            cbmasv.DisplayMember = "idsinhvien";



            searchmsv.DataSource = tb;
            searchmsv.ValueMember = "idsinhvien";
            searchmsv.DisplayMember = "idsinhvien";
        }
        private void loadhososuckhoe()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select hs.idhosuckhoe, hs.idsinhvien, hs.vande, hs.dieutri, hs.ngay " +
                "from hososuckhoe hs " +
                "Join sinhvien sv on hs.idsinhvien = sv.idsinhvien";
            // lay them lop
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        public bool checktrungmasv(string masv)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "Select count (*) from hososuckhoe Where idsinhvien= '" + masv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
                return true; //trung ma 
            else
                return false;//khong trung 
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void suckhoe_Load(object sender, EventArgs e)
        {
            loadhososuckhoe();
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string masv = cbmasv.SelectedValue.ToString();
            string vande = txtvande.Text.Trim();
            string dieutri = txtdieutri.Text.Trim();
            DateTime ngay = txtngay.Value;

            if (checktrungmasv(masv))
            {
                MessageBox.Show("Trùng mã sinh viên.");
                cbmasv.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO hocbong VALUES ( @msv, @vande, @dieutri, @ngay)";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@msv", masv);
                com.Parameters.AddWithValue("@vande", vande);
                com.Parameters.AddWithValue("@dieutri", dieutri);
                com.Parameters.AddWithValue("@ngay", ngay);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                loadhososuckhoe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string masv = cbmasv.SelectedValue.ToString();
            string vande = txtvande.Text.Trim();
            string dieutri = txtdieutri.Text.Trim();
            DateTime ngay = txtngay.Value;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE hososuckhoe SET  vande = @vande, dieutri = @dieutri, ngay = @ngay WHERE idsinhvien = @msv";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@msv", masv);
                com.Parameters.AddWithValue("@vande", vande);
                com.Parameters.AddWithValue("@dieutri", dieutri);
                com.Parameters.AddWithValue("@ngay", ngay);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    loadhososuckhoe();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hồ sơ cần cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string masv = cbmasv.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM hososuckhoe WHERE idsinhvien = @msv";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@msv", masv);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    loadhososuckhoe();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ để xoá.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timkiem_Click(object sender, EventArgs e)
        {
            string dieutri = searchdieutri.Text != null ? searchdieutri.Text.Trim() : "";
            string msv = searchmsv.SelectedValue != null ? searchmsv.SelectedValue.ToString() : "";
            string vande = searchvande.Text != null ? searchvande.Text.Trim() : "";

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT * FROM hososuckhoe WHERE 1=1";
                if (dieutri != null && dieutri != "")
                {
                    sql += "AND dieutri LIKE @dieutri";
                }
                if (msv != null && msv != "")
                {
                    sql += "AND idsinhvien = @msv";
                }
                if (vande != null && vande != "")
                {
                    sql += "AND vande LIKE @vande";
                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dieutri", "%" + dieutri + "%");
                cmd.Parameters.AddWithValue("@msv", msv);
                cmd.Parameters.AddWithValue("@vande", "%" + vande + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {

                cbmasv.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtvande.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdieutri.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtngay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "DANH SACH HO SO SUC KHOE";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MA HO SO";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "MA SINH VIEN";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "VAN DE";
            cl3.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "DIEU TRI";
            cl4.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "NGAY";
            cl5.ColumnWidth = 25.0;






            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)
                    if (c == 5)
                    {
                        arr[r, c] = "'" + dr[c];
                    }
                    else
                    {
                        arr[r, c] = dr[c];
                    }

            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            Microsoft.Office.Interop.Excel.Range cl_ngs = oSheet.get_Range("E" + rowStart, "E" + rowEnd);
            cl_ngs.Columns.NumberFormat = "dd/mm/yyyy";
        }

        private void Xuat_Click(object sender, EventArgs e)
        {
            string msv = cbmasv.SelectedValue.ToString();
            string vande = txtvande.Text.Trim();
            string dieutri = txtdieutri.Text.Trim();
            DateTime ngay = txtngay.Value;


            string sql = "SELECT * FROM hososuckhoe";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            ExportExcel(tb, "DSHSSK");
        }

        private void ReadExcel(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Chưa chọn file");
                return;
            }

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = Excel.Workbooks.Open(filename);

            try
            {
                foreach (Microsoft.Office.Interop.Excel.Worksheet wsheet in workbook.Worksheets)
                {
                    int i = 2;  // Bắt đầu đọc từ dòng 2 (bỏ dòng tiêu đề)
                    while (!IsRowEmpty(wsheet, i))
                    {
                        // Xử lý ngày sinh (cột 4 - NGÀY SINH)
                        object cellValue = wsheet.Cells[i, 5].Value;
                        DateTime ngay;

                        if (cellValue == null)
                        {
                            ngay = DateTime.MinValue; // Gán giá trị mặc định nếu trống
                        }
                        else if (cellValue is DateTime)
                        {
                            ngay = (DateTime)cellValue;
                        }
                        else if (cellValue is double)
                        {
                            ngay = DateTime.FromOADate((double)cellValue);
                        }
                        else
                        {
                            DateTime.TryParse(cellValue.ToString(), out ngay);
                        }



                        // Đưa dữ liệu vào DB
                        Themmoihssuckhoe(
                            GetCellString(wsheet.Cells[i, 1].Value),
                            GetCellString(wsheet.Cells[i, 2].Value),
                            GetCellString(wsheet.Cells[i, 3].Value),

                            ngay
                        );

                        i++; // Chuyển sang dòng tiếp theo
                    }
                }
            }
            finally
            {
                // Đóng Workbook và Application
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }
                if (Excel != null)
                {
                    Excel.Quit();
                    Marshal.ReleaseComObject(Excel);
                }

                GC.Collect();  // Dọn dẹp bộ nhớ
                GC.WaitForPendingFinalizers();
            }
        }

        private void Themmoihssuckhoe(dynamic msv, dynamic vande, dynamic dieutri, DateTime ngay)
        {
            if (checktrungmasv(msv))
            {
                MessageBox.Show("Trùng mã kỷ luật.");
                cbmasv.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO kyluat VALUES (@msv, @vande, @dieutri, @ngay)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@vande", vande);
                com.Parameters.AddWithValue("@dieutri", dieutri);
                com.Parameters.AddWithValue("@ngay", ngay);

                com.ExecuteNonQuery();
                loadhososuckhoe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
            finally
            {
                con.Close();
            }
        }

        private bool IsRowEmpty(Microsoft.Office.Interop.Excel.Worksheet worksheet, int row)
        {
            for (int col = 1; col <= 6; col++) // Kiểm tra từ cột 1 đến cột 6
            {
                object value = worksheet.Cells[row, col].Value;
                if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private string GetCellString(object cellValue)
        {
            return cellValue != null ? cellValue.ToString().Trim() : string.Empty;
        }

        private void nhapexcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.csv",
                Title = "Chọn file Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ReadExcel(filePath);
                MessageBox.Show("Nhập dữ liệu từ Excel thành công!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loadhososuckhoe();
            }
        }
    }
}
