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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(51, 47);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(168, 100);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnRecMail
            // 
            this.btnRecMail.Location = new System.Drawing.Point(51, 177);
            this.btnRecMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecMail.Name = "btnRecMail";
            this.btnRecMail.Size = new System.Drawing.Size(168, 100);
            this.btnRecMail.TabIndex = 0;
            this.btnRecMail.Text = "Recieve Mail";
            this.btnRecMail.UseVisualStyleBackColor = true;
            this.btnRecMail.Click += new System.EventHandler(this.btnRecMail_Click);
            // 
            // btnAppMail
            // 
            this.btnAppMail.Location = new System.Drawing.Point(51, 311);
            this.btnAppMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAppMail.Name = "btnAppMail";
            this.btnAppMail.Size = new System.Drawing.Size(168, 100);
            this.btnAppMail.TabIndex = 0;
            this.btnAppMail.Text = "App Mail";
            this.btnAppMail.UseVisualStyleBackColor = true;
            this.btnAppMail.Click += new System.EventHandler(this.btnAppMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khưu Minh Phong – 20521742";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nguyễn Đàm Nhật Anh – 20520880";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phan Nguyễn Văn Duy – 20520168";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vi Minh Tiến – 20520810";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAppMail);
            this.Controls.Add(this.btnRecMail);
            this.Controls.Add(this.btnSendMail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnRecMail;
        private System.Windows.Forms.Button btnAppMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}