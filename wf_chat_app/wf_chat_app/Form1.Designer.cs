namespace wf_chat_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt1 = new Button();
            bt2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            tb_register_re_pass = new TextBox();
            label7 = new Label();
            bt_register = new Button();
            tb_register_pass = new TextBox();
            tb_register_email = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bt_login = new Button();
            tb_login_password = new TextBox();
            tb_login_email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ActiveBorder;
            bt1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt1.ForeColor = SystemColors.ButtonHighlight;
            bt1.Location = new Point(12, 12);
            bt1.Name = "bt1";
            bt1.Size = new Size(189, 68);
            bt1.TabIndex = 0;
            bt1.Text = "login";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.BackColor = SystemColors.ActiveBorder;
            bt2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt2.ForeColor = SystemColors.ButtonHighlight;
            bt2.Location = new Point(264, 12);
            bt2.Name = "bt2";
            bt2.Size = new Size(189, 68);
            bt2.TabIndex = 1;
            bt2.Text = "rigister";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += bt2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(bt_login);
            panel1.Controls.Add(tb_login_password);
            panel1.Controls.Add(tb_login_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 517);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_register_re_pass);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(bt_register);
            panel2.Controls.Add(tb_register_pass);
            panel2.Controls.Add(tb_register_email);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 517);
            panel2.TabIndex = 6;
            // 
            // tb_register_re_pass
            // 
            tb_register_re_pass.Location = new Point(136, 269);
            tb_register_re_pass.Name = "tb_register_re_pass";
            tb_register_re_pass.Size = new Size(262, 27);
            tb_register_re_pass.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 276);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 12;
            label7.Text = "RE_PASSWORD: ";
            // 
            // bt_register
            // 
            bt_register.BackColor = SystemColors.HotTrack;
            bt_register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_register.ForeColor = SystemColors.ButtonHighlight;
            bt_register.Location = new Point(136, 362);
            bt_register.Name = "bt_register";
            bt_register.Size = new Size(189, 68);
            bt_register.TabIndex = 11;
            bt_register.Text = "register";
            bt_register.UseVisualStyleBackColor = false;
            // 
            // tb_register_pass
            // 
            tb_register_pass.Location = new Point(136, 184);
            tb_register_pass.Name = "tb_register_pass";
            tb_register_pass.Size = new Size(262, 27);
            tb_register_pass.TabIndex = 10;
            // 
            // tb_register_email
            // 
            tb_register_email.Location = new Point(136, 94);
            tb_register_email.Name = "tb_register_email";
            tb_register_email.Size = new Size(262, 27);
            tb_register_email.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 187);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 8;
            label4.Text = "PASSWORD: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 97);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 7;
            label5.Text = "EMAIL: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 24);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 6;
            label6.Text = "REGISTER";
            // 
            // bt_login
            // 
            bt_login.BackColor = SystemColors.HotTrack;
            bt_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_login.ForeColor = SystemColors.ButtonHighlight;
            bt_login.Location = new Point(136, 327);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(189, 68);
            bt_login.TabIndex = 5;
            bt_login.Text = "login";
            bt_login.UseVisualStyleBackColor = false;
            // 
            // tb_login_password
            // 
            tb_login_password.Location = new Point(136, 246);
            tb_login_password.Name = "tb_login_password";
            tb_login_password.Size = new Size(262, 27);
            tb_login_password.TabIndex = 4;
            // 
            // tb_login_email
            // 
            tb_login_email.Location = new Point(136, 156);
            tb_login_email.Name = "tb_login_email";
            tb_login_email.Size = new Size(262, 27);
            tb_login_email.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 249);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD: ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 159);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "EMAIL: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 24);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(465, 615);
            Controls.Add(panel1);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bt1;
        private Button bt2;
        private Panel panel1;
        private TextBox tb_login_password;
        private TextBox tb_login_email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_login;
        private Panel panel2;
        private TextBox tb_register_re_pass;
        private Label label7;
        private Button bt_register;
        private TextBox tb_register_pass;
        private TextBox tb_register_email;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
