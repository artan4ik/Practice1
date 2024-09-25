using meow11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zalupka3d
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection;
        
        public LoginForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=localhost;Initial Catalog=Pizdets;Integrated Security=True;Encrypt=False");
            connection.Open();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Код для авторизации
            string query = "SELECT * FROM Users WHERE Login = @Login AND Password = @Password ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Login", textBoxLogin.Text);
            command.Parameters.AddWithValue("@Password", textBoxPassword.Text);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Авторизация успешна
                MessageBox.Show("Авторизация успешна");
               
                string roleName = reader["RoleName"].ToString();
                MessageBox.Show("Добро пожаловать, " + roleName);
               
                    Form1 form1 = new Form1(roleName);
                    form1.Show();
                    this.Hide();
               

            }
            else
            {
                // Авторизация неуспешна
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

