
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
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.Label();
            this.txtWorkTypeName = new System.Windows.Forms.Label();
            this.elipseControl1 = new WindowsFormsApp1.ElipseControl();
            this.backgroundcolor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundcolor
            // 
            this.backgroundcolor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.backgroundcolor.Controls.Add(this.txtWorkTypeName);
            this.backgroundcolor.Controls.Add(this.txtDescription);
            this.backgroundcolor.Controls.Add(this.btnRemove);
            this.backgroundcolor.Controls.Add(this.btnEdit);
            this.backgroundcolor.Location = new System.Drawing.Point(0, 0);
            this.backgroundcolor.Name = "backgroundcolor";
            this.backgroundcolor.Size = new System.Drawing.Size(200, 200);
            this.backgroundcolor.TabIndex = 4;
            this.backgroundcolor.Click += new System.EventHandler(this.backgroundcolor_Click);
            this.backgroundcolor.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundcolor_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::WindowsFormsApp1.Properties.Resources._8725775_edit_icon;
            this.btnEdit.Location = new System.Drawing.Point(100, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(39, 42);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 0;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources._3844425_can_trash_icon;
            this.btnRemove.Location = new System.Drawing.Point(154, 144);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 42);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDescription.Location = new System.Drawing.Point(12, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 78);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Mô tả công việc";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // txtWorkTypeName
            // 
            this.txtWorkTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtWorkTypeName.Location = new System.Drawing.Point(8, 13);
            this.txtWorkTypeName.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtWorkTypeName.Name = "txtWorkTypeName";
            this.txtWorkTypeName.Size = new System.Drawing.Size(189, 35);
            this.txtWorkTypeName.TabIndex = 3;
            this.txtWorkTypeName.Text = "Tên loại công việc";
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // TypeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backgroundcolor);
            this.Name = "TypeWork";
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.TypeWork_Load);
            this.backgroundcolor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel backgroundcolor;
        private System.Windows.Forms.PictureBox btnRemove;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.Label txtWorkTypeName;
        private System.Windows.Forms.Label txtDescription;
        private ElipseControl elipseControl1;
    }
}
