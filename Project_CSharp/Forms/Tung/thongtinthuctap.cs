using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Tung
{
    public partial class thongtinthuctap: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public thongtinthuctap()
        {
            InitializeComponent();
            loadsinhvien();
            loadthuctap();
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
        private void loadthuctap()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select tt.idthuctap, tt.idsinhvien, tt.congty, tt.vitri, tt.ngaybatdau, tt.ngayketthuc, tt.giamsatvien, tt.danhgia, tt.trangthai, tt.ghichu " +
                "from thongtinthuctap tt " +
                "Join sinhvien sv on tt.idsinhvien = sv.idsinhvien";
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
        public bool checktrungmattap(string mattap)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "Select count (*) from thongtinthuctap Where idthuctap= '" + mattap + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
                return true; //trung ma 
            else
                return false;//khong trung 
        }
        private void Luu_Click(object sender, EventArgs e)
        {
            string mattap = txtmattap.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string congty = txtcty.Text.Trim();
            string vitri = txtvitri.Text.Trim();
            DateTime ngaybd = txtngaybd.Value;
            DateTime ngaykt = txtngaykt.Value;
            string gsatvien = txtgsatvien.Text.Trim();
            string danhgia = txtdanhgia.Text.Trim();
            string trangthai = txttrangthai.Text.Trim();
            string note = txtnote.Text.Trim();

            if (checktrungmattap(mattap))
            {
                MessageBox.Show("Trùng mã thực tập.");
                txtmattap.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO kyluat VALUES (@mttap, @msv, @congty, @vitri, @ngaybd, @ngaykt, @gsatvien, @danhgia, @trangthai, @ghichu)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mttap", mattap);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@congty", congty);
                com.Parameters.AddWithValue("@vitri", vitri);
                com.Parameters.AddWithValue("@ngaybd", ngaybd);
                com.Parameters.AddWithValue("@ngaykt", ngaykt);
                com.Parameters.AddWithValue("@gsatvien", gsatvien);
                com.Parameters.AddWithValue("@danhgia", danhgia);
                com.Parameters.AddWithValue("@trangthai", trangthai);
                com.Parameters.AddWithValue("@ghichu", note);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                loadthuctap();
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

        private void thongtinthuctap_Load(object sender, EventArgs e)
        {
            loadthuctap();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string mattap = txtmattap.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string congty = txtcty.Text.Trim();
            string vitri = txtvitri.Text.Trim();
            DateTime ngaybd = txtngaybd.Value;
            DateTime ngaykt = txtngaykt.Value;
            string gsatvien = txtgsatvien.Text.Trim();
            string danhgia = txtdanhgia.Text.Trim();
            string trangthai = txttrangthai.Text.Trim();
            string note = txtnote.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE thongtinthuctap SET idsinhvien = @msv, congty = @congty, vitri = @vitri, ngaybatdau = @ngbd, ngayketthuc = @ngkt, giamsatvien= @gsatvien, danhgia =@danhgia, trangthai = @trangthai, ghichu = @ghichu WHERE idthuctap = @mttap";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mttap", mattap);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@congty", congty);
                com.Parameters.AddWithValue("@vitri", vitri);
                com.Parameters.AddWithValue("@ngaybd", ngaybd);
                com.Parameters.AddWithValue("@ngaykt", ngaykt);
                com.Parameters.AddWithValue("@gsatvien", gsatvien);
                com.Parameters.AddWithValue("@danhgia", danhgia);
                com.Parameters.AddWithValue("@trangthai", trangthai);
                com.Parameters.AddWithValue("@ghichu", note);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    loadthuctap ();
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
            string mattap = txtmattap.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM thongtinthuctap WHERE idthuctap = @mttap";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mttap", mattap);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    loadthuctap();
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
            string mattap = searchmattap.Text.Trim();
            string msv = searchmasv.SelectedValue.ToString();
            string congty = searchcty.Text.Trim();
            string vitri = searchvitri.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT * FROM thongtinthuctap WHERE idthuctap LIKE @mttap AND idsinhvien LIKE @msv AND congty LIKE @congty AND vitri LIKE @vitri";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mttap", "%" + mattap + "%");
                cmd.Parameters.AddWithValue("@msv", "%" + msv + "%");
                cmd.Parameters.AddWithValue("@congty", "%" + congty + "%");
                cmd.Parameters.AddWithValue("@vitri", "%" + vitri + "%");

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
                txtmattap.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbmasv.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtcty.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtvitri.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtngaybd.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                txtngaykt.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                txtgsatvien.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtdanhgia.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txttrangthai.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtnote.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
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
            head.Value2 = "DANH SACH THUC TAP";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MA THUC TAP";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "MA SINH VIEN";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "CONG TY";
            cl3.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "VI TRI";
            cl4.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "NGAY BAT DAU";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl5.Value2 = "NGAY KET THUC";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl5.Value2 = "GIAM SAT VIEN";
            cl5.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl5.Value2 = "DANH GIA";
            cl5.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl5.Value2 = "TRANG THAI";
            cl5.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "GHI CHU";
            cl5.ColumnWidth = 50.0;





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
            Microsoft.Office.Interop.Excel.Range cl_ngbd = oSheet.get_Range("E" + rowStart, "E" + rowEnd);
            cl_ngbd.Columns.NumberFormat = "dd/mm/yyyy";
            Microsoft.Office.Interop.Excel.Range cl_ngkt = oSheet.get_Range("F" + rowStart, "F" + rowEnd);
            cl_ngkt.Columns.NumberFormat = "dd/mm/yyyy";
        }

        private void Xuat_Click(object sender, EventArgs e)
        {
            string mattap = txtmattap.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string congty = txtcty.Text.Trim();
            string vitri = txtvitri.Text.Trim();
            DateTime ngaybd = txtngaybd.Value;
            DateTime ngaykt = txtngaykt.Value;
            string gsatvien = txtgsatvien.Text.Trim();
            string danhgia = txtdanhgia.Text.Trim();
            string trangthai = txttrangthai.Text.Trim();
            string note = txtnote.Text.Trim();


            string sql = "SELECT * FROM thongtinthuctap";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            ExportExcel(tb, "DSTT");
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
                        
                        object cellValue = wsheet.Cells[i, 5].Value;
                        
                        DateTime ngbd;
                        DateTime ngkt;

                        if (cellValue == null)
                        {
                            ngbd = DateTime.MinValue;
                            ngkt = DateTime.MinValue;// Gán giá trị mặc định nếu trống
                        }
                        else if (cellValue is DateTime)
                        {
                            ngbd = (DateTime)cellValue;
                            ngkt = (DateTime)cellValue;
                        }
                        else if (cellValue is double)
                        {
                            ngbd = DateTime.FromOADate((double)cellValue);
                            ngkt = DateTime.FromOADate((double)cellValue);
                        }
                        else
                        {
                            DateTime.TryParse(cellValue.ToString(), out ngbd);
                            DateTime.TryParse(cellValue.ToString(), out ngkt);
                        }



                        // Đưa dữ liệu vào DB
                        ThemmoiThuctap(
                            GetCellString(wsheet.Cells[i, 1].Value), // Mã kỷ luật
                            GetCellString(wsheet.Cells[i, 2].Value), // Họ và tên
                            GetCellString(wsheet.Cells[i, 3].Value), // Vi phạm
                            GetCellString(wsheet.Cells[i, 4].Value),  // Hình thức
                            ngbd,                             // Ngày  (DateTime)
                            ngkt,
                            GetCellString(wsheet.Cells[i, 7].Value), 
                            GetCellString(wsheet.Cells[i, 8].Value), 
                            GetCellString(wsheet.Cells[i, 9].Value), 
                            GetCellString(wsheet.Cells[i, 10].Value)
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

        private void ThemmoiThuctap(dynamic mattap, dynamic msv, dynamic cty, dynamic vitri, DateTime ngaybd, DateTime ngaykt, dynamic gsatvien, dynamic danhgia, dynamic trangthai, dynamic note)
        {
            if (checktrungmattap(mattap))
            {
                MessageBox.Show("Trùng mã thuc tap.");
                txtmattap.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO thongtinthuctap VALUES (@mttap, @msv, @congty, @vitri, @ngaybd, @ngaykt, @gsatvien, @danhgia, @trangthai, @ghichu)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mttap", mattap);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@congty", congty);
                com.Parameters.AddWithValue("@vitri", vitri);
                com.Parameters.AddWithValue("@ngaybd", ngaybd);
                com.Parameters.AddWithValue("@ngaykt", ngaykt);
                com.Parameters.AddWithValue("@gsatvien", gsatvien);
                com.Parameters.AddWithValue("@danhgia", danhgia);
                com.Parameters.AddWithValue("@trangthai", trangthai);
                com.Parameters.AddWithValue("@ghichu", note);

                com.ExecuteNonQuery();
               loadthuctap();
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
                loadthuctap();
            }
        }
    }
}
