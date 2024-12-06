namespace Pizzeria
{
    partial class MenuPolWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pizzaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaDataSet = new Pizzeria.PizzeriaDataSet();
            this.pizzasTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.PizzasTableAdapter();
            this.Vixod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pizzaIDDataGridViewTextBoxColumn,
            this.pizzaNameDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pizzasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pizzaIDDataGridViewTextBoxColumn
            // 
            this.pizzaIDDataGridViewTextBoxColumn.DataPropertyName = "PizzaID";
            this.pizzaIDDataGridViewTextBoxColumn.HeaderText = "PizzaID";
            this.pizzaIDDataGridViewTextBoxColumn.Name = "pizzaIDDataGridViewTextBoxColumn";
            this.pizzaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pizzaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pizzaNameDataGridViewTextBoxColumn
            // 
            this.pizzaNameDataGridViewTextBoxColumn.DataPropertyName = "PizzaName";
            this.pizzaNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.pizzaNameDataGridViewTextBoxColumn.Name = "pizzaNameDataGridViewTextBoxColumn";
            this.pizzaNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pizzasBindingSource
            // 
            this.pizzasBindingSource.DataMember = "Pizzas";
            this.pizzasBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // pizzeriaDataSet
            // 
            this.pizzeriaDataSet.DataSetName = "PizzeriaDataSet";
            this.pizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzasTableAdapter
            // 
            this.pizzasTableAdapter.ClearBeforeFill = true;
            // 
            // Vixod
            // 
            this.Vixod.Location = new System.Drawing.Point(27, 332);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(75, 23);
            this.Vixod.TabIndex = 1;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // MenuPolWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 388);
            this.Controls.Add(this.Vixod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenuPolWin";
            this.Text = "MenuPolWin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPolWin_FormClosed);
            this.Load += new System.EventHandler(this.MenuPolWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzeriaDataSet pizzeriaDataSet;
        private System.Windows.Forms.BindingSource pizzasBindingSource;
        private PizzeriaDataSetTableAdapters.PizzasTableAdapter pizzasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Vixod;
    }
}