namespace Pizzeria
{
    partial class Akcii
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
            this.promotionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaDataSet = new Pizzeria.PizzeriaDataSet();
            this.promotionsTableAdapter = new Pizzeria.PizzeriaDataSetTableAdapters.PromotionsTableAdapter();
            this.Vixod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.promotionIDDataGridViewTextBoxColumn,
            this.promotionNameDataGridViewTextBoxColumn,
            this.discountPercentageDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.promotionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // promotionIDDataGridViewTextBoxColumn
            // 
            this.promotionIDDataGridViewTextBoxColumn.DataPropertyName = "PromotionID";
            this.promotionIDDataGridViewTextBoxColumn.HeaderText = "PromotionID";
            this.promotionIDDataGridViewTextBoxColumn.Name = "promotionIDDataGridViewTextBoxColumn";
            this.promotionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.promotionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // promotionNameDataGridViewTextBoxColumn
            // 
            this.promotionNameDataGridViewTextBoxColumn.DataPropertyName = "PromotionName";
            this.promotionNameDataGridViewTextBoxColumn.HeaderText = "Акция";
            this.promotionNameDataGridViewTextBoxColumn.Name = "promotionNameDataGridViewTextBoxColumn";
            this.promotionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountPercentageDataGridViewTextBoxColumn
            // 
            this.discountPercentageDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.discountPercentageDataGridViewTextBoxColumn.Name = "discountPercentageDataGridViewTextBoxColumn";
            this.discountPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Дата конца";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // promotionsBindingSource
            // 
            this.promotionsBindingSource.DataMember = "Promotions";
            this.promotionsBindingSource.DataSource = this.pizzeriaDataSet;
            // 
            // pizzeriaDataSet
            // 
            this.pizzeriaDataSet.DataSetName = "PizzeriaDataSet";
            this.pizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promotionsTableAdapter
            // 
            this.promotionsTableAdapter.ClearBeforeFill = true;
            // 
            // Vixod
            // 
            this.Vixod.Location = new System.Drawing.Point(25, 416);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(75, 23);
            this.Vixod.TabIndex = 1;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // Akcii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 451);
            this.Controls.Add(this.Vixod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Akcii";
            this.Text = "Akcii";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Akcii_FormClosed);
            this.Load += new System.EventHandler(this.Akcii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzeriaDataSet pizzeriaDataSet;
        private System.Windows.Forms.BindingSource promotionsBindingSource;
        private PizzeriaDataSetTableAdapters.PromotionsTableAdapter promotionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Vixod;
    }
}