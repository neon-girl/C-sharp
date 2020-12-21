namespace Distant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLevenshteinDist = new System.Windows.Forms.Button();
            this.buttonSearchWord = new System.Windows.Forms.Button();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxParallTime = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.textBoxSearchTime = new System.Windows.Forms.TextBox();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.listBoxResult1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(16, 31);
            this.buttonLoadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(177, 35);
            this.buttonLoadFile.TabIndex = 0;
            this.buttonLoadFile.Text = "Выбрать файл";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1442, 560);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(127, 39);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLevenshteinDist
            // 
            this.buttonLevenshteinDist.Location = new System.Drawing.Point(914, 212);
            this.buttonLevenshteinDist.Name = "buttonLevenshteinDist";
            this.buttonLevenshteinDist.Size = new System.Drawing.Size(148, 62);
            this.buttonLevenshteinDist.TabIndex = 9;
            this.buttonLevenshteinDist.Text = "Параллельный поиск";
            this.buttonLevenshteinDist.UseVisualStyleBackColor = true;
            this.buttonLevenshteinDist.Click += new System.EventHandler(this.buttonLevenshteinDist_Click);
            // 
            // buttonSearchWord
            // 
            this.buttonSearchWord.Location = new System.Drawing.Point(12, 149);
            this.buttonSearchWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchWord.Name = "buttonSearchWord";
            this.buttonSearchWord.Size = new System.Drawing.Size(177, 35);
            this.buttonSearchWord.TabIndex = 2;
            this.buttonSearchWord.Text = "Поиск";
            this.buttonSearchWord.UseVisualStyleBackColor = true;
            this.buttonSearchWord.Click += new System.EventHandler(this.buttonSearchWord_Click);
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(11, 554);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(182, 39);
            this.buttonSaveReport.TabIndex = 15;
            this.buttonSaveReport.Text = "Сохранить отчет";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(592, 271);
            this.textBoxFileReadTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.ReadOnly = true;
            this.textBoxFileReadTime.Size = new System.Drawing.Size(199, 26);
            this.textBoxFileReadTime.TabIndex = 14;
            // 
            // textBoxParallTime
            // 
            this.textBoxParallTime.Location = new System.Drawing.Point(592, 510);
            this.textBoxParallTime.Name = "textBoxParallTime";
            this.textBoxParallTime.ReadOnly = true;
            this.textBoxParallTime.Size = new System.Drawing.Size(199, 26);
            this.textBoxParallTime.TabIndex = 11;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(230, 31);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(427, 26);
            this.textBoxFileName.TabIndex = 12;
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(592, 347);
            this.textBoxFileReadCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.ReadOnly = true;
            this.textBoxFileReadCount.Size = new System.Drawing.Size(199, 26);
            this.textBoxFileReadCount.TabIndex = 4;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(274, 97);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(561, 26);
            this.textBoxFind.TabIndex = 1;
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(1349, 131);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(82, 26);
            this.textBoxMaxDist.TabIndex = 21;
            // 
            // textBoxSearchTime
            // 
            this.textBoxSearchTime.Location = new System.Drawing.Point(592, 420);
            this.textBoxSearchTime.Name = "textBoxSearchTime";
            this.textBoxSearchTime.ReadOnly = true;
            this.textBoxSearchTime.Size = new System.Drawing.Size(199, 26);
            this.textBoxSearchTime.TabIndex = 10;
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(1363, 175);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(82, 26);
            this.textBoxThreadCount.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время чтения из файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество уникальных слов в файле:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите значение для поиска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время поиска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1106, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Результат поиска:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(884, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Максимальное расстояние для параллельногор поиска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Время параллельного поиска:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(957, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество потоков:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Результат поиска:";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(4, 233);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(484, 284);
            this.listBoxResult.TabIndex = 11;
            // 
            // listBoxResult1
            // 
            this.listBoxResult1.FormattingEnabled = true;
            this.listBoxResult1.ItemHeight = 20;
            this.listBoxResult1.Location = new System.Drawing.Point(1110, 243);
            this.listBoxResult1.Name = "listBoxResult1";
            this.listBoxResult1.Size = new System.Drawing.Size(415, 284);
            this.listBoxResult1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 607);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.textBoxParallTime);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.buttonSearchWord);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLevenshteinDist);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.textBoxSearchTime);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.listBoxResult1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Поиск в файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.Button buttonSearchWord;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TextBox textBoxSearchTime;
        private System.Windows.Forms.TextBox textBoxParallTime;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.ListBox listBoxResult1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.Button buttonLevenshteinDist;
    }
}

