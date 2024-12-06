namespace Pizzeria
{
    partial class VxodWin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vxod = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.regist = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vxod
            // 
            this.Vxod.BackColor = System.Drawing.Color.Peru;
            this.Vxod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vxod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vxod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vxod.Location = new System.Drawing.Point(298, 293);
            this.Vxod.Name = "Vxod";
            this.Vxod.Size = new System.Drawing.Size(161, 49);
            this.Vxod.TabIndex = 0;
            this.Vxod.Text = "Вход";
            this.Vxod.UseVisualStyleBackColor = false;
            this.Vxod.Click += new System.EventHandler(this.Vxod_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(298, 203);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(161, 20);
            this.Login.TabIndex = 1;
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(298, 245);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(161, 20);
            this.pass.TabIndex = 2;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.UseSystemPasswordChar = true;
            // 
            // regist
            // 
            this.regist.ActiveLinkColor = System.Drawing.Color.Gold;
            this.regist.AutoSize = true;
            this.regist.LinkColor = System.Drawing.Color.SaddleBrown;
            this.regist.Location = new System.Drawing.Point(339, 355);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(72, 13);
            this.regist.TabIndex = 3;
            this.regist.TabStop = true;
            this.regist.Text = "Регистрация";
            this.regist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regist_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(222, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "АВТОРИЗАЦИЯ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(273, 277);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(224, 13);
            this.Error.TabIndex = 9;
            this.Error.Text = "Ошибка! Не правильный логин или пароль";
            this.Error.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pizzeria.Properties.Resources.pngwing1;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 765);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // VxodWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 533);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Vxod);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VxodWin";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VxodWin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vxod;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.LinkLabel regist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Error;
    }
}

