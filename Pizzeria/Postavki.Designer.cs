namespace Pizzeria
{
    partial class Postavki
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
            this.supplyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaDataSet = new Pizzeria.PizzeriaDataSet();
            this.ingredientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.suppliesTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.SuppliesTableAdapter();
            this.suppliersTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.SuppliersTableAdapter();
            this.pizzaIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaIngredientsTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.PizzaIngredientsTableAdapter();
            this.ingredientsTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.IngredientsTableAdapter();
            this.Soxran = new System.Windows.Forms.Button();
            this.vixod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaIngredientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplyIDDataGridViewTextBoxColumn,
            this.postavkaDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.ingredientIDDataGridViewTextBoxColumn,
            this.supplyDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.suppliesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supplyIDDataGridViewTextBoxColumn
            // 
            this.supplyIDDataGridViewTextBoxColumn.DataPropertyName = "SupplyID";
            this.supplyIDDataGridViewTextBoxColumn.HeaderText = "SupplyID";
            this.supplyIDDataGridViewTextBoxColumn.Name = "supplyIDDataGridViewTextBoxColumn";
            this.supplyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // postavkaDataGridViewTextBoxColumn
            // 
            this.postavkaDataGridViewTextBoxColumn.DataPropertyName = "SupplyDate";
            this.postavkaDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.postavkaDataGridViewTextBoxColumn.Name = "postavkaDataGridViewTextBoxColumn";
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.DataSource = this.suppliersBindingSource;
            this.supplierIDDataGridViewTextBoxColumn.DisplayMember = "ContactName";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplierIDDataGridViewTextBoxColumn.ValueMember = "SupplierID";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // pizzeriaDataSet
            // 
            this.pizzeriaDataSet.DataSetName = "PizzeriaDataSet";
            this.pizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientIDDataGridViewTextBoxColumn
            // 
            this.ingredientIDDataGridViewTextBoxColumn.DataPropertyName = "IngredientID";
            this.ingredientIDDataGridViewTextBoxColumn.DataSource = this.ingredientsBindingSource;
            this.ingredientIDDataGridViewTextBoxColumn.DisplayMember = "IngredientName";
            this.ingredientIDDataGridViewTextBoxColumn.HeaderText = "Ингредиенты";
            this.ingredientIDDataGridViewTextBoxColumn.Name = "ingredientIDDataGridViewTextBoxColumn";
            this.ingredientIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ingredientIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ingredientIDDataGridViewTextBoxColumn.ValueMember = "IngredientID";
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // supplyDateDataGridViewTextBoxColumn
            // 
            this.supplyDateDataGridViewTextBoxColumn.DataPropertyName = "SupplyDate";
            this.supplyDateDataGridViewTextBoxColumn.DataSource = this.suppliesBindingSource;
            this.supplyDateDataGridViewTextBoxColumn.DisplayMember = "SupplyDate";
            this.supplyDateDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.supplyDateDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.supplyDateDataGridViewTextBoxColumn.Name = "supplyDateDataGridViewTextBoxColumn";
            this.supplyDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplyDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplyDateDataGridViewTextBoxColumn.ValueMember = "SupplyDate";
            this.supplyDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "Supplies";
            this.suppliesBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.DataSource = this.suppliesBindingSource;
            this.quantityDataGridViewTextBoxColumn.DisplayMember = "Quantity";
            this.quantityDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.quantityDataGridViewTextBoxColumn.ValueMember = "Quantity";
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // pizzaIngredientsBindingSource
            // 
            this.pizzaIngredientsBindingSource.DataMember = "PizzaIngredients";
            this.pizzaIngredientsBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // pizzaIngredientsTableAdapter
            // 
            this.pizzaIngredientsTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // Soxran
            // 
            this.Soxran.Location = new System.Drawing.Point(388, 431);
            this.Soxran.Name = "Soxran";
            this.Soxran.Size = new System.Drawing.Size(75, 23);
            this.Soxran.TabIndex = 2;
            this.Soxran.Text = "Сохранить";
            this.Soxran.UseVisualStyleBackColor = true;
            this.Soxran.Click += new System.EventHandler(this.Soxran_Click);
            // 
            // vixod
            // 
            this.vixod.Location = new System.Drawing.Point(27, 430);
            this.vixod.Name = "vixod";
            this.vixod.Size = new System.Drawing.Size(75, 23);
            this.vixod.TabIndex = 3;
            this.vixod.Text = "Выход";
            this.vixod.UseVisualStyleBackColor = true;
            this.vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // Postavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 466);
            this.Controls.Add(this.vixod);
            this.Controls.Add(this.Soxran);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Postavki";
            this.Text = "Postavki";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Postavki_FormClosed);
            this.Load += new System.EventHandler(this.Postavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaIngredientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzeriaDataSet pizzeriaDataSet;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private PizzeriaDataSetTableAdapters.SuppliesTableAdapter suppliesTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private PizzeriaDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource pizzaIngredientsBindingSource;
        private PizzeriaDataSetTableAdapters.PizzaIngredientsTableAdapter pizzaIngredientsTableAdapter;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private PizzeriaDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ingredientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Soxran;
        private System.Windows.Forms.Button vixod;
    }
}