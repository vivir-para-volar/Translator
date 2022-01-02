using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Translator
{
    public class SyntaxAnalysis
    {
        private List<string> listLexemes;

        private int currentIndex = -1;
        private int currentLine = 0;
        private int prevLine = 0;

        private string lexeme;
        private string inTable;

        private List<string> functionWord;
        private List<string> separator;
        private List<string> variable;
        private List<string> literal;

        TextBox tbDijkstra;

        /// <summary>
        /// Запускает синтаксический анализ
        /// </summary>
        public void Start(List<string> listLexemes, List<string> functionWord, List<string> separator, List<string> variable, List<string> literal, RichTextBox rtbCode, TextBox tbResult, TextBox tbDijkstra)
        {
            this.listLexemes = listLexemes;

            this.functionWord = functionWord;
            this.separator = separator;
            this.variable = variable;
            this.literal = literal;

            this.tbDijkstra = tbDijkstra;

            try
            {
                if (Program())
                {
                    tbResult.Text += "Синтаксический анализ успешно завершён\r\n";
                }
            }
            catch (Exception exp)
            {
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

                tbResult.Text += "Синтаксический анализ: " + exp.Message + "\r\n";
                throw new Exception();
            }
        }

        //Следующая лексема
        private void Next()
        {
            prevLine = currentLine;
            currentIndex++;

            if(currentIndex >= listLexemes.Count)
            {
                lexeme = " ";
                return;
            }

            string[] str = listLexemes[currentIndex].Split(',');
            int table = Convert.ToInt32(str[0]), number = Convert.ToInt32(str[1]);
            currentLine = Convert.ToInt32(str[2]);

            switch (table)
            {
                case 1:
                    lexeme = functionWord[number];
                    break;
                case 2:
                    lexeme = separator[number];
                    break;
                case 3:
                    lexeme = "id";
                    inTable = variable[number];
                    break;
                case 4:
                    lexeme = "lit";
                    inTable = literal[number];
                    break;
            }
        }

        // Программа
        private bool Program()
        {
            Next();
            if (lexeme != "void") throw new Exception("Ожидался void"); 
            Next();
            if (lexeme != "main") throw new Exception("Ожидался main"); 
            Next();
            if (lexeme != "(") throw new Exception("Ожидалась ("); 
            Next();
            if (lexeme != ")") throw new Exception("Ожидалась )"); 
            Next();
            if (lexeme != "{") throw new Exception("Ожидалась {"); 
            Next();
            ListOfOperators();
            if (lexeme != "}") throw new Exception("Ожидалась }");
            if (currentIndex != listLexemes.Count - 1) throw new Exception("В конце программы лишний символ");
            return true;
        }

        // Список операторов
        private void ListOfOperators()
        {
            Operator();
            Next();
            AdditionalListOfOperators();
        }

        // Доп. список операторов
        private void AdditionalListOfOperators()
        {
            if (lexeme == "int" || lexeme == "float" || lexeme == "double" || lexeme == "id" || lexeme == "lit" || lexeme == "for")
            {
                ListOfOperators();
            }
        }

        // Оператор
        private void Operator()
        {
            if (lexeme == "int" || lexeme == "float" || lexeme == "double")
            {
                Declaration();
                Next();
                if (lexeme != ";")
                {
                    currentLine = prevLine;
                    throw new Exception("Ожидалаcь ;");
                }
            }
            else if (lexeme == "id")
            {
                Assignment();
                Next();
                if (lexeme != ";")
                {
                    currentLine = prevLine;
                    throw new Exception("Ожидалаcь ;");
                }
            }
            else if (lexeme == "for") Cycle();
            else throw new Exception("Ожидалcя оператор");
        }

        // Объявление
        private void Declaration()
        {
            Type();
            Next();
            ListOfVariables();
            currentIndex--;
        }

        // Присваивание
        private void Assignment()
        {
            if (lexeme != "id") throw new Exception("Ожидалась переменная");
            Next();
            if (lexeme != "=") throw new Exception("Ожидалоcь =");
            Next();

            //!!!!!!!!!!!!!!!!!!!!!!!!!
            //expr
            //!!!!!!!!!!!!!!!!!!!!!!!!!
            List<string> list = new List<string>();
            while (lexeme != ";" && lexeme != "," && lexeme != "}")
            {
                string temp = lexeme + "," + inTable;
                list.Add(temp);
                Next();
            }
            if (!Dijkstra(list)) throw new Exception("Произошла ошибка при разборе выражения");
            currentIndex--;
        }

        // Цикл
        private void Cycle()
        {
            if (lexeme != "for") throw new Exception("Ожидалcя for"); 
            Next();
            if (lexeme != "(") throw new Exception("Ожидалась ("); 
            Next();
            CycleDescription();
            Next();
            if (lexeme != ")")
            {
                currentLine = prevLine;
                throw new Exception("Ожидалась )");
            }
            Next();
            CycleBody();
        }

        // Тип
        private void Type()
        {
            if (lexeme != "int" && lexeme != "float" && lexeme != "double")
            {
                throw new Exception("Ожидался тип переменной");
            }
        }

        // Список переменных
        private void ListOfVariables()
        {
            if (lexeme != "id")
            {
                currentLine = prevLine;
                throw new Exception("Ожидалась переменная");
            }
            Next();
            if (lexeme == ";" || lexeme == ",") AdditionalListOfVariables();
            else if (lexeme == "=")
            {
                currentIndex--;
                lexeme = "id";
                Assignment();
                Next();
                AdditionalListOfVariables();
            }
            else
            {
                currentLine = prevLine;
                throw new Exception("Ожидалась ; или ,(дополнительная переменная) или присваивание");
            }
        }

        // Доп. список переменных
        private void AdditionalListOfVariables()
        {
            if (lexeme == ",")
            {
                Next();
                ListOfVariables();
            }
            else if (lexeme != ";")
            {
                currentLine = prevLine;
                throw new Exception("Ожидалась ; или ,(дополнительная переменная) или присваивание");
            }
        }

        // Описание цикла
        private void CycleDescription()
        {
            Initialization();
            Next();
            if (lexeme != ";")
            {
                currentLine = prevLine;
                throw new Exception("Ожидалаcь ;");
            }
            Next();
            Condition();
            Next();
            if (lexeme != ";")
            {
                currentLine = prevLine;
                throw new Exception("Ожидалаcь ;");
            }
            Next();
            Modification();
        }

        // Тело цикла
        private void CycleBody()
        {
            if (lexeme == "{")
            {
                Next();
                ListOfOperators();
                if (lexeme != "}")
                {
                    currentLine = prevLine;
                    throw new Exception("Ожидалаcь }");
                }
            }
            else if (lexeme == "int" || lexeme == "float" || lexeme == "double" || lexeme == "id" || lexeme == "for")
            {
                Operator();
            }
        }

        // Инициализация
        private void Initialization()
        {
            if (lexeme == "int" || lexeme == "float" || lexeme == "double")
            {
                Declaration();
            }
            else if (lexeme == "id")
            {
                Assignment();
            }
            else if (lexeme == ";") currentIndex--;
            else if (lexeme != ";") throw new Exception("Ожидалась инициализация цикла");
        }

        // Условие
        private void Condition()
        {
            if (lexeme == "lit" || lexeme == "id")
            {
                Operand();
                Next();
                LogicalSign();
                Next();
                Operand();
            }
            else if (lexeme == ";") currentIndex--;
            else if (lexeme != ";") throw new Exception("Ожидалось условие цикла");
        }

        // Модификация
        private void Modification()
        {
            if (lexeme == "id")
            {
                Next();
                if (lexeme == "+" || lexeme == "-") DoubleSign();
                else if (lexeme == "=")
                {
                    Next();
                    if (lexeme != "lit" && lexeme != "id") throw new Exception("Ожидалось число или переменная");
                    Next();

                    if (lexeme == ")") currentIndex--;
                    else
                    {
                        ArithmeticSign();
                        Next();
                        if (lexeme != "lit" && lexeme != "id") throw new Exception("Ожидалось число или переменная");
                    }
                }
            }
            else if (lexeme == "+" || lexeme == "-")
            {
                DoubleSign();
                Next();
                if (lexeme != "id") throw new Exception("Ожидалась переменная");
            }
            else if (lexeme == ")") currentIndex--;
            else if (lexeme != ")") throw new Exception("Ожидалась модификация цикла");
        }

        // Арифметический знак
        private void ArithmeticSign()
        {
            if (lexeme != "+" && lexeme != "-" && lexeme != "*" && lexeme != "/") throw new Exception("Некорректный знак");
        }

        // Операнд
        private void Operand()
        {
            if (lexeme != "lit" && lexeme != "id") throw new Exception("Ожидалось число или переменная");
        }

        // Логический знак
        private void LogicalSign()
        {
            if (lexeme == "<" || lexeme == ">")
            {
                Next();
                AdditionalSign();
            }
            else if (lexeme == "=" || lexeme == "!")
            {
                Next();
                if (lexeme != "=") throw new Exception("Ожидалось =");
            }
            else throw new Exception("Некорректный знак");
        }

        // Доп. знак
        private void AdditionalSign()
        {
            if (lexeme != "=" && lexeme != "lit" && lexeme != "id") throw new Exception("Ожидалось число или переменная");
            if (lexeme == "lit" || lexeme == "id") currentIndex--;
        }

        // Двойной знак
        private void DoubleSign()
        {
            if(lexeme == "+")
            {
                Next();
                if (lexeme != "+") throw new Exception("Ожидался ++");
            }
            else if (lexeme == "-")
            {
                Next();
                if (lexeme != "-") throw new Exception("Ожидался --");
            }
            else throw new Exception("Ожидался ++ или --");
        }




        /// <summary>
        /// Метод Дейкстры
        /// </summary>
        private bool Dijkstra(List<string> list)
        {
            //переводим в ОПН
            list = RPN(list);

            int count = 0;
            Stack<string> stack = new Stack<string>();

            {
                string[] str = list[0].Split(',');
                string itemLexeme = str[0];
                string itemInTable = "";
                if (str.Length > 1) itemInTable = str[1];
                if (list.Count == 1 && (itemLexeme == "id" || itemLexeme == "lit"))
                {
                    return true;
                }
            }

            foreach (var item in list)
            {
                string[] str = item.Split(',');
                string itemLexeme = str[0];

                //если символ - число или операнд, добавляем его в стек
                if (itemLexeme == "id" || itemLexeme == "lit")
                {
                    stack.Push(item);
                    continue;
                }
                //если символ - операция
                else
                {
                    if (stack.Count < 2) throw new Exception("Не хватает переменной");

                    string element1 = stack.Pop();
                    string[] strTemp = element1.Split(',');
                    string itemInTable1 = "";
                    if (strTemp.Length > 1) itemInTable1 = strTemp[1];
                    else itemInTable1 = strTemp[0];

                    string element2 = stack.Pop();
                    strTemp = element2.Split(',');
                    string itemInTable2 = "";
                    if (strTemp.Length > 1) itemInTable2 = strTemp[1];
                    else itemInTable2 = strTemp[0];

                    string temp = "M" + ++count;
                    stack.Push(temp);
                    tbDijkstra.Text += temp + ": " + item + " " + itemInTable1 + " " + itemInTable2 + "\r\n";
                }
            }
            tbDijkstra.Text += "\r\n";

            if (stack.Count == 1) return true;
            else throw new Exception("Не хватает знака");
        }

        /// <summary>
        /// Перевод в обратную польскую нотацию (ОПН) - Reverse Polish notation (RPN)
        /// </summary>
        private List<string> RPN(List<string> list)
        {
            List<string> list_result = new List<string>();
            Stack<string> stack = new Stack<string>();

            if (IsOperation(list[0]) || IsOperation(list[list.Count - 1])) throw new Exception("Не хватает переменной");

            int count = 0;
            foreach (var item in list)
            {
                string[] str = item.Split(',');
                string itemLexeme = str[0];

                //если символ - число или операнд, добавляем его в список-результат
                if (itemLexeme == "id" || itemLexeme == "lit")
                {
                    list_result.Add(item);
                    continue;
                }

                //если символ - операция
                if (IsOperation(itemLexeme))
                {
                    //если это первая операция, кладем ее в стек, и переходим к следующему символу
                    if (stack.Count == 0)
                    {
                        stack.Push(itemLexeme);
                        continue;
                    }

                    //если это не первая операция, то сравниваем ее с последней операцией, хранящейся в стеке
                    //если приоритет текущей операции больше приоритета последней, хранящейся в стеке, то кладем ее в стек
                    if (GetOperationPriority(stack.Peek()) < GetOperationPriority(itemLexeme))
                    {
                        stack.Push(itemLexeme);
                        continue;
                    }
                    // иначе, выталкиваем последнюю операцию, а текущую сохраняем в стек
                    else
                    {
                        list_result.Add(stack.Pop());
                        stack.Push(itemLexeme);
                        continue;
                    }
                }

                //если символ - (, кладем его в стек
                if (itemLexeme == "(")
                {
                    stack.Push(itemLexeme);
                    count++;
                    continue;
                }

                //если текущий символ - ), то забираем из стека все операции в список-результат, пока не встретим знак (
                if (itemLexeme == ")")
                {
                    count--;
                    while (stack.Count != 0 && stack.Peek() != "(")
                    {
                        list_result.Add(stack.Pop());
                    }
                    if(stack.Count != 0) stack.Pop();
                    else throw new Exception("Лишняя закрывающаяся скобка");
                    continue;
                }

                throw new Exception("Некорректный знак");
            }

            if (count != 0) throw new Exception("Не хватает закрывающейся скобки");

            //после проверки всей строки, забираем из стека оставшиеся операции
            while (stack.Count != 0)
            {
                list_result.Add(stack.Pop());
            }

            return list_result;
        }

        /// <summary>
        /// Определяет является ли лексема операцией
        /// </summary>
        private static bool IsOperation(string item)
        {
            if (item == "+" || item == "-" || item == "*" || item == "/") return true;
            return false;
        }

        /// <summary>
        /// Определяет приоритет операции
        /// </summary>
        private static int GetOperationPriority(string sign)
        {
            switch (sign)
            {
                case "+": return 1;
                case "-": return 1;
                case "*": return 2;
                case "/": return 2;
                default: return 0;
            }
        }
    }
}
