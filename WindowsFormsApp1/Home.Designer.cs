﻿namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDoneWork = new System.Windows.Forms.Panel();
            this.doneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelUndoneWork = new System.Windows.Forms.Panel();
            this.undoneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUndoneWorkTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_ListTypeWork = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panelDoneWork.SuspendLayout();
            this.panelUndoneWork.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panelDoneWork);
            this.panel3.Controls.Add(this.panelUndoneWork);
            this.panel3.Location = new System.Drawing.Point(-5, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 492);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelDoneWork
            // 
            this.panelDoneWork.AllowDrop = true;
            this.panelDoneWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDoneWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDoneWork.Controls.Add(this.doneWorkLayout);
            this.panelDoneWork.Controls.Add(this.label4);
            this.panelDoneWork.Location = new System.Drawing.Point(525, 8);
            this.panelDoneWork.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelDoneWork.Name = "panelDoneWork";
            this.panelDoneWork.Size = new System.Drawing.Size(486, 484);
            this.panelDoneWork.TabIndex = 9;
            // 
            // doneWorkLayout
            // 
            this.doneWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doneWorkLayout.AutoScroll = true;
            this.doneWorkLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(143)))));
            this.doneWorkLayout.Location = new System.Drawing.Point(2, 43);
            this.doneWorkLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.doneWorkLayout.Name = "doneWorkLayout";
            this.doneWorkLayout.Size = new System.Drawing.Size(485, 441);
            this.doneWorkLayout.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(2, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Công việc đã làm";
            // 
            // panelUndoneWork
            // 
            this.panelUndoneWork.AllowDrop = true;
            this.panelUndoneWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUndoneWork.AutoScroll = true;
            this.panelUndoneWork.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUndoneWork.Controls.Add(this.undoneWorkLayout);
            this.panelUndoneWork.Controls.Add(this.txtUndoneWorkTitle);
            this.panelUndoneWork.Location = new System.Drawing.Point(2, 8);
            this.panelUndoneWork.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelUndoneWork.Name = "panelUndoneWork";
            this.panelUndoneWork.Size = new System.Drawing.Size(519, 481);
            this.panelUndoneWork.TabIndex = 8;
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
            this.undoneWorkLayout.Size = new System.Drawing.Size(519, 438);
            this.undoneWorkLayout.TabIndex = 1;
            // 
            // txtUndoneWorkTitle
            // 
            this.txtUndoneWorkTitle.AutoSize = true;
            this.txtUndoneWorkTitle.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.txtUndoneWorkTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtUndoneWorkTitle.Location = new System.Drawing.Point(2, 8);
            this.txtUndoneWorkTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUndoneWorkTitle.Name = "txtUndoneWorkTitle";
            this.txtUndoneWorkTitle.Size = new System.Drawing.Size(296, 30);
            this.txtUndoneWorkTitle.TabIndex = 0;
            this.txtUndoneWorkTitle.Text = "Công việc chưa làm";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(378, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "CÔNG VIỆC HÔM NAY";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(2, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 62);
            this.panel4.TabIndex = 2;
            // 
            // lbl_ListTypeWork
            // 
            this.lbl_ListTypeWork.AutoSize = true;
            this.lbl_ListTypeWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(117)))));
            this.lbl_ListTypeWork.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListTypeWork.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_ListTypeWork.Location = new System.Drawing.Point(8, 8);
            this.lbl_ListTypeWork.Name = "lbl_ListTypeWork";
            this.lbl_ListTypeWork.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.lbl_ListTypeWork.Size = new System.Drawing.Size(230, 38);
            this.lbl_ListTypeWork.TabIndex = 3;
            this.lbl_ListTypeWork.Text = "Quản lý loại công việc";
            this.lbl_ListTypeWork.Click += new System.EventHandler(this.lbl_ListTypeWork_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lbl_ListTypeWork);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 54);
            this.panel1.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1009, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.panel3.ResumeLayout(false);
            this.panelDoneWork.ResumeLayout(false);
            this.panelDoneWork.PerformLayout();
            this.panelUndoneWork.ResumeLayout(false);
            this.panelUndoneWork.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelUndoneWork;
        private System.Windows.Forms.FlowLayoutPanel undoneWorkLayout;
        private System.Windows.Forms.Label txtUndoneWorkTitle;
        private System.Windows.Forms.Panel panelDoneWork;
        private System.Windows.Forms.FlowLayoutPanel doneWorkLayout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_ListTypeWork;
        private System.Windows.Forms.Panel panel1;
    }
}