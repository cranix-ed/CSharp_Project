using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsAppTest.Helpers
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=DESKTOP-G15R77V\\SQLEXPRESS;Initial Catalog=tacgia;User ID=sa;Password=56tfg7hj8"; // Thay bằng chuỗi kết nối thực tế

        public DatabaseHelper(string connString)
        {
            this.connectionString = connString;
        }

        // HÀM INSERT DỮ LIỆU
        public bool InsertData(string tableName, Dictionary<string, object> data)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string columns = string.Join(", ", data.Keys);
                    string parameters = string.Join(", ", data.Keys.Select(k => "@" + k));

                    string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        foreach (var item in data)
                        {
                            command.Parameters.AddWithValue("@" + item.Key, item.Value ?? DBNull.Value);
                        }
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // HÀM UPDATE DỮ LIỆU
        public bool UpdateData(string tableName, Dictionary<string, object> data, string whereClause, params SqlParameter[] whereParams)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string setClause = string.Join(", ", data.Keys.Select(k => $"{k} = @{k}"));

                    string query = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        foreach (var item in data)
                        {
                            command.Parameters.AddWithValue("@" + item.Key, item.Value ?? DBNull.Value);
                        }
                        command.Parameters.AddRange(whereParams);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // HÀM DELETE DỮ LIỆU
        public bool DeleteData(string tableName, string whereClause, params SqlParameter[] whereParams)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"DELETE FROM {tableName} WHERE {whereClause}";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddRange(whereParams);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // HÀM TÌM KIẾM DỮ LIỆU
        public DataTable SearchData(string tableName, string columns = "*", string joinQuery = "", string whereClause = "1=1", params SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT {columns} FROM {tableName} {joinQuery} WHERE {whereClause}";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dataTable;
        }

        // HÀM LOAD DATA LÊN DATAGRIDVIEW
        public void LoadDataToDataGridView(DataGridView dgv, string tableName, string columns = "*", string joinQuery = "", string whereClause = "1=1", params SqlParameter[] parameters)
        {
            DataTable dataTable = SearchData(tableName, columns, joinQuery, whereClause, parameters);
            dgv.DataSource = dataTable;
        }

        // HÀM LOAD DATA LÊN COMBOBOX
        public void LoadComboBox(ComboBox comboBox, string tableName, string displayColumn, string valueColumn, string defaultText = "--Chọn--")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT {valueColumn}, {displayColumn} FROM {tableName}";
                    using (SqlCommand sqlCmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Thêm dòng mặc định
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[displayColumn] = defaultText;
                        dataRow[valueColumn] = DBNull.Value; // Giá trị rỗng
                        dataTable.Rows.InsertAt(dataRow, 0);

                        // Gán dữ liệu vào ComboBox
                        comboBox.DataSource = dataTable;
                        comboBox.DisplayMember = displayColumn;
                        comboBox.ValueMember = valueColumn;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool IsCheckExists(string tableName, Dictionary<string, object> conditions)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string whereClause = string.Join(" AND ", conditions.Keys.Select(k => $"{k} = @{k}"));
                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE {whereClause}";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        foreach (var condition in conditions)
                        {
                            cmd.Parameters.AddWithValue("@" + condition.Key, condition.Value ?? DBNull.Value);
                        }

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool CheckExists(string tableName, Dictionary<string, object> conditions, string fieldName = "Dữ liệu")
        {
            bool exists = IsCheckExists(tableName, conditions);

            if (exists)
            {
                MessageBox.Show($"{fieldName} đã tồn tại trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // Dừng lại ngay nếu dữ liệu đã tồn tại
            }

            return false; // Trả về false nếu không tồn tại, tiếp tục xử lý
        }

    }
}
