using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordBookmarksAndCheckboxs
{
    static class Bookmark
    {
        public static void GetBookmarksChildElement(WordprocessingDocument doc)
        {
            List<string> list = new List<string>();
            var body = doc.MainDocumentPart.Document.Body;
            var bookmarks = doc.MainDocumentPart.Document.Body.Descendants<BookmarkStart>();
            IEnumerable<SdtContentCheckBox> boxs = doc.MainDocumentPart.Document.Body.Descendants<SdtContentCheckBox>();
            foreach (SdtContentCheckBox cb in boxs)
            {
                var bookmarkStart = body.Descendants<BookmarkStart>().Where(b => b.Ancestors<SdtContentCheckBox>() == cb );
                list.Add(bookmarkStart.First().Name);
            }
            //foreach (BookmarkStart bookmark in bookmarks)
            //{
            //    if (!bookmark.Name.ToString().StartsWith("_"))
            //    {
            //        //var checkBox = doc.MainDocumentPart.Document.Body.Descendants<SdtContentCheckBox>().Where(c => c.);
            //    }
            //}
        }

        public static void GetBookmarkStartId()
        {

        }

        public static void GetBookmarkEndId()
        {

        }
    }
}
