﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Dizruptor
{
    public partial class Form1 : Form
    {
        Words w = Words.GetInstance();
        WorkWithPDF PDF = new WorkWithPDF();
        List<string> targetWordsChose = new List<string>();
        //IOrderedEnumerable<KeyValuePair<string, int>> tempList;
        IEnumerable<KeyValuePair<string, int>> tempList;
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

            w.GetWordsFreq();
            tempList = w.WordsWithOUTBad;
            foreach (var item in w.WordsWithOUTBad)
            {
                allWords_lstbx.Items.Add(item.Key + " ------>>> " + item.Value);
            }
            allWords_grpBx.Enabled = true;
        }

        private void ToBadWords_btn_Click(object sender, EventArgs e)
        {
            FromAllToSimple();
        }

        private void FromAllToSimple()
        {
            string[] temp = allWords_lstbx.SelectedItem.ToString().Split(' ');
            badWords_lstBx.Items.Add(temp[0]);
            w.AddBadWord(temp[0]);
            w.WordsWithOUTBad.Remove(temp[0]);
            RefreshAllWordsLSTBX();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Words w = Words.GetInstance();
            w.SaveBadWords();
        }

        private void findFile_btn_Click(object sender, EventArgs e)
        {
            book_fd.ShowDialog();
            pathToBook_txtBx.Text = book_fd.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void ToTarget_btn_Click(object sender, EventArgs e)
        {
            FromAllToTrget();

        }

        private void FromAllToTrget()
        {
            string s = allWords_lstbx.SelectedItem.ToString();
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

            w.WordsWithOUTBad.Remove(v[0]);
            RefreshAllWordsLSTBX();
        }

        private void RefreshAllWordsLSTBX()
        {
            SortAllWordListByName();
        }

        private void SortAllWordListByName()
        {
            allWords_lstbx.Items.Clear();
            tempList = tempList.OrderBy(t => t.Key);
            foreach (var item in tempList)
            {
                allWords_lstbx.Items.Add(item.Key + " ------>>> " + item.Value);
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
                    pages.AddRange(w.allWordsDic[word]);

                }

                pages.Sort();
                pages = pages.Select(it => it+=(int)pageSatart_nmUD.Value).ToList();

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
                mainWord = "";
                innerWords = "";
                shortPages = "";
                allPages = "";

            }

            using (StreamWriter w = new StreamWriter("result.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine(res);
            }
        }

        private void TargetWords_lstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInnerList();
        }

        private void removeWord_btn_Click(object sender, EventArgs e)
        {
            if (innerWords_lstbx.SelectedItem == null)
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

        private void targetLoad_btn_Click(object sender, EventArgs e)
        {
            targetLoadFile_FD.ShowDialog();
            targetListLoad_txtBx.Text = targetLoadFile_FD.FileName;
        }

        private void targetLoadWords_btn_Click(object sender, EventArgs e)
        {
            if (targetListLoad_txtBx.Text.EndsWith("xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(TargetWordsTemp[]),
                                 new XmlRootAttribute() { ElementName = "TargetItems" });
                using (FileStream fs = new FileStream(targetListLoad_txtBx.Text, FileMode.OpenOrCreate))
                {
                    var t = (TargetWordsTemp[])formatter.Deserialize(fs);
                    w.targetList.Clear();
                    foreach (var item in t)
                    {
                        w.targetList.Add(item.name, item.val);
                    }
                }
                RefreshTargetList();
            }
            else if (targetListLoad_txtBx.Text.EndsWith("txt"))
            {
                string line;
                w.targetList.Clear();
                using (StreamReader file = new StreamReader(targetListLoad_txtBx.Text))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        w.targetList.Add(line, new List<string>());
                        w.targetList[line].Add(line);
                    }
                }
                RefreshTargetList();
            }
        }

        private void saveTargetToXML_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(TargetWordsTemp[]),
                                 new XmlRootAttribute() { ElementName = "TargetItems" });

            using (FileStream fs = new FileStream("targetWords.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, w.targetList.Select(kv => new TargetWordsTemp(kv.Key, kv.Value)).ToArray());
            }


        }

        private void allWordsSortByCount_rdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void allWordsSortByName_rdBtn_Click(object sender, EventArgs e)
        {
            RefreshAllWordsLSTBX();
        }

        private void allWordsSortByCount_rdBtn_Click(object sender, EventArgs e)
        {
            SortAllWordsListByCount();
        }

        private void SortAllWordsListByCount()
        {
            tempList = tempList.OrderBy(t => t.Value);
            allWords_lstbx.Items.Clear();
            foreach (var item in tempList)
            {
                allWords_lstbx.Items.Add(item.Key + " ------>>> " + item.Value);
            }
        }

        private void allWordsSortByLength_rdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void allWordsSortByLength_rdBtn_Click(object sender, EventArgs e)
        {
            SortAllWordsListByLenthg();
        }

        private void SortAllWordsListByLenthg()
        {
            tempList = tempList.OrderBy(t => t.Key.Length);
            allWords_lstbx.Items.Clear();
            foreach (var item in tempList)
            {
                allWords_lstbx.Items.Add(item.Key + " ------>>> " + item.Value);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 't' || e.KeyChar == 'T' || e.KeyChar == 'н' || e.KeyChar == 'Н')
            {
                FromAllToTrget();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var k = Keys.Z | Keys.Control;
            if (e.KeyCode == k)
            {
                FromAllToTrget();
            }
        }

        private void allWords_lstbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Control)
            {
                FromAllToTrget();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                FromAllToSimple();
                e.Handled = true;
            }
        }

        private void withOutCuntOne_chkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (withOutCuntOne_chkBx.Checked)
            {
                allWords_lstbx.Items.Clear();
                tempList = tempList.Where(t=>t.Value>1);
                
                foreach (var item in tempList)
                {
                    allWords_lstbx.Items.Add(item.Key + " ------>>> " + item.Value);
                }
            }
            else
            {
                allWords_lstbx.Items.Clear();
                tempList = w.WordsWithOUTBad;
                if(allWordsSortByCount_rdBtn.Checked)
                {
                    SortAllWordsListByCount();
                }
                else if (allWordsSortByLength_rdBtn.Checked)
                {
                    SortAllWordsListByLenthg();
                }
                else
                {
                    SortAllWordListByName();
                }

               
            }
        }
    }
}
