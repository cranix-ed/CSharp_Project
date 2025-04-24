using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp.Helpers
{
    internal class ExcelHelper
    {
        public static DataTable ReadExcel(string filePath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("My Name");

            DataTable dt = new DataTable();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                if (worksheet.Dimension == null)
                    throw new Exception("File Excel không có dữ liệu!");

                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;

                // Lấy tiêu đề cột từ hàng đầu tiên
                for (int col = 1; col <= colCount; col++)
                {
                    var columnName = worksheet.Cells[1, col].Value?.ToString() ?? $"Column{col}";
                    dt.Columns.Add(columnName);
                }

                // Lấy dữ liệu từ hàng thứ 2 trở đi
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dr = dt.NewRow();
                    for (int col = 1; col <= colCount; col++)
                    {
                        dr[col - 1] = worksheet.Cells[row, col].Value?.ToString() ?? string.Empty;
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        public static void ExportDataGridViewToExcel(DataGridView dgv, string fileName = "DanhSachSinhVien.xlsx")
        {
            // Bắt buộc với EPPlus từ phiên bản 8 trở lên
            ExcelPackage.License.SetNonCommercialPersonal("My Name");

            try
            {
                // Lấy đường dẫn đến thư mục bin (Debug/Release)
                string binPath = AppDomain.CurrentDomain.BaseDirectory;

                // Lùi lên 2 cấp để đến thư mục gốc project
                string projectRoot = Path.GetFullPath(Path.Combine(binPath, @"..\..\"));

                string folderPath = Path.Combine(projectRoot, "Resources", "Excel");

                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                // Đường dẫn file cuối cùng
                string fullPath = Path.Combine(folderPath, fileName);

                using (ExcelPackage package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("SinhVien");

                    // Tiêu đề cột
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dgv.Columns[col].HeaderText;
                    }

                    // Dữ liệu
                    for (int row = 0; row < dgv.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dgv.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    // AutoFit
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Ghi file
                    File.WriteAllBytes(fullPath, package.GetAsByteArray());

                    MessageBox.Show($"Xuất Excel thành công!\nĐường dẫn: {fullPath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

