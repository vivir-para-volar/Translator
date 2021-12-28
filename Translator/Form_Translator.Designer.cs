
namespace Translator
{
    partial class Form_Translator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Translator));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbCodeRepeat = new System.Windows.Forms.RichTextBox();
            this.dgvLexemes = new System.Windows.Forms.DataGridView();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLiteral = new System.Windows.Forms.DataGridView();
            this.NumberLiteral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Literal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSeparator = new System.Windows.Forms.DataGridView();
            this.NumberSeparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Separator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVariable = new System.Windows.Forms.DataGridView();
            this.NumberVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFunctionWord = new System.Windows.Forms.DataGridView();
            this.NumberFunctionWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.tbDijkstra = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_analysis = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiteral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionWord)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbCodeRepeat);
            this.tabPage2.Controls.Add(this.dgvLexemes);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvLiteral);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgvSeparator);
            this.tabPage2.Controls.Add(this.dgvVariable);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvFunctionWord);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лексический анализ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbCodeRepeat
            // 
            this.rtbCodeRepeat.Location = new System.Drawing.Point(8, 41);
            this.rtbCodeRepeat.Name = "rtbCodeRepeat";
            this.rtbCodeRepeat.ReadOnly = true;
            this.rtbCodeRepeat.Size = new System.Drawing.Size(572, 260);
            this.rtbCodeRepeat.TabIndex = 10;
            this.rtbCodeRepeat.Text = "";
            // 
            // dgvLexemes
            // 
            this.dgvLexemes.AllowUserToAddRows = false;
            this.dgvLexemes.AllowUserToDeleteRows = false;
            this.dgvLexemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLexemes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexeme,
            this.Type,
            this.Table});
            this.dgvLexemes.Location = new System.Drawing.Point(604, 41);
            this.dgvLexemes.Name = "dgvLexemes";
            this.dgvLexemes.ReadOnly = true;
            this.dgvLexemes.RowHeadersVisible = false;
            this.dgvLexemes.RowHeadersWidth = 51;
            this.dgvLexemes.RowTemplate.Height = 24;
            this.dgvLexemes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLexemes.Size = new System.Drawing.Size(368, 260);
            this.dgvLexemes.TabIndex = 0;
            // 
            // Lexeme
            // 
            this.Lexeme.HeaderText = "Лексема";
            this.Lexeme.MinimumWidth = 6;
            this.Lexeme.Name = "Lexeme";
            this.Lexeme.ReadOnly = true;
            this.Lexeme.Width = 65;
            // 
            // Type
            // 
            this.Type.HeaderText = "Предварительный тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 105;
            // 
            // Table
            // 
            this.Table.HeaderText = "Таблица";
            this.Table.MinimumWidth = 6;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Width = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Таблица \r\nлитералов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Таблица лексем";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLiteral
            // 
            this.dgvLiteral.AllowUserToAddRows = false;
            this.dgvLiteral.AllowUserToDeleteRows = false;
            this.dgvLiteral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiteral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberLiteral,
            this.Literal});
            this.dgvLiteral.Location = new System.Drawing.Point(754, 368);
            this.dgvLiteral.Name = "dgvLiteral";
            this.dgvLiteral.ReadOnly = true;
            this.dgvLiteral.RowHeadersVisible = false;
            this.dgvLiteral.RowHeadersWidth = 51;
            this.dgvLiteral.RowTemplate.Height = 24;
            this.dgvLiteral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLiteral.Size = new System.Drawing.Size(218, 306);
            this.dgvLiteral.TabIndex = 8;
            // 
            // NumberLiteral
            // 
            this.NumberLiteral.HeaderText = "№";
            this.NumberLiteral.MinimumWidth = 6;
            this.NumberLiteral.Name = "NumberLiteral";
            this.NumberLiteral.ReadOnly = true;
            this.NumberLiteral.Width = 50;
            // 
            // Literal
            // 
            this.Literal.HeaderText = "Литерал";
            this.Literal.MinimumWidth = 6;
            this.Literal.Name = "Literal";
            this.Literal.ReadOnly = true;
            this.Literal.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Таблица \r\nпеременных";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSeparator
            // 
            this.dgvSeparator.AllowUserToAddRows = false;
            this.dgvSeparator.AllowUserToDeleteRows = false;
            this.dgvSeparator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeparator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberSeparator,
            this.Separator});
            this.dgvSeparator.Location = new System.Drawing.Point(260, 368);
            this.dgvSeparator.Name = "dgvSeparator";
            this.dgvSeparator.ReadOnly = true;
            this.dgvSeparator.RowHeadersVisible = false;
            this.dgvSeparator.RowHeadersWidth = 51;
            this.dgvSeparator.RowTemplate.Height = 24;
            this.dgvSeparator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSeparator.Size = new System.Drawing.Size(218, 306);
            this.dgvSeparator.TabIndex = 4;
            // 
            // NumberSeparator
            // 
            this.NumberSeparator.HeaderText = "№";
            this.NumberSeparator.MinimumWidth = 6;
            this.NumberSeparator.Name = "NumberSeparator";
            this.NumberSeparator.ReadOnly = true;
            this.NumberSeparator.Width = 50;
            // 
            // Separator
            // 
            this.Separator.HeaderText = "Разделитель";
            this.Separator.MinimumWidth = 6;
            this.Separator.Name = "Separator";
            this.Separator.ReadOnly = true;
            this.Separator.Width = 90;
            // 
            // dgvVariable
            // 
            this.dgvVariable.AllowUserToAddRows = false;
            this.dgvVariable.AllowUserToDeleteRows = false;
            this.dgvVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberVariable,
            this.Variable});
            this.dgvVariable.Location = new System.Drawing.Point(514, 368);
            this.dgvVariable.Name = "dgvVariable";
            this.dgvVariable.ReadOnly = true;
            this.dgvVariable.RowHeadersVisible = false;
            this.dgvVariable.RowHeadersWidth = 51;
            this.dgvVariable.RowTemplate.Height = 24;
            this.dgvVariable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVariable.Size = new System.Drawing.Size(218, 306);
            this.dgvVariable.TabIndex = 6;
            // 
            // NumberVariable
            // 
            this.NumberVariable.HeaderText = "№";
            this.NumberVariable.MinimumWidth = 6;
            this.NumberVariable.Name = "NumberVariable";
            this.NumberVariable.ReadOnly = true;
            this.NumberVariable.Width = 50;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Переменная";
            this.Variable.MinimumWidth = 6;
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            this.Variable.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \r\nслужебных слов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFunctionWord
            // 
            this.dgvFunctionWord.AllowUserToAddRows = false;
            this.dgvFunctionWord.AllowUserToDeleteRows = false;
            this.dgvFunctionWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctionWord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberFunctionWord,
            this.FunctionWord});
            this.dgvFunctionWord.Location = new System.Drawing.Point(9, 368);
            this.dgvFunctionWord.Name = "dgvFunctionWord";
            this.dgvFunctionWord.ReadOnly = true;
            this.dgvFunctionWord.RowHeadersVisible = false;
            this.dgvFunctionWord.RowHeadersWidth = 51;
            this.dgvFunctionWord.RowTemplate.Height = 24;
            this.dgvFunctionWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFunctionWord.Size = new System.Drawing.Size(218, 306);
            this.dgvFunctionWord.TabIndex = 1;
            // 
            // NumberFunctionWord
            // 
            this.NumberFunctionWord.HeaderText = "№";
            this.NumberFunctionWord.MinimumWidth = 6;
            this.NumberFunctionWord.Name = "NumberFunctionWord";
            this.NumberFunctionWord.ReadOnly = true;
            this.NumberFunctionWord.Width = 50;
            // 
            // FunctionWord
            // 
            this.FunctionWord.HeaderText = "Служебное слово";
            this.FunctionWord.MinimumWidth = 6;
            this.FunctionWord.Name = "FunctionWord";
            this.FunctionWord.ReadOnly = true;
            this.FunctionWord.Width = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Таблица \r\nразделителей";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 721);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rtbCode);
            this.tabPage1.Controls.Add(this.tbDijkstra);
            this.tabPage1.Controls.Add(this.tbResult);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btn_open);
            this.tabPage1.Controls.Add(this.btn_analysis);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Код";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Разбор арифметических выражений";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 15;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbCode
            // 
            this.rtbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbCode.Location = new System.Drawing.Point(17, 17);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(515, 436);
            this.rtbCode.TabIndex = 10;
            this.rtbCode.Text = "void main () { \n  int sum = 56 + 1090;  \n  double gh = 6.987; \n  int j = sum; \n  " +
    "for(int i=1; i<=sum; i++) // цикл  \n  { \n    j = j + (21 * 56) / sum + sum * 65;" +
    " \n  } \n}";
            // 
            // tbDijkstra
            // 
            this.tbDijkstra.Location = new System.Drawing.Point(611, 63);
            this.tbDijkstra.Multiline = true;
            this.tbDijkstra.Name = "tbDijkstra";
            this.tbDijkstra.ReadOnly = true;
            this.tbDijkstra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDijkstra.Size = new System.Drawing.Size(342, 390);
            this.tbDijkstra.TabIndex = 14;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(17, 569);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(950, 98);
            this.tbResult.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(373, 481);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 50);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(14, 481);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(159, 50);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Открыть файл";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btn_analysis
            // 
            this.btn_analysis.Location = new System.Drawing.Point(196, 481);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(159, 50);
            this.btn_analysis.TabIndex = 1;
            this.btn_analysis.Text = "Анализировать";
            this.btn_analysis.UseVisualStyleBackColor = true;
            this.btn_analysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // Form_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Translator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiteral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionWord)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvLexemes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLiteral;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberLiteral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Literal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Separator;
        private System.Windows.Forms.DataGridView dgvVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFunctionWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberFunctionWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.TextBox tbDijkstra;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_analysis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbCodeRepeat;
    }
}

