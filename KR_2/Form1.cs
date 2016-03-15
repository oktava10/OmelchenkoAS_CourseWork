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
        Clients clients;
        Products products;        
        AddCodeOfClient newAddCodeOfClient;
        AddCodeOfProduct newAddCodeOfProduct;
        public FSales()
        {
            InitializeComponent();
            clients = new Clients();
            clients.Owner = this;
            products = new Products();
            products.Owner = this;                       
        }
        
        
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            clients.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            products.ShowDialog();
        }

        private void addSales_Click(object sender, EventArgs e)
        {
                        
        }

        private void onClickProductSalesTB(object sender, EventArgs e)
        {
            using (newAddCodeOfProduct = new AddCodeOfProduct())
            {
                newAddCodeOfProduct.ShowDialog();
            }
        }

        private void onClickClientSalesTB(object sender, EventArgs e)
        {
            using (newAddCodeOfClient = new AddCodeOfClient()) {
                newAddCodeOfClient.ShowDialog();
            }
            
        }
    }
}
