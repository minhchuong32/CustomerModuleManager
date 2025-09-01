using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerModuleManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=CustomerModuleDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Success");
                    String sql = "select * from Customer";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string data = "";
                            while (reader.Read())
                            {
                                // Ví dụ lấy 2 cột CustomerID và FullName
                                data += $"ID: {reader["CustomerID"]}, Name: {reader["FullName"]}\n";
                            }
                            MessageBox.Show(data == "" ? "Không có dữ liệu" : data);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
