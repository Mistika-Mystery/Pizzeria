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

namespace Pizzeria
{
    public partial class Reg : Form
    {
        bool stopWindow = true;
        public Reg()
        {
            InitializeComponent();
        }
        private void new_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_reg_Click(object sender, EventArgs e)
        {
            stopWindow = false;
            string login1= new_login.Text.Trim();
            string password1= new_pass.Text.Trim();
            string password2= povt_pass.Text.Trim();
            bool admin = false;

            if (string.IsNullOrEmpty(login1) || string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Pizzeria;Integrated Security=True"))
                {
                    connection.Open();
                    string Test = "SELECT COUNT(*) FROM Users WHERE Login=@login";
                    using (SqlCommand testSql = new SqlCommand(Test, connection))
                    {
                        testSql.Parameters.AddWithValue("@Login", login1);
                        int validUser = (int)testSql.ExecuteScalar();

                        if (validUser > 0)
                        {
                            MessageBox.Show("Логин поменяй, уже есть такой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string AddUser = "INSERT INTO Users(Login, Password,PositionID) VALUES (@Login, @Password,@PositionID)";
                    using (SqlCommand addSql = new SqlCommand(AddUser, connection))
                    {
                        addSql.Parameters.AddWithValue("@Login", login1);
                        addSql.Parameters.AddWithValue("@Password", password1);
                        addSql.Parameters.AddWithValue("@PositionID", admin);

                        int testAdd = addSql.ExecuteNonQuery();

                        if (testAdd > 0)
                        {
                            MessageBox.Show("Регистрация успешна!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form aut = new MenuPol();
                            aut.Left = this.Left;
                            aut.Top = this.Top;
                            aut.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось зарегистрироваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось зарегистрироваться:{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void new_vxod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            stopWindow = false;
            new_login.Clear();
            new_pass.Clear();
            povt_pass.Visible = false;
            Form mnu = new VxodWin();
            mnu.Left = this.Left;
            mnu.Top = this.Top;
            mnu.Show();
            this.Hide();
        }

        private void povt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
             if (stopWindow) Application.Exit();
        }
    }
}
