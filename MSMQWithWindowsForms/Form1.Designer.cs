
namespace MSMQWithWindowsForms
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
            this.helpRequestQueue = new System.Messaging.MessageQueue();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendMessage = new System.Windows.Forms.Button();
            this.refreshMessages = new System.Windows.Forms.Button();
            this.purgeMessages = new System.Windows.Forms.Button();
            this.highPriority = new System.Windows.Forms.CheckBox();
            this.messageGrid = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.messageGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // helpRequestQueue
            // 
            this.helpRequestQueue.DefaultPropertiesToSend.HashAlgorithm = System.Messaging.HashAlgorithm.Sha512;
            this.helpRequestQueue.MessageReadPropertyFilter.LookupId = true;
            this.helpRequestQueue.MessageReadPropertyFilter.Priority = true;
            this.helpRequestQueue.Path = "LAPTOP-RSJ1URLE\\Private$\\WFqueue";
            this.helpRequestQueue.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(63, 129);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(417, 23);
            this.sendMessage.TabIndex = 2;
            this.sendMessage.Text = "Send";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // refreshMessages
            // 
            this.refreshMessages.Location = new System.Drawing.Point(63, 158);
            this.refreshMessages.Name = "refreshMessages";
            this.refreshMessages.Size = new System.Drawing.Size(417, 23);
            this.refreshMessages.TabIndex = 3;
            this.refreshMessages.Text = "Refresh list";
            this.refreshMessages.UseVisualStyleBackColor = true;
            this.refreshMessages.Click += new System.EventHandler(this.refreshMessages_Click);
            // 
            // purgeMessages
            // 
            this.purgeMessages.Location = new System.Drawing.Point(63, 187);
            this.purgeMessages.Name = "purgeMessages";
            this.purgeMessages.Size = new System.Drawing.Size(417, 23);
            this.purgeMessages.TabIndex = 4;
            this.purgeMessages.Text = "Eliminate Messages";
            this.purgeMessages.UseVisualStyleBackColor = true;
            this.purgeMessages.Click += new System.EventHandler(this.purgeMessages_Click);
            // 
            // highPriority
            // 
            this.highPriority.AutoSize = true;
            this.highPriority.Location = new System.Drawing.Point(399, 98);
            this.highPriority.Name = "highPriority";
            this.highPriority.Size = new System.Drawing.Size(81, 17);
            this.highPriority.TabIndex = 5;
            this.highPriority.Text = "High priority";
            this.highPriority.UseVisualStyleBackColor = true;
            // 
            // messageGrid
            // 
            this.messageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageGrid.Location = new System.Drawing.Point(34, 226);
            this.messageGrid.Name = "messageGrid";
            this.messageGrid.Size = new System.Drawing.Size(465, 223);
            this.messageGrid.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(388, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(92, 72);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(388, 20);
            this.txtMessage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 461);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.messageGrid);
            this.Controls.Add(this.highPriority);
            this.Controls.Add(this.purgeMessages);
            this.Controls.Add(this.refreshMessages);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Message Queuing WF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Messaging.MessageQueue helpRequestQueue;
        private System.Windows.Forms.DataGridView messageGrid;
        private System.Windows.Forms.CheckBox highPriority;
        private System.Windows.Forms.Button purgeMessages;
        private System.Windows.Forms.Button refreshMessages;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
    }
}

