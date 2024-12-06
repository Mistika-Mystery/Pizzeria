namespace Pizzeria
{
    partial class OtziviWin
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
            this.OtziviOkno = new System.Windows.Forms.DataGridView();
            this.reviewIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaDataSet = new Pizzeria.PizzeriaDataSet();
            this.pizzaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewsTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.ReviewsTableAdapter();
            this.usersTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.UsersTableAdapter();
            this.pizzasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzasTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.PizzasTableAdapter();
            this.Vixod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OtziviOkno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OtziviOkno
            // 
            this.OtziviOkno.AutoGenerateColumns = false;
            this.OtziviOkno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtziviOkno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.pizzaIDDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.reviewDateDataGridViewTextBoxColumn});
            this.OtziviOkno.DataSource = this.reviewsBindingSource;
            this.OtziviOkno.Location = new System.Drawing.Point(48, 21);
            this.OtziviOkno.Name = "OtziviOkno";
            this.OtziviOkno.Size = new System.Drawing.Size(546, 400);
            this.OtziviOkno.TabIndex = 1;
            // 
            // reviewIDDataGridViewTextBoxColumn
            // 
            this.reviewIDDataGridViewTextBoxColumn.DataPropertyName = "ReviewID";
            this.reviewIDDataGridViewTextBoxColumn.HeaderText = "ReviewID";
            this.reviewIDDataGridViewTextBoxColumn.Name = "reviewIDDataGridViewTextBoxColumn";
            this.reviewIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reviewIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.customerIDDataGridViewTextBoxColumn.DisplayMember = "Login";
            this.customerIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Имя пользователя";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerIDDataGridViewTextBoxColumn.ValueMember = "CustomerID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // pizzeriaDataSet
            // 
            this.pizzeriaDataSet.DataSetName = "PizzeriaDataSet";
            this.pizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzaIDDataGridViewTextBoxColumn
            // 
            this.pizzaIDDataGridViewTextBoxColumn.DataPropertyName = "PizzaID";
            this.pizzaIDDataGridViewTextBoxColumn.HeaderText = "Пицца";
            this.pizzaIDDataGridViewTextBoxColumn.Name = "pizzaIDDataGridViewTextBoxColumn";
            this.pizzaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pizzaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reviewDateDataGridViewTextBoxColumn
            // 
            this.reviewDateDataGridViewTextBoxColumn.DataPropertyName = "ReviewDate";
            this.reviewDateDataGridViewTextBoxColumn.HeaderText = "Дата отзыва";
            this.reviewDateDataGridViewTextBoxColumn.Name = "reviewDateDataGridViewTextBoxColumn";
            this.reviewDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataMember = "Reviews";
            this.reviewsBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // reviewsTableAdapter
            // 
            this.reviewsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // pizzasBindingSource
            // 
            this.pizzasBindingSource.DataMember = "Pizzas";
            this.pizzasBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // pizzasTableAdapter
            // 
            this.pizzasTableAdapter.ClearBeforeFill = true;
            // 
            // Vixod
            // 
            this.Vixod.Location = new System.Drawing.Point(48, 445);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(75, 23);
            this.Vixod.TabIndex = 2;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // OtziviWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 502);
            this.Controls.Add(this.Vixod);
            this.Controls.Add(this.OtziviOkno);
            this.Name = "OtziviWin";
            this.Text = "Otzivi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OtziviWin_FormClosed);
            this.Load += new System.EventHandler(this.AkciiWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtziviOkno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OtziviOkno;
        private PizzeriaDataSet pizzeriaDataSet;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private PizzeriaDataSetTableAdapters.ReviewsTableAdapter reviewsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PizzeriaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource pizzasBindingSource;
        private PizzeriaDataSetTableAdapters.PizzasTableAdapter pizzasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Vixod;
    }
}