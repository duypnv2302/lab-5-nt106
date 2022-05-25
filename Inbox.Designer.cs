namespace lab_5_nt106
{
    partial class Inbox
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
            this.bodyBox = new System.Windows.Forms.RichTextBox();
            this.toBox = new System.Windows.Forms.RichTextBox();
            this.subBox = new System.Windows.Forms.RichTextBox();
            this.fromBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(94, 162);
            this.bodyBox.Margin = new System.Windows.Forms.Padding(2);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(392, 203);
            this.bodyBox.TabIndex = 16;
            this.bodyBox.Text = "";
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(152, 111);
            this.toBox.Margin = new System.Windows.Forms.Padding(2);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(267, 28);
            this.toBox.TabIndex = 15;
            this.toBox.Text = "";
            // 
            // subBox
            // 
            this.subBox.Location = new System.Drawing.Point(152, 69);
            this.subBox.Margin = new System.Windows.Forms.Padding(2);
            this.subBox.Name = "subBox";
            this.subBox.Size = new System.Drawing.Size(267, 28);
            this.subBox.TabIndex = 14;
            this.subBox.Text = "";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(152, 29);
            this.fromBox.Margin = new System.Windows.Forms.Padding(2);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(267, 28);
            this.fromBox.TabIndex = 13;
            this.fromBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.subBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.Inbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox bodyBox;
        private System.Windows.Forms.RichTextBox toBox;
        private System.Windows.Forms.RichTextBox subBox;
        private System.Windows.Forms.RichTextBox fromBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}