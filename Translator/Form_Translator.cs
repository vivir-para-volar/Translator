using System;
using System.IO;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form_Translator : Form
    {
        public Form_Translator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Позволяет пользователю выбрать си файл для открытия и копирует данные из него в TextBox
        /// </summary>
        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "C| *.c;.h* ";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();
                        textBox.Text = fileContent;
                    }
                }
            }
        }

        /// <summary>
        /// Разбивает текст из TextBox на массив строк и отправляет его на анализ
        /// </summary>
        private void btn_analysis_Click(object sender, EventArgs e)
        {
            if (textBox.Text != string.Empty)
            {
                string[] arrStr = textBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                LexicalAnalysis lexicalAnalysis = new LexicalAnalysis();
                lexicalAnalysis.AnalysisArray(arrStr);
                lexicalAnalysis.AddDataInDGV(dgvLexemes, dgvFunctionWord, dgvSeparator, dgvVariable, dgvLiteral);               
            }

            MessageBox.Show("Анализ готов", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
