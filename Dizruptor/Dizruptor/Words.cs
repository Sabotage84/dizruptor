using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizruptor
{
    class Words
    {
        public Dictionary<string, int> allWordsDic;

        public Words()
        {
            allWordsDic = new Dictionary<string, int>();
        }

        public void AddCurrentWord(string w)
        {
            if (allWordsDic.ContainsKey(w))
                allWordsDic[w]++;
            else
                allWordsDic.Add(w, 1);
        }

    }
}
