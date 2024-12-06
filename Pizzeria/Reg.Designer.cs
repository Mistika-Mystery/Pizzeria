namespace Pizzeria
{
    partial class Reg
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
            this.label1 = new System.Windows.Forms.Label();
            this.new_login = new System.Windows.Forms.TextBox();
            this.new_reg = new System.Windows.Forms.Button();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.povt_pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.new_vxod = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(243, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // new_login
            // 
            this.new_login.Location = new System.Drawing.Point(305, 183);
            this.new_login.Name = "new_login";
            this.new_login.Size = new System.Drawing.Size(161, 20);
            this.new_login.TabIndex = 1;
            this.new_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_login.TextChanged += new System.EventHandler(this.new_login_TextChanged);
            // 
            // new_reg
            // 
            this.new_reg.BackColor = System.Drawing.Color.Peru;
            this.new_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_reg.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_reg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.new_reg.Location = new System.Drawing.Point(305, 313);
            this.new_reg.Name = "new_reg";
            this.new_reg.Size = new System.Drawing.Size(161, 47);
            this.new_reg.TabIndex = 2;
            this.new_reg.Text = "Регистрация";
            this.new_reg.UseVisualStyleBackColor = false;
            this.new_reg.Click += new System.EventHandler(this.new_reg_Click);
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(305, 231);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(161, 20);
            this.new_pass.TabIndex = 3;
            this.new_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_pass.TextChanged += new System.EventHandler(this.new_pass_TextChanged);
            // 
            // povt_pass
            // 
            this.povt_pass.Location = new System.Drawing.Point(305, 276);
            this.povt_pass.Name = "povt_pass";
            this.povt_pass.Size = new System.Drawing.Size(161, 20);
            this.povt_pass.TabIndex = 4;
            this.povt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.povt_pass.TextChanged += new System.EventHandler(this.povt_pass_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Pizzeria.Properties.Resources.pngwing1;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 687);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // new_vxod
            // 
            this.new_vxod.ActiveLinkColor = System.Drawing.Color.Gold;
            this.new_vxod.AutoSize = true;
            this.new_vxod.LinkColor = System.Drawing.Color.SaddleBrown;
            this.new_vxod.Location = new System.Drawing.Point(370, 376);
            this.new_vxod.Name = "new_vxod";
            this.new_vxod.Size = new System.Drawing.Size(31, 13);
            this.new_vxod.TabIndex = 6;
            this.new_vxod.TabStop = true;
            this.new_vxod.Text = "Вход";
            this.new_vxod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.new_vxod_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Повторите пароль";
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.new_vxod);
            this.Controls.Add(this.povt_pass);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.new_reg);
            this.Controls.Add(this.new_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reg";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reg_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_login;
        private System.Windows.Forms.Button new_reg;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.TextBox povt_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel new_vxod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}