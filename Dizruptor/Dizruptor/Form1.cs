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
        WorkWithPDF PDF = new WorkWithPDF();

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
            string test = "";
            
            test += TargetWords_lstBx.SelectedItems[0].ToString() + Environment.NewLine;

            
            
            for (int i = 1; i < TargetWords_lstBx.SelectedItems.Count; i++)
            {
                foreach (var item in w.targetList[TargetWords_lstBx.SelectedItems[i].ToString()])
                {
                    w.targetList[TargetWords_lstBx.SelectedItems[0].ToString()].Add(item);
                }
                
            }

            for (int i = 1; i < TargetWords_lstBx.SelectedItems.Count; i++)
            {
                 w.targetList.Remove(TargetWords_lstBx.SelectedItems[i].ToString());
            }

            w.targetList[TargetWords_lstBx.SelectedItems[0].ToString()].Distinct();

            TargetWords_lstBx.Items.Clear();
            foreach (var item in w.targetList.Keys)
            {
                TargetWords_lstBx.Items.Add(item);
            }

            //foreach (var item in w.targetList[TargetWords_lstBx.SelectedItems[0].ToString()])
            //{
            //    test += item + Environment.NewLine;
            //}
            //MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string test = "";
            foreach (var item in w.targetList)
            {
                test += item.Key + "---->";
                foreach (var word in item.Value)
                {
                    List<int> pages = PDF.ReadPdfFile(pathToBook_txtBx.Text, word);
                    foreach (var p in pages)
                    {
                        test += p.ToString() + " ";
                    }
                }
                test += Environment.NewLine;
            }

            MessageBox.Show(test);
        }
    }
}
