using System;
using System.Drawing;
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
                    clearRichTextBox();

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();
                        richTextBoxCode.Text = fileContent;
                    }
                }
            }
        }

        /// <summary>
        /// Разбивает текст из TextBox на массив строк и отправляет его на анализ
        /// </summary>
        private void btn_analysis_Click(object sender, EventArgs e)
        {
            clearRichTextBox();

            if (richTextBoxCode.Text != string.Empty)
            {
                string[] arrStr = richTextBoxCode.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    LexicalAnalysis lexicalAnalysis = new LexicalAnalysis(richTextBoxResult);
                    lexicalAnalysis.AnalysisArray(arrStr);
                    lexicalAnalysis.AddDataInDGV(dgvLexemes, dgvFunctionWord, dgvSeparator, dgvVariable, dgvLiteral);

                    SyntaxAnalysis syntaxAnalysis = new SyntaxAnalysis();
                    syntaxAnalysis.Start(lexicalAnalysis.ListLexemes, lexicalAnalysis.FunctionWord, lexicalAnalysis.Separator, richTextBoxCode, richTextBoxResult);
                }
                catch (Exception exp)
                {
                    richTextBoxResult.Text += exp.Message + "\n";
                }
            }
        }

        /// <summary>
        /// Чистит все выделенные до этого ошибки в richTextBoxCode и чистит richTextBoxResult
        /// </summary>
        private void clearRichTextBox()
        {
            richTextBoxResult.Text = "";

            richTextBoxCode.SelectionStart = 0;
            richTextBoxCode.SelectionLength = richTextBoxCode.Text.Length + 1;
            richTextBoxCode.SelectionBackColor = Color.White;
        }
    }
}
