namespace Pizzeria
{
    partial class AdmMenuAdm
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
            this.pizzaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pizzasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaDataSet = new Pizzeria.PizzeriaDataSet();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pizzaCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pizzasTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.PizzasTableAdapter();
            this.pizzaCategoriesTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.PizzaCategoriesTableAdapter();
            this.Soxran = new System.Windows.Forms.Button();
            this.Vixod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaCategoriesBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 376);
            this.dataGridView1.TabIndex = 2;
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
            this.pizzaNameDataGridViewTextBoxColumn.DataSource = this.pizzasBindingSource;
            this.pizzaNameDataGridViewTextBoxColumn.DisplayMember = "PizzaName";
            this.pizzaNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pizzaNameDataGridViewTextBoxColumn.HeaderText = "Пицца";
            this.pizzaNameDataGridViewTextBoxColumn.Name = "pizzaNameDataGridViewTextBoxColumn";
            this.pizzaNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pizzaNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pizzaNameDataGridViewTextBoxColumn.ValueMember = "PizzaName";
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
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.DataSource = this.pizzaCategoriesBindingSource;
            this.categoryIDDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIDDataGridViewTextBoxColumn.ValueMember = "CategoryID";
            // 
            // pizzaCategoriesBindingSource
            // 
            this.pizzaCategoriesBindingSource.DataMember = "PizzaCategories";
            this.pizzaCategoriesBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.DataSource = this.pizzasBindingSource;
            this.priceDataGridViewTextBoxColumn.DisplayMember = "Price";
            this.priceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.priceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.priceDataGridViewTextBoxColumn.ValueMember = "Price";
            // 
            // pizzasTableAdapter
            // 
            this.pizzasTableAdapter.ClearBeforeFill = true;
            // 
            // pizzaCategoriesTableAdapter
            // 
            this.pizzaCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Soxran
            // 
            this.Soxran.Location = new System.Drawing.Point(283, 394);
            this.Soxran.Name = "Soxran";
            this.Soxran.Size = new System.Drawing.Size(75, 23);
            this.Soxran.TabIndex = 3;
            this.Soxran.Text = "Сохранить";
            this.Soxran.UseVisualStyleBackColor = true;
            this.Soxran.Click += new System.EventHandler(this.Soxran_Click);
            // 
            // Vixod
            // 
            this.Vixod.Location = new System.Drawing.Point(23, 394);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(75, 23);
            this.Vixod.TabIndex = 4;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // AdmMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 526);
            this.Controls.Add(this.Vixod);
            this.Controls.Add(this.Soxran);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdmMenuAdm";
            this.Text = "AdmMenuAdm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdmMenuAdm_FormClosed);
            this.Load += new System.EventHandler(this.AdmMenuAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzeriaDataSet pizzeriaDataSet;
        private System.Windows.Forms.BindingSource pizzasBindingSource;
        private PizzeriaDataSetTableAdapters.PizzasTableAdapter pizzasTableAdapter;
        private System.Windows.Forms.BindingSource pizzaCategoriesBindingSource;
        private PizzeriaDataSetTableAdapters.PizzaCategoriesTableAdapter pizzaCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pizzaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Soxran;
        private System.Windows.Forms.Button Vixod;
    }
}