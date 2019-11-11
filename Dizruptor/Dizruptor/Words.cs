using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Dizruptor
{
    class Words
    {
        private static readonly Words instance = new Words();
        public SortedDictionary<string, List<int>> allWordsDic;
        public SortedList<string, int> badWords= new SortedList<string, int>();
	    public SortedList<string, List<string>> targetList= new SortedList<string, List<string>>();

        Words()
        {
            allWordsDic = new SortedDictionary<string, List<int>>();
            string[] Mass = File.ReadAllLines(@"simpleWords.txt");
            foreach (var item in Mass)
            {
                AddBadWord(item);
            }
        }

        public void GetAllWordsFromPDF(string pdfFileName)
        {
            WorkWithPDF pdf = new WorkWithPDF();
            allWordsDic = pdf.ExtractAllWordsFromPDF(pdfFileName);
        }
        
        public SortedDictionary<string,int> GetWordsFreq()
        {


            SortedDictionary<string, int> res = new SortedDictionary<string, int>();
            foreach (var item in allWordsDic)
            {
                if (!badWords.ContainsKey(item.Key))
                    res.Add(item.Key, item.Value.Count);
            }

            return res;
        }


        

        public static Words GetInstance()
        {
           
            return instance;
        }

        public void AddBadWord(string w)
        {
            if (!badWords.ContainsKey(w))
                badWords.Add(w, 1);
        }

        public void SaveBadWords()
        {
            string temp = "";
            foreach (var item in badWords.Keys)
            {
                temp += item + Environment.NewLine;
            }
            File.WriteAllText(@"simpleWords.txt", temp);
        }


    }
}
