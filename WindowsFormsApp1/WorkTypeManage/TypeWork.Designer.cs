
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
            this.txtWorkTypeName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.elipseControl1 = new WindowsFormsApp1.ElipseControl();
            this.backgroundcolor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
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
            this.backgroundcolor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backgroundcolor.Name = "backgroundcolor";
            this.backgroundcolor.Size = new System.Drawing.Size(150, 175);
            this.backgroundcolor.TabIndex = 4;
            this.backgroundcolor.Click += new System.EventHandler(this.backgroundcolor_Click);
            this.backgroundcolor.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundcolor_Paint);
            // 
            // txtWorkTypeName
            // 
            this.txtWorkTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtWorkTypeName.Location = new System.Drawing.Point(6, 11);
            this.txtWorkTypeName.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.txtWorkTypeName.Name = "txtWorkTypeName";
            this.txtWorkTypeName.Size = new System.Drawing.Size(142, 31);
            this.txtWorkTypeName.TabIndex = 3;
            this.txtWorkTypeName.Text = "Tên loại công việc";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDescription.Location = new System.Drawing.Point(9, 55);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(128, 68);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Mô tả công việc";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::WindowsFormsApp1.Properties.Resources._3844425_can_trash_icon;
            this.btnRemove.Location = new System.Drawing.Point(116, 126);
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
            this.btnEdit.Location = new System.Drawing.Point(75, 126);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
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
