﻿using System;
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
    public partial class Inbox : Form
    {
        public Inbox(string from, string subject, string to, string body)
        {
            InitializeComponent();
            fromBox.Text = from;
            subBox.Text = subject;
            toBox.Text = to;
            bodyBox.Text = body;
        }

        private void Inbox_Load(object sender, EventArgs e)
        {

        }
    }
}
