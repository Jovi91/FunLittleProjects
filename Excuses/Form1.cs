using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excuses
{
    public partial class Form1 : Form
    {
        const string initialDirectory = @"C:\Users\jowit\source\repos\HeadFirstProjects092020\Excuses\ExcusesFiles";
        string choosenFolderPath;
        Random rnd;
        bool excuseSaved = true;
        Excuse currentExcuse;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_directory_Click(object sender, EventArgs e)
        {


            folderBrowserDialog1.SelectedPath = initialDirectory;
            //openFileDialog1.Filter = @"text files (*.excuse)|*.excuse";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                choosenFolderPath = folderBrowserDialog1.SelectedPath;

                b_save.Enabled = true;
                b_open.Enabled = true;
                b_randomExcuse.Enabled = true;
            }

        }

        private void b_open_Click(object sender, EventArgs e)
        {
            if (excuseSaved == false)
                if (MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            openFileDialog1.InitialDirectory = choosenFolderPath;
            openFileDialog1.Filter = @"text files (*.excuse)|*.excuse|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool clearForm = false;
                try
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    try
                    {
                       UpdateForm(false);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Nie można otworzyć wymówki. Plik '" + openFileDialog1.FileName + "' jest nieprawidłowy. Błąd:" + ex.Message);
                        clearForm = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Podczas próby otwarcia pliku wymówki '" + openFileDialog1.FileName + @"' wystąpił błąd: " + ex.Message);
                    using (StreamWriter stream = new StreamWriter(choosenFolderPath + @"\log.txt", true))
                        stream.WriteLine(DateTime.Now.ToString() + ": " + ex.Message);
                    clearForm = true;
                }
                finally
                {
                    if(clearForm==true)
                    {
                        tb_excuse.Text = "";
                        tb_resultOfExcuse.Text = "";
                    }
                }

            }
            
        }

        private void b_save_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(tb_excuse.Text) || String.IsNullOrEmpty(tb_resultOfExcuse.Text))
            {
                MessageBox.Show("Określ wymówkę i rezultat");
            }
            else if (excuseSaved)
            {
                MessageBox.Show("Ta wymówka jest już zapisana");
            }
            else
            {
                currentExcuse = new Excuse(choosenFolderPath, tb_excuse.Text, tb_resultOfExcuse.Text, dtp_lastUsedDate.Value);
                currentExcuse.SaveFile();

                
                excuseSaved = true;
                ActiveForm.Text = ChangeFormTitle();
                MessageBox.Show("Wymówka zapisana");
                l_fileSaveDate.Text = DateTime.Now.ToString();
            }
        }

        private void b_randomExcuse_Click(object sender, EventArgs e)
        {
            rnd = new Random();

            if (excuseSaved == false)
                if (MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            String[] excuses = Directory.GetFiles(choosenFolderPath, "*.excuse");

            if (excuses.Length <= 0)
                MessageBox.Show("Wybierz folder z wymówkami", "Wybrany folder nie zawiera wymówek");
            else
            {
                try
                {
                    currentExcuse = new Excuse(rnd, choosenFolderPath);
                    UpdateForm(false);
                }
                catch (Exception)
                {
                    currentExcuse = new Excuse();
                    currentExcuse.Content = "";
                    currentExcuse.Result = "";
                    currentExcuse.DateOfLastUse = DateTime.Now;


                    MessageBox.Show("Wybierz folder z prawidłowym formatem plików dla wymówek","Wybrany folder zawiera nieprawidłowy format plików");
                }
                finally
                {
                    UpdateForm(false);
                }

            }

        }

        void UpdateForm(bool Changed)
        {
            if(!Changed)
            {
                tb_excuse.Text = currentExcuse.Content;
                tb_resultOfExcuse.Text = currentExcuse.Result;
                dtp_lastUsedDate.Value = currentExcuse.DateOfLastUse;
                excuseSaved = true;
                if (!String.IsNullOrEmpty(currentExcuse.FilePath))
                {
                    l_fileSaveDate.Text = File.GetLastWriteTime(currentExcuse.FilePath).ToString();
                    
                }
            }
            this.Text = ChangeFormTitle();
        }


        public string ChangeFormTitle()
        {
            if (excuseSaved)
                return "Program do zarządzania wymówkami";
            else
                return "Program do zarządzania wymówkami * ";
        }        
        
        private void tb_excuse_TextChanged(object sender, EventArgs e)
        {
            excuseSaved = false;
            this.Text = ChangeFormTitle();
        }


        private void tb_resultOfExcuse_TextChanged(object sender, EventArgs e)
        {
            excuseSaved = false;
            this.Text = ChangeFormTitle();
        }

        private void cb_LastUseOfTheExcuseDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            excuseSaved = false;
            this.Text = ChangeFormTitle();
        }
    }
}
