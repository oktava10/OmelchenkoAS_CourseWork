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
        FSales linkToFSalesObjProduct;
        public AddCodeOfProduct(FSales refToObj)
        {
            InitializeComponent();
            linkToFSalesObjProduct = refToObj;            
            foreach (DataGridViewRow row in linkToFSalesObjProduct.products.productDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    addCodeOfProductDGV.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
                }

            }            
        }
                
        private void addCodeOfProductBTN_Click(object sender, EventArgs e)
        {
            linkToFSalesObjProduct.setCodeOfProductSalesTB(addCodeOfProductDGV.SelectedCells[0].Value.ToString());
            Close();
        }
    }
}
