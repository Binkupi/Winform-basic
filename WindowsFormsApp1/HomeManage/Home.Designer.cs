namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUndoneWork = new System.Windows.Forms.Panel();
            this.undoneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUndoneWorkTitle = new System.Windows.Forms.Label();
            this.panelDoneWork = new System.Windows.Forms.Panel();
            this.doneWorkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelUndoneWork.SuspendLayout();
            this.panelDoneWork.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 62);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(443, -9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 79);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(204, -8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 79);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách loại công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách công việc";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panelDoneWork);
            this.panel3.Controls.Add(this.panelUndoneWork);
            this.panel3.Location = new System.Drawing.Point(5, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 463);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(394, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "CÔNG VIỆC HÔM NAY";
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
            this.panelUndoneWork.Size = new System.Drawing.Size(507, 452);
            this.panelUndoneWork.TabIndex = 8;
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
            this.undoneWorkLayout.Location = new System.Drawing.Point(2, 46);
            this.undoneWorkLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.undoneWorkLayout.Name = "undoneWorkLayout";
            this.undoneWorkLayout.Size = new System.Drawing.Size(505, 401);
            this.undoneWorkLayout.TabIndex = 1;
            // 
            // txtUndoneWorkTitle
            // 
            this.txtUndoneWorkTitle.AutoSize = true;
            this.txtUndoneWorkTitle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndoneWorkTitle.Location = new System.Drawing.Point(2, 8);
            this.txtUndoneWorkTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUndoneWorkTitle.Name = "txtUndoneWorkTitle";
            this.txtUndoneWorkTitle.Size = new System.Drawing.Size(197, 24);
            this.txtUndoneWorkTitle.TabIndex = 0;
            this.txtUndoneWorkTitle.Text = "Công việc chưa làm";
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
            this.panelDoneWork.Location = new System.Drawing.Point(513, 8);
            this.panelDoneWork.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelDoneWork.Name = "panelDoneWork";
            this.panelDoneWork.Size = new System.Drawing.Size(488, 452);
            this.panelDoneWork.TabIndex = 9;
            // 
            // doneWorkLayout
            // 
            this.doneWorkLayout.AllowDrop = true;
            this.doneWorkLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doneWorkLayout.AutoSize = true;
            this.doneWorkLayout.Location = new System.Drawing.Point(2, 43);
            this.doneWorkLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.doneWorkLayout.Name = "doneWorkLayout";
            this.doneWorkLayout.Size = new System.Drawing.Size(487, 406);
            this.doneWorkLayout.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Công việc đã làm";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(2, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 53);
            this.panel4.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 586);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelUndoneWork.ResumeLayout(false);
            this.panelUndoneWork.PerformLayout();
            this.panelDoneWork.ResumeLayout(false);
            this.panelDoneWork.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelUndoneWork;
        private System.Windows.Forms.FlowLayoutPanel undoneWorkLayout;
        private System.Windows.Forms.Label txtUndoneWorkTitle;
        private System.Windows.Forms.Panel panelDoneWork;
        private System.Windows.Forms.FlowLayoutPanel doneWorkLayout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}