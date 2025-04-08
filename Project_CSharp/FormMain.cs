using Project_CSharp.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project_CSharp.Forms.Anh;
using Project_CSharp.Forms.Ngoc;
using Project_CSharp.Forms.Vinh;

namespace Project_CSharp
{
    public partial class FormMain : Form
    {
        private Dictionary<Panel, bool> dropdownStates = new Dictionary<Panel, bool>(); // Lưu trạng thái mở/đóng cho từng panel

        private Panel currentPanel;
        private int dropdownMaxHeight;
        private int dropdownMinHeight = 45;
        private int dropdownStep = 10; // Mỗi lần tăng/giảm bao nhiêu pixel

        private bool isSidebarExpanded = true; // Trạng thái sidebar (mở hay đóng)
        private int sidebarMaxWidth = 240; // Chiều rộng tối đa
        private int sidebarMinWidth = 45; // Chiều rộng tối thiểu khi thu gọn
        private int sidebarStep = 10; // Bước tăng/giảm

        public FormMain()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void CloseCurrentDropdown()
        {
            if (currentPanel != null && dropdownStates[currentPanel])
            {
                dropdownStates[currentPanel] = false;
                dropdownTimer.Start(); // Kích hoạt hiệu ứng đóng
            }
        }

        private void OpenChildForm(Form childForm)
        {
            // Xóa form con cũ trước khi mở form mới
            if (PanelContent.Controls.Count > 0)
                PanelContent.Controls.Clear();

            childForm.TopLevel = false; // Không phải cửa sổ độc lập
            childForm.FormBorderStyle = FormBorderStyle.None; // Ẩn viền
            childForm.Dock = DockStyle.Fill; // Tự động căn chỉnh form con

            PanelContent.Controls.Add(childForm);
            PanelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ToggleDropdown(Panel panel, int maxHeight)
        {
            if (!dropdownStates.ContainsKey(panel))
            {
                dropdownStates[panel] = false; // Khởi tạo trạng thái đóng nếu chưa có
            }

            if (currentPanel != null && currentPanel != panel && dropdownStates[currentPanel])
            {
                // Nếu có dropdown khác đang mở, đóng nó trước
                dropdownStates[currentPanel] = false;
            }

            // Chuyển trạng thái dropdown
            currentPanel = panel;
            dropdownMaxHeight = maxHeight;
            dropdownStates[panel] = !dropdownStates[panel];

            dropdownTimer.Start(); // Kích hoạt hiệu ứng
            flowLayoutPanel1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentPanel == null) return;

            if (dropdownStates[currentPanel]) // Nếu đang mở rộng
            {
                if (currentPanel.Height < dropdownMaxHeight)
                {
                    currentPanel.Height += dropdownStep;
                }
                else
                {
                    dropdownTimer.Stop();
                    currentPanel.Height = dropdownMaxHeight;
                }
            }
            else // Nếu đang thu nhỏ
            {
                if (currentPanel.Height > dropdownMinHeight)
                {
                    currentPanel.Height -= dropdownStep;
                }
                else
                {
                    dropdownTimer.Stop();
                    currentPanel.Height = dropdownMinHeight;
                }
            }
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDownVinh, 180);
        }

        private void btnDropDown1_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDown1, 180);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ttnguoidung());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Thông tin người dùng";
        }

        private void btnDropDown2_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDownNgoc, 180);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpanded)
            {
                if (PanelSideBar.Width > sidebarMinWidth)
                {
                    PanelSideBar.Width -= sidebarStep; // Thu nhỏ
                }
                else
                {
                    sidebarTimer.Stop();
                    isSidebarExpanded = false;
                }
            }
            else
            {
                if (PanelSideBar.Width < sidebarMaxWidth)
                {
                    PanelSideBar.Width += sidebarStep; // Mở rộng
                }
                else
                {
                    sidebarTimer.Stop();
                    isSidebarExpanded = true;
                }
            }

            if (PanelSideBar.Width == sidebarMinWidth || PanelSideBar.Width == sidebarMaxWidth)
            {
                foreach (Control ctrl in PanelSideBar.Controls)
                {
                    ctrl.Visible = true;  // Hiện lại khi hoàn tất
                }
            }
            else
            {
                foreach (Control ctrl in PanelSideBar.Controls)
                {
                    ctrl.Visible = false; // Ẩn khi đang thay đổi kích thước
                }
            }
        }

        private void ImabtnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSinhVien());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý sinh viên";

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLopHoc());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý lớp học";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XepLopHoc());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Xếp lớp học sinh viên";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new qlymonhoc());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý môn học";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new qlykhoahoc());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý khóa học";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new suckhoe());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Hồ sơ sức khỏe";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new kyluat());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý kỷ luật";
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new hocbong());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý học bổng";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Phanquyen());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý phân quyền";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Nganhhoc());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý ngành học";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Giangvien());
            CloseCurrentDropdown();
            labelTitleHeader.Text = "Quản lý giảng viên";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDownAnh, 180);
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDownTung, 180);
        }
    }
}