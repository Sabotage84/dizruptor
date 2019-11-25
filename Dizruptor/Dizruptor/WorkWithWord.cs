using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dizruptor
{
    class WorkWithWord
    {
        
        Object missing = Type.Missing;
        Object fileName;

        public void SetPath(string path)
        {
            fileName = path;
        }

        public void OpenWordFile()
        {
            
        }

        public bool FindString(string str)
        {
            return true;
            //Find find = wordFile.Selection.Find;
            //find.Text = str;
            //find.Replacement.Text = "два";
            //Object wrap = Word.WdFindWrap.wdFindContinue;
            //Object replace = Word.WdReplace.wdReplaceAll;
            //return find.Execute(FindText: Type.Missing,
            //            MatchCase: false,
            //            MatchWholeWord: false,
            //            MatchWildcards: false,
            //            MatchSoundsLike: missing,
            //            MatchAllWordForms: false,
            //            Forward: true,
            //            Wrap: missing,
            //            Format: false,
            //            ReplaceWith: missing, Replace: missing);

        }

        public List<int> FindPage(string str)
        {
            List<int> res = new List<int>();
            //Range range = wordFile.ActiveDocument.Content;
            //Find find = range.Find;
            //find.Text = "один";
            //find.ClearFormatting();
            //range.Find.Execute(
            //        ref missing, ref missing, ref missing, ref missing, ref missing,
            //        ref missing, ref missing, ref missing, ref missing, ref missing,
            //        ref missing, ref missing, ref missing, ref missing, ref missing);


            //while (range.Find.Found)
            //{
            //    //Get selected index.
            //    // Do as you please with range...
            //    //res.Add( (int)range.get_Information(WdInformation.wdActiveEndPageNumber));
                
            //    //Positions:  range.Start... range.End
                
                
                
            //    //search again
            //    range.Find.Execute(
            //       ref missing, ref missing, ref missing, ref missing, ref missing,
            //       ref missing, ref missing, ref missing, ref missing, ref missing,
            //       ref missing, ref missing, ref missing, ref missing, ref missing);
            //}


            return res;
        }

        public void CloseAndQuit()
        {
            //wordFile.ActiveDocument.Close();
            //wordFile.Quit();      
        }

        
        
        
        
        
        
       
        
        

    }
}
