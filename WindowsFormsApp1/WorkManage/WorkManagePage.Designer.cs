
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
            this.panelUndoneWork = new System.Windows.Forms.Panel();
            this.btnDefaultExport = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.PictureBox();
            this.undoneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUndoneWorkTitle = new System.Windows.Forms.Label();
            this.panelDoneWork = new System.Windows.Forms.Panel();
            this.doneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLatedWork = new System.Windows.Forms.Panel();
            this.titleLatedWork = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.latedWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTool = new System.Windows.Forms.Panel();
            this.panelUndoneWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            this.panelDoneWork.SuspendLayout();
            this.panelLatedWork.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUndoneWork
            // 
            this.panelUndoneWork.AllowDrop = true;
            this.panelUndoneWork.AutoScroll = true;
            this.panelUndoneWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUndoneWork.Controls.Add(this.undoneWorkLayout);
            this.panelUndoneWork.Controls.Add(this.txtUndoneWorkTitle);
            this.panelUndoneWork.Controls.Add(this.panelTool);
            this.panelUndoneWork.Location = new System.Drawing.Point(0, 4);
            this.panelUndoneWork.Name = "panelUndoneWork";
            this.panelUndoneWork.Size = new System.Drawing.Size(676, 368);
            this.panelUndoneWork.TabIndex = 0;
            this.panelUndoneWork.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDefaultExport
            // 
            this.btnDefaultExport.Image = global::WindowsFormsApp1.Properties.Resources._172516_paper_clip_icon;
            this.btnDefaultExport.Location = new System.Drawing.Point(118, 4);
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
            this.btnDownload.Location = new System.Drawing.Point(177, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(41, 40);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownload.TabIndex = 3;
            this.btnDownload.TabStop = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::WindowsFormsApp1.Properties.Resources._2849798_upload_multimedia_icon;
            this.btnUpload.Location = new System.Drawing.Point(50, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(41, 40);
            this.btnUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpload.TabIndex = 2;
            this.btnUpload.TabStop = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // undoneWorkLayout
            // 
            this.undoneWorkLayout.AllowDrop = true;
            this.undoneWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.undoneWorkLayout.AutoSize = true;
            this.undoneWorkLayout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.undoneWorkLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoneWorkLayout.Location = new System.Drawing.Point(2, 53);
            this.undoneWorkLayout.Name = "undoneWorkLayout";
            this.undoneWorkLayout.Size = new System.Drawing.Size(673, 310);
            this.undoneWorkLayout.TabIndex = 1;
            this.undoneWorkLayout.DragDrop += new System.Windows.Forms.DragEventHandler(this.undoneWorkLayout_DragDrop);
            this.undoneWorkLayout.DragEnter += new System.Windows.Forms.DragEventHandler(this.undoneWorkLayout_DragEnter);
            this.undoneWorkLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoneWorkLayout_MouseDown);
            this.undoneWorkLayout.MouseEnter += new System.EventHandler(this.undoneWorkLayout_MouseEnter);
            this.undoneWorkLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.undoneWorkLayout_MouseMove);
            this.undoneWorkLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.undoneWorkLayout_MouseUp);
            // 
            // txtUndoneWorkTitle
            // 
            this.txtUndoneWorkTitle.AutoSize = true;
            this.txtUndoneWorkTitle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndoneWorkTitle.Location = new System.Drawing.Point(3, 9);
            this.txtUndoneWorkTitle.Name = "txtUndoneWorkTitle";
            this.txtUndoneWorkTitle.Size = new System.Drawing.Size(250, 30);
            this.txtUndoneWorkTitle.TabIndex = 0;
            this.txtUndoneWorkTitle.Text = "Công việc chưa làm";
            // 
            // panelDoneWork
            // 
            this.panelDoneWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDoneWork.Controls.Add(this.doneWorkLayout);
            this.panelDoneWork.Controls.Add(this.label2);
            this.panelDoneWork.Location = new System.Drawing.Point(681, 4);
            this.panelDoneWork.Name = "panelDoneWork";
            this.panelDoneWork.Size = new System.Drawing.Size(654, 371);
            this.panelDoneWork.TabIndex = 1;
            // 
            // doneWorkLayout
            // 
            this.doneWorkLayout.AllowDrop = true;
            this.doneWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doneWorkLayout.Location = new System.Drawing.Point(2, 49);
            this.doneWorkLayout.Name = "doneWorkLayout";
            this.doneWorkLayout.Size = new System.Drawing.Size(652, 319);
            this.doneWorkLayout.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Công việc đã làm";
            // 
            // panelLatedWork
            // 
            this.panelLatedWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLatedWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLatedWork.Controls.Add(this.latedWorkLayout);
            this.panelLatedWork.Controls.Add(this.titleLatedWork);
            this.panelLatedWork.Location = new System.Drawing.Point(3, 379);
            this.panelLatedWork.Name = "panelLatedWork";
            this.panelLatedWork.Size = new System.Drawing.Size(1332, 308);
            this.panelLatedWork.TabIndex = 2;
            // 
            // titleLatedWork
            // 
            this.titleLatedWork.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.titleLatedWork.Location = new System.Drawing.Point(541, 21);
            this.titleLatedWork.Name = "titleLatedWork";
            this.titleLatedWork.Size = new System.Drawing.Size(259, 30);
            this.titleLatedWork.TabIndex = 0;
            this.titleLatedWork.Text = "Công việc đã trễ hạn";
            this.titleLatedWork.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // latedWorkLayout
            // 
            this.latedWorkLayout.AllowDrop = true;
            this.latedWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latedWorkLayout.AutoSize = true;
            this.latedWorkLayout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.latedWorkLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.latedWorkLayout.Location = new System.Drawing.Point(9, 66);
            this.latedWorkLayout.Name = "latedWorkLayout";
            this.latedWorkLayout.Size = new System.Drawing.Size(1320, 239);
            this.latedWorkLayout.TabIndex = 2;
            // 
            // panelTool
            // 
            this.panelTool.AutoSize = true;
            this.panelTool.Controls.Add(this.btnUpload);
            this.panelTool.Controls.Add(this.btnDefaultExport);
            this.panelTool.Controls.Add(this.btnDownload);
            this.panelTool.Location = new System.Drawing.Point(447, 3);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(221, 48);
            this.panelTool.TabIndex = 5;
            // 
            // WorkManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 699);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelLatedWork);
            this.Controls.Add(this.panelDoneWork);
            this.Controls.Add(this.panelUndoneWork);
            this.Name = "WorkManagePage";
            this.Text = "Quản lý công việc";
            this.Load += new System.EventHandler(this.WorkManagePage_Load);
            this.SizeChanged += new System.EventHandler(this.WorkManagePage_SizeChanged);
            this.Resize += new System.EventHandler(this.WorkManagePage_Resize);
            this.panelUndoneWork.ResumeLayout(false);
            this.panelUndoneWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            this.panelDoneWork.ResumeLayout(false);
            this.panelDoneWork.PerformLayout();
            this.panelLatedWork.ResumeLayout(false);
            this.panelLatedWork.PerformLayout();
            this.panelTool.ResumeLayout(false);
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
    }
}