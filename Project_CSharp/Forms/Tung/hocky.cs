using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Tung
{
    public partial class hocky: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public hocky()
        {
            InitializeComponent();
            Loadhocky();
        }
        private void Loadhocky()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
            string sql = "SELECT * FROM hocky";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            dataGridView1.DataSource = tb;
            //  dataGridView1.Refresh();
        }
        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Luu_Click(object sender, EventArgs e)
        {
            
            string tenhk = cbhocky.SelectedValue.ToString();
            string namhoc = cbnamhoc.SelectedValue.ToString();
            DateTime ngaybd = txtngaybd.Value;
            DateTime ngaykt = txtngaykt.Value;
            string trangthai = txttrangthai.Text.Trim();
            

            
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO hocky VALUES ( @tenhk, @namhoc, @ngaybd, @ngaykt, @trangthai)";
                SqlCommand com = new SqlCommand(sql, con);
                
                com.Parameters.AddWithValue("@tenhk", tenhk);
                com.Parameters.AddWithValue("@namhoc", namhoc);
                com.Parameters.AddWithValue("@ngaybd", ngaybd);
                com.Parameters.AddWithValue("@ngaykt", ngaykt);
                com.Parameters.AddWithValue("@trangthai", trangthai);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                Loadhocky();
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

        
        private void Sua_Click(object sender, EventArgs e)
        {
            
            string tenhk = cbhocky.SelectedValue.ToString();
            string namhoc = cbnamhoc.SelectedValue.ToString();
            DateTime ngaybd = txtngaybd.Value;
            DateTime ngaykt = txtngaykt.Value;
            string trangthai = txttrangthai.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE hocky SET  namhoc = @namhoc, ngaybd = @ngaybatdau, ngayketthuc = @ngaykt, trangthai=@trangthai WHERE tenhocky = @tenhk";
                SqlCommand com = new SqlCommand(sql, con);
               
                com.Parameters.AddWithValue("@tenhk", tenhk);
                com.Parameters.AddWithValue("@namhoc", namhoc);
                com.Parameters.AddWithValue("@ngaybd", ngaybd);
                com.Parameters.AddWithValue("@ngaykt", ngaykt);
                com.Parameters.AddWithValue("@trangthai", trangthai);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    Loadhocky();
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

        private void hocky_Load(object sender, EventArgs e)
        {
            Loadhocky();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string tenhk = cbhocky.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM hocky WHERE tenhocky = @tenhk";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@tenhk", tenhk);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    Loadhocky();
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
            
            string tenhk = searchtenhk.Text != null ? searchtenhk.Text.Trim() : "";
            string namhoc = searchnamhoc.Text != null ? searchnamhoc.Text.Trim() : "";

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT * FROM hocky WHERE 1=1";
                if (tenhk != null && tenhk != "")
                {
                    sql += "AND tenhocky = @tenhk";
                }
                if (namhoc != null && namhoc != "")
                {
                    sql += "AND namhoc = @namhoc";
                }
                SqlCommand cmd = new SqlCommand(sql, con);
                
                cmd.Parameters.AddWithValue("@tenhk", tenhk );
                cmd.Parameters.AddWithValue("@namhoc",  namhoc );

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

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                
                cbhocky.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbnamhoc.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtngaybd.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                txtngaykt.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                txttrangthai.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = "DANH SACH HOC KY";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MA HOC KY";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TEN HOC KY";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NAM HOC";
            cl3.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "NGAY BAT DAU";
            cl4.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "NGAY KET THUC";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl5.Value2 = "TRANG THAI";
            cl5.ColumnWidth = 25.0;






            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");
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
            Microsoft.Office.Interop.Excel.Range cl_ngbd = oSheet.get_Range("D" + rowStart, "D" + rowEnd);
            cl_ngbd.Columns.NumberFormat = "dd/mm/yyyy";
            Microsoft.Office.Interop.Excel.Range cl_ngkt = oSheet.get_Range("E" + rowStart, "E" + rowEnd);
            cl_ngkt.Columns.NumberFormat = "dd/mm/yyyy";
        }

        private void Xuat_Click(object sender, EventArgs e)
        {
            
            string tenhk = cbhocky.SelectedValue.ToString();
            string namhoc = cbnamhoc.SelectedValue.ToString();
            DateTime ngaybd = txtngaybd.Value;
            DateTime ngaykt = txtngaykt.Value;
            string trangthai = txttrangthai.Text.Trim();

            
            string sql = "SELECT * FROM hocky";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            ExportExcel(tb, "DSHK");
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
                        object cellValue = wsheet.Cells[i, 4].Value;
                        DateTime ngaybd;

                        DateTime ngaykt;

                        if (cellValue == null)
                        {
                            ngaybd = DateTime.MinValue;
                            ngaykt = DateTime.MinValue;
                        }
                        else if (cellValue is DateTime)
                        {
                            ngaybd = (DateTime)cellValue;
                            ngaykt = (DateTime)cellValue;
                        }
                        else if (cellValue is double)
                        {
                            ngaybd = DateTime.FromOADate((double)cellValue);
                            ngaykt = DateTime.FromOADate((double)cellValue);
                        }
                        else
                        {
                            DateTime.TryParse(cellValue.ToString(), out ngaybd);
                            DateTime.TryParse(cellValue.ToString(), out ngaykt);
                        }



                        // Đưa dữ liệu vào DB
                        ThemmoiHocKy(
                            GetCellString(wsheet.Cells[i, 1].Value), // Mã kỷ luật
                            GetCellString(wsheet.Cells[i, 2].Value), // Họ và tên
                             // Vi phạm
                            ngaybd,
                            ngaykt,
                            GetCellString(wsheet.Cells[i, 4].Value)
                            
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

        private void ThemmoiHocKy( dynamic tenhk, dynamic namhoc, DateTime ngaybd, DateTime ngaykt, dynamic trangthai)
        {
           

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO hocky VALUES ( @tenhk, @namhoc, @ngaybd, @ngaykt, @trangthai)";
                SqlCommand com = new SqlCommand(sql, con);
               
                com.Parameters.AddWithValue("@tenhk", tenhk);
                com.Parameters.AddWithValue("@namhoc", namhoc);
                com.Parameters.AddWithValue("@ngaybd", ngaybd);
                com.Parameters.AddWithValue("@ngaykt", ngaykt);
                com.Parameters.AddWithValue("@trangthai", trangthai);

                com.ExecuteNonQuery();
                Loadhocky();
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
                Loadhocky();
            }
        }
    }
}
