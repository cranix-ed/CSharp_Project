using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_CSharp.Forms.Ngoc
{
    public partial class Nganhhoc: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;User ID=sa;Password=56tfg7hj8");
        public Nganhhoc()
        {
            InitializeComponent();
            load_nganhhoc();
            load_id();
        }
        public bool checktrungtn(String tn)
        {
            //Ket noi den DB
            if (con.State == ConnectionState.Closed)
                con.Open();
            //Tao doi tuong command de thuc hien den cac ban ghi co Matacgia
            String sql = "Select count(*) from nganhhoc Where tennganh ='" + tn + "'";
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
        private void load_id()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "SELECT idkhoa FROM khoa";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbkhoa.DataSource = dt;
            cbkhoa.DisplayMember = "idkhoa";
            cbkhoa.ValueMember = "idkhoa";
            con.Close();
        }

        private void load_nganhhoc()
        {
            if (con.State == ConnectionState.Closed)
            con.Open();

            String sql = "SELECT * FROM nganhhoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            Capnhatnganh.DataSource = tb;
            Capnhatnganh.Refresh();

        }

        private void Capnhatnganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra click đúng vào dòng dữ liệu
            {
                int i = e.RowIndex;
                txtidnganh.Text = Capnhatnganh.Rows[i].Cells[0].Value.ToString();
                txttennganh.Text = Capnhatnganh.Rows[i].Cells[1].Value.ToString();
                txtmanganh.Text = Capnhatnganh.Rows[i].Cells[2].Value.ToString();
                cbkhoa.Text = Capnhatnganh.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String idnganh = txtidnganh.Text.Trim();
            String tn = txttennganh.Text.Trim();
            String mn = txtmanganh.Text.Trim();
            String khoa = cbkhoa.SelectedValue.ToString();

            if (string.IsNullOrEmpty(tn) || string.IsNullOrEmpty(mn))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ngành học.");
                return;
            }

            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "INSERT INTO nganhhoc (tennganh, manganh, idkhoa) VALUES (@tennganh, @manganh, @idkhoa)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tennganh", tn);
            cmd.Parameters.AddWithValue("@manganh", mn);
            cmd.Parameters.AddWithValue("@idkhoa", khoa);
            if (tn == "")
            {
                MessageBox.Show("Yêu cầu nhập tên ngành");
                txttennganh.Focus();
                return;
            }
            if (checktrungtn(tn))
            {
                MessageBox.Show("Trùng tên ngành");
                txttennganh.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Thêm ngành học thành công!");
            load_nganhhoc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtidnganh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ngành học để sửa.");
                return;
            }

            if (cbkhoa.SelectedValue == null || cbkhoa.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Vui lòng chọn ngành.");
                cbkhoa.Focus();
                return;
            }

            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "UPDATE nganhhoc SET tennganh=@tennganh, manganh=@manganh, idkhoa=@idkhoa WHERE idnganh=@idnganh";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tennganh", txttennganh.Text.Trim());
            cmd.Parameters.AddWithValue("@manganh", txtmanganh.Text.Trim());
            cmd.Parameters.AddWithValue("@idkhoa", cbkhoa.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@idnganh", txtidnganh.Text.Trim());

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Sửa ngành học thành công!");

            load_nganhhoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                {
                    string id = txtidnganh.Text.Trim();
                    if (string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Vui lòng chọn ngành cần xóa!");
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();

                        string sql = "DELETE FROM nganhhoc WHERE idnganh= @idnganh";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@idnganh", id);

                        int result = cmd.ExecuteNonQuery();
                        con.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            load_nganhhoc(); // Cập nhật lại danh sách
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!");
                        }
                    }
                }
            }

        }

        private void btnTimKien_Click(object sender, EventArgs e)
        {
            String mn = txttkmanganh.Text.Trim();   // mã ngành
            String tn = txttktennganh.Text.Trim();  // tên ngành

            if (con.State == ConnectionState.Closed)
                con.Open();

            String sql = "Select * From nganhhoc Where manganh like '%" + mn + "%' and tennganh like N'%" + tn + "%'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();

            Capnhatnganh.DataSource = tb;
            Capnhatnganh.Refresh();
        }
    }
}
