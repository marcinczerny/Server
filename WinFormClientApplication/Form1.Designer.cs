namespace WinFormClientApplication
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
            this.OpenConnectionBtn = new System.Windows.Forms.Button();
            this.CloseConnectionBtn = new System.Windows.Forms.Button();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenConnectionBtn
            // 
            this.OpenConnectionBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenConnectionBtn.Name = "OpenConnectionBtn";
            this.OpenConnectionBtn.Size = new System.Drawing.Size(101, 23);
            this.OpenConnectionBtn.TabIndex = 0;
            this.OpenConnectionBtn.Text = "Open Connection";
            this.OpenConnectionBtn.UseVisualStyleBackColor = true;
            this.OpenConnectionBtn.Click += new System.EventHandler(this.OpenConnectionBtn_Click);
            // 
            // CloseConnectionBtn
            // 
            this.CloseConnectionBtn.Location = new System.Drawing.Point(12, 41);
            this.CloseConnectionBtn.Name = "CloseConnectionBtn";
            this.CloseConnectionBtn.Size = new System.Drawing.Size(101, 23);
            this.CloseConnectionBtn.TabIndex = 1;
            this.CloseConnectionBtn.Text = "Close Connection";
            this.CloseConnectionBtn.UseVisualStyleBackColor = true;
            this.CloseConnectionBtn.Click += new System.EventHandler(this.CloseConnectionBtn_Click);
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(12, 92);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(101, 23);
            this.SendMessageBtn.TabIndex = 2;
            this.SendMessageBtn.Text = "Send Message";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Received Messages";
            // 
            // ReceivedMessagesListBox
            // 
            this.ReceivedMessagesListBox.FormattingEnabled = true;
            this.ReceivedMessagesListBox.Location = new System.Drawing.Point(12, 152);
            this.ReceivedMessagesListBox.Name = "ReceivedMessagesListBox";
            this.ReceivedMessagesListBox.Size = new System.Drawing.Size(394, 160);
            this.ReceivedMessagesListBox.TabIndex = 4;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(133, 94);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(273, 20);
            this.MessageTextBox.TabIndex = 5;
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(130, 17);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(79, 13);
            this.ConnectionStatusLabel.TabIndex = 6;
            this.ConnectionStatusLabel.Text = "Not Connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 322);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ReceivedMessagesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMessageBtn);
            this.Controls.Add(this.CloseConnectionBtn);
            this.Controls.Add(this.OpenConnectionBtn);
            this.Name = "Form1";
            this.Text = "WinForm Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenConnectionBtn;
        private System.Windows.Forms.Button CloseConnectionBtn;
        private System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ReceivedMessagesListBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label ConnectionStatusLabel;
    }
}

