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
            //FileToWords fw = new FileToWords();
            //fw.ReadTXTFile(pathToBook_txtBx.Text);
            //w = fw.GetStatistic();

            WorkWithPDF PDF = new WorkWithPDF();
            var pdfWords = w.FilterAllWords(PDF.ReadAllPDF(pathToBook_txtBx.Text));

            foreach (var item in pdfWords)
            {
                allWords_lstbx.Items.Add(item.Key+" ------>>> "+item.Value);
            }
        }

        private void ToBadWords_btn_Click(object sender, EventArgs e)
        {
            string[] temp =  allWords_lstbx.SelectedItem.ToString().Split(' ');
            badWords_lstBx.Items.Add(temp[0]);
            w.AddBadWord(temp[0]);
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
            //word.SetPath(PathToWordFile_txtbx.Text);
            //word.OpenWordFile();

            WorkWithPDF PDF = new WorkWithPDF();
            

            List<int> lst = new List<int>();

            lst = PDF.ReadPdfFile(PathToWordFile_txtbx.Text, "Вульва");
            
            //lst = word.FindPage("один");
            string s = "";
            foreach (var item in lst)
            {
                s += item+" ";
            }
            MessageBox.Show(s);

            //word.CloseAndQuit();
        }

        private void PathToWordFile_btn_Click(object sender, EventArgs e)
        {
            word_FD.ShowDialog();
            PathToWordFile_txtbx.Text = word_FD.FileName;
        }

        private void ToTarget_btn_Click(object sender, EventArgs e)
        {
            string s= allWords_lstbx.SelectedItem.ToString();
            string[] v = s.Split(' ');
            if (TargetWords_lstBx.SelectedItem == null)
            {
                TargetWords_lstBx.Items.Add(v[0]);
                if (!w.targetList.ContainsKey(v[0]))
                {
                    w.targetList.Add(v[0], new List<string>());
                    w.targetList[v[0]].Add(v[0]);
                }
                else
                {
                    MessageBox.Show("Словарь уже содержит данное значение!");
                }
            }
            else
            {
                w.targetList[TargetWords_lstBx.SelectedItem.ToString()].Add(v[0]);
            }

        }

        private void combineWords_btn_Click(object sender, EventArgs e)
        {
            var t = TargetWords_lstBx.SelectedItems;
            string str = "";
            foreach (var item in t)
            {
                str += item.ToString() + Environment.NewLine;

            }

            MessageBox.Show(str);
        }
    }
}
