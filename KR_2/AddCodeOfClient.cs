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
            Clients receiveDataFromClient = new Clients();
                foreach (DataGridViewRow row in receiveDataFromClient.clientDataGridView.Rows)
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
