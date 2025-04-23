using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("���� �����, �������� �� ����.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Email, PasswordHash, DateRegistered, Role) VALUES (@Username, @Email, @PasswordHash, @DateRegistered, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", password); // ?? ����� ������������ ���
                        cmd.Parameters.AddWithValue("@DateRegistered", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Role", "User");

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("���������� ������ �������������!");
                        else
                            MessageBox.Show("��������� �� �������.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������: " + ex.Message);
            }
        }

        private void btnShowReports_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // ?? 1. ���������� ����������
                using (SqlCommand cmd1 = new SqlCommand("SELECT TOP 1 Username, DateRegistered FROM Users ORDER BY DateRegistered ASC", conn))
                using (SqlDataReader reader1 = cmd1.ExecuteReader())
                {
                    if (reader1.Read())
                    {
                        string name = reader1["Username"].ToString();
                        DateTime date = Convert.ToDateTime(reader1["DateRegistered"]);
                        MessageBox.Show($"���������� ����������: {name}, {date.ToShortDateString()}");
                    }
                }

                // ?? 2. ������ 3 �����������
                using (SqlCommand cmd2 = new SqlCommand("SELECT TOP 3 Username, DateRegistered FROM Users ORDER BY DateRegistered DESC", conn))
                using (SqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    string result = "������ 3 �����������:\n";
                    while (reader2.Read())
                    {
                        string name = reader2["Username"].ToString();
                        DateTime date = Convert.ToDateTime(reader2["DateRegistered"]);
                        result += $"{name} � {date.ToShortDateString()}\n";
                    }
                    MessageBox.Show(result);
                }

                // ?? 3. ʳ������ ������������ �� ������
                using (SqlCommand cmd3 = new SqlCommand("SELECT Role, COUNT(*) AS Count FROM Users GROUP BY Role", conn))
                using (SqlDataReader reader3 = cmd3.ExecuteReader())
                {
                    string rolesResult = "ʳ������ ������������ �� ������:\n";
                    while (reader3.Read())
                    {
                        string role = reader3["Role"].ToString();
                        int count = Convert.ToInt32(reader3["Count"]);
                        rolesResult += $"{role}: {count}\n";
                    }
                    MessageBox.Show(rolesResult);
                }
            }
        }
    }
}
