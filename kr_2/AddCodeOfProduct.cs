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
    public partial class AddCodeOfProduct : Form
    {
        public AddCodeOfProduct()
        {
            InitializeComponent();
            using (Products riceveDataFromProduct = new Products())
            {
                foreach (DataGridViewRow row in riceveDataFromProduct.productDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        addCodeOfProductDGV.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
                    }

                }
            }
        }
                
        private void addCodeOfProductBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
