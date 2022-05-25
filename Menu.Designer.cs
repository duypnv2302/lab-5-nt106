namespace lab_5_nt106
{
    partial class Menu
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
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnRecMail = new System.Windows.Forms.Button();
            this.btnAppMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(38, 38);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(126, 81);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnRecMail
            // 
            this.btnRecMail.Location = new System.Drawing.Point(38, 144);
            this.btnRecMail.Name = "btnRecMail";
            this.btnRecMail.Size = new System.Drawing.Size(126, 81);
            this.btnRecMail.TabIndex = 0;
            this.btnRecMail.Text = "Recieve Mail";
            this.btnRecMail.UseVisualStyleBackColor = true;
            this.btnRecMail.Click += new System.EventHandler(this.btnRecMail_Click);
            // 
            // btnAppMail
            // 
            this.btnAppMail.Location = new System.Drawing.Point(38, 253);
            this.btnAppMail.Name = "btnAppMail";
            this.btnAppMail.Size = new System.Drawing.Size(126, 81);
            this.btnAppMail.TabIndex = 0;
            this.btnAppMail.Text = "App Mail";
            this.btnAppMail.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 381);
            this.Controls.Add(this.btnAppMail);
            this.Controls.Add(this.btnRecMail);
            this.Controls.Add(this.btnSendMail);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnRecMail;
        private System.Windows.Forms.Button btnAppMail;
    }
}