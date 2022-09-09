namespace WCFDemoSvcGUICli
{
    partial class frmMain
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
            this.btnOpenSingleForm = new System.Windows.Forms.Button();
            this.btnOpenLoadTest = new System.Windows.Forms.Button();
            this.btnOpenSecureClientForm = new System.Windows.Forms.Button();
            this.btnWCFCliFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenSingleForm
            // 
            this.btnOpenSingleForm.Location = new System.Drawing.Point(50, 27);
            this.btnOpenSingleForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenSingleForm.Name = "btnOpenSingleForm";
            this.btnOpenSingleForm.Size = new System.Drawing.Size(152, 37);
            this.btnOpenSingleForm.TabIndex = 27;
            this.btnOpenSingleForm.Text = "Open Single Form";
            this.btnOpenSingleForm.UseVisualStyleBackColor = true;
            this.btnOpenSingleForm.Click += new System.EventHandler(this.btnOpenSingleForm_Click);
            // 
            // btnOpenLoadTest
            // 
            this.btnOpenLoadTest.Location = new System.Drawing.Point(50, 132);
            this.btnOpenLoadTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenLoadTest.Name = "btnOpenLoadTest";
            this.btnOpenLoadTest.Size = new System.Drawing.Size(152, 37);
            this.btnOpenLoadTest.TabIndex = 28;
            this.btnOpenLoadTest.Text = "Open Load Test Form";
            this.btnOpenLoadTest.UseVisualStyleBackColor = true;
            this.btnOpenLoadTest.Click += new System.EventHandler(this.btnOpenLoadTest_Click);
            // 
            // btnOpenSecureClientForm
            // 
            this.btnOpenSecureClientForm.Location = new System.Drawing.Point(50, 78);
            this.btnOpenSecureClientForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenSecureClientForm.Name = "btnOpenSecureClientForm";
            this.btnOpenSecureClientForm.Size = new System.Drawing.Size(152, 37);
            this.btnOpenSecureClientForm.TabIndex = 29;
            this.btnOpenSecureClientForm.Text = "Open Secure Client Form";
            this.btnOpenSecureClientForm.UseVisualStyleBackColor = true;
            this.btnOpenSecureClientForm.Click += new System.EventHandler(this.btnOpenSecureClientForm_Click);
            // 
            // btnWCFCliFrm
            // 
            this.btnWCFCliFrm.Location = new System.Drawing.Point(50, 183);
            this.btnWCFCliFrm.Margin = new System.Windows.Forms.Padding(2);
            this.btnWCFCliFrm.Name = "btnWCFCliFrm";
            this.btnWCFCliFrm.Size = new System.Drawing.Size(152, 37);
            this.btnWCFCliFrm.TabIndex = 30;
            this.btnWCFCliFrm.Text = "Open WCF Client Form";
            this.btnWCFCliFrm.UseVisualStyleBackColor = true;
            this.btnWCFCliFrm.Click += new System.EventHandler(this.btnWCFCliFrm_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 267);
            this.Controls.Add(this.btnWCFCliFrm);
            this.Controls.Add(this.btnOpenSecureClientForm);
            this.Controls.Add(this.btnOpenLoadTest);
            this.Controls.Add(this.btnOpenSingleForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "WCF Test Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSingleForm;
        private System.Windows.Forms.Button btnOpenLoadTest;
        private System.Windows.Forms.Button btnOpenSecureClientForm;
        private System.Windows.Forms.Button btnWCFCliFrm;
    }
}