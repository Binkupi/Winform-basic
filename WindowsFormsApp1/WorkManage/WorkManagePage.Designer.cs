
namespace WindowsFormsApp1
{
    partial class WorkManagePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkManagePage));
            this.label4 = new System.Windows.Forms.Label();
            this.panelLatedWork = new System.Windows.Forms.Panel();
            this.latedWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLatedWork = new System.Windows.Forms.Label();
            this.panelDoneWork = new System.Windows.Forms.Panel();
            this.doneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUndoneWork = new System.Windows.Forms.Panel();
            this.undoneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUndoneWorkTitle = new System.Windows.Forms.Label();
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.PictureBox();
            this.btnDefaultExport = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.panelLatedWork.SuspendLayout();
            this.panelDoneWork.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUndoneWork.SuspendLayout();
            this.panelTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelLatedWork
            // 
            this.panelLatedWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLatedWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLatedWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLatedWork.Controls.Add(this.latedWorkLayout);
            this.panelLatedWork.Controls.Add(this.titleLatedWork);
            this.panelLatedWork.Location = new System.Drawing.Point(2, 379);
            this.panelLatedWork.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelLatedWork.Name = "panelLatedWork";
            this.panelLatedWork.Size = new System.Drawing.Size(1031, 365);
            this.panelLatedWork.TabIndex = 2;
            this.panelLatedWork.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLatedWork_Paint);
            // 
            // latedWorkLayout
            // 
            this.latedWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latedWorkLayout.AutoScroll = true;
            this.latedWorkLayout.BackColor = System.Drawing.Color.DarkSalmon;
            this.latedWorkLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.latedWorkLayout.Location = new System.Drawing.Point(2, 49);
            this.latedWorkLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.latedWorkLayout.Name = "latedWorkLayout";
            this.latedWorkLayout.Size = new System.Drawing.Size(1027, 313);
            this.latedWorkLayout.TabIndex = 2;
            this.latedWorkLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.latedWorkLayout_Paint);
            // 
            // titleLatedWork
            // 
            this.titleLatedWork.BackColor = System.Drawing.Color.Transparent;
            this.titleLatedWork.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.titleLatedWork.ForeColor = System.Drawing.Color.DarkSalmon;
            this.titleLatedWork.Location = new System.Drawing.Point(411, 9);
            this.titleLatedWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLatedWork.Name = "titleLatedWork";
            this.titleLatedWork.Size = new System.Drawing.Size(308, 26);
            this.titleLatedWork.TabIndex = 0;
            this.titleLatedWork.Text = "Công việc đã trễ hạn";
            this.titleLatedWork.Click += new System.EventHandler(this.titleLatedWork_Click);
            // 
            // panelDoneWork
            // 
            this.panelDoneWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDoneWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDoneWork.Controls.Add(this.doneWorkLayout);
            this.panelDoneWork.Controls.Add(this.label2);
            this.panelDoneWork.Controls.Add(this.panelHome);
            this.panelDoneWork.Location = new System.Drawing.Point(557, 4);
            this.panelDoneWork.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelDoneWork.Name = "panelDoneWork";
            this.panelDoneWork.Size = new System.Drawing.Size(478, 370);
            this.panelDoneWork.TabIndex = 1;
            this.panelDoneWork.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDoneWork_Paint);
            // 
            // doneWorkLayout
            // 
            this.doneWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doneWorkLayout.AutoScroll = true;
            this.doneWorkLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(143)))));
            this.doneWorkLayout.Location = new System.Drawing.Point(0, 46);
            this.doneWorkLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.doneWorkLayout.Name = "doneWorkLayout";
            this.doneWorkLayout.Size = new System.Drawing.Size(478, 324);
            this.doneWorkLayout.TabIndex = 1;
            this.doneWorkLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.doneWorkLayout_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Công việc đã làm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(412, 2);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(52, 42);
            this.panelHome.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._216242_home_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelUndoneWork
            // 
            this.panelUndoneWork.AllowDrop = true;
            this.panelUndoneWork.AutoScroll = true;
            this.panelUndoneWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUndoneWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUndoneWork.Controls.Add(this.undoneWorkLayout);
            this.panelUndoneWork.Controls.Add(this.txtUndoneWorkTitle);
            this.panelUndoneWork.Controls.Add(this.panelTool);
            this.panelUndoneWork.Location = new System.Drawing.Point(0, 4);
            this.panelUndoneWork.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelUndoneWork.Name = "panelUndoneWork";
            this.panelUndoneWork.Size = new System.Drawing.Size(555, 370);
            this.panelUndoneWork.TabIndex = 0;
            this.panelUndoneWork.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUndoneWork_Paint);
            // 
            // undoneWorkLayout
            // 
            this.undoneWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.undoneWorkLayout.AutoScroll = true;
            this.undoneWorkLayout.BackColor = System.Drawing.Color.SkyBlue;
            this.undoneWorkLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoneWorkLayout.Location = new System.Drawing.Point(2, 46);
            this.undoneWorkLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.undoneWorkLayout.Name = "undoneWorkLayout";
            this.undoneWorkLayout.Size = new System.Drawing.Size(553, 324);
            this.undoneWorkLayout.TabIndex = 1;
            this.undoneWorkLayout.DragDrop += new System.Windows.Forms.DragEventHandler(this.undoneWorkLayout_DragDrop);
            this.undoneWorkLayout.DragEnter += new System.Windows.Forms.DragEventHandler(this.undoneWorkLayout_DragEnter);
            this.undoneWorkLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.undoneWorkLayout_Paint);
            this.undoneWorkLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoneWorkLayout_MouseDown);
            this.undoneWorkLayout.MouseEnter += new System.EventHandler(this.undoneWorkLayout_MouseEnter);
            this.undoneWorkLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.undoneWorkLayout_MouseMove);
            this.undoneWorkLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.undoneWorkLayout_MouseUp);
            // 
            // txtUndoneWorkTitle
            // 
            this.txtUndoneWorkTitle.AutoSize = true;
            this.txtUndoneWorkTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtUndoneWorkTitle.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.txtUndoneWorkTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtUndoneWorkTitle.Location = new System.Drawing.Point(2, 8);
            this.txtUndoneWorkTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUndoneWorkTitle.Name = "txtUndoneWorkTitle";
            this.txtUndoneWorkTitle.Size = new System.Drawing.Size(296, 30);
            this.txtUndoneWorkTitle.TabIndex = 0;
            this.txtUndoneWorkTitle.Text = "Công việc chưa làm";
            this.txtUndoneWorkTitle.Click += new System.EventHandler(this.txtUndoneWorkTitle_Click);
            // 
            // panelTool
            // 
            this.panelTool.AutoSize = true;
            this.panelTool.BackColor = System.Drawing.Color.Transparent;
            this.panelTool.Controls.Add(this.btnUpload);
            this.panelTool.Controls.Add(this.btnDefaultExport);
            this.panelTool.Controls.Add(this.btnDownload);
            this.panelTool.Location = new System.Drawing.Point(380, 4);
            this.panelTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(168, 42);
            this.panelTool.TabIndex = 5;
            this.panelTool.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTool_Paint);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Image = global::WindowsFormsApp1.Properties.Resources._2849798_upload_multimedia_icon;
            this.btnUpload.Location = new System.Drawing.Point(38, 4);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(31, 35);
            this.btnUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpload.TabIndex = 2;
            this.btnUpload.TabStop = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDefaultExport
            // 
            this.btnDefaultExport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDefaultExport.Image = global::WindowsFormsApp1.Properties.Resources._172516_paper_clip_icon;
            this.btnDefaultExport.Location = new System.Drawing.Point(88, 4);
            this.btnDefaultExport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDefaultExport.Name = "btnDefaultExport";
            this.btnDefaultExport.Size = new System.Drawing.Size(31, 35);
            this.btnDefaultExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDefaultExport.TabIndex = 4;
            this.btnDefaultExport.TabStop = false;
            this.btnDefaultExport.Click += new System.EventHandler(this.btnDefaultExport_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDownload.Image = global::WindowsFormsApp1.Properties.Resources._1564526_add_arrow_download_save_guardar_icon;
            this.btnDownload.Location = new System.Drawing.Point(133, 4);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(31, 35);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownload.TabIndex = 3;
            this.btnDownload.TabStop = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // WorkManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1036, 754);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelLatedWork);
            this.Controls.Add(this.panelDoneWork);
            this.Controls.Add(this.panelUndoneWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "WorkManagePage";
            this.Text = "Quản lý công việc";
            this.Load += new System.EventHandler(this.WorkManagePage_Load);
            this.SizeChanged += new System.EventHandler(this.WorkManagePage_SizeChanged);
            this.Resize += new System.EventHandler(this.WorkManagePage_Resize);
            this.panelLatedWork.ResumeLayout(false);
            this.panelDoneWork.ResumeLayout(false);
            this.panelDoneWork.PerformLayout();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUndoneWork.ResumeLayout(false);
            this.panelUndoneWork.PerformLayout();
            this.panelTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUndoneWork;
        private System.Windows.Forms.Label txtUndoneWorkTitle;
        private System.Windows.Forms.Panel panelDoneWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLatedWork;
        private System.Windows.Forms.Label titleLatedWork;
        private System.Windows.Forms.FlowLayoutPanel undoneWorkLayout;
        private System.Windows.Forms.FlowLayoutPanel doneWorkLayout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnDownload;
        private System.Windows.Forms.PictureBox btnUpload;
        private System.Windows.Forms.PictureBox btnDefaultExport;
        private System.Windows.Forms.FlowLayoutPanel latedWorkLayout;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}