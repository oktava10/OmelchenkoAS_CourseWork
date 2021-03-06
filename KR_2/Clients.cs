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
    
    public partial class Clients : Form
    {
        int id_client = 0; // id элемента в базе данных и таблице "Клиенты"
        FSales fsValue;
        public Clients(FSales fs)
        {
            InitializeComponent();
            fsValue = fs;
            using (StreamReader fsRead = new StreamReader(StoreStaticVariables.pathToClientDB)) // открываем нашу базу данных по клиентам для чтения и записываем 
            {                                                                                   // все данные из нее в таблицу "Клиенты", выдергивая последний id 
                                                                                                // элемента в таблице.
                string clientElement; // Элемент таблицы "Клиенты" в базе данных
                string[] tempArray; // Временный массив для разбиения строки, прочитанной из базы данных                 
                while ((clientElement = fsRead.ReadLine()) != null) // Цикл обработки читаемого файла с разбиением и записью в таблицу
                {                   
                    tempArray = clientElement.Split(';'); // Разбить строку на элементы, разделитель ";"
                    clientDataGridView.Rows.Add(tempArray[0], tempArray[1]); // добавляем элементы в таблицу "Клиенты"
                    id_client = Convert.ToInt32(tempArray[0]); // вытаскиваем текущий ID элемента, а в последующем последний ID для его увеличения, конвертируя его
                }                
            }
        }       
        private void addClient_Click(object sender, EventArgs e)
        {         
            id_client++; // увеличиваем id на единицу
            clientDataGridView.Rows.Add(id_client, addNewClientTextBox.Text); // добавляем запись в таблицу "Кленты"
            using (FileStream fsWriteToAdd = File.Open(StoreStaticVariables.pathToClientDB, FileMode.Append, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                Byte[] theClient = new UTF8Encoding(true).GetBytes(id_client + ";" + addNewClientTextBox.Text + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                                                                            // в базу данных.
                fsWriteToAdd.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                fsWriteToAdd.Close(); // Закрыли файл 
            }
            addNewClientTextBox.Clear(); // чистим поле для ввода записи             
        }

        private void removeClient_Click(object sender, EventArgs e)
        {        
            if (clientDataGridView.SelectedRows.Count == clientDataGridView.Rows.Count) {                
                foreach (DataGridViewRow row in clientDataGridView.SelectedRows)
                {
                    fsValue.deleteEntriesById(row.Cells[0].Value.ToString(), 2);
                }
                clientDataGridView.Rows.Clear();
            }
            foreach (DataGridViewRow row in clientDataGridView.SelectedRows) {
                clientDataGridView.Rows.Remove(row);
                fsValue.deleteEntriesById(row.Cells[0].Value.ToString(), 2);
            }
            using (FileStream fsWriteToDelete = File.Open(StoreStaticVariables.pathToClientDB, FileMode.Create, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                for (int i = 0; clientDataGridView.Rows.Count > i; i++) {
                    Byte[] theClient = new UTF8Encoding(true).GetBytes(clientDataGridView.Rows[i].Cells[0].Value + ";" + 
                        clientDataGridView.Rows[i].Cells[1].Value + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                          // в базу данных.
                    fsWriteToDelete.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                }
                fsWriteToDelete.Close();
            }
            
        }

        private void ChgEntryClientBTN_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in clientDataGridView.SelectedRows)
                {
                    row.Cells[1].Value = addNewClientTextBox.Text;                    
                }
            }
            using (FileStream fsWriteToChange = File.Open(StoreStaticVariables.pathToClientDB, FileMode.Create, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                for (int i = 0; clientDataGridView.Rows.Count > i; i++)
                {
                    Byte[] theClient = new UTF8Encoding(true).GetBytes(clientDataGridView.Rows[i].Cells[0].Value + ";" +
                        clientDataGridView.Rows[i].Cells[1].Value + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                                // в базу данных.
                    fsWriteToChange.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
                }
                fsWriteToChange.Close();
            }
        }

        private void entryChangeClientDGV(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in clientDataGridView.SelectedRows)
                {
                    addNewClientTextBox.Text = row.Cells[1].Value.ToString();                    
                }
            }
        }
    }
}
