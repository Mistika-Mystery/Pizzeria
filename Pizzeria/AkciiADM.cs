using Pizzeria.PizzeriaDataSetTableAdapters;
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
    public partial class AkciiADM : Form
    {
        bool stopWindow = true;
        public AkciiADM()
        {
            InitializeComponent();
        }

        private void AkciiADM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Promotions". При необходимости она может быть перемещена или удалена.
            this.promotionsTableAdapter.Fill(this.pizzeriaDataSet.Promotions);

        }

        private void Soxran_Click(object sender, EventArgs e)
        {
            try
            {
                promotionsTableAdapter.Update(pizzeriaDataSet.Promotions);
                MessageBox.Show("Данные сохранены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 547:
                        MessageBox.Show("Невозможно изменить данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        MessageBox.Show("Невозможно изменить данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                }
            }
        }

        private void Vixod_Click(object sender, EventArgs e)
        {
            stopWindow = false;
            Form aut = new MenuAdm();
            aut.Left = this.Left;
            aut.Top = this.Top;
            aut.Show();
            this.Close();
        }

        private void AkciiADM_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stopWindow) Application.Exit();
        }
    }
}
