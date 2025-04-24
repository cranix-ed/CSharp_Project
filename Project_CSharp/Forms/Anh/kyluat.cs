using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Anh
{
    public partial class kyluat: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public kyluat()
        {
            InitializeComponent();
            loadsinhvien();
            loadkyluat();

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
        private void loadkyluat()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select kl.idkyluat, kl.idsinhvien, kl.vipham, kl.hinhthucxuly, kl.ngay " +
                "from kyluat kl " +
                "Join sinhvien sv on kl.idsinhvien = sv.idsinhvien";
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
        public bool checktrungmakl(string makl)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "Select count (*) from kyluat Where idkyluat= '" + makl + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
                return true; //trung ma 
            else
                return false;//khong trung 
        }
        private void Luu_Click(object sender, EventArgs e)
        {
            string makl = txtmakl.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string vipham = txtvipham.Text.Trim();
            string hinhthuc = txthinhthuc.Text.Trim();
            DateTime ngay = txtngay.Value;

            if (checktrungmakl(makl))
            {
                MessageBox.Show("Trùng mã kỷ luật.");
                txtmakl.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO kyluat VALUES (@mkl, @msv, @vipham, @hinhthuc, @ngay)";
                SqlCommand com = new SqlCommand(sql, con);
                
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@vipham", vipham);
                com.Parameters.AddWithValue("@hinhthuc", hinhthuc);
                com.Parameters.AddWithValue("@ngay", ngay);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                loadkyluat();
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

        private void kyluat_Load(object sender, EventArgs e)
        {
            loadkyluat();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string makl = txtmakl.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string vipham = txtvipham.Text.Trim();
            string hinhthuc = txthinhthuc.Text.Trim();
            DateTime ngay = txtngay.Value;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE kyluat SET idsinhvien = @msv, vipham = @vipham, hinhthuc = @hinhthuc, ngay = @ngay WHERE idkyluat = @mkl";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mkl", makl);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@vipham", vipham);
                com.Parameters.AddWithValue("@hinhthuc", hinhthuc);
                com.Parameters.AddWithValue("@ngay", ngay);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    loadkyluat();
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
            string makl = txtmakl.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM kyluat WHERE kyluat = @mkl";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mkl", makl);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    loadkyluat();
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

        private void Timkiem_Click(object sender, EventArgs e)
        {
            string makl = searchmakl.Text.Trim();
            string msv = searchmasv.SelectedValue.ToString();
            string vipham = searchvipham.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT * FROM kyluat WHERE idkyluat LIKE @mkl AND idsinhvien LIKE @msv AND vipham LIKE @vipham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mkl", "%" + makl + "%");
                cmd.Parameters.AddWithValue("@msv", "%" + msv + "%");
                cmd.Parameters.AddWithValue("@vipham", "%" + vipham + "%");

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtmakl.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbmasv.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtvipham.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txthinhthuc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtngay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
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
            head.Value2 = "DANH SACH KY LUAT";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MA KY LUAT";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "MA SINH VIEN";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "VI PHAM";
            cl3.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "HINH THUC XU LY";
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
            string makl = searchmakl.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string vipham = txtvipham.Text.Trim();
            string hinhthuc = txthinhthuc.Text.Trim();
            DateTime ngay = txtngay.Value;

            /*string sql = "SELECT * FROM kyluat WHERE idkyluat LIKE '%" + makl + "%' AND idsinhvien LIKE N'%" + msv + "%' " +
                "AND vipham LIKE '%" + vipham + "%' AND ngay LIKE '%" + ngay + "%'";*/
            string sql = "SELECT * FROM kyluat";
            
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            ExportExcel(tb, "DSKL");
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
                        ThemmoiKyLuat(
                            GetCellString(wsheet.Cells[i, 1].Value), // Mã kỷ luật
                            GetCellString(wsheet.Cells[i, 2].Value), // Họ và tên
                            GetCellString(wsheet.Cells[i, 3].Value), // Vi phạm
                            GetCellString(wsheet.Cells[i, 4].Value),  // Hình thức
                            ngay                             // Ngày sinh (DateTime)                                  
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

        private void ThemmoiKyLuat(dynamic makl, dynamic msv, dynamic vipham, dynamic hinhthuc, DateTime ngay)
        {
            if (checktrungmakl(makl))
            {
                MessageBox.Show("Trùng mã kỷ luật.");
                txtmakl.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO kyluat VALUES (@msv, @vipham, @hinhthuc, @ngay)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@vipham", vipham);
                com.Parameters.AddWithValue("@hinhthuc", hinhthuc);
                com.Parameters.AddWithValue("@ngay", ngay);

                com.ExecuteNonQuery();
                loadkyluat();
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
                loadkyluat();
            }
        
    }
}
}
