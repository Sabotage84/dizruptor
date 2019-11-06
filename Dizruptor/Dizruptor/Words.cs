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
	    public SortedList<string, List<string>> targetList= new SortedList<string, List<string>>();

        Words()
        {
            allWordsDic = new SortedDictionary<string, int>();
            string[] Mass = File.ReadAllLines(@"simpleWords.txt");
            foreach (var item in Mass)
            {
                AddBadWord(item);
            }
        }

        public SortedDictionary<string,int> FilterAllWords(SortedDictionary<string,int> allWords )
        {


            SortedDictionary<string, int> res = new SortedDictionary<string, int>();
            foreach (var item in allWords)
            {
                if (!badWords.ContainsKey(item.Key))
                    res.Add(item.Key, item.Value);
            }

            return res;
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
