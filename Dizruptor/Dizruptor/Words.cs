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
        public SortedDictionary<string, int> allWordsDic;
        public SortedList<string, int> badWords= new SortedList<string, int>();

        Words()
        {
            allWordsDic = new SortedDictionary<string, int>();
            string[] Mass = File.ReadAllLines(@"simpleWords.txt");
            foreach (var item in Mass)
            {
                AddBadWord(item);
            }
        }

        public void AddCurrentWord(string w)
        {
            if (!badWords.ContainsKey(w))
            {
                if (allWordsDic.ContainsKey(w))
                    allWordsDic[w]++;
                else
                    allWordsDic.Add(w, 1);
            }
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
