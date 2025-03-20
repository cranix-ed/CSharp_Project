using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest.Helpers
{
    internal class CheckInputHelper
    {
        // 🟢 KIỂM TRA CHUỖI CÓ RỖNG KHÔNG
        public static bool IsEmpty(string input, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($"{fieldName} không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        // 🟢 KIỂM TRA ĐỊNH DẠNG EMAIL
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // 🟢 KIỂM TRA EMAIL & HIỂN THỊ LỖI
        public static bool CheckEmail(string email)
        {
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 🟢 KIỂM TRA SỐ ĐIỆN THOẠI
        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;

            string phonePattern = @"^\d{10}$";
            return Regex.IsMatch(phone, phonePattern);
        }

        public static bool CheckPhoneNumber(string phone)
        {
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 🟢 KIỂM TRA ĐỊNH DẠNG SỐ NGUYÊN
        public static bool IsInteger(string input, string fieldName)
        {
            if (!int.TryParse(input, out _))
            {
                MessageBox.Show($"{fieldName} phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 🟢 KIỂM TRA CHIỀU DÀI CHUỖI
        public static bool CheckLength(string input, string fieldName, int minLength, int maxLength)
        {
            if (input.Length < minLength || input.Length > maxLength)
            {
                MessageBox.Show($"{fieldName} phải từ {minLength} đến {maxLength} ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
