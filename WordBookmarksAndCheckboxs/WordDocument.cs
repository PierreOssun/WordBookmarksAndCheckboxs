using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordBookmarksAndCheckboxs
{
    static class WordDocument
    {
        public static WordprocessingDocument OpenDocument()
        {
            WordprocessingDocument doc = WordprocessingDocument.Open("C:\\Users\\SDX\\Source\\Repos\\WordBookmarksAndCheckboxs\\WordBookmarksAndCheckboxs\\Doc1.docx", true);
            return doc;
        }
    }
}
