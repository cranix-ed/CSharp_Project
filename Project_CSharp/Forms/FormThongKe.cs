using Project_CSharp.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_CSharp.Forms
{
    public partial class FormThongKe : Form
    {

        private SinhVienBLL sinhVienBLL = new SinhVienBLL();
        private LopHocBLL lopHocBLL = new LopHocBLL();

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void LoadChartGioiTinh()
        {
            chartGioiTinh.Series.Clear();
            chartGioiTinh.Titles.Clear();
            chartGioiTinh.ChartAreas.Clear();


            chartGioiTinh.Titles.Add("Tỉ lệ giới tính sinh viên");

            ChartArea chartArea = new ChartArea();
            chartGioiTinh.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#PERCENT\n#VALX: #VAL",
            };

            int soNam = sinhVienBLL.LaySoSinhVienTheoGioiTinh("Nam");
            int soNu = sinhVienBLL.LaySoSinhVienTheoGioiTinh("Nữ");

            series.Points.AddXY("Nam", soNam);
            series.Points.AddXY("Nữ", soNu);

            chartGioiTinh.Series.Add(series);
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            lblSoSinhVien.Text = sinhVienBLL.LayTongSinhVien().ToString();
            lblSoLopHoc.Text = lopHocBLL.LayTongLopHoc().ToString();
            lblSoluongGiangvien.Text = lopHocBLL.LayTongGiangVien().ToString();

            dgvThongkeKhoahoc.DataSource = sinhVienBLL.LayThongKeTheoKhoaHoc();
            dgvThongkeKhoa.DataSource = sinhVienBLL.LayThongKeTheoKhoa();
            dgvThongkeNganh.DataSource = sinhVienBLL.LayThongKeTheoNganh();
            dgvSinhVien.DataSource = sinhVienBLL.GetAllSinhVien();

            LoadChartGioiTinh();
        }
    }
}
