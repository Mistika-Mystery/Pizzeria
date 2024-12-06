namespace Pizzeria
{
    partial class AkciiADM
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
            this.Soxran = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 396);
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
            this.promotionNameDataGridViewTextBoxColumn.HeaderText = "Название акции";
            this.promotionNameDataGridViewTextBoxColumn.Name = "promotionNameDataGridViewTextBoxColumn";
            this.promotionNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // discountPercentageDataGridViewTextBoxColumn
            // 
            this.discountPercentageDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.HeaderText = "Процент скидки";
            this.discountPercentageDataGridViewTextBoxColumn.Name = "discountPercentageDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
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
            // Soxran
            // 
            this.Soxran.Location = new System.Drawing.Point(387, 439);
            this.Soxran.Name = "Soxran";
            this.Soxran.Size = new System.Drawing.Size(75, 23);
            this.Soxran.TabIndex = 1;
            this.Soxran.Text = "Сохранить";
            this.Soxran.UseVisualStyleBackColor = true;
            this.Soxran.Click += new System.EventHandler(this.Soxran_Click);
            // 
            // Vixod
            // 
            this.Vixod.Location = new System.Drawing.Point(13, 438);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(75, 23);
            this.Vixod.TabIndex = 2;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // AkciiADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 548);
            this.Controls.Add(this.Vixod);
            this.Controls.Add(this.Soxran);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AkciiADM";
            this.Text = "AkciiADM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AkciiADM_FormClosed);
            this.Load += new System.EventHandler(this.AkciiADM_Load);
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
        private System.Windows.Forms.Button Soxran;
        private System.Windows.Forms.Button Vixod;
    }
}