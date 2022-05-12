
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
            this.txtWorkTypeName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtWorkTypeDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWorkTypeName
            // 
            this.txtWorkTypeName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkTypeName.Location = new System.Drawing.Point(96, 21);
            this.txtWorkTypeName.Name = "txtWorkTypeName";
            this.txtWorkTypeName.Size = new System.Drawing.Size(147, 48);
            this.txtWorkTypeName.TabIndex = 0;
            this.txtWorkTypeName.Text = "Tên loại công việc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(220, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(283, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtWorkTypeDescription
            // 
            this.txtWorkTypeDescription.Location = new System.Drawing.Point(21, 101);
            this.txtWorkTypeDescription.Name = "txtWorkTypeDescription";
            this.txtWorkTypeDescription.Size = new System.Drawing.Size(302, 127);
            this.txtWorkTypeDescription.TabIndex = 3;
            this.txtWorkTypeDescription.Text = "Mô tả";
            // 
            // TypeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtWorkTypeDescription);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtWorkTypeName);
            this.Name = "TypeWork";
            this.Size = new System.Drawing.Size(336, 293);
            this.Load += new System.EventHandler(this.TypeWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtWorkTypeName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtWorkTypeDescription;
    }
}
