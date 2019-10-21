using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizruptor
{
    class FileToWords
    {
        string[] lines;
        List<string> words;
        public void ReadTXTFile(string path)
        {
            lines = File.ReadAllLines(path, Encoding.GetEncoding(1251));
        }

        void LinesToWords()
        {
            words = new List<string>();
            foreach (var item in lines)
            {
                var t = item.Split(' ', ',', '.', ':', '-', '!', '@', '#', ';', '*', '<', '>', '?', '|', '{', '}', '[', ']', '(', ')', '%');
                foreach (var w in t)
                {
                    words.Add(w);
                }
            }
        }

        public Words GetStatistic()
        {
            Words w = new Words();
            LinesToWords();
            foreach (var item in words)
            {
                w.AddCurrentWord(item);
            }

            return w;
        }
    }
}
