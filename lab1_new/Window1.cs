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
    public partial class Window1 : Form
    {
        bool correctInput = true;
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Load(object sender, EventArgs e)
        {

        }

        string key;
        string plainText;

        private void encrypt_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (correctInput)
            {
                string cipherText = Vigener.vigenerCipher(key, plainText);
                resultText.Text = cipherText;
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            keyInput.Text = "";
            textInput.Text = "";
            resultText.Text = "";
        }


        private void decrypt_Click(object sender, EventArgs e)
        {

            CheckInput();

            if (correctInput)
            {
                string cipherText = Vigener.vigenerDecipher(key, plainText);

                resultText.Text = cipherText;
            }
        }

        private void CheckInput()
        {
            correctInput = true;
            string input = keyInput.Text.ToUpper();

            string pattern = "[^А-ЯЁ]";
            key = Regex.Replace(input, pattern, "");


            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Ключ введён некорректно. Введите ключ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correctInput = false;
            }

            plainText = textInput.Text.ToUpper();

            plainText = Regex.Replace(plainText, pattern, "");

            if (string.IsNullOrWhiteSpace(plainText))
            {
                MessageBox.Show("Текст введён некорректно. Введите текст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correctInput = false;
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

        private void Save_Click(object sender, EventArgs e)
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
    }
}
