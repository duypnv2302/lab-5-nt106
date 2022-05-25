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
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBody = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
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
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 78);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(105, 69);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(200, 101);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(247, 20);
            this.txtEmailFrom.TabIndex = 5;
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(200, 127);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(247, 20);
            this.txtEmailTo.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(582, 103);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(142, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(142, 183);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(247, 20);
            this.txtSubject.TabIndex = 5;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(84, 257);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(602, 181);
            this.txtBody.TabIndex = 6;
            this.txtBody.Text = "";
            // 
            // SEND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtEmailTo);
            this.Controls.Add(this.txtEmailFrom);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbFrom);
            this.Name = "SEND";
            this.Text = "SEND";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.RichTextBox txtBody;
    }
}

