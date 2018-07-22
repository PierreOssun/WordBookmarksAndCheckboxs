using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;

namespace WordBookmarksAndCheckboxs
{
    class Program
    {
        static void Main(string[] args)
        {
            WordprocessingDocument doc = WordDocument.OpenDocument();
            Bookmark.GetBookmarksChildElement(doc);
        }
    }
}
