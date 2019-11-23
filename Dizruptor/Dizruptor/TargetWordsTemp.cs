using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dizruptor
{
    [Serializable]
    public class TargetWordsTemp
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public List<string> val = new List<string>();

        
        public TargetWordsTemp(string name, List<string> val)
        {
            this.name = name;
            this.val = val;
        }
        public TargetWordsTemp()
        {

        }
    }
}
