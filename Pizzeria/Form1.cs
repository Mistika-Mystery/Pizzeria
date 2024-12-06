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
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void Postavka_Click(object sender, EventArgs e)
        {
            Form aut = new MenuPol();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void MenuMenu_Click(object sender, EventArgs e)
        {
            Form aut = new MenuPol();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void Otzivi_Click(object sender, EventArgs e)
        {
            Form aut = new MenuPol();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void Dostavki_Click(object sender, EventArgs e)
        {
            Form aut = new MenuPol();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void UsersUsers_Click(object sender, EventArgs e)
        {
            Form aut = new MenuPol();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void Akcii_Click(object sender, EventArgs e)
        {
            Form aut = new MenuPol();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void Vixod_Click(object sender, EventArgs e)
        {
            Form aut = new VxodWin();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }
    }
}
