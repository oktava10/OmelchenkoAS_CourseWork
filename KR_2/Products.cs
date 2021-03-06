﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KR_2
{
    public partial class Products : Form
    {
        int id_product = 0; // id элемента в базе данных и таблице "Товары"
        FSales fsValue;
        public Products(FSales fs)
        {
            InitializeComponent();
            fsValue = fs;
            using (StreamReader fsRead = new StreamReader(StoreStaticVariables.pathToProductDB)) // открываем нашу базу данных по товарам для чтения и записываем 
            {                                                                                   // все данные из нее в таблицу "Товары", выдергивая последний id 
                                                                                                // элемента в таблице.
                string productElement; // Элемент таблицы "Товары" в базе данных
                string[] tempArray; // Временный массив для разбиения строки, прочитанной из базы данных 
                while ((productElement = fsRead.ReadLine()) != null) // Цикл обработки читаемого файла с разбиением и записью в таблицу
                {
                    tempArray = productElement.Split(';'); // Разбить строку на элементы, разделитель ";"
                    productDataGridView.Rows.Add(tempArray[0], tempArray[1], tempArray[2]); // добавляем элементы в таблицу "Товары"
                    id_product = Convert.ToInt32(tempArray[0]); // вытаскиваем текущий ID элемента, а в последующем последний ID для его увеличения, конвертируя его
                }
                fsRead.Close();
            }
        }
        private void addNewProductBtn_Click(object sender, EventArgs e)
        {
            id_product++; // увеличиваем id на единицу
            productDataGridView.Rows.Add(id_product, nameOfProductTextBox.Text, priceOfProductTextBox.Text); // добавляем запись в таблицу "Кленты"
            using (FileStream fsWriteToAdd = 
                File.Open(StoreStaticVariables.pathToProductDB, FileMode.Append, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего добавления клиента.
            {                                                                                                                         
                Byte[] theClient = new UTF8Encoding(true).GetBytes(id_product + ";" + nameOfProductTextBox.Text + ";" +
                    priceOfProductTextBox.Text + ";" + Environment.NewLine); // Подготавливаем для записи в базу данных.
                fsWriteToAdd.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                fsWriteToAdd.Close();
            }
            nameOfProductTextBox.Clear();
            priceOfProductTextBox.Clear();  // чистим поля для ввода записей
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count == productDataGridView.Rows.Count)
            {
                foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                {
                    fsValue.deleteEntriesById(row.Cells[0].Value.ToString(), 3);
                }
                productDataGridView.Rows.Clear();
            }
            foreach (DataGridViewRow row in productDataGridView.SelectedRows)
            {
                productDataGridView.Rows.Remove(row);
                fsValue.deleteEntriesById(row.Cells[0].Value.ToString(), 3);
            }
            using (FileStream fsWriteToDelete = File.Open(StoreStaticVariables.pathToProductDB, FileMode.Create, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                for (int i = 0; productDataGridView.Rows.Count > i; i++)
                {
                    Byte[] theClient = new UTF8Encoding(true).GetBytes(productDataGridView.Rows[i].Cells[0].Value + ";" +
                        productDataGridView.Rows[i].Cells[1].Value + ";" + productDataGridView.Rows[i].Cells[2].Value + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                                // в базу данных.
                    fsWriteToDelete.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                }
                fsWriteToDelete.Close();
            }
        }

        private void entryChangeProductDGV(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (productDataGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                {
                    nameOfProductTextBox.Text = row.Cells[1].Value.ToString();
                    priceOfProductTextBox.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void changeProductBTN_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                {
                    row.Cells[1].Value = nameOfProductTextBox.Text;
                    row.Cells[2].Value = priceOfProductTextBox.Text;
                }
            }
            using (FileStream fsWriteToChange = File.Open(StoreStaticVariables.pathToProductDB, FileMode.Create, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                for (int i = 0; productDataGridView.Rows.Count > i; i++)
                {
                    Byte[] theClient = new UTF8Encoding(true).GetBytes(productDataGridView.Rows[i].Cells[0].Value + ";" +
                        productDataGridView.Rows[i].Cells[1].Value + ";" + productDataGridView.Rows[i].Cells[2].Value + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                                                                                    // в базу данных.
                    fsWriteToChange.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                }
                fsWriteToChange.Close();
            }
        }
    }
}
