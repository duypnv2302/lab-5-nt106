using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5_nt106
{
    public partial class SEND : Form
    {
        public SEND()
        {
            InitializeComponent();
            txtPass.Text = "";
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 15;
        }

        void SendMail()
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = txtEmailFrom.Text.Trim();
                string mailto = txtEmailTo.Text.Trim();
                string password = txtPass.Text.Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = txtSubject.Text.Trim();

                    message.IsBodyHtml = false;
                    message.Body = txtBody.Text.Trim();
                    message.To.Add(mailto);

                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Gửi mail thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (txtEmailFrom.Text == string.Empty || txtEmailTo.Text == string.Empty)
            {
                MessageBox.Show("Nhập đủ mail người nhận và người gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPass.Text == string.Empty)
            {
                MessageBox.Show("Nhập password!");
            }
            else
            {
                if ((txtEmailFrom.Text == "duyphan@nhom02.nt106" || txtEmailFrom.Text == "phongkhuu@nhom2.nt106" || txtEmailFrom.Text == "tienvi@nhom2.nt106" || txtEmailFrom.Text == "anhnguyen@nhom2.nt106")
                    && (txtEmailTo.Text == "duyphan@nhom02.nt106" || txtEmailTo.Text == "phongkhuu@nhom2.nt106" || txtEmailTo.Text == "tienvi@nhom2.nt106" || txtEmailTo.Text == "anhnguyen@nhom2.nt106")
                    && txtPass.Text == "Hello12345!")
                {
                    SendMail();
                }
                else if (txtPass.Text.Trim() != "Hello12345!")
                {
                    MessageBox.Show("Nhập sai mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Địa chỉ Email không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
