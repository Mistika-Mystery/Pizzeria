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
    public partial class Akcii : Form
    {
        bool stopWindow = true;
        public Akcii()
        {
            InitializeComponent();
        }

        private void Akcii_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Promotions". При необходимости она может быть перемещена или удалена.
            this.promotionsTableAdapter.Fill(this.pizzeriaDataSet.Promotions);

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

        private void Akcii_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stopWindow) Application.Exit();
        }
    }
}
