namespace WCFDemoSvcGUICli
{
    partial class frmSingleTest
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
            this.tbHostTime = new System.Windows.Forms.TextBox();
            this.gbMethodInvocation = new System.Windows.Forms.GroupBox();
            this.tbGetPerson = new System.Windows.Forms.TextBox();
            this.btnGetPerson = new System.Windows.Forms.Button();
            this.tbGuessGender = new System.Windows.Forms.TextBox();
            this.btnGuessGender = new System.Windows.Forms.Button();
            this.tbGetCounter = new System.Windows.Forms.TextBox();
            this.tbDecrementCounter = new System.Windows.Forms.TextBox();
            this.tbIncrementCounter = new System.Windows.Forms.TextBox();
            this.tbCauseException = new System.Windows.Forms.TextBox();
            this.btnGetCounter = new System.Windows.Forms.Button();
            this.btnDecrementCounter = new System.Windows.Forms.Button();
            this.btnIncrementCounter = new System.Windows.Forms.Button();
            this.btnCauseException = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.tbPing = new System.Windows.Forms.TextBox();
            this.btnEcho = new System.Windows.Forms.Button();
            this.tbEcho = new System.Windows.Forms.TextBox();
            this.btnGetHostName = new System.Windows.Forms.Button();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.btnGetHostTime = new System.Windows.Forms.Button();
            this.cBoxClientList = new System.Windows.Forms.ComboBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.gbMethodInvocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHostTime
            // 
            this.tbHostTime.Location = new System.Drawing.Point(121, 142);
            this.tbHostTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbHostTime.Name = "tbHostTime";
            this.tbHostTime.Size = new System.Drawing.Size(176, 20);
            this.tbHostTime.TabIndex = 4;
            // 
            // gbMethodInvocation
            // 
            this.gbMethodInvocation.Controls.Add(this.tbGetPerson);
            this.gbMethodInvocation.Controls.Add(this.btnGetPerson);
            this.gbMethodInvocation.Controls.Add(this.tbGuessGender);
            this.gbMethodInvocation.Controls.Add(this.btnGuessGender);
            this.gbMethodInvocation.Controls.Add(this.tbGetCounter);
            this.gbMethodInvocation.Controls.Add(this.tbDecrementCounter);
            this.gbMethodInvocation.Controls.Add(this.tbIncrementCounter);
            this.gbMethodInvocation.Controls.Add(this.tbCauseException);
            this.gbMethodInvocation.Controls.Add(this.btnGetCounter);
            this.gbMethodInvocation.Controls.Add(this.btnDecrementCounter);
            this.gbMethodInvocation.Controls.Add(this.btnIncrementCounter);
            this.gbMethodInvocation.Controls.Add(this.btnCauseException);
            this.gbMethodInvocation.Controls.Add(this.btnPing);
            this.gbMethodInvocation.Controls.Add(this.tbPing);
            this.gbMethodInvocation.Controls.Add(this.btnEcho);
            this.gbMethodInvocation.Controls.Add(this.tbEcho);
            this.gbMethodInvocation.Controls.Add(this.btnGetHostName);
            this.gbMethodInvocation.Controls.Add(this.tbHostName);
            this.gbMethodInvocation.Controls.Add(this.btnGetHostTime);
            this.gbMethodInvocation.Controls.Add(this.tbHostTime);
            this.gbMethodInvocation.Location = new System.Drawing.Point(17, 57);
            this.gbMethodInvocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbMethodInvocation.Name = "gbMethodInvocation";
            this.gbMethodInvocation.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbMethodInvocation.Size = new System.Drawing.Size(311, 422);
            this.gbMethodInvocation.TabIndex = 25;
            this.gbMethodInvocation.TabStop = false;
            this.gbMethodInvocation.Text = "Method Calls";
            // 
            // tbGetPerson
            // 
            this.tbGetPerson.Location = new System.Drawing.Point(121, 378);
            this.tbGetPerson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbGetPerson.Name = "tbGetPerson";
            this.tbGetPerson.Size = new System.Drawing.Size(176, 20);
            this.tbGetPerson.TabIndex = 19;
            // 
            // btnGetPerson
            // 
            this.btnGetPerson.Location = new System.Drawing.Point(5, 378);
            this.btnGetPerson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetPerson.Name = "btnGetPerson";
            this.btnGetPerson.Size = new System.Drawing.Size(106, 25);
            this.btnGetPerson.TabIndex = 18;
            this.btnGetPerson.Text = "Get Person";
            this.btnGetPerson.UseVisualStyleBackColor = true;
            this.btnGetPerson.Click += new System.EventHandler(this.btnGetPerson_Click);
            // 
            // tbGuessGender
            // 
            this.tbGuessGender.Location = new System.Drawing.Point(121, 339);
            this.tbGuessGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbGuessGender.Name = "tbGuessGender";
            this.tbGuessGender.Size = new System.Drawing.Size(176, 20);
            this.tbGuessGender.TabIndex = 17;
            // 
            // btnGuessGender
            // 
            this.btnGuessGender.Location = new System.Drawing.Point(5, 339);
            this.btnGuessGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuessGender.Name = "btnGuessGender";
            this.btnGuessGender.Size = new System.Drawing.Size(106, 25);
            this.btnGuessGender.TabIndex = 16;
            this.btnGuessGender.Text = "Guess Gender";
            this.btnGuessGender.UseVisualStyleBackColor = true;
            this.btnGuessGender.Click += new System.EventHandler(this.btnGuessGender_Click);
            // 
            // tbGetCounter
            // 
            this.tbGetCounter.Location = new System.Drawing.Point(121, 298);
            this.tbGetCounter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbGetCounter.Name = "tbGetCounter";
            this.tbGetCounter.Size = new System.Drawing.Size(176, 20);
            this.tbGetCounter.TabIndex = 15;
            // 
            // tbDecrementCounter
            // 
            this.tbDecrementCounter.Location = new System.Drawing.Point(121, 259);
            this.tbDecrementCounter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDecrementCounter.Name = "tbDecrementCounter";
            this.tbDecrementCounter.Size = new System.Drawing.Size(176, 20);
            this.tbDecrementCounter.TabIndex = 14;
            // 
            // tbIncrementCounter
            // 
            this.tbIncrementCounter.Location = new System.Drawing.Point(121, 220);
            this.tbIncrementCounter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbIncrementCounter.Name = "tbIncrementCounter";
            this.tbIncrementCounter.Size = new System.Drawing.Size(176, 20);
            this.tbIncrementCounter.TabIndex = 13;
            // 
            // tbCauseException
            // 
            this.tbCauseException.Location = new System.Drawing.Point(121, 181);
            this.tbCauseException.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbCauseException.Name = "tbCauseException";
            this.tbCauseException.Size = new System.Drawing.Size(176, 20);
            this.tbCauseException.TabIndex = 12;
            // 
            // btnGetCounter
            // 
            this.btnGetCounter.Location = new System.Drawing.Point(5, 298);
            this.btnGetCounter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetCounter.Name = "btnGetCounter";
            this.btnGetCounter.Size = new System.Drawing.Size(106, 25);
            this.btnGetCounter.TabIndex = 11;
            this.btnGetCounter.Text = "Get Counter";
            this.btnGetCounter.UseVisualStyleBackColor = true;
            this.btnGetCounter.Click += new System.EventHandler(this.btnGetCounter_Click);
            // 
            // btnDecrementCounter
            // 
            this.btnDecrementCounter.Location = new System.Drawing.Point(5, 259);
            this.btnDecrementCounter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDecrementCounter.Name = "btnDecrementCounter";
            this.btnDecrementCounter.Size = new System.Drawing.Size(106, 25);
            this.btnDecrementCounter.TabIndex = 10;
            this.btnDecrementCounter.Text = "Decrement Counter";
            this.btnDecrementCounter.UseVisualStyleBackColor = true;
            this.btnDecrementCounter.Click += new System.EventHandler(this.btnDecrementCounter_Click);
            // 
            // btnIncrementCounter
            // 
            this.btnIncrementCounter.Location = new System.Drawing.Point(5, 220);
            this.btnIncrementCounter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIncrementCounter.Name = "btnIncrementCounter";
            this.btnIncrementCounter.Size = new System.Drawing.Size(106, 25);
            this.btnIncrementCounter.TabIndex = 9;
            this.btnIncrementCounter.Text = "Increment Counter";
            this.btnIncrementCounter.UseVisualStyleBackColor = true;
            this.btnIncrementCounter.Click += new System.EventHandler(this.btnIncrementCounter_Click);
            // 
            // btnCauseException
            // 
            this.btnCauseException.Location = new System.Drawing.Point(5, 181);
            this.btnCauseException.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCauseException.Name = "btnCauseException";
            this.btnCauseException.Size = new System.Drawing.Size(106, 25);
            this.btnCauseException.TabIndex = 8;
            this.btnCauseException.Text = "Cause Exception";
            this.btnCauseException.UseVisualStyleBackColor = true;
            this.btnCauseException.Click += new System.EventHandler(this.btnCauseException_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(5, 25);
            this.btnPing.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(106, 25);
            this.btnPing.TabIndex = 0;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // tbPing
            // 
            this.tbPing.Location = new System.Drawing.Point(121, 25);
            this.tbPing.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPing.Name = "tbPing";
            this.tbPing.Size = new System.Drawing.Size(176, 20);
            this.tbPing.TabIndex = 7;
            // 
            // btnEcho
            // 
            this.btnEcho.Location = new System.Drawing.Point(5, 64);
            this.btnEcho.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEcho.Name = "btnEcho";
            this.btnEcho.Size = new System.Drawing.Size(106, 25);
            this.btnEcho.TabIndex = 1;
            this.btnEcho.Text = "Echo";
            this.btnEcho.UseVisualStyleBackColor = true;
            this.btnEcho.Click += new System.EventHandler(this.btnEcho_Click);
            // 
            // tbEcho
            // 
            this.tbEcho.Location = new System.Drawing.Point(121, 64);
            this.tbEcho.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEcho.Name = "tbEcho";
            this.tbEcho.Size = new System.Drawing.Size(176, 20);
            this.tbEcho.TabIndex = 6;
            // 
            // btnGetHostName
            // 
            this.btnGetHostName.Location = new System.Drawing.Point(5, 103);
            this.btnGetHostName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetHostName.Name = "btnGetHostName";
            this.btnGetHostName.Size = new System.Drawing.Size(106, 25);
            this.btnGetHostName.TabIndex = 2;
            this.btnGetHostName.Text = "Get Host Name";
            this.btnGetHostName.UseVisualStyleBackColor = true;
            this.btnGetHostName.Click += new System.EventHandler(this.btnGetHostName_Click);
            // 
            // tbHostName
            // 
            this.tbHostName.Location = new System.Drawing.Point(121, 103);
            this.tbHostName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(176, 20);
            this.tbHostName.TabIndex = 5;
            // 
            // btnGetHostTime
            // 
            this.btnGetHostTime.Location = new System.Drawing.Point(5, 142);
            this.btnGetHostTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetHostTime.Name = "btnGetHostTime";
            this.btnGetHostTime.Size = new System.Drawing.Size(106, 25);
            this.btnGetHostTime.TabIndex = 3;
            this.btnGetHostTime.Text = "Get Host Time";
            this.btnGetHostTime.UseVisualStyleBackColor = true;
            this.btnGetHostTime.Click += new System.EventHandler(this.btnGetHostTime_Click);
            // 
            // cBoxClientList
            // 
            this.cBoxClientList.FormattingEnabled = true;
            this.cBoxClientList.Location = new System.Drawing.Point(104, 23);
            this.cBoxClientList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cBoxClientList.Name = "cBoxClientList";
            this.cBoxClientList.Size = new System.Drawing.Size(225, 21);
            this.cBoxClientList.TabIndex = 26;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(19, 23);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(83, 13);
            this.lblServiceName.TabIndex = 27;
            this.lblServiceName.Text = "Service Name : ";
            // 
            // frmSingleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 517);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.gbMethodInvocation);
            this.Controls.Add(this.cBoxClientList);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmSingleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Single Test";
            this.gbMethodInvocation.ResumeLayout(false);
            this.gbMethodInvocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHostTime;
        private System.Windows.Forms.GroupBox gbMethodInvocation;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox tbPing;
        private System.Windows.Forms.Button btnEcho;
        private System.Windows.Forms.TextBox tbEcho;
        private System.Windows.Forms.Button btnGetHostName;
        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.Button btnGetHostTime;
        private System.Windows.Forms.ComboBox cBoxClientList;
        private System.Windows.Forms.Button btnCauseException;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Button btnIncrementCounter;
        private System.Windows.Forms.Button btnDecrementCounter;
        private System.Windows.Forms.TextBox tbGetCounter;
        private System.Windows.Forms.TextBox tbDecrementCounter;
        private System.Windows.Forms.TextBox tbIncrementCounter;
        private System.Windows.Forms.TextBox tbCauseException;
        private System.Windows.Forms.Button btnGetCounter;
        private System.Windows.Forms.TextBox tbGuessGender;
        private System.Windows.Forms.Button btnGuessGender;
        private System.Windows.Forms.TextBox tbGetPerson;
        private System.Windows.Forms.Button btnGetPerson;
    }
}