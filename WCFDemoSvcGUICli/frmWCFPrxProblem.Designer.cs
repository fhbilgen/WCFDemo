namespace WCFDemoSvcGUICli
{
    partial class frmWCFPrxProblem
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
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cBoxClientList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPingThreads = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(11, 29);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(83, 13);
            this.lblServiceName.TabIndex = 29;
            this.lblServiceName.Text = "Service Name : ";
            // 
            // cBoxClientList
            // 
            this.cBoxClientList.FormattingEnabled = true;
            this.cBoxClientList.Location = new System.Drawing.Point(96, 29);
            this.cBoxClientList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cBoxClientList.Name = "cBoxClientList";
            this.cBoxClientList.Size = new System.Drawing.Size(272, 21);
            this.cBoxClientList.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Call Ping on ";
            // 
            // tbPingThreads
            // 
            this.tbPingThreads.Location = new System.Drawing.Point(96, 74);
            this.tbPingThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPingThreads.Name = "tbPingThreads";
            this.tbPingThreads.Size = new System.Drawing.Size(76, 20);
            this.tbPingThreads.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "threads";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(262, 71);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 25);
            this.btnStart.TabIndex = 33;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmWCFPrxProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 143);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPingThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.cBoxClientList);
            this.Name = "frmWCFPrxProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmWCFPrxProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.ComboBox cBoxClientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPingThreads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
    }
}