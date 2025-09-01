using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CustomerModuleManager.DAL
{
    public class DbHelper
    {
        // Lấy chuỗi kết nối từ file cấu hình
        private static string connStr = ConfigurationManager.ConnectionStrings["CustomerDB"].ConnectionString;


        // Lấy đối tượng kết nối SQL
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

        // Thực thi SELECT, trả về DataTable
        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn); // đối tượng gửi lệnh sql -> sqlserver

            // nếu truyền tham số (where @id = id) 
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    cmd.Parameters.Add(p);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd); //cầu nối giữa SQL Server và DataTable/DataSet.
            DataTable dt = new DataTable();
            da.Fill(dt);



            // giải phóng bộ nhớ 
            da.Dispose();
            dt.Dispose();
            conn.Dispose();


            return dt;
        }


        // Thực thi INSERT/UPDATE/DELETE
        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);

            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    cmd.Parameters.Add(p);
                }
            }

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
            conn.Dispose();

            return rows;
        }

        // Thực thi và trả về 1 giá trị duy nhất
        public static object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);

            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    cmd.Parameters.Add(p);
                }
            }

            conn.Open();
            object result = cmd.ExecuteScalar();

            cmd.Dispose();
            conn.Close();
            conn.Dispose();

            return result;
        }
    }
}
