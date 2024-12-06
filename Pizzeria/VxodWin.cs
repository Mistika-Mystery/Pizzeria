using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Net;
namespace Pizzeria
{
    public partial class VxodWin : Form
    {
        bool stopWindow = true;
        public static bool isAdmin;
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Pizzeria;Integrated Security=True";
        public VxodWin()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = pass.Text;
            if (ValidateUser(login, password, out bool isAdmin))
            {
                Login.Clear();
                pass.Clear();
                Error.Visible = false;

                Form mnu;
                if (isAdmin)
                {
                    mnu = new MenuAdm(); 
                }
                else
                {
                    mnu = new MenuPol(); 
                }
                stopWindow = false;
                mnu.Left = this.Left;
                mnu.Top = this.Top;
                mnu.Show();
                this.Hide();
            }
            else
            {
                Error.Visible = true;
            }
        }

        private bool ValidateUser(string login, string password, out bool isAdmin)
        {
            isAdmin = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PositionID FROM Users WHERE login=@login AND password=@password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        isAdmin = Convert.ToInt32(result) == 1;
                        return true;
                    }
                    return false;
                }
            }
        }


        private void regist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            stopWindow = false;
            Login.Clear();
            pass.Clear();
            Error.Visible = false;
            Form menu1 = new Reg();
            menu1.Left = this.Left;
            menu1.Top = this.Top;
            menu1.Show();
            this.Hide();
        }

        private void VxodWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stopWindow) Application.Exit();
        }
    }
}
