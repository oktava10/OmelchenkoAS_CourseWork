using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace KR_2
{
    public partial class FSales : Form
    {
        public Clients clients;
        public Products products;        
        AddCodeOfClient newAddCodeOfClient;
        AddCodeOfProduct newAddCodeOfProduct;
        int id_sales = 0; // id элемента в базе данных и таблице "Продажи"
        public FSales()
        {
            InitializeComponent();
            clients = new Clients(this);
            clients.Owner = this;
            products = new Products(this);
            products.Owner = this;
            using (StreamReader fsRead = new StreamReader(StoreStaticVariables.pathToSalesDB)) // открываем нашу базу данных по клиентам для чтения и записываем 
            {                                                                                   // все данные из нее в таблицу "Продажи", выдергивая последний id 
                                                                                                // элемента в таблице.
                string slaesElement; // Элемент таблицы "Продажи" в базе данных
                string[] tempArray; // Временный массив для разбиения строки, прочитанной из базы данных                 
                while ((slaesElement = fsRead.ReadLine()) != null) // Цикл обработки читаемого файла с разбиением и записью в таблицу
                {
                    tempArray = slaesElement.Split(';'); // Разбить строку на элементы, разделитель ";"
                    salesDGV.Rows.Add(tempArray[0], tempArray[1], tempArray[2], tempArray[3], tempArray[4]); // добавляем элементы в таблицу "Продажи"
                    id_sales = Convert.ToInt32(tempArray[0]); // вытаскиваем текущий ID элемента, а в последующем последний ID для его увеличения, конвертируя его
                }
                fsRead.Close();
            }
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
            id_sales++; // увеличиваем id на единицу
            salesDGV.Rows.Add(id_sales, dateTimePickerOfSales.Text, codeOfClientSalesTB.Text, codeOfProductSalesTB.Text, countOfSalesTB.Text); // добавляем запись в таблицу "Кленты"
            using (FileStream fsWriteToAdd = File.Open(StoreStaticVariables.pathToSalesDB, FileMode.Append, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                Byte[] theSale = new UTF8Encoding(true).GetBytes(id_sales + ";" + dateTimePickerOfSales.Text + ";" + codeOfClientSalesTB.Text 
                    + ";" + codeOfProductSalesTB.Text + ";" + countOfSalesTB.Text + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                                                                            // в базу данных.
                fsWriteToAdd.Write(theSale, 0, theSale.Length); // записываем данные в базу данных
                fsWriteToAdd.Close();
            }
            codeOfClientSalesTB.Clear();
            codeOfProductSalesTB.Clear();
            countOfSalesTB.Clear();     // чистим поле для ввода записи
        }
        private void removeSales_Click(object sender, EventArgs e)
        {
            if (salesDGV.SelectedRows.Count == salesDGV.Rows.Count)
            {
                salesDGV.Rows.Clear();
            }
            foreach (DataGridViewRow row in salesDGV.SelectedRows)
            {
                salesDGV.Rows.Remove(row);
            }
            using (FileStream fsWriteToDelete = File.Open(StoreStaticVariables.pathToSalesDB, FileMode.Create, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                for (int i = 0; salesDGV.Rows.Count - 1 > i; i++)
                {
                    Byte[] theClient = new UTF8Encoding(true).GetBytes( salesDGV.Rows[i].Cells[0].Value + ";" +
                        salesDGV.Rows[i].Cells[1].Value + ";" + salesDGV.Rows[i].Cells[2].Value + ";" + salesDGV.Rows[i].Cells[3].Value + ";" +
                        salesDGV.Rows[i].Cells[4].Value + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                                // в базу данных.
                    fsWriteToDelete.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                }
                fsWriteToDelete.Close();
            }
        }

        private void onClickProductSalesTB(object sender, EventArgs e)
        {
            using (newAddCodeOfProduct = new AddCodeOfProduct(this))
            {
                newAddCodeOfProduct.ShowDialog();
            }
        }

        private void onClickClientSalesTB(object sender, EventArgs e)
        {
            using (newAddCodeOfClient = new AddCodeOfClient(this)) {
                newAddCodeOfClient.ShowDialog();
            }            
        }

        public string getCodeOfClientSalesTB() {
            return codeOfClientSalesTB.Text;
        }
        public void setCodeOfClientSalesTB(string text)
        {
            codeOfClientSalesTB.Text = text;
        }

        public string getCodeOfProductSalesTB()
        {
            return codeOfProductSalesTB.Text;
        }
        public void setCodeOfProductSalesTB(string text)
        {
            codeOfProductSalesTB.Text = text;
        }
        public void deleteEntriesById(string text, int index)
        {
            ArrayList idOfDeletingEntries = new ArrayList();
            foreach (DataGridViewRow row in salesDGV.Rows)
            {
                if ((row.Cells[index].Value != null) && (row.Cells[index].Value.ToString().Equals(text)))
                {
                    idOfDeletingEntries.Add(row);
                }
            }
            foreach (DataGridViewRow row in idOfDeletingEntries)
            {
                salesDGV.Rows.Remove(row);                                
            }
            using (FileStream fsWriteToDelete = File.Open(StoreStaticVariables.pathToSalesDB, FileMode.Create, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                for (int i = 0; salesDGV.Rows.Count - 1 > i; i++)
                {
                    Byte[] theClient = new UTF8Encoding(true).GetBytes(salesDGV.Rows[i].Cells[0].Value + ";" +
                        salesDGV.Rows[i].Cells[1].Value + ";" + salesDGV.Rows[i].Cells[2].Value + ";" + salesDGV.Rows[i].Cells[3].Value + ";" +
                        salesDGV.Rows[i].Cells[4].Value + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                      // в базу данных.
                    fsWriteToDelete.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                }
                fsWriteToDelete.Close();
            }
        }
        public void deleteEntriesByProductId(string text)
        {
            ArrayList idOfDeletingEntries = new ArrayList();
            foreach (DataGridViewRow row in salesDGV.Rows)
            {
                if ((row.Cells[2].Value != null) && (row.Cells[2].Value.ToString().Equals(text)))
                {
                    idOfDeletingEntries.Add(row);
                }
            }

        }

        private void ChgEntrySalesBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
