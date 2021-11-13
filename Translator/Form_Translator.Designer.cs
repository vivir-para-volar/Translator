
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_analysis = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.tableLexemes = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLiteral = new System.Windows.Forms.DataGridView();
            this.NumberLiteral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Literal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvVariable = new System.Windows.Forms.DataGridView();
            this.NumberVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSeparator = new System.Windows.Forms.DataGridView();
            this.NumberSeparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Separator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFunctionWord = new System.Windows.Forms.DataGridView();
            this.NumberFunctionWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLexemes = new System.Windows.Forms.DataGridView();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.main.SuspendLayout();
            this.tableLexemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiteral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexemes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main);
            this.tabControl1.Controls.Add(this.tableLexemes);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1396, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // main
            // 
            this.main.Controls.Add(this.textBox);
            this.main.Controls.Add(this.btn_analysis);
            this.main.Controls.Add(this.btn_open);
            this.main.Location = new System.Drawing.Point(4, 25);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3);
            this.main.Size = new System.Drawing.Size(1388, 607);
            this.main.TabIndex = 0;
            this.main.Text = "Главная";
            this.main.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(19, 19);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(750, 346);
            this.textBox.TabIndex = 2;
            this.textBox.Text = resources.GetString("textBox.Text");
            // 
            // btn_analysis
            // 
            this.btn_analysis.Location = new System.Drawing.Point(405, 389);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(215, 50);
            this.btn_analysis.TabIndex = 1;
            this.btn_analysis.Text = "Анализировать";
            this.btn_analysis.UseVisualStyleBackColor = true;
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(105, 389);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(215, 50);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Открыть файл";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // tableLexemes
            // 
            this.tableLexemes.Controls.Add(this.label5);
            this.tableLexemes.Controls.Add(this.dgvLiteral);
            this.tableLexemes.Controls.Add(this.label4);
            this.tableLexemes.Controls.Add(this.dgvVariable);
            this.tableLexemes.Controls.Add(this.label3);
            this.tableLexemes.Controls.Add(this.dgvSeparator);
            this.tableLexemes.Controls.Add(this.label2);
            this.tableLexemes.Controls.Add(this.label1);
            this.tableLexemes.Controls.Add(this.dgvFunctionWord);
            this.tableLexemes.Controls.Add(this.dgvLexemes);
            this.tableLexemes.Location = new System.Drawing.Point(4, 25);
            this.tableLexemes.Name = "tableLexemes";
            this.tableLexemes.Padding = new System.Windows.Forms.Padding(3);
            this.tableLexemes.Size = new System.Drawing.Size(1388, 607);
            this.tableLexemes.TabIndex = 1;
            this.tableLexemes.Text = "Лексический анализ";
            this.tableLexemes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1197, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Таблица \r\nлитералов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLiteral
            // 
            this.dgvLiteral.AllowUserToAddRows = false;
            this.dgvLiteral.AllowUserToDeleteRows = false;
            this.dgvLiteral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiteral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberLiteral,
            this.Literal});
            this.dgvLiteral.Location = new System.Drawing.Point(1142, 76);
            this.dgvLiteral.Name = "dgvLiteral";
            this.dgvLiteral.ReadOnly = true;
            this.dgvLiteral.RowHeadersVisible = false;
            this.dgvLiteral.RowHeadersWidth = 51;
            this.dgvLiteral.RowTemplate.Height = 24;
            this.dgvLiteral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLiteral.Size = new System.Drawing.Size(218, 506);
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
            this.label4.Location = new System.Drawing.Point(957, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Таблица \r\nпеременных";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVariable
            // 
            this.dgvVariable.AllowUserToAddRows = false;
            this.dgvVariable.AllowUserToDeleteRows = false;
            this.dgvVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberVariable,
            this.Variable});
            this.dgvVariable.Location = new System.Drawing.Point(902, 76);
            this.dgvVariable.Name = "dgvVariable";
            this.dgvVariable.ReadOnly = true;
            this.dgvVariable.RowHeadersVisible = false;
            this.dgvVariable.RowHeadersWidth = 51;
            this.dgvVariable.RowTemplate.Height = 24;
            this.dgvVariable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVariable.Size = new System.Drawing.Size(218, 506);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Таблица \r\nразделителей";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSeparator
            // 
            this.dgvSeparator.AllowUserToAddRows = false;
            this.dgvSeparator.AllowUserToDeleteRows = false;
            this.dgvSeparator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeparator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberSeparator,
            this.Separator});
            this.dgvSeparator.Location = new System.Drawing.Point(648, 76);
            this.dgvSeparator.Name = "dgvSeparator";
            this.dgvSeparator.ReadOnly = true;
            this.dgvSeparator.RowHeadersVisible = false;
            this.dgvSeparator.RowHeadersWidth = 51;
            this.dgvSeparator.RowTemplate.Height = 24;
            this.dgvSeparator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSeparator.Size = new System.Drawing.Size(218, 506);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Таблица \r\nстандартных символов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
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
            this.dgvFunctionWord.Location = new System.Drawing.Point(397, 76);
            this.dgvFunctionWord.Name = "dgvFunctionWord";
            this.dgvFunctionWord.ReadOnly = true;
            this.dgvFunctionWord.RowHeadersVisible = false;
            this.dgvFunctionWord.RowHeadersWidth = 51;
            this.dgvFunctionWord.RowTemplate.Height = 24;
            this.dgvFunctionWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFunctionWord.Size = new System.Drawing.Size(218, 506);
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
            // dgvLexemes
            // 
            this.dgvLexemes.AllowUserToAddRows = false;
            this.dgvLexemes.AllowUserToDeleteRows = false;
            this.dgvLexemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLexemes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexeme,
            this.Type,
            this.Table});
            this.dgvLexemes.Location = new System.Drawing.Point(18, 76);
            this.dgvLexemes.Name = "dgvLexemes";
            this.dgvLexemes.ReadOnly = true;
            this.dgvLexemes.RowHeadersVisible = false;
            this.dgvLexemes.RowHeadersWidth = 51;
            this.dgvLexemes.RowTemplate.Height = 24;
            this.dgvLexemes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLexemes.Size = new System.Drawing.Size(343, 506);
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
            // Form_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 642);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Translator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.tabControl1.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.tableLexemes.ResumeLayout(false);
            this.tableLexemes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiteral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexemes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage tableLexemes;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_analysis;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.DataGridView dgvLexemes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFunctionWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberFunctionWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLiteral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvVariable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Separator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberLiteral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Literal;
    }
}

