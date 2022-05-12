
namespace WindowsFormsApp1
{
    partial class WorkTypeManage
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
            this.flPanel_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flPanel_layout
            // 
            this.flPanel_layout.Location = new System.Drawing.Point(-1, 60);
            this.flPanel_layout.Name = "flPanel_layout";
            this.flPanel_layout.Size = new System.Drawing.Size(1165, 392);
            this.flPanel_layout.TabIndex = 0;
            // 
            // WorkTypeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.flPanel_layout);
            this.Name = "WorkTypeManage";
            this.Text = "Quản lý loại công việc";
            this.Load += new System.EventHandler(this.WorkTypeManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanel_layout;
    }
}

