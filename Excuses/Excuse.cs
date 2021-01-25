using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace Excuses
{
 [Serializable]   
    public class Excuse
    {
        public string FilePath { get;}
        public string Content { get;  set; }
        public string Result { get;  set; }
        public DateTime DateOfLastUse { get;  set; }
         
        public Excuse(string filePath)
        {
            OpenFile(filePath);
        }

        public Excuse(string filePath, string content, string result, DateTime dateOfLastUse)
        {
            this.FilePath = filePath;
            this.Content = content;
            this.Result = result;
            this.DateOfLastUse = dateOfLastUse;
        }

        public Excuse() { }
        public Excuse(Random rnd, string filePath)
        {
            this.FilePath = filePath;
            String[] excuses = Directory.GetFiles(filePath, "*.excuse");
            int randomExcuseIndex = rnd.Next(excuses.Length);
            OpenFile(excuses[randomExcuseIndex]);         
        }
        public void OpenFile(string filePath)
        {
            using (Stream input = File.OpenRead(filePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Excuse tempExcuse = (Excuse)formatter.Deserialize(input);
                Content = tempExcuse.Content;
                Result = tempExcuse.Result;
                DateOfLastUse = tempExcuse.DateOfLastUse;

                //Content = reader.ReadLine();
                //Result = reader.ReadLine();
                //DateOfLastUse = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void SaveFile()
        {

            using (Stream output = File.Create(FilePath + "//" + Content + ".excuse"))
            {

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, this);
            }
                //writer.WriteLine(Content);
                //writer.WriteLine(Result);
                //writer.WriteLine(DateOfLastUse);
            
                

        }

    }
}
