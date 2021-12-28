using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Translator
{
    class LexicalAnalysis
    {
        public LexicalAnalysis(RichTextBox rtbCode, TextBox tbResult)
        {
            this.rtbCode = rtbCode;
            this.tbResult = tbResult;
        }
        private RichTextBox rtbCode;
        private TextBox tbResult;

        private List<char> buffer = new List<char>();

        private List<string> listLexemes = new List<string>();

        private List<string> functionWord = new List<string> { "void", "main", "for", "int", "float", "double" };
        private List<string> separator = new List<string>() { "{", "}", "(", ")", ";", ",", "=", "<", ">", "!", "+", "-", "*", "/" };
        private List<string> variable = new List<string>();
        private List<string> literal = new List<string>();

        public List<string> ListLexemes
        {
            get { return listLexemes; }
        }
        public List<string> FunctionWord
        {
            get { return functionWord; }
        }
        public List<string> Separator
        {
            get { return separator; }
        }
        public List<string> Variable
        {
            get { return variable; }
        }
        public List<string> Literal
        {
            get { return literal; }
        }

        private int currentLine = 0;

        /// <summary>
        /// Отправляет каждую строку на анализ, обрабатывает ошибки
        /// </summary>
        /// <param name="arrStr">Массив строк текста</param>
        public void AnalysisArray(string[] arrStr)
        {
            try
            {
                for (int i = 0; i < arrStr.Length; i++)
                {
                    AnalysisLine(arrStr[i], i);
                }
                tbResult.Text += "Лексический анализ успешно завершён\r\n";
            }
            catch (Exception exp)
            {
                listLexemes.Clear();

                string[] lines = rtbCode.Lines;

                int index = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == currentLine)
                    {
                        rtbCode.SelectionStart = index;
                        rtbCode.SelectionLength = lines[i].Length + 1;
                        rtbCode.SelectionBackColor = Color.FromArgb(235, 76, 66);
                        break;
                    }
                    index += lines[i].Length + 1;
                }

                tbResult.Text += "Лексический анализ: " + exp.Message + "\r\n";
                throw new Exception();
            }
        }

        /// <summary>
        /// Анализирует каждую строку символов и разбивает её на лексемы
        /// </summary>
        /// <param name="str">Строка символов</param>
        /// <param name="line">Номер строки</param>
        private void AnalysisLine(string str, int line)
        {
            currentLine = line;

            //считываем посимвольно
            for (var i = 0; i < str.Length; i++)
            {
                //если прочитанный символ - пробел
                if (char.IsWhiteSpace(str[i]))
                {
                    continue;
                }

                //если прочитанный символ - начало комментария
                if (Convert.ToInt32(str[i]) == 47 && Convert.ToInt32(str[i + 1]) == 47)
                {
                    break;
                }

                //если прочитанный символ - цифра
                while (char.IsDigit(str[i]))
                {
                    buffer.Add(str[i]);

                    if ((i + 1) < str.Length && char.IsDigit(str[i + 1]))
                    {
                        i++;
                    }
                    else if ((i + 1) < str.Length && str[i + 1] == '.')
                    {
                        if (buffer.Contains('.')) throw new Exception("Неправильно введённое дробное число");

                        i++;
                        buffer.Add(str[i]);

                        if ((i + 1) < str.Length && char.IsNumber(str[i + 1]))
                        {
                            i++;
                        }
                        else throw new Exception("Неправильно введённое дробное число");
                    }
                    else 
                    {
                        AddLexeme("Литерал", line);
                        break;
                    }
                }

                //если прочитанный символ - буква
                if (char.IsLetter(str[i]))
                {
                    while (char.IsLetter(str[i]) || char.IsNumber(str[i]))
                    {
                        char temp = char.ToLower(str[i]);

                        if (char.IsLetter(temp) && (Convert.ToInt32(temp) < 97 || Convert.ToInt32(temp) > 122))
                        {
                            throw new Exception("Можно использовать только латинский алфавит");
                        }

                        buffer.Add(temp);

                        if ((i + 1) < str.Length && (char.IsLetter(str[i + 1]) || char.IsNumber(str[i + 1])))
                        {
                            i++;
                        }
                        else
                        {
                            if (buffer.Count <= 8)
                            {
                                AddLexeme("Идентификатор", line);
                            }
                            else
                            {
                                throw new Exception("Слишком большой идентификатор");
                            }
                            break;
                        }
                    }

                }

                //если прочитанный символ - разделитель
                if (char.IsPunctuation(str[i]) || char.IsSymbol(str[i]))
                {
                    if (separator.Contains(str[i].ToString()))
                    {
                        buffer.Add(str[i]);
                        AddLexeme("Разделитель", line);
                    }
                    else throw new Exception("Некорректный знак");
                }
            }
        }

        /// <summary>
        /// Добавляет новую лексему в List<Lexeme>
        /// </summary>
        /// <param name="type">Тип лексемы</param>
        /// <param name="line">Номер строки, в которой расположена лексема</param>
        private void AddLexeme(string type, int line)
        {
            string str = "";
            foreach (var item in buffer)
            {
                str += item;
            }
            buffer.Clear();

            switch (type)
            {
                case "Идентификатор":
                    if (functionWord.Exists(x => x == str))
                    {
                        listLexemes.Add("1," + functionWord.IndexOf(str) + ',' + line);
                    }
                    else
                    {
                        if (!variable.Exists(x => x == str))
                        {
                            variable.Add(str);
                        }
                        listLexemes.Add("3," + variable.IndexOf(str) + ',' + line);
                    }
                    break;

                case "Разделитель":
                    if (!separator.Exists(x => x == str))
                    {
                        throw new Exception("Разделитель не существует");
                    }
                    listLexemes.Add("2," + separator.IndexOf(str) + ',' + line);
                    break;

                case "Литерал":
                    if (!literal.Exists(x => x == str))
                    {
                        literal.Add(str);
                    }
                    listLexemes.Add("4," + literal.IndexOf(str) + ',' + line);
                    break;
            }
        }

        /// <summary>
        /// Записывает все данные в DataGridView
        /// </summary>
        /// <param name="dgvLexemes">Таблица лексем</param>
        /// <param name="dgvFunctionWord">Таблица служебных слов</param>
        /// <param name="dgvSeparator">Таблица разделителей</param>
        /// <param name="dgvVariable">Таблица переменных</param>
        /// <param name="dgvLiteral">Таблица литералов</param>
        public void AddDataInDGV(DataGridView dgvLexemes, DataGridView dgvFunctionWord, DataGridView dgvSeparator, DataGridView dgvVariable, DataGridView dgvLiteral)
        {
            dgvLexemes.Rows.Clear();
            dgvFunctionWord.Rows.Clear();
            dgvSeparator.Rows.Clear();
            dgvVariable.Rows.Clear();
            dgvLiteral.Rows.Clear();

            foreach (var item in listLexemes)
            {
                string[] str = item.Split(',');
                int table = Convert.ToInt32(str[0]), number = Convert.ToInt32(str[1]);

                switch (table)
                {
                    case 1:
                        dgvLexemes.Rows.Add(functionWord[number], "Идентификатор", "(" + table + "," + number + ")");
                        break;
                    case 2:
                        dgvLexemes.Rows.Add(separator[number], "Разделитель", "(" + table + "," + number + ")");
                        break;
                    case 3:
                        dgvLexemes.Rows.Add(variable[number], "Идентификатор", "(" + table + "," + number + ")");
                        break;
                    case 4:
                        dgvLexemes.Rows.Add(literal[number], "Литерал", "(" + table + "," + number + ")");
                        break;
                }
            }

            AdditionalDGV(functionWord, dgvFunctionWord);
            AdditionalDGV(separator, dgvSeparator);
            AdditionalDGV(variable, dgvVariable);
            AdditionalDGV(literal, dgvLiteral);
        }

        /// <summary>
        /// Заполнение вспомогательных таблиц DataGridView
        /// </summary>
        /// <param name="list">Данные для добавления</param>
        /// <param name="dgv">В какую таблицу DataGridView добавлять</param>
        private void AdditionalDGV(List<string> list, DataGridView dgv)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dgv.Rows.Add(i, list[i]);
            }
        }
    }
}
