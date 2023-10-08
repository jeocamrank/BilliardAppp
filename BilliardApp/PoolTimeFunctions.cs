using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardApp
{
    public static class PoolTimeFunctions
    {
        private static string connectionString = @"Data Source=DESKTOP-FC6I5GK;Initial Catalog=BilliardApp;Integrated Security=True";

        public static int StartSession(string username, int tableId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Lấy thời gian bắt đầu
                DateTime startTime = DateTime.Now;

                // Chuyển đổi thời gian bắt đầu thành chuỗi đúng định dạng để lưu vào cơ sở dữ liệu
                string formattedStartTime = startTime.ToString("yyyy-MM-dd HH:mm:ss");

                // Thực hiện INSERT phiên chơi mới
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Sessions (TimeBegin, TableId, UserId) VALUES (@TimeBegin, @TableId, @UserId); SELECT SCOPE_IDENTITY();", connection))
                {
                    cmd.Parameters.AddWithValue("@TimeBegin", formattedStartTime);
                    cmd.Parameters.AddWithValue("@TableId", tableId);
                    cmd.Parameters.AddWithValue("@UserId", GetUserIdByUsername(username));

                    int phienId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Cập nhật trạng thái của bàn
                    UpdateTableStatus(tableId, "In Use");

                    return phienId;
                }
            }
        }

        public static void EndSession(int phienId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Lấy thời gian kết thúc
                DateTime endTime = DateTime.Now;

                // Chuyển đổi thời gian kết thúc thành chuỗi đúng định dạng để lưu vào cơ sở dữ liệu
                string formattedEndTime = endTime.ToString("yyyy-MM-dd HH:mm:ss");

                // Tính toán tổng tiền
                decimal totalCost = CalculateSessionCost(phienId);

                // Cập nhật thời gian kết thúc và tổng tiền
                using (SqlCommand cmd = new SqlCommand("UPDATE Sessions SET TimeEnd = @TimeEnd, TotalAmount = @TotalAmount WHERE PhienId = @PhienId", connection))
                {
                    cmd.Parameters.AddWithValue("@TimeEnd", formattedEndTime);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalCost);
                    cmd.Parameters.AddWithValue("@PhienId", phienId);
                    cmd.ExecuteNonQuery();
                }

                // Cập nhật trạng thái của bàn
                int tableId = GetTableIdBySessionId(phienId);
                UpdateTableStatus(tableId, "Available");
            }
        }
        public static int GetTableIdBySessionId(int phienId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT TableId FROM Sessions WHERE PhienId = @PhienId", connection))
                {
                    cmd.Parameters.AddWithValue("@PhienId", phienId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static decimal CalculateSessionCost(int phienId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Lấy thời gian bắt đầu và kết thúc
                using (SqlCommand cmd = new SqlCommand("SELECT TimeBegin, TimeEnd FROM Sessions WHERE PhienId = @PhienId", connection))
                {
                    cmd.Parameters.AddWithValue("@PhienId", phienId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    DateTime startTime = reader.GetDateTime(0);
                    DateTime endTime = reader.GetDateTime(1);

                    reader.Close();

                    // Tính tiền thời gian
                    decimal cost = CalculateCost(startTime, endTime);

                    return cost;
                }
            }
        }

        private static decimal CalculateCost(DateTime startTime, DateTime endTime)
        {
            TimeSpan duration = endTime - startTime;
            double totalHours = duration.TotalHours;
            decimal pricePerHour = 80000; // Giá mỗi giờ

            decimal totalCost = Convert.ToDecimal(totalHours) * pricePerHour;
            return totalCost;
        }


        private static int GetUserIdByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT UserId FROM Users WHERE account = @Username", connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private static void UpdateTableStatus(int tableId, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Tables SET Status = @Status WHERE TableId = @TableId", connection))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@TableId", tableId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
