using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Ngoc
{
    public partial class Giangvien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public Giangvien()
        {
            InitializeComponent();
            load_Giangvien();
            load_Khoa();
        }
        public bool checktrungGvien(String mgv)
        {
            //Ket noi den DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            //Tao doi tuong command de thuc hien den cac ban ghi co Matacgia
            String sql = "Select count(*) from giaovien Where idgiaovien ='" + mgv + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
            {
                return true;//Trung ma tac gia
            }
            else
            {
                return false;//Khong trung Ma tac gia
            }
        }
        private bool Kiemtradienthoai(String dt)
        {
            return Regex.IsMatch(dt, @"^(0[2-9]\d{8,9})$");

        }
        private void load_Khoa()
        {
            // Kiểm tra kết nối trước khi mở
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "SELECT idkhoa, tenkhoa FROM khoa";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            // Bổ sung thêm 1 dòng "---Chọn Khoa---"
            DataRow r = tb.NewRow();
            r["idkhoa"] = DBNull.Value;
            r["tenkhoa"] = "---Chọn Khoa---";
            tb.Rows.InsertAt(r, 0);

            // Gán dữ liệu vào ComboBox
            cbkhoa.DataSource = tb;
            cbkhoa.DisplayMember = "tenkhoa";
            cbkhoa.ValueMember = "idkhoa"; // Quan trọng: Gán giá trị idkhoa

            cbtkkhoa.DataSource = tb;
            cbtkkhoa.DisplayMember = "tenkhoa";
            cbtkkhoa.ValueMember = "idkhoa"; // Gán cho combo tìm kiếm
        }
        private void load_Giangvien()
        {
            if (con.State == ConnectionState.Closed) ;
            con.Open();

            String sql = "SELECT * FROM giaovien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            Capnhatgiangvien.DataSource = tb;
            Capnhatgiangvien.Refresh();

        }
       
        private void GiangVien_Load(object sender, EventArgs e)
        {
            load_Giangvien();
            load_Khoa();
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
            head.Value2 = "DANH SÁCH GIÁO VIÊN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ GIÁO VIÊN";
            cl1.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "HỌ VÀ TÊN";
            cl2.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "NGÀY SINH";
            cl3.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "GIỚI TÍNH";
            cl4.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "ĐỊA CHỈ";
            cl5.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "SỐ ĐIỆN THOẠI";
            cl6.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "EMAIL";
            cl7.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "KHOA";
            cl8.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "MÃ KHOA";
            cl9.ColumnWidth = 10.0;

            //Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            //cl8.Value2 = "GHI CHÚ";
            //cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");
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

                {
                    if (c == 4)
                    {
                        arr[r, c] = "'" + dr[c];
                    }
                    else
                    {
                        arr[r, c] = dr[c];
                    }

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
            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            //oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl_ngs = oSheet.get_Range("D" + rowStart, "D" + rowEnd);
            cl_ngs.Columns.NumberFormat = "dd/mm/yyyy";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String mgv = txtid.Text.Trim();
            String ht = txtht.Text.Trim();
            DateTime ngs = date.Value;
            String gt = cbgt.SelectedItem.ToString();
            String dc = txtdc.Text.Trim();
            String dt = txtsdt.Text.Trim();
            String email = txtemail.Text.Trim();
            DataRowView selectedRow = (DataRowView)cbkhoa.SelectedItem;
            string tenkhoa = selectedRow["tenkhoa"].ToString();  // Cột muốn lấy
            String khoa = cbkhoa.SelectedValue.ToString();
            // Kiểm tra nếu không chọn khoa
            if (cbkhoa.SelectedValue == null || cbkhoa.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn khoa.");
                cbkhoa.Focus();
                return;
            }

            String sql = "INSERT INTO giaovien (hoten, ngaysinh, gioitinh, diachi, sodienthoai, email,tenkhoa,idkhoa) " +
                 "VALUES ( @hoten, @ngaysinh, @gioitinh, @diachi, @sodienthoai, @email,@tenkhoa,@idkhoa)";

            SqlCommand cmd = new SqlCommand(sql, con);


            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 50).Value = ht;

            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime, 50).Value = ngs;

            cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = gt;

            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = dc;

            cmd.Parameters.Add("@sodienthoai", SqlDbType.Text, 50).Value = dt;

            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 10).Value = email;

            cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar, 255).Value = tenkhoa;

            cmd.Parameters.Add("@idkhoa", SqlDbType.Int, 50).Value = khoa;


            if (mgv == "")
            {
                MessageBox.Show("Yêu cầu nhập mã giảng viên");
                txtid.Focus();
                return;
            }
            if (checktrungGvien(mgv))
            {
                MessageBox.Show("Trùng mã giang vien");
                txtid.Focus();
                return;
            }

            if (!Kiemtradienthoai(dt))
            {
                MessageBox.Show("So dien thoai khong hop le");
                txtsdt.Focus();
                return;
            }
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Thêm giảng viên thành công!");
            load_Giangvien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                String mgv = txtid.Text.Trim();
                String ht = txtht.Text.Trim();
                DateTime ngs = date.Value;
                String gt = cbgt.SelectedItem.ToString();
                String dc = txtdc.Text.Trim();
                String dt = txtsdt.Text.Trim();
                String email = txtemail.Text.Trim();
                DataRowView selectedRow = (DataRowView)cbkhoa.SelectedItem;
                string tenkhoa = selectedRow["tenkhoa"].ToString();  // Cột muốn lấy
                String khoa = cbkhoa.SelectedValue.ToString();

                if (con.State == ConnectionState.Closed)
                    con.Open();

                string sql = "UPDATE giaovien SET hoten=@hoten, gioitinh=@gioitinh, ngaysinh=@ngaysinh, " +
                 "sodienthoai=@sodienthoai, diachi=@diachi, email=@email,tenkhoa=@tenkhoa,idkhoa=@idkhoa " + 
                 "WHERE idgiaovien= @idgiaovien";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.Add("@idgiaovien", SqlDbType.NVarChar, 50).Value = mgv;

                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 50).Value = ht;

                cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime, 50).Value = ngs;

                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 50).Value = gt;

                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = dc;

                cmd.Parameters.Add("@sodienthoai", SqlDbType.Text, 50).Value = dt;

                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 10).Value = email;

                cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar, 255).Value = tenkhoa;

                cmd.Parameters.Add("@idkhoa", SqlDbType.Int, 50).Value = khoa;

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    load_Giangvien(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        private void Capnhatgiangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtid.Text = Capnhatgiangvien.Rows[i].Cells[0].Value.ToString();
            txtht.Text = Capnhatgiangvien.Rows[i].Cells[1].Value.ToString();
            date.Value = DateTime.Parse(Capnhatgiangvien.Rows[i].Cells[2].Value.ToString());
            cbgt.SelectedItem = Capnhatgiangvien.Rows[i].Cells[3].Value.ToString();
            txtdc.Text = Capnhatgiangvien.Rows[i].Cells[4].Value.ToString();
            txtsdt.Text = Capnhatgiangvien.Rows[i].Cells[5].Value.ToString();
            txtemail.Text = Capnhatgiangvien.Rows[i].Cells[6].Value.ToString();
            cbkhoa.Text = Capnhatgiangvien.Rows[i].Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                string mgv = txtid.Text.Trim();
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Vui lòng chọn giảng viên cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                       con.Open();

                    string sql = "DELETE FROM giaovien WHERE idgiaovien= @idgiaovien";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idgiaovien", mgv);

                    int result = cmd.ExecuteNonQuery();
                    con.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        load_Giangvien(); // Cập nhật lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
        }

        private void btnTimKien_Click(object sender, EventArgs e)
        {
            String mgv = txttkid.Text.Trim();
            String ht = txttkht.Text.Trim();
            String gt;
            if (cbtkgt.SelectedItem == null)
                gt = "";
            else

                gt = cbtkgt.SelectedItem.ToString();
            DataRowView selectedRow = (DataRowView)cbkhoa.SelectedItem;
            string tenkhoa = selectedRow["tenkhoa"].ToString();  // Cột muốn lấy
            String khoa = cbtkkhoa.SelectedValue.ToString();
            //kET NOI DB
            if (con.State == ConnectionState.Closed)
               con.Open();
            //Tao doi tuong command de tien hanh tim kiem dk
            String sql = "Select * From giaovien Where idgiaovien like '%" + mgv + "%' and hoten like N'%" + ht + "%' and gioitinh like N'%" + gt + "%' and tenkhoa like N'%" + tenkhoa + "%' and idkhoa like '%"+ khoa +"%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            //Tao doi tg Dataadapter de lay kq tu cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //Tao doi tg Datatable de lay du lieu tu da
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
           
            con.Close();
            
            //Hien thi tb len dataGribview
            Capnhatgiangvien.DataSource = tb;
            Capnhatgiangvien.Refresh();
           
        }

        private void Giangvien_Load_1(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (cbkhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selectedRow = (DataRowView)cbkhoa.SelectedItem;
            string tenkhoa = selectedRow["tenkhoa"].ToString();

            string sql = "SELECT * FROM giaovien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            ExportExcel(tb, "DSHB");
        }
    }
}
