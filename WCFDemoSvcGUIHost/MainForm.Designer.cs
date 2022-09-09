namespace WCFDemoSvcGUIHost
{
    partial class MainForm
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
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.cBoxServiceList = new System.Windows.Forms.ComboBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCMISingle = new System.Windows.Forms.RadioButton();
            this.rbCMIPerSession = new System.Windows.Forms.RadioButton();
            this.rbCMIPerCall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCMSingle = new System.Windows.Forms.RadioButton();
            this.rbCMMultiple = new System.Windows.Forms.RadioButton();
            this.rbCMReentrant = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbMaxConcurrentCalls = new System.Windows.Forms.TextBox();
            this.tbMaxConcurrentInstances = new System.Windows.Forms.TextBox();
            this.tbMaxConcurrentSessions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvRunningServices = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(443, 34);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(147, 29);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "Start Service";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(443, 549);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(147, 29);
            this.btnStopService.TabIndex = 1;
            this.btnStopService.Text = "Stop Service";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // cBoxServiceList
            // 
            this.cBoxServiceList.FormattingEnabled = true;
            this.cBoxServiceList.Location = new System.Drawing.Point(16, 39);
            this.cBoxServiceList.Name = "cBoxServiceList";
            this.cBoxServiceList.Size = new System.Drawing.Size(362, 24);
            this.cBoxServiceList.TabIndex = 2;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(13, 16);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(108, 17);
            this.lblServiceName.TabIndex = 3;
            this.lblServiceName.Text = "Service Name : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Behavior";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCMISingle);
            this.groupBox3.Controls.Add(this.rbCMIPerSession);
            this.groupBox3.Controls.Add(this.rbCMIPerCall);
            this.groupBox3.Location = new System.Drawing.Point(285, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 66);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instance Context Mode";
            // 
            // rbCMISingle
            // 
            this.rbCMISingle.AutoSize = true;
            this.rbCMISingle.Location = new System.Drawing.Point(9, 25);
            this.rbCMISingle.Name = "rbCMISingle";
            this.rbCMISingle.Size = new System.Drawing.Size(68, 21);
            this.rbCMISingle.TabIndex = 10;
            this.rbCMISingle.TabStop = true;
            this.rbCMISingle.Text = "Single";
            this.rbCMISingle.UseVisualStyleBackColor = true;
            // 
            // rbCMIPerSession
            // 
            this.rbCMIPerSession.AutoSize = true;
            this.rbCMIPerSession.Location = new System.Drawing.Point(164, 25);
            this.rbCMIPerSession.Name = "rbCMIPerSession";
            this.rbCMIPerSession.Size = new System.Drawing.Size(105, 21);
            this.rbCMIPerSession.TabIndex = 12;
            this.rbCMIPerSession.TabStop = true;
            this.rbCMIPerSession.Text = "Per Session";
            this.rbCMIPerSession.UseVisualStyleBackColor = true;
            // 
            // rbCMIPerCall
            // 
            this.rbCMIPerCall.AutoSize = true;
            this.rbCMIPerCall.Location = new System.Drawing.Point(81, 25);
            this.rbCMIPerCall.Name = "rbCMIPerCall";
            this.rbCMIPerCall.Size = new System.Drawing.Size(78, 21);
            this.rbCMIPerCall.TabIndex = 11;
            this.rbCMIPerCall.TabStop = true;
            this.rbCMIPerCall.Text = "Per Call";
            this.rbCMIPerCall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCMSingle);
            this.groupBox2.Controls.Add(this.rbCMMultiple);
            this.groupBox2.Controls.Add(this.rbCMReentrant);
            this.groupBox2.Location = new System.Drawing.Point(10, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 66);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Concurrency Mode";
            // 
            // rbCMSingle
            // 
            this.rbCMSingle.AutoSize = true;
            this.rbCMSingle.Location = new System.Drawing.Point(6, 25);
            this.rbCMSingle.Name = "rbCMSingle";
            this.rbCMSingle.Size = new System.Drawing.Size(68, 21);
            this.rbCMSingle.TabIndex = 7;
            this.rbCMSingle.TabStop = true;
            this.rbCMSingle.Text = "Single";
            this.rbCMSingle.UseVisualStyleBackColor = true;
            // 
            // rbCMMultiple
            // 
            this.rbCMMultiple.AutoSize = true;
            this.rbCMMultiple.Location = new System.Drawing.Point(174, 25);
            this.rbCMMultiple.Name = "rbCMMultiple";
            this.rbCMMultiple.Size = new System.Drawing.Size(77, 21);
            this.rbCMMultiple.TabIndex = 9;
            this.rbCMMultiple.TabStop = true;
            this.rbCMMultiple.Text = "Multiple";
            this.rbCMMultiple.UseVisualStyleBackColor = true;
            // 
            // rbCMReentrant
            // 
            this.rbCMReentrant.AutoSize = true;
            this.rbCMReentrant.Location = new System.Drawing.Point(78, 25);
            this.rbCMReentrant.Name = "rbCMReentrant";
            this.rbCMReentrant.Size = new System.Drawing.Size(92, 21);
            this.rbCMReentrant.TabIndex = 8;
            this.rbCMReentrant.TabStop = true;
            this.rbCMReentrant.Text = "Reentrant";
            this.rbCMReentrant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Running Services : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbMaxConcurrentCalls);
            this.groupBox4.Controls.Add(this.tbMaxConcurrentInstances);
            this.groupBox4.Controls.Add(this.tbMaxConcurrentSessions);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(16, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 141);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Throttling Behavior";
            // 
            // tbMaxConcurrentCalls
            // 
            this.tbMaxConcurrentCalls.Location = new System.Drawing.Point(215, 102);
            this.tbMaxConcurrentCalls.Name = "tbMaxConcurrentCalls";
            this.tbMaxConcurrentCalls.Size = new System.Drawing.Size(100, 22);
            this.tbMaxConcurrentCalls.TabIndex = 5;
            // 
            // tbMaxConcurrentInstances
            // 
            this.tbMaxConcurrentInstances.Location = new System.Drawing.Point(215, 68);
            this.tbMaxConcurrentInstances.Name = "tbMaxConcurrentInstances";
            this.tbMaxConcurrentInstances.Size = new System.Drawing.Size(100, 22);
            this.tbMaxConcurrentInstances.TabIndex = 4;
            // 
            // tbMaxConcurrentSessions
            // 
            this.tbMaxConcurrentSessions.Location = new System.Drawing.Point(215, 34);
            this.tbMaxConcurrentSessions.Name = "tbMaxConcurrentSessions";
            this.tbMaxConcurrentSessions.Size = new System.Drawing.Size(100, 22);
            this.tbMaxConcurrentSessions.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Max Concurrent Calls : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max Concurrent Instances : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max Concurrent Sessions : ";
            // 
            // lvRunningServices
            // 
            this.lvRunningServices.Location = new System.Drawing.Point(16, 388);
            this.lvRunningServices.Name = "lvRunningServices";
            this.lvRunningServices.Size = new System.Drawing.Size(574, 135);
            this.lvRunningServices.TabIndex = 8;
            this.lvRunningServices.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 615);
            this.Controls.Add(this.lvRunningServices);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.cBoxServiceList);
            this.Controls.Add(this.btnStopService);
            this.Controls.Add(this.btnStartService);
            this.Name = "MainForm";
            this.Text = "WCF GUI Host";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.ComboBox cBoxServiceList;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCMIPerSession;
        private System.Windows.Forms.RadioButton rbCMIPerCall;
        private System.Windows.Forms.RadioButton rbCMISingle;
        private System.Windows.Forms.RadioButton rbCMSingle;
        private System.Windows.Forms.RadioButton rbCMMultiple;
        private System.Windows.Forms.RadioButton rbCMReentrant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaxConcurrentCalls;
        private System.Windows.Forms.TextBox tbMaxConcurrentInstances;
        private System.Windows.Forms.TextBox tbMaxConcurrentSessions;
        private System.Windows.Forms.ListView lvRunningServices;
    }
}

