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
