namespace Pizzeria
{
    partial class MenuAdm
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
            this.MenuMenu = new System.Windows.Forms.Button();
            this.UsersUsers = new System.Windows.Forms.Button();
            this.Otzivi = new System.Windows.Forms.Button();
            this.Akcii = new System.Windows.Forms.Button();
            this.Postavka = new System.Windows.Forms.Button();
            this.Dostavki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Vixod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuMenu
            // 
            this.MenuMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuMenu.Location = new System.Drawing.Point(72, 210);
            this.MenuMenu.Name = "MenuMenu";
            this.MenuMenu.Size = new System.Drawing.Size(145, 62);
            this.MenuMenu.TabIndex = 0;
            this.MenuMenu.Text = "Меню";
            this.MenuMenu.UseVisualStyleBackColor = true;
            this.MenuMenu.Click += new System.EventHandler(this.MenuMenu_Click);
            // 
            // UsersUsers
            // 
            this.UsersUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersUsers.Location = new System.Drawing.Point(445, 210);
            this.UsersUsers.Name = "UsersUsers";
            this.UsersUsers.Size = new System.Drawing.Size(145, 61);
            this.UsersUsers.TabIndex = 1;
            this.UsersUsers.Text = "Пользователи";
            this.UsersUsers.UseVisualStyleBackColor = true;
            this.UsersUsers.Click += new System.EventHandler(this.UsersUsers_Click);
            // 
            // Otzivi
            // 
            this.Otzivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otzivi.Location = new System.Drawing.Point(72, 295);
            this.Otzivi.Name = "Otzivi";
            this.Otzivi.Size = new System.Drawing.Size(145, 62);
            this.Otzivi.TabIndex = 2;
            this.Otzivi.Text = "Отзывы";
            this.Otzivi.UseVisualStyleBackColor = true;
            this.Otzivi.Click += new System.EventHandler(this.Otzivi_Click);
            // 
            // Akcii
            // 
            this.Akcii.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Akcii.Location = new System.Drawing.Point(445, 296);
            this.Akcii.Name = "Akcii";
            this.Akcii.Size = new System.Drawing.Size(145, 61);
            this.Akcii.TabIndex = 3;
            this.Akcii.Text = "Акции";
            this.Akcii.UseVisualStyleBackColor = true;
            this.Akcii.Click += new System.EventHandler(this.Akcii_Click);
            // 
            // Postavka
            // 
            this.Postavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Postavka.Location = new System.Drawing.Point(72, 122);
            this.Postavka.Name = "Postavka";
            this.Postavka.Size = new System.Drawing.Size(145, 62);
            this.Postavka.TabIndex = 4;
            this.Postavka.Text = "Поставки";
            this.Postavka.UseVisualStyleBackColor = true;
            this.Postavka.Click += new System.EventHandler(this.Postavka_Click);
            // 
            // Dostavki
            // 
            this.Dostavki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dostavki.Location = new System.Drawing.Point(445, 122);
            this.Dostavki.Name = "Dostavki";
            this.Dostavki.Size = new System.Drawing.Size(145, 61);
            this.Dostavki.TabIndex = 5;
            this.Dostavki.Text = "Доставки";
            this.Dostavki.UseVisualStyleBackColor = true;
            this.Dostavki.Click += new System.EventHandler(this.Dostavki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(187, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "АДМИН МЕНЮ";
            // 
            // Vixod
            // 
            this.Vixod.Location = new System.Drawing.Point(298, 404);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(75, 23);
            this.Vixod.TabIndex = 7;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // MenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 448);
            this.Controls.Add(this.Vixod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dostavki);
            this.Controls.Add(this.Postavka);
            this.Controls.Add(this.Akcii);
            this.Controls.Add(this.Otzivi);
            this.Controls.Add(this.UsersUsers);
            this.Controls.Add(this.MenuMenu);
            this.Name = "MenuAdm";
            this.Text = "MenuAdm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuMenu;
        private System.Windows.Forms.Button UsersUsers;
        private System.Windows.Forms.Button Otzivi;
        private System.Windows.Forms.Button Akcii;
        private System.Windows.Forms.Button Postavka;
        private System.Windows.Forms.Button Dostavki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vixod;
    }
}