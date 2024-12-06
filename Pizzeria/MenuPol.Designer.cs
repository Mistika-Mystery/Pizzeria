namespace Pizzeria
{
    partial class MenuPol
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
            this.GlavCTR = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            this.Akcii = new System.Windows.Forms.Label();
            this.Otzivi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Vixod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GlavCTR
            // 
            this.GlavCTR.AutoSize = true;
            this.GlavCTR.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GlavCTR.ForeColor = System.Drawing.Color.Peru;
            this.GlavCTR.Location = new System.Drawing.Point(137, 112);
            this.GlavCTR.Name = "GlavCTR";
            this.GlavCTR.Size = new System.Drawing.Size(439, 50);
            this.GlavCTR.TabIndex = 0;
            this.GlavCTR.Text = "ГЛАВНАЯ СТРАНИЦА";
            this.GlavCTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.ForeColor = System.Drawing.Color.Chocolate;
            this.Menu.Location = new System.Drawing.Point(286, 214);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(110, 39);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Меню";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Akcii
            // 
            this.Akcii.AutoSize = true;
            this.Akcii.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.Akcii.ForeColor = System.Drawing.Color.Chocolate;
            this.Akcii.Location = new System.Drawing.Point(286, 284);
            this.Akcii.Name = "Akcii";
            this.Akcii.Size = new System.Drawing.Size(116, 39);
            this.Akcii.TabIndex = 2;
            this.Akcii.Text = "Акции";
            this.Akcii.Click += new System.EventHandler(this.Akcii_Click);
            // 
            // Otzivi
            // 
            this.Otzivi.AutoSize = true;
            this.Otzivi.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold);
            this.Otzivi.ForeColor = System.Drawing.Color.Chocolate;
            this.Otzivi.Location = new System.Drawing.Point(274, 353);
            this.Otzivi.Name = "Otzivi";
            this.Otzivi.Size = new System.Drawing.Size(138, 39);
            this.Otzivi.TabIndex = 3;
            this.Otzivi.Text = "Отзывы";
            this.Otzivi.Click += new System.EventHandler(this.Otzivi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pizzeria.Properties.Resources.pngwing1;
            this.pictureBox1.Location = new System.Drawing.Point(-33, -136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 850);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Vixod
            // 
            this.Vixod.Location = new System.Drawing.Point(308, 410);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(75, 23);
            this.Vixod.TabIndex = 5;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // MenuPol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 575);
            this.Controls.Add(this.Vixod);
            this.Controls.Add(this.Otzivi);
            this.Controls.Add(this.Akcii);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.GlavCTR);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuPol";
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPol_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GlavCTR;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label Akcii;
        private System.Windows.Forms.Label Otzivi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Vixod;
    }
}