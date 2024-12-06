using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class OtziviWin : Form
    {
        bool stopWindow = true;
        public OtziviWin()
        {
            InitializeComponent();
        }

        private void AkciiWin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Pizzas". При необходимости она может быть перемещена или удалена.
            this.pizzasTableAdapter.Fill(this.pizzeriaDataSet.Pizzas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.pizzeriaDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Reviews". При необходимости она может быть перемещена или удалена.
            this.reviewsTableAdapter.Fill(this.pizzeriaDataSet.Reviews);

        }

        private void Vixod_Click(object sender, EventArgs e)
        {
            stopWindow = false;
            Form aut = new MenuPol();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void OtziviWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stopWindow) Application.Exit();
        }
    }
}
