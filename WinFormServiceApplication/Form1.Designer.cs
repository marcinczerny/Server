namespace WinFormServiceApplication
{
    partial class Form1
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
            this.StartServiceBtn = new System.Windows.Forms.Button();
            this.StopServiceBtn = new System.Windows.Forms.Button();
            this.ServiceStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectedClientsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReceivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectClientBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAcknowledge = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StartServiceBtn
            // 
            this.StartServiceBtn.Location = new System.Drawing.Point(12, 12);
            this.StartServiceBtn.Name = "StartServiceBtn";
            this.StartServiceBtn.Size = new System.Drawing.Size(96, 23);
            this.StartServiceBtn.TabIndex = 0;
            this.StartServiceBtn.Text = "Start Service";
            this.StartServiceBtn.UseVisualStyleBackColor = true;
            this.StartServiceBtn.Click += new System.EventHandler(this.StartServiceBtn_Click);
            // 
            // StopServiceBtn
            // 
            this.StopServiceBtn.Location = new System.Drawing.Point(12, 41);
            this.StopServiceBtn.Name = "StopServiceBtn";
            this.StopServiceBtn.Size = new System.Drawing.Size(96, 23);
            this.StopServiceBtn.TabIndex = 1;
            this.StopServiceBtn.Text = "Stop Service";
            this.StopServiceBtn.UseVisualStyleBackColor = true;
            this.StopServiceBtn.Click += new System.EventHandler(this.StopServiceBtn_Click);
            // 
            // ServiceStatusLabel
            // 
            this.ServiceStatusLabel.AutoSize = true;
            this.ServiceStatusLabel.Location = new System.Drawing.Point(248, 12);
            this.ServiceStatusLabel.Name = "ServiceStatusLabel";
            this.ServiceStatusLabel.Size = new System.Drawing.Size(67, 13);
            this.ServiceStatusLabel.TabIndex = 2;
            this.ServiceStatusLabel.Text = "Not Running";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connected Clients";
            // 
            // ConnectedClientsListBox
            // 
            this.ConnectedClientsListBox.FormattingEnabled = true;
            this.ConnectedClientsListBox.Location = new System.Drawing.Point(12, 211);
            this.ConnectedClientsListBox.Name = "ConnectedClientsListBox";
            this.ConnectedClientsListBox.Size = new System.Drawing.Size(230, 186);
            this.ConnectedClientsListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Messages Received from Clients";
            // 
            // ReceivedMessagesListBox
            // 
            this.ReceivedMessagesListBox.FormattingEnabled = true;
            this.ReceivedMessagesListBox.Location = new System.Drawing.Point(248, 211);
            this.ReceivedMessagesListBox.Name = "ReceivedMessagesListBox";
            this.ReceivedMessagesListBox.Size = new System.Drawing.Size(260, 186);
            this.ReceivedMessagesListBox.TabIndex = 6;
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(12, 85);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(187, 23);
            this.SendMessageBtn.TabIndex = 7;
            this.SendMessageBtn.Text = "Send to Selected Client";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(251, 88);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(257, 20);
            this.MessageTextBox.TabIndex = 8;
            // 
            // DisconnectClientBtn
            // 
            this.DisconnectClientBtn.Location = new System.Drawing.Point(12, 114);
            this.DisconnectClientBtn.Name = "DisconnectClientBtn";
            this.DisconnectClientBtn.Size = new System.Drawing.Size(187, 23);
            this.DisconnectClientBtn.TabIndex = 9;
            this.DisconnectClientBtn.Text = "Disconnect Selected Client";
            this.DisconnectClientBtn.UseVisualStyleBackColor = true;
            this.DisconnectClientBtn.Click += new System.EventHandler(this.DisconnectClientBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Potwierdzenia";
            // 
            // listBoxAcknowledge
            // 
            this.listBoxAcknowledge.FormattingEnabled = true;
            this.listBoxAcknowledge.Location = new System.Drawing.Point(514, 212);
            this.listBoxAcknowledge.Name = "listBoxAcknowledge";
            this.listBoxAcknowledge.Size = new System.Drawing.Size(260, 186);
            this.listBoxAcknowledge.TabIndex = 11;
            this.listBoxAcknowledge.SelectedIndexChanged += new System.EventHandler(this.listBoxAcknowledge_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 410);
            this.Controls.Add(this.listBoxAcknowledge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectClientBtn);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SendMessageBtn);
            this.Controls.Add(this.ReceivedMessagesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConnectedClientsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServiceStatusLabel);
            this.Controls.Add(this.StopServiceBtn);
            this.Controls.Add(this.StartServiceBtn);
            this.Name = "Form1";
            this.Text = "WinForm Service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServiceBtn;
        private System.Windows.Forms.Button StopServiceBtn;
        private System.Windows.Forms.Label ServiceStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ConnectedClientsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ReceivedMessagesListBox;
        private System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button DisconnectClientBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAcknowledge;
    }
}

