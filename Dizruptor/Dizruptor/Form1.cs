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
        public Form1()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            FileToWords fw = new FileToWords();
            fw.ReadTXTFile(@"C:/test.txt");
            Words w = fw.GetStatistic();
            foreach (var item in w.allWordsDic)
            {
                allWords_lstbx.Items.Add(item.Key+" ------>>> "+item.Value);
            }
        }
    }
}
