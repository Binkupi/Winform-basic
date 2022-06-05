
namespace WindowsFormsApp1
{
    partial class TypeWork
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundcolor = new System.Windows.Forms.Panel();
            this.btnNotification = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkTypeName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.elipseControl1 = new WindowsFormsApp1.ElipseControl();
            this.backgroundcolor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundcolor
            // 
            this.backgroundcolor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backgroundcolor.Controls.Add(this.btnNotification);
            this.backgroundcolor.Controls.Add(this.panel1);
            this.backgroundcolor.Controls.Add(this.txtWorkTypeName);
            this.backgroundcolor.Controls.Add(this.btnRemove);
            this.backgroundcolor.Controls.Add(this.btnEdit);
            this.backgroundcolor.Location = new System.Drawing.Point(0, 0);
            this.backgroundcolor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backgroundcolor.Name = "backgroundcolor";
            this.backgroundcolor.Size = new System.Drawing.Size(150, 175);
            this.backgroundcolor.TabIndex = 4;
            this.backgroundcolor.Click += new System.EventHandler(this.backgroundcolor_Click);
            this.backgroundcolor.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundcolor_Paint);
            // 
            // btnNotification
            // 
            this.btnNotification.Image = global::WindowsFormsApp1.Properties.Resources.no_notification;
            this.btnNotification.Location = new System.Drawing.Point(112, 0);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(28, 35);
            this.btnNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNotification.TabIndex = 5;
            this.btnNotification.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 90);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trễ hạn:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đã làm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chưa làm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWorkTypeName
            // 
            this.txtWorkTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtWorkTypeName.Location = new System.Drawing.Point(6, 11);
            this.txtWorkTypeName.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.txtWorkTypeName.Name = "txtWorkTypeName";
            this.txtWorkTypeName.Size = new System.Drawing.Size(142, 16);
            this.txtWorkTypeName.TabIndex = 3;
            this.txtWorkTypeName.Text = "Tên loại công việc";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources._3844425_can_trash_icon;
            this.btnRemove.Location = new System.Drawing.Point(116, 131);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 37);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::WindowsFormsApp1.Properties.Resources._8725775_edit_icon;
            this.btnEdit.Location = new System.Drawing.Point(75, 131);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 37);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 0;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // TypeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backgroundcolor);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TypeWork";
            this.Size = new System.Drawing.Size(150, 175);
            this.Load += new System.EventHandler(this.TypeWork_Load);
            this.backgroundcolor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel backgroundcolor;
        private System.Windows.Forms.PictureBox btnRemove;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.Label txtWorkTypeName;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnNotification;
    }
}
