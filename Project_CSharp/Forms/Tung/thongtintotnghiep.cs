using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Tung
{
    public partial class thongtintotnghiep: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public thongtintotnghiep()
        {
            InitializeComponent();
            loadsinhvien();
            loadtotnghiep();
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
        private void loadtotnghiep()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select tn.idtotnghiep, tn.idsinhvien, tn.ngaytotnghiep, tn.xeploai, tn.khoa, tn.nganh, tn.diemtrungbinh, tn.masobang, tn.ghichu " +
                "from thongtintotnghiep tn " +
                "Join sinhvien sv on tn.idsinhvien = sv.idsinhvien";
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
        public bool checktrungmatotnghiep(string matn)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "Select count (*) from thongtintotnghiep Where idtotnghiep '" + matn + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
                return true; //trung ma 
            else
                return false;//khong trung 
        }
        private void thongtintotnghiep_Load(object sender, EventArgs e)
        {
            loadtotnghiep();
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string matn = txtmtotnghiep.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            DateTime ngaytn = txtngtn.Value;
            string xeploai = cbxeploai.SelectedValue.ToString();
            string khoa = cbkhoa.SelectedValue.ToString();
            string nganh = cbnganh.SelectedValue.ToString();
            string diemtb = txtdiemtb.Text.Trim();
            string masb = txtmabang.Text.Trim();
            string note = txtnote.Text.Trim();

            if (checktrungmatotnghiep(matn))
            {
                MessageBox.Show("Trùng mã tot nghiep.");
                txtmtotnghiep.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO kyluat VALUES (@matn, @msv, @ngaytn, @xeploai, @khoa, @nganh, @diemtb, @masobang, @ghichu)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mtn", matn);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@ngaytn", ngaytn);
                com.Parameters.AddWithValue("@xeploai", xeploai);
                com.Parameters.AddWithValue("@khoa", khoa);
                com.Parameters.AddWithValue("@nganh", nganh);
                com.Parameters.AddWithValue("@diemtb", diemtb);
                com.Parameters.AddWithValue("@masobang", masb);
                com.Parameters.AddWithValue("@ghichu", note);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
               loadtotnghiep();
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
            string matn = txtmtotnghiep.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            DateTime ngaytn = txtngtn.Value;
            string xeploai = cbxeploai.SelectedValue.ToString();
            string khoa = cbkhoa.SelectedValue.ToString();
            string nganh = cbnganh.SelectedValue.ToString();
            string diemtb = txtdiemtb.Text.Trim();
            string masb = txtmabang.Text.Trim();
            string note = txtnote.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE thongtintotnghiep SET idsinhvien = @msv, ngaytotnghiep = @ngaytn, xeploai = @xeploai, khoa = @khoa, nganh=@nganh, diemtrungbinh = @diemtb, masobang= @masb, ghichu = @ghichu WHERE idtotnghiep = @mtn";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mtn", matn);
                com.Parameters.AddWithValue("@msv", msv);
                com.Parameters.AddWithValue("@ngaytn", ngaytn);
                com.Parameters.AddWithValue("@xeploai", xeploai);
                com.Parameters.AddWithValue("@khoa", khoa);
                com.Parameters.AddWithValue("@nganh", nganh);
                com.Parameters.AddWithValue("@diemtb", diemtb);
                com.Parameters.AddWithValue("@masobang", masb);
                com.Parameters.AddWithValue("@ghichu", note);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    loadtotnghiep();
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
            string matn = txtmtotnghiep.Text.Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "DELETE FROM thongtintotnghiep WHERE idtotnghiep = @mtn";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mtn", matn);

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    loadtotnghiep();
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
            string matn = txtmtotnghiep.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            string khoa = cbkhoa.SelectedValue.ToString();
            string nganh = cbnganh.SelectedValue.ToString();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "SELECT * FROM thongtintotnghiep WHERE idtotnghiep LIKE @mtn AND idsinhvien LIKE @msv AND khoa LIKE @khoa AND nganh LIKE @nganh";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mtn", "%" + matn + "%");
                cmd.Parameters.AddWithValue("@msv", "%" + msv + "%");
                cmd.Parameters.AddWithValue("@khoa", "%" + khoa + "%");
                cmd.Parameters.AddWithValue("@nganh", "%" + nganh + "%");

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
                txtmtotnghiep.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbmasv.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtngtn.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                cbxeploai.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbkhoa.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbnganh.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtdiemtb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtmabang.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtnote.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
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
            head.Value2 = "DANH SACH TOT NGHIEP";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MA TOT NGHIEP";
            cl1.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "MA SINH VIEN";

            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NGAY TOT NGHIEP";
            cl3.ColumnWidth = 40.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "XEP LOAI";
            cl4.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "KHOA";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl5.Value2 = "NGANH";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl5.Value2 = "DIEM TRUNG BINH";
            cl5.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl5.Value2 = "MA SO BANG";
            cl5.ColumnWidth = 50.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
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
            Microsoft.Office.Interop.Excel.Range cl_ngtn = oSheet.get_Range("C" + rowStart, "C" + rowEnd);
            cl_ngtn.Columns.NumberFormat = "dd/mm/yyyy";
            
        }

        private void Xuat_Click(object sender, EventArgs e)
        {
            string matn = txtmtotnghiep.Text.Trim();
            string msv = cbmasv.SelectedValue.ToString();
            DateTime ngaytn = txtngtn.Value;
            string xeploai = cbxeploai.SelectedValue.ToString();
            string khoa = cbkhoa.SelectedValue.ToString();
            string nganh = cbnganh.SelectedValue.ToString();
            string diemtb = txtdiemtb.Text.Trim();
            string masb = txtmabang.Text.Trim();
            string note = txtnote.Text.Trim();


            string sql = "SELECT * FROM thongtintotnghiep";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            ExportExcel(tb, "DSTN");
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

                        DateTime ngtn;
                        

                        if (cellValue == null)
                        {
                            ngtn = DateTime.MinValue;
                            
                        }
                        else if (cellValue is DateTime)
                        {
                            ngtn = (DateTime)cellValue;
                            
                        }
                        else if (cellValue is double)
                        {
                            ngtn = DateTime.FromOADate((double)cellValue);
                            
                        }
                        else
                        {
                            DateTime.TryParse(cellValue.ToString(), out ngtn);
                            
                        }



                        // Đưa dữ liệu vào DB
                        /*ThemmoiTotnghiep(
                            GetCellString(wsheet.Cells[i, 1].Value), // Mã kỷ luật
                            GetCellString(wsheet.Cells[i, 2].Value), // Họ và tên
                            ngtn,
                            GetCellString(wsheet.Cells[i, 3].Value), 
                            GetCellString(wsheet.Cells[i, 4].Value),  
                            GetCellString(wsheet.Cells[i, 7].Value),
                            GetCellString(wsheet.Cells[i, 8].Value),
                            GetCellString(wsheet.Cells[i, 9].Value)
                            
                        );*/

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

        private void ThemmoiTotnghiep(dynamic matn, dynamic msv, DateTime ngaytn, dynamic xeploai, dynamic khoa, dynamic nganh, dynamic diemtb, dynamic masb, dynamic note)
        {
            if (checktrungmatotnghiep(matn))
            {
                MessageBox.Show("Trùng mã tot nghiep.");
                txtmtotnghiep.Focus();
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "INSERT INTO thongtintotnghiep VALUES (@matn, @msv, @ngaytn, @xeploai, @khoa, @nganh, @diemtb, @masobang, @ghichu)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@mtn", matn);
                com.Parameters.AddWithValue("@msv", msv); 
                com.Parameters.AddWithValue("@ngaytn", ngaytn);
                com.Parameters.AddWithValue("@xeploai", xeploai);
                com.Parameters.AddWithValue("@khoa", khoa);
                com.Parameters.AddWithValue("@nganh", nganh);
                com.Parameters.AddWithValue("@diemtb", diemtb);
                com.Parameters.AddWithValue("@masobang", masb);
                com.Parameters.AddWithValue("@ghichu", note);


                com.ExecuteNonQuery();
                loadtotnghiep();
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
                loadtotnghiep();
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
