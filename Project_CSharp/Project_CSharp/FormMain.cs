using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class FormMain : Form
    {
        private Dictionary<Panel, bool> dropdownStates = new Dictionary<Panel, bool>(); // Lưu trạng thái mở/đóng cho từng panel
        
        private Panel currentPanel;
        private int dropdownMaxHeight;
        private int dropdownMinHeight = 45;
        private int dropdownStep = 10; // Mỗi lần tăng/giảm bao nhiêu pixel
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void CloseCurrentDropdown()
        {
            if (currentPanel != null && dropdownStates[currentPanel])
            {
                dropdownStates[currentPanel] = false;
                timer1.Start(); // Kích hoạt hiệu ứng đóng
            }
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

            timer1.Start(); // Kích hoạt hiệu ứng
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
                    timer1.Stop();
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
                    timer1.Stop();
                    currentPanel.Height = dropdownMinHeight;
                }
            }
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDown, 180);
        }

        private void btnDropDown1_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDown1, 180);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            CloseCurrentDropdown();
        }

        private void btnDropDown2_Click(object sender, EventArgs e)
        {
            ToggleDropdown(panelDropDown2, 180);
        }
    }
}
