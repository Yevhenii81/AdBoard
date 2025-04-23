//using System;
//using System.Data.SqlClient;
//using System.Windows.Forms;
//using AdBoard.Models;

//namespace AdBoard
//{
//    public partial class LoginForm : Form1
//    {
//        public LoginForm()
//        {
//            InitializeComponent();
//        }

//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            string email = txtEmail.Text.Trim();
//            string password = txtPassword.Text.Trim();
//            string passwordHash = HashPassword(password); // хешування

//            using (SqlConnection conn = DatabaseHelper.GetConnection())
//            {
//                conn.Open();
//                string query = "SELECT UserId, Username, Email, Role FROM Users WHERE Email = @Email AND PasswordHash = @PasswordHash";
//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.AddWithValue("@Email", email);
//                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {
//                            User user = new User
//                            {
//                                UserId = reader.GetInt32(0),
//                                Username = reader.GetString(1),
//                                Email = reader.GetString(2),
//                                Role = reader.GetString(3)
//                            };

//                            // Переходимо до головної форми
//                            this.Hide();
//                            MainForm mainForm = new MainForm(user);
//                            mainForm.Show();
//                        }
//                        else
//                        {
//                            MessageBox.Show("Невірний email або пароль.");
//                        }
//                    }
//                }
//            }
//        }

//        private string HashPassword(string password)
//        {
//            using (var sha = System.Security.Cryptography.SHA256.Create())
//            {
//                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
//                byte[] hash = sha.ComputeHash(bytes);
//                return Convert.ToBase64String(hash);
//            }
//        }
//    }
//}
