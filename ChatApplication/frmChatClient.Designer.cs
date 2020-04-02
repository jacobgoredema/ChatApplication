namespace ChatApplication
{
    partial class frmChatClient
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
            this.btnNewChatClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewChatClient
            // 
            this.btnNewChatClient.Location = new System.Drawing.Point(12, 10);
            this.btnNewChatClient.Name = "btnNewChatClient";
            this.btnNewChatClient.Size = new System.Drawing.Size(260, 63);
            this.btnNewChatClient.TabIndex = 0;
            this.btnNewChatClient.Text = "New Chat Client";
            this.btnNewChatClient.UseVisualStyleBackColor = true;
            this.btnNewChatClient.Click += new System.EventHandler(this.btnNewChatClient_Click);
            // 
            // frmChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 82);
            this.Controls.Add(this.btnNewChatClient);
            this.Name = "frmChatClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewChatClient;
    }
}