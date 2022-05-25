namespace lab_5_nt106
{
    partial class AppMail
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
            this.send_emailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.inboxBox = new System.Windows.Forms.ListView();
            this.sendBtn = new System.Windows.Forms.Button();
            this.attachBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.RichTextBox();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.subjectBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.to_emailBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // send_emailBox
            // 
            this.send_emailBox.Location = new System.Drawing.Point(134, 67);
            this.send_emailBox.Name = "send_emailBox";
            this.send_emailBox.Size = new System.Drawing.Size(144, 20);
            this.send_emailBox.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Inbox";
            // 
            // from
            // 
            this.from.Text = "From";
            this.from.Width = 287;
            // 
            // content
            // 
            this.content.Text = "Content";
            this.content.Width = 277;
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(134, 113);
            this.pwdBox.Margin = new System.Windows.Forms.Padding(2);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '*';
            this.pwdBox.Size = new System.Drawing.Size(144, 20);
            this.pwdBox.TabIndex = 36;
            // 
            // inboxBox
            // 
            this.inboxBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.content,
            this.from});
            this.inboxBox.HideSelection = false;
            this.inboxBox.Location = new System.Drawing.Point(62, 212);
            this.inboxBox.Margin = new System.Windows.Forms.Padding(2);
            this.inboxBox.Name = "inboxBox";
            this.inboxBox.Size = new System.Drawing.Size(427, 249);
            this.inboxBox.TabIndex = 34;
            this.inboxBox.UseCompatibleStateImageBehavior = false;
            this.inboxBox.View = System.Windows.Forms.View.Details;
            this.inboxBox.SelectedIndexChanged += new System.EventHandler(this.inboxBox_SelectedIndexChanged);
            this.inboxBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inboxBox_MouseClick);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(921, 391);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(70, 41);
            this.sendBtn.TabIndex = 33;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // attachBtn
            // 
            this.attachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachBtn.Location = new System.Drawing.Point(921, 78);
            this.attachBtn.Margin = new System.Windows.Forms.Padding(2);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(84, 25);
            this.attachBtn.TabIndex = 32;
            this.attachBtn.Text = "Attachment";
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.SystemColors.Control;
            this.pathBox.Location = new System.Drawing.Point(921, 123);
            this.pathBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathBox.Multiline = false;
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(139, 33);
            this.pathBox.TabIndex = 31;
            this.pathBox.Text = "";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(629, 212);
            this.contentBox.Margin = new System.Windows.Forms.Padding(2);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(289, 248);
            this.contentBox.TabIndex = 30;
            this.contentBox.Text = "";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(624, 123);
            this.subjectBox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(276, 33);
            this.subjectBox.TabIndex = 29;
            this.subjectBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Subject";
            // 
            // to_emailBox
            // 
            this.to_emailBox.Location = new System.Drawing.Point(624, 77);
            this.to_emailBox.Margin = new System.Windows.Forms.Padding(2);
            this.to_emailBox.Name = "to_emailBox";
            this.to_emailBox.Size = new System.Drawing.Size(152, 27);
            this.to_emailBox.TabIndex = 26;
            this.to_emailBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "From";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(300, 77);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(80, 35);
            this.loginBtn.TabIndex = 22;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email";
            // 
            // AppMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 522);
            this.Controls.Add(this.send_emailBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.inboxBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.to_emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppMail";
            this.Text = "AppMail";
            this.Load += new System.EventHandler(this.AppMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox send_emailBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader content;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.ListView inboxBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.RichTextBox pathBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.RichTextBox subjectBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox to_emailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}