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
    public partial class Postavki : Form
    {
        bool stopWindow = true;
        public Postavki()
        {
            InitializeComponent();
        }

        private void Postavki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Ingredients". При необходимости она может быть перемещена или удалена.
            this.ingredientsTableAdapter.Fill(this.pizzeriaDataSet.Ingredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.PizzaIngredients". При необходимости она может быть перемещена или удалена.
            this.pizzaIngredientsTableAdapter.Fill(this.pizzeriaDataSet.PizzaIngredients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.pizzeriaDataSet.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pizzeriaDataSet.Supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.pizzeriaDataSet.Supplies);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Soxran_Click(object sender, EventArgs e)
        {
            try
            {
                ingredientsTableAdapter.Update(pizzeriaDataSet.Ingredients);
                pizzaIngredientsTableAdapter.Update(pizzeriaDataSet.PizzaIngredients);
                suppliersTableAdapter.Update(pizzeriaDataSet.Suppliers);
                suppliesTableAdapter.Update(pizzeriaDataSet.Supplies);
                MessageBox.Show("Данные сохранены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
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

        private void Postavki_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stopWindow) Application.Exit();
        }
    }
    }

