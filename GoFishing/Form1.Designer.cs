namespace GoFishing
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
            this.Imię = new System.Windows.Forms.Label();
            this.tb_textProgress = new System.Windows.Forms.TextBox();
            this.tb_textName = new System.Windows.Forms.MaskedTextBox();
            this.b_buttonStart = new System.Windows.Forms.Button();
            this.tb_textBooks = new System.Windows.Forms.TextBox();
            this.lb_listHand = new System.Windows.Forms.ListBox();
            this.b_buttonAsk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cardsFromFile = new System.Windows.Forms.ListBox();
            this.b_saveCartsToFile = new System.Windows.Forms.Button();
            this.b_displayCartsFromFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Imię
            // 
            this.Imię.AutoSize = true;
            this.Imię.Location = new System.Drawing.Point(31, 29);
            this.Imię.Name = "Imię";
            this.Imię.Size = new System.Drawing.Size(33, 17);
            this.Imię.TabIndex = 0;
            this.Imię.Text = "Imię";
            // 
            // tb_textProgress
            // 
            this.tb_textProgress.BackColor = System.Drawing.SystemColors.Control;
            this.tb_textProgress.Location = new System.Drawing.Point(34, 93);
            this.tb_textProgress.Multiline = true;
            this.tb_textProgress.Name = "tb_textProgress";
            this.tb_textProgress.Size = new System.Drawing.Size(293, 278);
            this.tb_textProgress.TabIndex = 1;
            // 
            // tb_textName
            // 
            this.tb_textName.BackColor = System.Drawing.SystemColors.Control;
            this.tb_textName.Location = new System.Drawing.Point(34, 49);
            this.tb_textName.Name = "tb_textName";
            this.tb_textName.Size = new System.Drawing.Size(153, 22);
            this.tb_textName.TabIndex = 2;
            // 
            // b_buttonStart
            // 
            this.b_buttonStart.Location = new System.Drawing.Point(193, 43);
            this.b_buttonStart.Name = "b_buttonStart";
            this.b_buttonStart.Size = new System.Drawing.Size(134, 35);
            this.b_buttonStart.TabIndex = 3;
            this.b_buttonStart.Text = "Rozpocznij grę!";
            this.b_buttonStart.UseVisualStyleBackColor = true;
            this.b_buttonStart.Click += new System.EventHandler(this.b_buttonStart_Click);
            // 
            // tb_textBooks
            // 
            this.tb_textBooks.BackColor = System.Drawing.SystemColors.Control;
            this.tb_textBooks.Location = new System.Drawing.Point(34, 377);
            this.tb_textBooks.Multiline = true;
            this.tb_textBooks.Name = "tb_textBooks";
            this.tb_textBooks.Size = new System.Drawing.Size(293, 274);
            this.tb_textBooks.TabIndex = 4;
            // 
            // lb_listHand
            // 
            this.lb_listHand.FormattingEnabled = true;
            this.lb_listHand.ItemHeight = 16;
            this.lb_listHand.Location = new System.Drawing.Point(347, 49);
            this.lb_listHand.Name = "lb_listHand";
            this.lb_listHand.Size = new System.Drawing.Size(191, 404);
            this.lb_listHand.TabIndex = 5;
            // 
            // b_buttonAsk
            // 
            this.b_buttonAsk.Enabled = false;
            this.b_buttonAsk.Location = new System.Drawing.Point(347, 459);
            this.b_buttonAsk.Name = "b_buttonAsk";
            this.b_buttonAsk.Size = new System.Drawing.Size(191, 50);
            this.b_buttonAsk.TabIndex = 6;
            this.b_buttonAsk.Tag = "";
            this.b_buttonAsk.Text = "Zażądaj karty";
            this.b_buttonAsk.UseVisualStyleBackColor = true;
            this.b_buttonAsk.Click += new System.EventHandler(this.b_buttonAsk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Na ręce";
            // 
            // lb_cardsFromFile
            // 
            this.lb_cardsFromFile.FormattingEnabled = true;
            this.lb_cardsFromFile.ItemHeight = 16;
            this.lb_cardsFromFile.Location = new System.Drawing.Point(578, 49);
            this.lb_cardsFromFile.Name = "lb_cardsFromFile";
            this.lb_cardsFromFile.Size = new System.Drawing.Size(191, 404);
            this.lb_cardsFromFile.TabIndex = 8;
            // 
            // b_saveCartsToFile
            // 
            this.b_saveCartsToFile.Enabled = false;
            this.b_saveCartsToFile.Location = new System.Drawing.Point(347, 515);
            this.b_saveCartsToFile.Name = "b_saveCartsToFile";
            this.b_saveCartsToFile.Size = new System.Drawing.Size(191, 50);
            this.b_saveCartsToFile.TabIndex = 9;
            this.b_saveCartsToFile.Tag = "";
            this.b_saveCartsToFile.Text = "Zapisz karty do pliku";
            this.b_saveCartsToFile.UseVisualStyleBackColor = true;
            this.b_saveCartsToFile.Click += new System.EventHandler(this.b_saveCartsToFile_Click);
            // 
            // b_displayCartsFromFile
            // 
            this.b_displayCartsFromFile.Enabled = false;
            this.b_displayCartsFromFile.Location = new System.Drawing.Point(578, 459);
            this.b_displayCartsFromFile.Name = "b_displayCartsFromFile";
            this.b_displayCartsFromFile.Size = new System.Drawing.Size(191, 50);
            this.b_displayCartsFromFile.TabIndex = 10;
            this.b_displayCartsFromFile.Tag = "";
            this.b_displayCartsFromFile.Text = "Wyświetl karty z pliku";
            this.b_displayCartsFromFile.UseVisualStyleBackColor = true;
            this.b_displayCartsFromFile.Click += new System.EventHandler(this.b_displayCartsFromFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 663);
            this.Controls.Add(this.b_displayCartsFromFile);
            this.Controls.Add(this.b_saveCartsToFile);
            this.Controls.Add(this.lb_cardsFromFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_buttonAsk);
            this.Controls.Add(this.lb_listHand);
            this.Controls.Add(this.tb_textBooks);
            this.Controls.Add(this.b_buttonStart);
            this.Controls.Add(this.tb_textName);
            this.Controls.Add(this.tb_textProgress);
            this.Controls.Add(this.Imię);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Imię;
        private System.Windows.Forms.TextBox tb_textProgress;
        private System.Windows.Forms.MaskedTextBox tb_textName;
        private System.Windows.Forms.Button b_buttonStart;
        private System.Windows.Forms.TextBox tb_textBooks;
        private System.Windows.Forms.ListBox lb_listHand;
        private System.Windows.Forms.Button b_buttonAsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_cardsFromFile;
        private System.Windows.Forms.Button b_saveCartsToFile;
        private System.Windows.Forms.Button b_displayCartsFromFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

