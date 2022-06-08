
namespace WindowsFormsApp1.Client
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.textName = new System.Windows.Forms.TextBox();
            this.textPasswordAgain = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textName.Location = new System.Drawing.Point(262, 86);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(439, 30);
            this.textName.TabIndex = 0;
            // 
            // textPasswordAgain
            // 
            this.textPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textPasswordAgain.Location = new System.Drawing.Point(263, 222);
            this.textPasswordAgain.Name = "textPasswordAgain";
            this.textPasswordAgain.Size = new System.Drawing.Size(438, 30);
            this.textPasswordAgain.TabIndex = 1;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textEmail.Location = new System.Drawing.Point(263, 288);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(438, 30);
            this.textEmail.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRegister.Location = new System.Drawing.Point(398, 386);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 49);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Đăng kí";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogin.Location = new System.Drawing.Point(138, 387);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 49);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(47, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(52, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(292, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đăng kí";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.textPassword);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnLogin);
            this.panel.Controls.Add(this.btnRegister);
            this.panel.Controls.Add(this.textEmail);
            this.panel.Controls.Add(this.textPasswordAgain);
            this.panel.Controls.Add(this.textName);
            this.panel.Location = new System.Drawing.Point(12, 43);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(773, 492);
            this.panel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(46, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mật khẩu";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textPassword.Location = new System.Drawing.Point(263, 158);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(438, 30);
            this.textPassword.TabIndex = 9;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterPage";
            this.Text = "Trang đăng kí";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            this.SizeChanged += new System.EventHandler(this.RegisterPage_SizeChanged);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPasswordAgain;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPassword;
    }
}