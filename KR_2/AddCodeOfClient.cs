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
        public AddCodeOfClient()
        {
            InitializeComponent();
            //foreach (DataGridViewRow row in ClientsProuctsDataGrids.TempDataGridViewClients.Rows) {
            //   addCodeOfClientDGV.Rows.Add(row);
            //}
            using (Clients riceveDataFromClient = new Clients()) {
                foreach (DataGridViewRow row in riceveDataFromClient.clientDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null) {
                        addCodeOfClientDGV.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
                    }
                    
                }
            }                       
        }
    }
}
