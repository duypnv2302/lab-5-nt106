using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Search;
using System.Windows.Forms;
using System.Threading;
using MailKit.Security;
using System.Linq.Expressions;

namespace lab_5_nt106
{
    public partial class RECIEVE : Form
    {
        public RECIEVE()
        {
            InitializeComponent();
            listShow.Columns.Add("Subject", 200);
            listShow.Columns.Add("From", 200);
            listShow.Columns.Add("Date", 200);
            listShow.View = View.Details;
            txtPass.Clear();
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 15;
        }

        void ReadMail()
        {
            try
            {
                using (ImapClient client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("localhost", 993, true);

                    client.Authenticate(txtEmail.Text, txtPass.Text);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    lbTotal.Text = inbox.Count.ToString();
                    lbRecent.Text = inbox.Recent.ToString();

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);

                        ListViewItem item = new ListViewItem();
                        item.Text = message.Subject;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.Date.ToString() });
                        listShow.Items.Add(item);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kiểm tra user và password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RECIEVE_Load(object sender, EventArgs e)
        {

        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty && txtPass.Text == string.Empty)
            {
                MessageBox.Show("Điền user và password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Điền user!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPass.Text == string.Empty)
            {
                MessageBox.Show("Điền password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                if ((txtEmail.Text == "duyphan@nhom02.nt106" || txtEmail.Text == "phongkhuu@nhom2.nt106" || txtEmail.Text == "tienvi@nhom2.nt106" || txtEmail.Text == "anhnguyen@nhom2.nt106")
                    && txtPass.Text == "Hello12345!")
                {
                    ReadMail();
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

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
