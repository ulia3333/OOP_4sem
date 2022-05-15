namespace Laba_1
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lenghtStrBut = new System.Windows.Forms.Button();
            this.InputStr = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.Label();
            this.ResultStr = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SubStr0 = new System.Windows.Forms.TextBox();
            this.SubStr1 = new System.Windows.Forms.TextBox();
            this.SubLBox0 = new System.Windows.Forms.Label();
            this.SubBox1 = new System.Windows.Forms.Label();
            this.ReplaceBut = new System.Windows.Forms.Button();
            this.DeleteSubBut = new System.Windows.Forms.Button();
            this.SymbolByIndexBut = new System.Windows.Forms.Button();
            this.indexStr = new System.Windows.Forms.TextBox();
            this.indexBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConsBut = new System.Windows.Forms.Button();
            this.VowBut = new System.Windows.Forms.Button();
            this.ConsonantStr = new System.Windows.Forms.TextBox();
            this.VowelsStr = new System.Windows.Forms.TextBox();
            this.ConsonantsBox = new System.Windows.Forms.Label();
            this.VowelsBox = new System.Windows.Forms.Label();
            this.SenBut = new System.Windows.Forms.Button();
            this.NameFormBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lenghtStrBut
            // 
            this.lenghtStrBut.Cursor = System.Windows.Forms.Cursors.Default;
            this.lenghtStrBut.Location = new System.Drawing.Point(396, 343);
            this.lenghtStrBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lenghtStrBut.Name = "lenghtStrBut";
            this.lenghtStrBut.Size = new System.Drawing.Size(167, 74);
            this.lenghtStrBut.TabIndex = 0;
            this.lenghtStrBut.Text = "Длина строки";
            this.lenghtStrBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lenghtStrBut.UseVisualStyleBackColor = true;
            this.lenghtStrBut.Click += new System.EventHandler(this.lenghtStrBut_Click);
            // 
            // InputStr
            // 
            this.InputStr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputStr.Location = new System.Drawing.Point(14, 118);
            this.InputStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputStr.Name = "InputStr";
            this.InputStr.Size = new System.Drawing.Size(297, 27);
            this.InputStr.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.AutoSize = true;
            this.inputBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBox.Location = new System.Drawing.Point(14, 76);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(171, 32);
            this.inputBox.TabIndex = 3;
            this.inputBox.Text = "Ведите строку";
            // 
            // resultBox
            // 
            this.resultBox.AutoSize = true;
            this.resultBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultBox.Location = new System.Drawing.Point(22, 525);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(125, 32);
            this.resultBox.TabIndex = 4;
            this.resultBox.Text = "Результат:";
            // 
            // ResultStr
            // 
            this.ResultStr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultStr.Location = new System.Drawing.Point(148, 532);
            this.ResultStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultStr.Multiline = true;
            this.ResultStr.Name = "ResultStr";
            this.ResultStr.ReadOnly = true;
            this.ResultStr.Size = new System.Drawing.Size(550, 70);
            this.ResultStr.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(538, 627);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(159, 42);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SubStr0
            // 
            this.SubStr0.Location = new System.Drawing.Point(14, 198);
            this.SubStr0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubStr0.Name = "SubStr0";
            this.SubStr0.Size = new System.Drawing.Size(334, 27);
            this.SubStr0.TabIndex = 7;
            // 
            // SubStr1
            // 
            this.SubStr1.Location = new System.Drawing.Point(388, 198);
            this.SubStr1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubStr1.Name = "SubStr1";
            this.SubStr1.Size = new System.Drawing.Size(357, 27);
            this.SubStr1.TabIndex = 7;
            // 
            // SubLBox0
            // 
            this.SubLBox0.AutoSize = true;
            this.SubLBox0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubLBox0.Location = new System.Drawing.Point(14, 163);
            this.SubLBox0.Name = "SubLBox0";
            this.SubLBox0.Size = new System.Drawing.Size(371, 32);
            this.SubLBox0.TabIndex = 3;
            this.SubLBox0.Text = "Подстрока, подлежащая замене";
            // 
            // SubBox1
            // 
            this.SubBox1.AutoSize = true;
            this.SubBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubBox1.Location = new System.Drawing.Point(388, 161);
            this.SubBox1.Name = "SubBox1";
            this.SubBox1.Size = new System.Drawing.Size(280, 32);
            this.SubBox1.TabIndex = 3;
            this.SubBox1.Text = "Заменяющая подстрока";
            // 
            // ReplaceBut
            // 
            this.ReplaceBut.Location = new System.Drawing.Point(214, 344);
            this.ReplaceBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReplaceBut.Name = "ReplaceBut";
            this.ReplaceBut.Size = new System.Drawing.Size(161, 72);
            this.ReplaceBut.TabIndex = 8;
            this.ReplaceBut.Text = "Изменить подстроку";
            this.ReplaceBut.UseVisualStyleBackColor = true;
            this.ReplaceBut.Click += new System.EventHandler(this.ReplaceBut_Click);
            // 
            // DeleteSubBut
            // 
            this.DeleteSubBut.Location = new System.Drawing.Point(214, 430);
            this.DeleteSubBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteSubBut.Name = "DeleteSubBut";
            this.DeleteSubBut.Size = new System.Drawing.Size(161, 79);
            this.DeleteSubBut.TabIndex = 9;
            this.DeleteSubBut.Text = "Удалить подстроку";
            this.DeleteSubBut.UseVisualStyleBackColor = true;
            this.DeleteSubBut.Click += new System.EventHandler(this.DeleteSubstr_Click);
            // 
            // SymbolByIndexBut
            // 
            this.SymbolByIndexBut.Location = new System.Drawing.Point(396, 430);
            this.SymbolByIndexBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SymbolByIndexBut.Name = "SymbolByIndexBut";
            this.SymbolByIndexBut.Size = new System.Drawing.Size(167, 79);
            this.SymbolByIndexBut.TabIndex = 10;
            this.SymbolByIndexBut.Text = "Посчитать символ по индексу";
            this.SymbolByIndexBut.UseVisualStyleBackColor = true;
            this.SymbolByIndexBut.Click += new System.EventHandler(this.SymbolByIndexBut_Click);
            // 
            // indexStr
            // 
            this.indexStr.Location = new System.Drawing.Point(630, 463);
            this.indexStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.indexStr.Multiline = true;
            this.indexStr.Name = "indexStr";
            this.indexStr.Size = new System.Drawing.Size(60, 38);
            this.indexStr.TabIndex = 11;
            // 
            // indexBox
            // 
            this.indexBox.AutoSize = true;
            this.indexBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indexBox.Location = new System.Drawing.Point(570, 429);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(188, 32);
            this.indexBox.TabIndex = 12;
            this.indexBox.Text = "Введите индекс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-63, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // ConsBut
            // 
            this.ConsBut.Location = new System.Drawing.Point(22, 257);
            this.ConsBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsBut.Name = "ConsBut";
            this.ConsBut.Size = new System.Drawing.Size(167, 74);
            this.ConsBut.TabIndex = 15;
            this.ConsBut.Text = "Количество согласных и гласных";
            this.ConsBut.UseVisualStyleBackColor = true;
            this.ConsBut.Click += new System.EventHandler(this.ConsBut_Click);
            // 
            // VowBut
            // 
            this.VowBut.Location = new System.Drawing.Point(22, 343);
            this.VowBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VowBut.Name = "VowBut";
            this.VowBut.Size = new System.Drawing.Size(167, 74);
            this.VowBut.TabIndex = 16;
            this.VowBut.Text = "Посчитать количество слов";
            this.VowBut.UseVisualStyleBackColor = true;
            this.VowBut.Click += new System.EventHandler(this.VowBut_Click);
            // 
            // ConsonantStr
            // 
            this.ConsonantStr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsonantStr.Location = new System.Drawing.Point(328, 258);
            this.ConsonantStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsonantStr.Name = "ConsonantStr";
            this.ConsonantStr.Size = new System.Drawing.Size(51, 34);
            this.ConsonantStr.TabIndex = 17;
            // 
            // VowelsStr
            // 
            this.VowelsStr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VowelsStr.Location = new System.Drawing.Point(328, 296);
            this.VowelsStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VowelsStr.Name = "VowelsStr";
            this.VowelsStr.Size = new System.Drawing.Size(51, 34);
            this.VowelsStr.TabIndex = 17;
            // 
            // ConsonantsBox
            // 
            this.ConsonantsBox.AutoSize = true;
            this.ConsonantsBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsonantsBox.Location = new System.Drawing.Point(195, 257);
            this.ConsonantsBox.Name = "ConsonantsBox";
            this.ConsonantsBox.Size = new System.Drawing.Size(132, 32);
            this.ConsonantsBox.TabIndex = 18;
            this.ConsonantsBox.Text = "Согласные";
            // 
            // VowelsBox
            // 
            this.VowelsBox.AutoSize = true;
            this.VowelsBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VowelsBox.Location = new System.Drawing.Point(218, 296);
            this.VowelsBox.Name = "VowelsBox";
            this.VowelsBox.Size = new System.Drawing.Size(105, 32);
            this.VowelsBox.TabIndex = 19;
            this.VowelsBox.Text = "Гласные";
            // 
            // SenBut
            // 
            this.SenBut.Location = new System.Drawing.Point(22, 429);
            this.SenBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SenBut.Name = "SenBut";
            this.SenBut.Size = new System.Drawing.Size(167, 80);
            this.SenBut.TabIndex = 20;
            this.SenBut.Text = "Посчитать количество предложений";
            this.SenBut.UseVisualStyleBackColor = true;
            this.SenBut.Click += new System.EventHandler(this.SenBut_Click);
            // 
            // NameFormBox
            // 
            this.NameFormBox.AutoSize = true;
            this.NameFormBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NameFormBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameFormBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameFormBox.Location = new System.Drawing.Point(245, 17);
            this.NameFormBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFormBox.Name = "NameFormBox";
            this.NameFormBox.Size = new System.Drawing.Size(283, 28);
            this.NameFormBox.TabIndex = 24;
            this.NameFormBox.Text = "ТЕКСТОВЫЙ КАЛЬКУЛЯТОР";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(762, 671);
            this.Controls.Add(this.NameFormBox);
            this.Controls.Add(this.SenBut);
            this.Controls.Add(this.VowelsBox);
            this.Controls.Add(this.ConsonantsBox);
            this.Controls.Add(this.VowelsStr);
            this.Controls.Add(this.ConsonantStr);
            this.Controls.Add(this.VowBut);
            this.Controls.Add(this.ConsBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.indexStr);
            this.Controls.Add(this.SymbolByIndexBut);
            this.Controls.Add(this.DeleteSubBut);
            this.Controls.Add(this.ReplaceBut);
            this.Controls.Add(this.SubBox1);
            this.Controls.Add(this.SubLBox0);
            this.Controls.Add(this.SubStr1);
            this.Controls.Add(this.SubStr0);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ResultStr);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.InputStr);
            this.Controls.Add(this.lenghtStrBut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lenghtStrBut;
        private System.Windows.Forms.TextBox InputStr;
        private System.Windows.Forms.Label inputBox;
        private System.Windows.Forms.Label resultBox;
        private System.Windows.Forms.TextBox ResultStr;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox SubStr0;
        private System.Windows.Forms.TextBox SubStr1;
        private System.Windows.Forms.Label SubLBox0;
        private System.Windows.Forms.Label SubBox1;
        private System.Windows.Forms.Button ReplaceBut;
        private System.Windows.Forms.Button DeleteSubBut;
        private System.Windows.Forms.Button SymbolByIndexBut;
        private System.Windows.Forms.TextBox indexStr;
        private System.Windows.Forms.Label indexBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ConsBut;
        private System.Windows.Forms.Button VowBut;
        private System.Windows.Forms.TextBox ConsonantStr;
        private System.Windows.Forms.TextBox VowelsStr;
        private System.Windows.Forms.Label ConsonantsBox;
        private System.Windows.Forms.Label VowelsBox;
        private System.Windows.Forms.Button SenBut;
        private System.Windows.Forms.Label NameFormBox;
    }
}

