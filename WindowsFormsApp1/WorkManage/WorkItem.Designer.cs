
namespace WindowsFormsApp1

{
    partial class workItem
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.Panel();
            this.elipseControl1 = new WindowsFormsApp1.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(17, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 85);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Công việc";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDate.Location = new System.Drawing.Point(20, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(76, 19);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "Ngày giờ";
            this.txtDate.Click += new System.EventHandler(this.txtDate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::WindowsFormsApp1.Properties.Resources._8725775_edit_icon;
            this.btnEdit.Location = new System.Drawing.Point(161, 140);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 32);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Image = global::WindowsFormsApp1.Properties.Resources._3844425_can_trash_icon;
            this.btnDelete.Location = new System.Drawing.Point(124, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 32);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // background
            // 
            this.background.Controls.Add(this.btnEdit);
            this.background.Controls.Add(this.txtDate);
            this.background.Controls.Add(this.txtName);
            this.background.Controls.Add(this.btnDelete);
            this.background.Location = new System.Drawing.Point(1, 1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(204, 180);
            this.background.TabIndex = 4;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // workItem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.background);
            this.Name = "workItem";
            this.Size = new System.Drawing.Size(208, 184);
            this.Load += new System.EventHandler(this.WorkItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.Label txtDate;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.Panel background;
    }
}
