using System;
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
        Clients clients; 
        Products products; 
        NewSales newSales;
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients = new Clients();
            clients.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products = new Products();
            products.ShowDialog();
        }

        private void addSales_Click(object sender, EventArgs e)
        {
            newSales = new NewSales();
            newSales.ShowDialog();
        }
    }
}
