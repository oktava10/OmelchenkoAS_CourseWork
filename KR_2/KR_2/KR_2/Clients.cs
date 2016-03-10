using System;
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
        public Clients()
        {
            InitializeComponent();            
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
            using (FileStream fs = File.Open(StoreStaticVariables.pathToClientDB, FileMode.Append, FileAccess.Write, FileShare.None)) // Поток записи в файл текущего 
            {                                                                                                                         // добавления клиента.
                Byte[] theClient = new UTF8Encoding(true).GetBytes(id_client + ";" + addNewClientTextBox.Text + ";" + Environment.NewLine); // Подготавливаем для записи 
                                                                                                                                            // в базу данных.
                fs.Write(theClient, 0, theClient.Length); // записываем данные в базу данных
            }
            addNewClientTextBox.Clear(); // чистим поле для ввода записи 
        }

        private void removeClient_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count == clientDataGridView.Rows.Count) {
                clientDataGridView.Rows.Clear();
            }
            foreach (DataGridViewRow row in clientDataGridView.SelectedRows) {
                clientDataGridView.Rows.Remove(row);
            }

        }
    }
}
