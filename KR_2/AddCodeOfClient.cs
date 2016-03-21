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
    public partial class AddCodeOfClient : Form
    {
        FSales linkToFSalesObjClient;
        public AddCodeOfClient(FSales refToObj)
        {
            InitializeComponent();
            linkToFSalesObjClient = refToObj;            
                foreach (DataGridViewRow row in linkToFSalesObjClient.clients.clientDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null) {
                        addCodeOfClientDGV.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
                    }
                    
                }                              
        }        

        private void addCodeOfClientbtn_Click(object sender, EventArgs e)
        {
            linkToFSalesObjClient.setCodeOfClientSalesTB(addCodeOfClientDGV.SelectedCells[0].Value.ToString());
            Close();
        }
    }
}
