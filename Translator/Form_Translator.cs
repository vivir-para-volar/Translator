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
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "C| *.c;.h* ";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clear();

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();
                        rtbCode.Text = fileContent;
                    }
                }
            }
        }

        /// <summary>
        /// Разбивает текст из rtbCode на массив строк и отправляет его на анализ
        /// </summary>
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            clear();

            rtbCodeRepeat.Text = rtbCode.Text;

            if (rtbCode.Text != string.Empty)
            {
                try
                {
                    string[] arrStr = rtbCode.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    LexicalAnalysis lexicalAnalysis = new LexicalAnalysis(rtbCode, tbResult);
                    lexicalAnalysis.AnalysisArray(arrStr);
                    lexicalAnalysis.AddDataInDGV(dgvLexemes, dgvFunctionWord, dgvSeparator, dgvVariable, dgvLiteral);

                    SyntaxAnalysis syntaxAnalysis = new SyntaxAnalysis();
                    syntaxAnalysis.Start(lexicalAnalysis.ListLexemes, lexicalAnalysis.FunctionWord, lexicalAnalysis.Separator, lexicalAnalysis.Variable, lexicalAnalysis.Literal, rtbCode, tbResult, tbDijkstra);

                }
                catch { }
            }
        }

        /// <summary>
        /// Чистит rtbCodeRepeat, tbResult, tbDijkstra, все DataGridView и все выделения ошибок в rtbCode
        /// </summary>
        private void clear()
        {
            tbResult.Text = "";
            tbDijkstra.Text = "";
            rtbCodeRepeat.Text = "";

            dgvLexemes.Rows.Clear(); dgvFunctionWord.Rows.Clear(); dgvSeparator.Rows.Clear(); dgvVariable.Rows.Clear(); dgvLiteral.Rows.Clear();

            rtbCode.SelectionStart = 0;
            rtbCode.SelectionLength = rtbCode.Text.Length + 1;
            rtbCode.SelectionBackColor = Color.White;
        }

        /// <summary>
        /// Чистит все TextBox и все DataGridView
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            rtbCode.Text = "";
        }
    }
}
