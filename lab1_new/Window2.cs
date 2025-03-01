using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_new
{
    public partial class Window2 : Form
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Window2_Load(object sender, EventArgs e)
        {

        }
        string key;
        string plainText;
        string key1;
        string key2;
        string key3;
        string key4;
        bool correctInput = true;
        List<char[,]> keyList = new List<char[,]>();
        private void Input()
        {

            //  List<char> keyList = new List<char>;
            key1 = keyInput1.Text;
            key1 = CheckInputKey(key1);
            key2 = keyInput2.Text;
            key2 = CheckInputKey(key2);
            key3 = keyInput3.Text;
            key3 = CheckInputKey(key3);
            key4 = keyInput4.Text;
            key4 = CheckInputKey(key4);

            if (correctInput)
            {
                keyList = Playfer.initKeys(key1, key2, key3, key4);


                displayMatrix(keyList[0], m1);
                displayMatrix(keyList[1], m2);
                displayMatrix(keyList[2], m3);
                displayMatrix(keyList[3], m4);
                SetupDataGridViews(m1, m2, m3, m4);

                plainText = textInput.Text;
                plainText = CheckInputText(plainText);
            }


        }
        private void encrypt_Click(object sender, EventArgs e)
        {
            ClearDataGrids();
            Input();
            if (correctInput)
            {
                resultText.Text = Playfer.playferCipher(keyList, plainText, Playfer.alphabetString);
            }

        }

        private void displayMatrix(char[,] matrix, DataGridView table)
        {
            int columnCount = matrix.GetLength(1);
            table.ColumnCount = columnCount;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[columnCount];

                for (int j = 0; j < columnCount; j++)
                {
                    row[j] = matrix[i, j].ToString();
                }
                table.Rows.Add(row);
            }
        }
        private void SetupDataGridViews(params DataGridView[] tables)
        {
            foreach (var table in tables)
            {
                foreach (DataGridViewColumn column in table.Columns)
                {
                    column.Width = 30; // Установка ширины столбцов
                }
                table.RowTemplate.Height = 30; // Высота строк
                foreach (DataGridViewColumn column in table.Columns)
                {
                    column.Resizable = DataGridViewTriState.False;
                }

            }

        }
        private void clean_Click(object sender, EventArgs e)
        {
            keyInput1.Text = "";
            keyInput2.Text = "";
            keyInput3.Text = "";
            keyInput4.Text = "";
            textInput.Text = "";
            resultText.Text = "";
        }

        string pattern = "[^A-Z]";
        private string CheckInputKey(string input)
        {
            correctInput = true;
            input = input.ToUpper();
            key = Regex.Replace(input, pattern, "");
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Ключ введён некорректно. Введите ключ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correctInput = false;
            }
            return key;
        }

        private string CheckInputText(string plainText)
        {
            correctInput = true;

            plainText = plainText.ToUpper();

            plainText = Regex.Replace(plainText, pattern, "");

            if (string.IsNullOrWhiteSpace(plainText))
            {
                MessageBox.Show("Текст введён некорректно. Введите текст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correctInput = false;
            }
            return plainText;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            ClearDataGrids();
            Input();
            plainText = textInput.Text;
            plainText = CheckInputText(plainText);
            if (correctInput)
            {
                resultText.Text = Playfer.playferDecipher(keyList, plainText, Playfer.alphabetString);
            }

        }

        private void fileChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Text files (*.txt)|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получить путь к выбранному файлу
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                textInput.Text = fileContent;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(resultText.Text);
                }

            }
        }
        private void ClearDataGrids()
        {
            ClearDataGrid(m1);
            ClearDataGrid(m2);
            ClearDataGrid(m3);
            ClearDataGrid(m4);
        }

        private void ClearDataGrid(DataGridView table)
        {
            table.Rows.Clear();
            table.Columns.Clear();
        }
    }
}
