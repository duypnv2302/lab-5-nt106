namespace lab_5_nt106
{
    partial class RECIEVE
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
            this.lbPass = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbRecent = new System.Windows.Forms.Label();
            this.listShow = new System.Windows.Forms.ListView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPass
            // 
            this.lbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(34, 80);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(82, 20);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(34, 54);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email:";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(45, 143);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(41, 16);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "Total:";
            this.lbTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbRecent
            // 
            this.lbRecent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRecent.AutoSize = true;
            this.lbRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecent.Location = new System.Drawing.Point(242, 143);
            this.lbRecent.Name = "lbRecent";
            this.lbRecent.Size = new System.Drawing.Size(53, 16);
            this.lbRecent.TabIndex = 10;
            this.lbRecent.Text = "Recent:";
            this.lbRecent.Click += new System.EventHandler(this.label1_Click);
            // 
            // listShow
            // 
            this.listShow.HideSelection = false;
            this.listShow.Location = new System.Drawing.Point(38, 180);
            this.listShow.Name = "listShow";
            this.listShow.Size = new System.Drawing.Size(575, 266);
            this.listShow.TabIndex = 12;
            this.listShow.UseCompatibleStateImageBehavior = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(443, 50);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 53);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(121, 82);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(247, 20);
            this.txtPass.TabIndex = 15;
            // 
            // RECIEVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 458);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.listShow);
            this.Controls.Add(this.lbRecent);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbEmail);
            this.Name = "RECIEVE";
            this.Text = "RECIEVE";
            this.Load += new System.EventHandler(this.RECIEVE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbRecent;
        private System.Windows.Forms.ListView listShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
    }
}