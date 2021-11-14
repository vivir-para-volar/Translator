using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Translator
{
    public class SyntaxAnalysis
    {
        private List<string> listLexemes;
        int currentIndex = -1;

        private string lexeme;

        private List<string> functionWord;
        private List<string> separator;
        private List<string> variable;
        private List<string> literal;

        public void Start(List<string> listLexemes, List<string> functionWord, List<string> separator, List<string> variable, List<string> literal)
        {
            this.listLexemes = listLexemes;

            this.functionWord = functionWord;
            this.separator = separator;
            this.variable = variable;
            this.literal = literal;

            try
            {
                if (Program())
                {
                    MessageBox.Show("Синтаксический анализ успешно завершён", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next()
        {
            currentIndex++;

            string[] str = listLexemes[currentIndex].Split(',');
            int table = Convert.ToInt32(str[0]), number = Convert.ToInt32(str[1]);

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
                    break;
                case 4:
                    lexeme = "lit";
                    break;
            }
        }

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
            Next();
            if (lexeme != "}") throw new Exception("Ожидалась }"); 
            return true;
        }

        private void ListOfOperators()
        {
            Operator();
            Next();
            AdditionalListOfOperators();
        }

        private void AdditionalListOfOperators()
        {
            if (lexeme == "int" || lexeme == "float" || lexeme == "double" || lexeme == "id" || lexeme == "lit" || lexeme == "for")
            {
                ListOfOperators();
            }
            else if (lexeme != "}" && lexeme != ";") throw new Exception("Ожидался оператор");
            else if (lexeme == "}") currentIndex--;
        }

        private void Operator()
        {
            if (lexeme == "int" || lexeme == "float" || lexeme == "double")
            {
                Declaration();
                Next();
                if (lexeme != ";") throw new Exception("Ожидалаcь ;");
            }
            else if (lexeme == "id")
            {
                Assignment();
                Next();
                if (lexeme != ";") throw new Exception("Ожидалаcь ;");
            }
            else if (lexeme == "for") Cycle();
            else throw new Exception("Ожидалcя оператор");
        }

        private void Declaration()
        {
            Type();
            Next();
            ListOfVariables();
            currentIndex--;
        }

        private void Assignment()
        {
            if (lexeme != "id") throw new Exception("Ожидалась переменная");
            Next();
            if (lexeme != "=") throw new Exception("Ожидалоcь =");
            Next();

            //!!!!!!!!!!!!!!!!!!!!!!!!!
            //expr
            //!!!!!!!!!!!!!!!!!!!!!!!!!
            while (lexeme != ";" && lexeme != "," && lexeme != ")")
            {
                Next();
            }
            currentIndex--;
        }

        private void Cycle()
        {
            if (lexeme != "for") throw new Exception("Ожидалcя for"); 
            Next();
            if (lexeme != "(") throw new Exception("Ожидалась ("); 
            Next();
            CycleDescription();
            Next();
            if (lexeme != ")") throw new Exception("Ожидалась )"); 
            Next();
            CycleBody();
        }

        private void Type()
        {
            if (lexeme != "int" && lexeme != "float" && lexeme != "double")
            {
                throw new Exception("Ожидался тип переменной");
            }
        }

        private void ListOfVariables()
        {
            if (lexeme != "id") throw new Exception("Ожидалась переменная");
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
            else throw new Exception("Ожидалась ; или ,(дополнительная переменная) или присваивание");
        }

        private void AdditionalListOfVariables()
        {
            if(lexeme == ",")
            {
                Next();
                ListOfVariables();
            }
            else if(lexeme != ";") throw new Exception("Ожидалась ; или ,(дополнительная переменная)");
        }

        private void CycleDescription()
        {
            Initialization();
            Next();
            if (lexeme != ";") throw new Exception("Ожидалаcь ;"); 
            Next();
            Condition();
            Next();
            if (lexeme != ";") throw new Exception("Ожидалаcь ;"); 
            Next();
            Modification();
        }

        private void CycleBody()
        {
            if (lexeme == "{")
            {
                Next();
                ListOfOperators();
                Next();
                if (lexeme != "}") throw new Exception("Ожидалаcь }");
            }
            else if (lexeme == "int" || lexeme == "float" || lexeme == "double" || lexeme == "id" || lexeme == "lit")
            {
                ListOfOperators();
            }
            else if (lexeme != "}") throw new Exception("Ожидался оператор");
        }

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
            else if (lexeme != ";") throw new Exception("Ожидалась инициализация цикла");
        }

        private void Condition()
        {
            if (lexeme == "lit" || lexeme == "id")
            {
                Operand();
                Next();
                Sign();
                Next();
                Operand();
            }
            else if (lexeme != ";") throw new Exception("Ожидалось условие цикла");
        }

        private void Modification()
        {
            if (lexeme == "id")
            {
                Next();
                if (lexeme == "+" || lexeme == "-") DoubleSign();
                else if (lexeme == "=")
                {
                    currentIndex--;
                    lexeme = "id";
                    Assignment();
                }
            }
            else if (lexeme == "+" || lexeme == "-")
            {
                DoubleSign();
                Next();
                if (lexeme != "id") throw new Exception("Ожидалась переменная");
            }
            else if (lexeme != ")") throw new Exception("Ожидалась модификация цикла");
        }

        private void Operand()
        {
            if (lexeme != "lit" && lexeme != "id")
            {
                throw new Exception("Ожидалось число или переменная");
            }
        }

        private void Sign()
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
            else if (lexeme != "&" || lexeme != "|")
            {
                throw new Exception("Некорректный знак");
            }
        }

        private void AdditionalSign()
        {
            if (lexeme != "=" && lexeme != "lit" && lexeme != "id")
            {
                throw new Exception("Ожидалось число или переменная");
            }
        }

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
    }
}
