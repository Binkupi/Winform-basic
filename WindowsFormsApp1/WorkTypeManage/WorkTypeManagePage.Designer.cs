
namespace WindowsFormsApp1
{
    partial class WorkTypeManagePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.PictureBox();
            this.btnDefaultExport = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanel_layout
            // 
            this.flPanel_layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flPanel_layout.AutoScroll = true;
            this.flPanel_layout.Location = new System.Drawing.Point(-1, 59);
            this.flPanel_layout.Name = "flPanel_layout";
            this.flPanel_layout.Size = new System.Drawing.Size(1165, 433);
            this.flPanel_layout.TabIndex = 0;
            this.flPanel_layout.Paint += new System.Windows.Forms.PaintEventHandler(this.flPanel_layout_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách loại công việc";
            // 
            // panelTool
            // 
            this.panelTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTool.AutoSize = true;
            this.panelTool.Controls.Add(this.btnUpload);
            this.panelTool.Controls.Add(this.btnDefaultExport);
            this.panelTool.Controls.Add(this.btnDownload);
            this.panelTool.Location = new System.Drawing.Point(459, 3);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(211, 48);
            this.panelTool.TabIndex = 6;
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::WindowsFormsApp1.Properties.Resources._2849798_upload_multimedia_icon;
            this.btnUpload.Location = new System.Drawing.Point(17, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(41, 40);
            this.btnUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpload.TabIndex = 2;
            this.btnUpload.TabStop = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDefaultExport
            // 
            this.btnDefaultExport.Image = global::WindowsFormsApp1.Properties.Resources._172516_paper_clip_icon;
            this.btnDefaultExport.Location = new System.Drawing.Point(84, 5);
            this.btnDefaultExport.Name = "btnDefaultExport";
            this.btnDefaultExport.Size = new System.Drawing.Size(41, 40);
            this.btnDefaultExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDefaultExport.TabIndex = 4;
            this.btnDefaultExport.TabStop = false;
            this.btnDefaultExport.Click += new System.EventHandler(this.btnDefaultExport_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Image = global::WindowsFormsApp1.Properties.Resources._1564526_add_arrow_download_save_guardar_icon;
            this.btnDownload.Location = new System.Drawing.Point(144, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(41, 40);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownload.TabIndex = 3;
            this.btnDownload.TabStop = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelTool);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 53);
            this.panel1.TabIndex = 7;
            // 
            // WorkTypeManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flPanel_layout);
            this.Name = "WorkTypeManagePage";
            this.Text = "Quản lý loại công việc";
            this.Load += new System.EventHandler(this.WorkTypeManage_Load);
            this.panelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanel_layout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.PictureBox btnUpload;
        private System.Windows.Forms.PictureBox btnDefaultExport;
        private System.Windows.Forms.PictureBox btnDownload;
        private System.Windows.Forms.Panel panel1;
    }
}

