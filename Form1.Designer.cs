namespace lab_5_nt106
{
    partial class SEND
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
            this.btnSend = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtEmailFrom = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmailTo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.txtSubject = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBody = new System.Windows.Forms.Label();
            this.txtBody = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(23, 92);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 58);
            this.btnSend.TabIndex = 0;
            this.btnSend.Values.Text = "SEND";
            this.btnSend.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(200, 98);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(247, 23);
            this.txtEmailFrom.TabIndex = 1;
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(200, 127);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(247, 23);
            this.txtEmailTo.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(573, 98);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(142, 23);
            this.txtPass.TabIndex = 1;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(138, 101);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(50, 20);
            this.lbFrom.TabIndex = 2;
            this.lbFrom.Text = "From:";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(138, 127);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(31, 20);
            this.lbTo.TabIndex = 2;
            this.lbTo.Text = "To:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(485, 101);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(82, 20);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password:";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.Location = new System.Drawing.Point(30, 181);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(63, 20);
            this.lbSubject.TabIndex = 2;
            this.lbSubject.Text = "Subject";
            this.lbSubject.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(126, 181);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(247, 23);
            this.txtSubject.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBody.Location = new System.Drawing.Point(30, 222);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(45, 20);
            this.lbBody.TabIndex = 2;
            this.lbBody.Text = "Body";
            this.lbBody.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBody
            // 
            this.txtBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBody.Location = new System.Drawing.Point(34, 260);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(681, 161);
            this.txtBody.TabIndex = 3;
            this.txtBody.Text = "";
            this.txtBody.TextChanged += new System.EventHandler(this.kryptonRichTextBox1_TextChanged);
            // 
            // SEND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.txtEmailFrom);
            this.Controls.Add(this.btnSend);
            this.Name = "SEND";
            this.Text = "SEND";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSend;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmailFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmailTo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPass;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbSubject;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBody;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtBody;
    }
}

