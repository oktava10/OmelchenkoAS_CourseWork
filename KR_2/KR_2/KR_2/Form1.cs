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
    public partial class FSales : Form
    {
        public FSales()
        {
            InitializeComponent();
            
        }
        Clients clients = new Clients();
        Products products = new Products();
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products.Show();
        }
    }
}
