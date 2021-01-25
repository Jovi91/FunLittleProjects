namespace Excuses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_excuse = new System.Windows.Forms.TextBox();
            this.tb_resultOfExcuse = new System.Windows.Forms.TextBox();
            this.b_directory = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_open = new System.Windows.Forms.Button();
            this.b_randomExcuse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.l_fileSaveDate = new System.Windows.Forms.Label();
            this.dtp_lastUsedDate = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wymówka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wynik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ostatni użyte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data pliku";
            // 
            // tb_excuse
            // 
            this.tb_excuse.Location = new System.Drawing.Point(120, 17);
            this.tb_excuse.Name = "tb_excuse";
            this.tb_excuse.Size = new System.Drawing.Size(307, 22);
            this.tb_excuse.TabIndex = 4;
            this.tb_excuse.TextChanged += new System.EventHandler(this.tb_excuse_TextChanged);
            // 
            // tb_resultOfExcuse
            // 
            this.tb_resultOfExcuse.Location = new System.Drawing.Point(120, 57);
            this.tb_resultOfExcuse.Name = "tb_resultOfExcuse";
            this.tb_resultOfExcuse.Size = new System.Drawing.Size(307, 22);
            this.tb_resultOfExcuse.TabIndex = 5;
            this.tb_resultOfExcuse.TextChanged += new System.EventHandler(this.tb_resultOfExcuse_TextChanged);
            // 
            // b_directory
            // 
            this.b_directory.Location = new System.Drawing.Point(15, 169);
            this.b_directory.Name = "b_directory";
            this.b_directory.Size = new System.Drawing.Size(81, 33);
            this.b_directory.TabIndex = 8;
            this.b_directory.Text = "Folder";
            this.b_directory.UseVisualStyleBackColor = true;
            this.b_directory.Click += new System.EventHandler(this.b_directory_Click);
            // 
            // b_save
            // 
            this.b_save.Enabled = false;
            this.b_save.Location = new System.Drawing.Point(102, 169);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(82, 33);
            this.b_save.TabIndex = 9;
            this.b_save.Text = "Zapisz";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_open
            // 
            this.b_open.Enabled = false;
            this.b_open.Location = new System.Drawing.Point(190, 169);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(83, 33);
            this.b_open.TabIndex = 10;
            this.b_open.Text = "Otwórz";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // b_randomExcuse
            // 
            this.b_randomExcuse.Enabled = false;
            this.b_randomExcuse.Location = new System.Drawing.Point(279, 169);
            this.b_randomExcuse.Name = "b_randomExcuse";
            this.b_randomExcuse.Size = new System.Drawing.Size(148, 33);
            this.b_randomExcuse.TabIndex = 11;
            this.b_randomExcuse.Text = "Losowa wymówka";
            this.b_randomExcuse.UseVisualStyleBackColor = true;
            this.b_randomExcuse.Click += new System.EventHandler(this.b_randomExcuse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // l_fileSaveDate
            // 
            this.l_fileSaveDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_fileSaveDate.Location = new System.Drawing.Point(120, 131);
            this.l_fileSaveDate.Name = "l_fileSaveDate";
            this.l_fileSaveDate.Size = new System.Drawing.Size(307, 23);
            this.l_fileSaveDate.TabIndex = 12;
            // 
            // dtp_lastUsedDate
            // 
            this.dtp_lastUsedDate.Location = new System.Drawing.Point(120, 93);
            this.dtp_lastUsedDate.Name = "dtp_lastUsedDate";
            this.dtp_lastUsedDate.Size = new System.Drawing.Size(307, 22);
            this.dtp_lastUsedDate.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 314);
            this.Controls.Add(this.dtp_lastUsedDate);
            this.Controls.Add(this.l_fileSaveDate);
            this.Controls.Add(this.b_randomExcuse);
            this.Controls.Add(this.b_open);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_directory);
            this.Controls.Add(this.tb_resultOfExcuse);
            this.Controls.Add(this.tb_excuse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program do zarządzania wymówkami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_excuse;
        private System.Windows.Forms.TextBox tb_resultOfExcuse;
        private System.Windows.Forms.Button b_directory;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.Button b_randomExcuse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label l_fileSaveDate;
        private System.Windows.Forms.DateTimePicker dtp_lastUsedDate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

