using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest.FormTest
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String masv = txtMaSV.Text;
            String hoten = txtHoTen.Text;
            String diachi = txtDiaChi.Text;
            String ngaysinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            String lop = cbLop.SelectedItem.ToString();

            dtgTable.Rows.Add(masv, hoten, diachi, ngaysinh, lop);

            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            cbLop.SelectedItem = "";
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            int i = dtgTable.CurrentRow.Index;

            String masv = txtMaSV.Text;
            String hoten = txtHoTen.Text;
            String diachi = txtDiaChi.Text;
            String ngaysinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            String lop = cbLop.SelectedItem.ToString();

            dtgTable.Rows[i].Cells["MaSV"].Value = masv;
            dtgTable.Rows[i].Cells["HoTen"].Value = hoten;
            dtgTable.Rows[i].Cells["DiaChi"].Value = diachi;
            dtgTable.Rows[i].Cells["NgaySinh"].Value = ngaysinh;
            dtgTable.Rows[i].Cells["Lop"].Value = lop;

            txtMaSV.Enabled = true;
        }

        private void dtgTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgTable.CurrentRow.Index;

            txtMaSV.Text = dtgTable.Rows[i].Cells["MaSV"].Value.ToString();
            txtHoTen.Text = dtgTable.Rows[i].Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = dtgTable.Rows[i].Cells["DiaChi"].Value.ToString();
            dtpNgaySinh.Value = DateTime.ParseExact(dtgTable.Rows[i].Cells["NgaySinh"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            cbLop.SelectedItem = dtgTable.Rows[i].Cells["Lop"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dtgTable.SelectedRows.Count;
            for (int i = 0; i < index; i++)
            {
                dtgTable.Rows.RemoveAt(i);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
