using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest.FormTest
{
    public partial class FormDataGridView : Form
    {
        public FormDataGridView()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String hoten = txtHoten.Text;
            String gioitinh = cboGioitinh.SelectedItem.ToString();
            String ngaysinh = dtpNgaysinh.Value.ToString("dd/MM/yyyy");

            dtgTable.Rows.Add(hoten, gioitinh, ngaysinh);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = dtgTable.CurrentRow.Index;

            String hoten = txtHoten.Text;
            String gioitinh = cboGioitinh.SelectedItem.ToString();
            String ngaysinh = dtpNgaysinh.Value.ToString("dd/MM/yyyy");

            dtgTable.Rows[i].Cells["Hoten"].Value = hoten;
            dtgTable.Rows[i].Cells["Gioitinh"].Value = gioitinh;
            dtgTable.Rows[i].Cells["Ngaysinh"].Value = ngaysinh;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dtgTable.CurrentRow.Index;
            dtgTable.Rows.RemoveAt(i);
        }

        private void dtgTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtHoten.Text = dtgTable.Rows[i].Cells[0].Value.ToString();
            cboGioitinh.SelectedItem = dtgTable.Rows[i].Cells[1].Value.ToString();
            dtpNgaysinh.Value = DateTime.ParseExact(dtgTable.Rows[i].Cells[2].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);


            txtHoten.Enabled = false;
        }
    }
}
