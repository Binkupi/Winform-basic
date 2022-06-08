
namespace WindowsFormsApp1.Client
{
    partial class ForgotPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordPage));
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnGetPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textEmail.Location = new System.Drawing.Point(118, 227);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(493, 30);
            this.textEmail.TabIndex = 0;
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGetPassword.Location = new System.Drawing.Point(253, 299);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.Size = new System.Drawing.Size(224, 48);
            this.btnGetPassword.TabIndex = 1;
            this.btnGetPassword.Text = "Lấy lại mật khẩu";
            this.btnGetPassword.UseVisualStyleBackColor = true;
            this.btnGetPassword.Click += new System.EventHandler(this.btnGetPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(206, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui lòng nhập email bạn đã đăng kí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(220, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quên mật khẩu";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.btnGetPassword);
            this.panel.Controls.Add(this.textEmail);
            this.panel.Location = new System.Drawing.Point(33, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(734, 392);
            this.panel.TabIndex = 4;
            // 
            // ForgotPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPasswordPage";
            this.Text = "Trang lấy lại mật khẩu";
            this.SizeChanged += new System.EventHandler(this.ForgotPasswordPage_SizeChanged);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnGetPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
    }
}