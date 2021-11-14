using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Translator
{
    class LexicalAnalysis
    {
        private List<char> buffer = new List<char>();

        private struct Lexeme
        {
            public string lexeme;
            public char type;

            public Lexeme(string lexeme, char type)
            {
                this.lexeme = lexeme;
                this.type = type;
            }
        }
        private List<string> listLexemes = new List<string>();

        private List<string> functionWord = new List<string> { "void", "main", "for", "int", "float", "double" };
        private List<string> separator = new List<string>() { "{", "}", "(", ")", ";", "=", "<", ">", "+", "-", "," };
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


        /// <summary>
        /// Отправляет каждую строку на анализ, обрабатывает ошибки
        /// </summary>
        /// <param name="arrStr">Массив строк текста</param>
        public void AnalysisArray(string[] arrStr)
        {
            try
            {
                foreach (var line in arrStr)
                {
                    AnalysisLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listLexemes.Clear();
            }
        }

        /// <summary>
        /// Анализирует каждую строку символов и разбивает её на лексемы
        /// </summary>
        /// <param name="str">Строка символов</param>
        private void AnalysisLine(string str)
        {
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

                    if ((i + 1) < str.Length && char.IsNumber(str[i + 1]))
                    {
                        i++;
                    }
                    else
                    {
                        AddLexeme("Литерал");
                        break;
                    }
                }

                //если прочитанный символ - буква
                if (char.IsLetter(str[i]))
                {
                    while (char.IsLetter(str[i]) || char.IsNumber(str[i]))
                    {
                        char temp = char.ToLower(str[i]);

                        if (Convert.ToInt32(temp) >= 97 && Convert.ToInt32(temp) <= 122)
                        {
                            buffer.Add(char.ToLower(str[i]));

                            if ((i + 1) < str.Length && (char.IsLetter(str[i + 1]) || char.IsNumber(str[i + 1])))
                            {
                                i++;
                            }
                            else
                            {
                                if (buffer.Count < 8)
                                {
                                    AddLexeme("Идентификатор");
                                }
                                else
                                {
                                    throw new Exception("Слишком большой идентификатор");
                                }
                                break;
                            }
                        }
                        else
                        {
                            throw new Exception("Можно использовать только латинский алфавит");
                        }
                    }

                }

                //если прочитанный символ - разделитель
                if (char.IsPunctuation(str[i]) || char.IsSymbol(str[i]))
                {
                    buffer.Add(str[i]);
                    AddLexeme("Разделитель");
                }
            }
        }

        /// <summary>
        /// Добавляет новую лексему в List<Lexeme>
        /// </summary>
        /// <param name="type">Тип лексемы</param>
        private void AddLexeme(string type)
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
                        listLexemes.Add("1," + functionWord.IndexOf(str));
                    }
                    else
                    {
                        if (!variable.Exists(x => x == str))
                        {
                            variable.Add(str);
                        }
                        listLexemes.Add("3," + variable.IndexOf(str));
                    }
                    break;

                case "Разделитель":
                    if (!separator.Exists(x => x == str))
                    {
                        throw new Exception("Разделитель не существует");
                    }
                    listLexemes.Add("2," + separator.IndexOf(str));
                    break;

                case "Литерал":
                    if (!literal.Exists(x => x == str))
                    {
                        literal.Add(str);
                    }
                    listLexemes.Add("4," + literal.IndexOf(str));
                    break;
            }
        }

        /// <summary>
        /// Записывает все данные в DataGridView
        /// </summary>
        /// <param name="dgvLexemes">Таблица стандартных символов</param>
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
                        dgvLexemes.Rows.Add(functionWord[number], "Идентификатор", "(" + item + ")");
                        break;
                    case 2:
                        dgvLexemes.Rows.Add(separator[number], "Разделитель", "(" + item + ")");
                        break;
                    case 3:
                        dgvLexemes.Rows.Add(variable[number], "Идентификатор", "(" + item + ")");
                        break;
                    case 4:
                        dgvLexemes.Rows.Add(literal[number], "Литерал", "(" + item + ")");
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
