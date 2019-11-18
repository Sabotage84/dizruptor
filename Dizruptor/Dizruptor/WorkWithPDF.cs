using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizruptor
{
    class WorkWithPDF
    {
        public List<int> ReadPdfFile(string fileName, String searthText)
        {
            List<int> pages = new List<int>();
            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);
                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

                    string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
                    if (currentPageText.Contains(searthText))
                    {
                        pages.Add(page);
                    }
                }
                pdfReader.Close();
            }
            return pages;
        }

        public SortedDictionary<string, List<int>> ExtractAllWordsFromPDF(string fileName)
        {
            SortedDictionary<string, List<int>> res = new SortedDictionary<string, List<int>>();
            List<int> pages = new List<int>();
            if (File.Exists(fileName))
            {
                string firstPrefficks = "";
                bool flag = false;
                PdfReader pdfReader = new PdfReader(fileName);
                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();


                    int per = 173;
                    char p = (char)per;



                    string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
                    
                    
                    int numberOfPage = 0;
                    for (int i = currentPageText.Length - 1; i >= 0; i--)
                    {
                        int r;
                        if (int.TryParse(currentPageText[i].ToString(), out r))
                        {
                            numberOfPage++;
                        }
                        else
                            break;
                    }
                    currentPageText = currentPageText.Substring(0, currentPageText.Length - numberOfPage);
                    if (currentPageText.EndsWith("-\n"))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                    currentPageText = currentPageText.Replace(p.ToString() + "\n", "");
                    



                    var t1 = currentPageText.Split(' ', ',', '.', ':', '-', '!', '@', '#', ';', '*', '<', '>', '?', '|', '{', '}', '[', ']', '(', ')', '%', '\t', '&', '/', '«', '»', '–', '\n');
                    List<string> t= t1.ToList();
                    t.RemoveAll(string.IsNullOrEmpty);

                    string tempPrefix = firstPrefficks;

                    if (flag)
                    {

                        firstPrefficks = t.Last();
                       
                    }
                    else
                        firstPrefficks = string.Empty;

                    if ((!string.IsNullOrEmpty(tempPrefix)) && t.Count > 1)
                            t.Add(tempPrefix + t.First());
                    
                    int s = 0;
                    foreach (var w in t)
                    {
                        if (!int.TryParse(w, out s))
                        {

                            if (res.ContainsKey(w.ToLower()))
                                res[w.ToLower()].Add(page);
                            else
                            {
                                res.Add(w.ToLower(), new List<int>());
                                res[w.ToLower()].Add(page);
                            }
                        }
                    }

                }
                pdfReader.Close();
            }
            return res;
        }

        public SortedDictionary<string, int> ReadAllPDF(string fileName)
        {
            SortedDictionary<string, int> res = new SortedDictionary<string, int>();
            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);
                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

                    string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
                    var t = currentPageText.Split(' ', ',', '.', ':', '-', '!', '@', '#', ';', '*', '<', '>', '?', '|', '{', '}', '[', ']', '(', ')', '%', '\t', '&', '/', '«', '»', '–', '\n');
                    int s = 0;
                    foreach (var w in t)
                    {
                        if (!int.TryParse(w, out s))
                        {
                            if (res.ContainsKey(w))
                                res[w]++;
                            else
                            {
                                res.Add(w, 1);
                            }
                        }
                    }
                }
                pdfReader.Close();
            }
            return res;
        }
    }
}
