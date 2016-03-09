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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        NewProduct newProduct = new NewProduct();
        private void addNewProductBtn_Click(object sender, EventArgs e)
        {
            newProduct.Show();
        }
    }
}
