﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KR_2
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        NewClient newClientForm = new NewClient();
        private void addClient_Click(object sender, EventArgs e)
        {
            newClientForm.ShowDialog();
        }
    }
}
