using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5_nt106
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            Form b1 = new SEND();
            b1.Show();
        }

        private void btnRecMail_Click(object sender, EventArgs e)
        {
            Form b2 = new RECIEVE();
            b2.Show();
        }

        private void btnAppMail_Click(object sender, EventArgs e)
        {
            Form b3 = new AppMail();
            b3.Show();
        }
    }
}
