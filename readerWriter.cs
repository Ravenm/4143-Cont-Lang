using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

///Name:
///Name:
namespace temp
{
    public partial class readerWriter : Form
    {
        public readerWriter()
        {
            InitializeComponent();
        }

        private List<string> nameList = new List<string>();

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void readFileByLine()
        {
            FileStream fs = File.Open(openFileDialog1.FileName, FileMode.OpenOrCreate);
            BufferedStream bs = new BufferedStream(fs);
            StreamReader sr = new StreamReader(bs);
            var lineOfFile = "";
            while((lineOfFile = sr.ReadLine()) != null)
            {
                nameList.Add(lineOfFile);
            }
            nameList.Sort();
            sr.Close();
            bs.Close();
            fs.Close();
        }


        private void openBtn_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuidler = new StringBuilder();
            openFileDialog1.ShowDialog();
            try
            {
                readFileByLine();
                
                foreach (var element in nameList)
                {
                    stringBuidler.AppendLine(element);
                }
            }
            catch(IOException)
            {

            }
            outPutBox.Text = stringBuidler.ToString();
        }

        private void saveBtm_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            BufferedStream bs = new BufferedStream(fs);
            StreamWriter streamWritter = new StreamWriter(bs);
            foreach (var element in nameList)
            {
                streamWritter.WriteLine(element);
            }
            streamWritter.Close();
            bs.Close();
            fs.Close();
        }
    }
}
