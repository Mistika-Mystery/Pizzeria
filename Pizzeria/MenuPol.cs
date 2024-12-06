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
    public partial class MenuPol : Form
    {
        bool stopWindow = true;
        public MenuPol()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            stopWindow = false;
            Form aut = new MenuPolWin();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void Akcii_Click(object sender, EventArgs e)
        {
            stopWindow = false;
            Form aut = new Akcii();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void Otzivi_Click(object sender, EventArgs e)
        {
            stopWindow = false;
            Form aut = new OtziviWin();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void Vixod_Click(object sender, EventArgs e)
        {
            stopWindow = false;
            Form aut = new VxodWin();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void MenuPol_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stopWindow) Application.Exit();
        }
    }
}
