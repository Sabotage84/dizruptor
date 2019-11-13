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
        List<string> targetWordsChose = new List<string>();

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
           
            w.GetAllWordsFromPDF(pathToBook_txtBx.Text);

            var pdfWords = w.GetWordsFreq();

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
            string res = "";
            string mainWord = "";
            string innerWords = "";
            string shortPages = "";
            string allPages = "";
            List<int> pages = new List<int>();
            foreach (var item in w.targetList)
            {
                mainWord = item.Key;

                foreach (var word in item.Value)
                {
                    innerWords += word + " ";
                    pages.AddRange( w.allWordsDic[word]);
                    
                }

                pages.Sort();

                for (int i = 0; i < pages.Count; i++)
                {
                    if (i == 0)
                    {
                        shortPages += pages[i];
                    }
                    else if (pages[i] == pages[i - 1])
                    {

                    }
                    else if (pages[i] == pages[i - 1] + 1)
                    {
                        shortPages += " -";
                    }
                    else
                    {
                        if (shortPages[shortPages.Length - 1] == '-')
                        {
                            shortPages += " " + pages[i - 1] + " " + pages[i];
                        }
                        else
                            shortPages += " " + pages[i] + " ";
                    }

                    allPages += pages[i] + " ";
                }

                res += mainWord + " (" + innerWords + ") " + shortPages + " (" + allPages + ")" + Environment.NewLine;

                pages.Clear();
            }

            MessageBox.Show(res);
        }

        private void TargetWords_lstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInnerList();
        }

        private void removeWord_btn_Click(object sender, EventArgs e)
        {
            if (innerWords_lstbx.SelectedItem==null)
                MessageBox.Show("Выберите слово для удаления!");
            else
            {
                foreach (var item in targetWordsChose)
                {
                    if (w.targetList.ContainsKey(item))
                    {
                        if (w.targetList[item].Contains(innerWords_lstbx.SelectedItem.ToString()))
                        {
                            w.targetList[item].Remove(innerWords_lstbx.SelectedItem.ToString());

                        }
                        if (w.targetList[item].Count == 0)
                        {
                            w.targetList.Remove(item);
                            RefreshTargetList();
                        }
                    }
                }
                RefreshInnerList();

            }
        }

        private void RefreshTargetList()
        {
            TargetWords_lstBx.Items.Clear();
            foreach (var item in w.targetList.Keys)
            {
                TargetWords_lstBx.Items.Add(item);
            }
        }

        private void RefreshInnerList()
        {
            innerWords_lstbx.Items.Clear();
            targetWordsChose.Clear();
            foreach (var item in TargetWords_lstBx.SelectedItems)
            {
                targetWordsChose.Add(item.ToString());
                foreach (var word in w.targetList[item.ToString()])
                {

                    innerWords_lstbx.Items.Add(word);
                }
            }
        }
    }
}
