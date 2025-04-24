using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Anh
{
    public partial class hocbong : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");

        public hocbong()
        {
            InitializeComponent();
            loadsinhvien();
            loadhocbong();
        }
        private void loadsinhvien()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "select idsinhvien, hoten from sinhvien"; // chọn rõ ràng
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            // Tạo dòng trống để làm dòng "Chọn sinh viên"
            DataRow r = tb.NewRow();
            r["idsinhvien"] = 0; // hoặc DBNull.Value
            r["hoten"] = "<-- Chọn id -->";
            tb.Rows.InsertAt(r, 0);

            // Gán dữ liệu cho ComboBox
            cbmasv.DataSource = tb;
            cbmasv.ValueMember = "idsinhvien";
            cbmasv.DisplayMember = "hoten";

            searchmasv.DataSource = tb;
            searchmasv.ValueMember = "idsinhvien";
            searchmasv.DisplayMember = "hoten";
        }
        private void loadhocbong()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select hb.idhocbong, hb.idsinhvien, hb.tenhocbong,hb.sotien, hb.ngaycap " +
                "from hocbong hb " +
                "Join sinhvien sv on hb.idsinhvien = sv.idsinhvien";
            // lay them lop
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = tb;
            //dataGridView1.Refresh();

        }
        

        public bool checktrungmahb(string mahb)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT COUNT(*) FROM hocbong WHERE idhocbong = @mahb";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mahb", mahb);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            finally
            {
                con.Close();
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string mahb = txtmahb.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string tenhb = txttenhb.Text.Trim();
            string sotien = txtsotien.Text.Trim();
            DateTime ngcap = txtngcap.Value;

            if (checktrungmahb(mahb))
            {
                MessageBox.Show("Trùng mã học bổng.");
                txtmahb.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO hocbong VALUES (@mhb, @msv, @tenhb, @sotien, @ngcap)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mhb", mahb);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@tenhb", tenhb);
                com.Parameters.AddWithValue("@sotien", sotien);
                com.Parameters.AddWithValue("@ngcap", ngcap);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                loadhocbong();
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
            string mahb = txtmahb.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string tenhb = txttenhb.Text.Trim();
            string sotien = txtsotien.Text.Trim();
            DateTime ngcap = txtngcap.Value;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE hocbong SET idsinhvien = @msv, tenhocbong = @tenhb, sotien = @sotien, ngaycap = @ngcap WHERE idhocbong = @mhb";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mhb", mahb);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@tenhb", tenhb);
                com.Parameters.AddWithValue("@sotien", sotien);
                com.Parameters.AddWithValue("@ngcap", ngcap);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    loadhocbong();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã học bổng cần cập nhật.");
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
            string mahb = txtmahb.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM hocbong WHERE idhocbong = @mhb";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mhb", mahb);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    loadhocbong();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học bổng để xoá.");
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

        private void Timkiem_Click(object sender, EventArgs e)
        {
            string mahb = searchmhb.Text.Trim();
            string msv = searchmasv.SelectedValue.ToString();
            string tenhb = searchtenhb.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT * FROM hocbong WHERE idhocbong LIKE @mahb AND idsinhvien LIKE @msv AND tenhocbong LIKE @tenhb";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mahb", "%" + mahb + "%");
                cmd.Parameters.AddWithValue("@msv", "%" + msv + "%");
                cmd.Parameters.AddWithValue("@tenhb", "%" + tenhb + "%");

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

        private void hocbong_Load(object sender, EventArgs e)
        {
            loadhocbong();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtmahb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbmasv.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttenhb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsotien.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtngcap.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            }
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
            head.Value2 = "DANH SACH HOC BONG";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MA HOC BONG";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "MA SINH VIEN";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "TEN HOC BONG";
            cl3.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "SO TIEN";
            cl4.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "NGAY CAP";
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
            string mahb = txtmahb.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string tenhb = txttenhb.Text.Trim();
            string sotien = txtsotien.Text.Trim();
            DateTime ngcap = txtngcap.Value;

            string sql = "SELECT * FROM hocbong";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            ExportExcel(tb, "DSHB");
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
                        DateTime ngcap;

                        if (cellValue == null)
                        {
                            ngcap = DateTime.MinValue; // Gán giá trị mặc định nếu trống
                        }
                        else if (cellValue is DateTime)
                        {
                            ngcap = (DateTime)cellValue;
                        }
                        else if (cellValue is double)
                        {
                            ngcap = DateTime.FromOADate((double)cellValue);
                        }
                        else
                        {
                            DateTime.TryParse(cellValue.ToString(), out ngcap);
                        }



                        // Đưa dữ liệu vào DB
                        ThemmoiKyLuat(
                            GetCellString(wsheet.Cells[i, 1].Value), // Mã kỷ luật
                            GetCellString(wsheet.Cells[i, 2].Value), // Ma sv
                            GetCellString(wsheet.Cells[i, 3].Value), // Vi phạm
                            GetCellString(wsheet.Cells[i, 4].Value),  // Hình thức
                            ngcap                             // Ngày  (DateTime)                                  
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
        private void ThemmoiKyLuat(dynamic mahb, dynamic msv, dynamic tenhb, dynamic sotien, DateTime ngcap)
        {
            if (checktrungmahb(mahb))
            {
                MessageBox.Show("Trùng mã học bổng.");
                txtmahb.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO hocbong VALUES (@msv, @tenhb, @sotien, @ngaycap)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@tenhb", tenhb);
                com.Parameters.AddWithValue("@sotien", sotien);
                com.Parameters.AddWithValue("@ngaycap", ngcap);

                com.ExecuteNonQuery();
                loadhocbong();
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

        private void button1_Click(object sender, EventArgs e)
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
                loadhocbong();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
