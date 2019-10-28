using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizruptor
{
    public partial class Form1 : Form
    {
        Words w =Words.GetInstance();
        public Form1()
        {
            InitializeComponent();
            LoadBadWords();

        }
        void LoadBadWords()
        {
            foreach (var item in w.badWords.Keys)
            {
                badWords_lstBx.Items.Add(item);
            }
        }
        
        private void start_btn_Click(object sender, EventArgs e)
        {
            allWords_lstbx.Items.Clear();
            FileToWords fw = new FileToWords();
            fw.ReadTXTFile(pathToBook_txtBx.Text);
            w = fw.GetStatistic();
            foreach (var item in w.allWordsDic)
            {
                allWords_lstbx.Items.Add(item.Key+" ------>>> "+item.Value);
            }
        }

        private void ToBadWords_btn_Click(object sender, EventArgs e)
        {
            string temp = (w.allWordsDic.ElementAt(allWords_lstbx.Items.IndexOf(allWords_lstbx.SelectedItem)).Key);
            badWords_lstBx.Items.Add(temp);
            w.AddBadWord(temp);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Words w = Words.GetInstance();
            w.SaveBadWords();
        }

        private void findFile_btn_Click(object sender, EventArgs e)
        {
            book_fd.ShowDialog();
            pathToBook_txtBx.Text= book_fd.FileName;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkWithWord word = new WorkWithWord();
            word.SetPath(@"E:/t1.docx");
            word.OpenWordFile();

            List<int> lst = word.FindPage("один");
            string s = "";
            foreach (var item in lst)
            {
                s += item+" ";
            }
            MessageBox.Show(s);

            word.CloseAndQuit();
        }
    }
}
