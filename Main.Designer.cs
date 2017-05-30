namespace BasicMailClient
{
    partial class MainWindow
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
            this.SendMailBtn = new System.Windows.Forms.Button();
            this.RecipientAddress = new System.Windows.Forms.TextBox();
            this.MessageSubject = new System.Windows.Forms.TextBox();
            this.UserMessage = new System.Windows.Forms.RichTextBox();
            this.LABEL1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendMailBtn
            // 
            this.SendMailBtn.Location = new System.Drawing.Point(423, 259);
            this.SendMailBtn.Name = "SendMailBtn";
            this.SendMailBtn.Size = new System.Drawing.Size(274, 23);
            this.SendMailBtn.TabIndex = 0;
            this.SendMailBtn.Text = "Send!";
            this.SendMailBtn.UseVisualStyleBackColor = true;
            this.SendMailBtn.Click += new System.EventHandler(this.SendMailBtn_Click);
            // 
            // RecipientAddress
            // 
            this.RecipientAddress.Location = new System.Drawing.Point(88, 12);
            this.RecipientAddress.Name = "RecipientAddress";
            this.RecipientAddress.Size = new System.Drawing.Size(342, 20);
            this.RecipientAddress.TabIndex = 1;
            this.RecipientAddress.TextChanged += new System.EventHandler(this.RecipientAddress_TextChanged);
            // 
            // MessageSubject
            // 
            this.MessageSubject.Location = new System.Drawing.Point(88, 58);
            this.MessageSubject.Name = "MessageSubject";
            this.MessageSubject.Size = new System.Drawing.Size(342, 20);
            this.MessageSubject.TabIndex = 2;
            // 
            // UserMessage
            // 
            this.UserMessage.Location = new System.Drawing.Point(88, 105);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(609, 148);
            this.UserMessage.TabIndex = 3;
            this.UserMessage.Text = "";
            // 
            // LABEL1
            // 
            this.LABEL1.AutoSize = true;
            this.LABEL1.Location = new System.Drawing.Point(16, 19);
            this.LABEL1.Name = "LABEL1";
            this.LABEL1.Size = new System.Drawing.Size(53, 13);
            this.LABEL1.TabIndex = 4;
            this.LABEL1.Text = "MAIL TO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SUBJECT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MESSAGE:";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.AutoSize = true;
            this.ConnectionStatus.Location = new System.Drawing.Point(16, 269);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(40, 13);
            this.ConnectionStatus.TabIndex = 7;
            this.ConnectionStatus.Text = "Status:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 294);
            this.Controls.Add(this.ConnectionStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LABEL1);
            this.Controls.Add(this.UserMessage);
            this.Controls.Add(this.MessageSubject);
            this.Controls.Add(this.RecipientAddress);
            this.Controls.Add(this.SendMailBtn);
            this.Name = "MainWindow";
            this.Text = "Basic Mail Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMailBtn;
        private System.Windows.Forms.TextBox RecipientAddress;
        private System.Windows.Forms.TextBox MessageSubject;
        private System.Windows.Forms.RichTextBox UserMessage;
        private System.Windows.Forms.Label LABEL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ConnectionStatus;
    }
}

