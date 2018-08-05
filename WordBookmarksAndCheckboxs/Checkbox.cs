using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordBookmarksAndCheckboxs
{
    public static class Checkbox
    {
        public static List<string> GetTextofCheckbox(WordprocessingDocument doc)
        {
            List<SdtContentCheckBox> listOfCheckedBoxs = GetListOfCheckedBoxs(doc);

            if (doc == null)
            {
                Console.WriteLine($"Cannot find a document");
            }

            if(listOfCheckedBoxs == null )
            {
                Console.WriteLine($"Your document doesn't contians checkboxs");
            }

            List<string> textOfChecedbox = new List<string>();

            foreach(SdtContentCheckBox cb in listOfCheckedBoxs)
            {
                var paragraph = cb.Ancestors<Paragraph>().First();
                var textContent = paragraph.Descendants<Text>().Skip(1).First().InnerText;
                textOfChecedbox.Add(textContent);
            }

            Dictionary<SdtContentCheckBox, string> checkedBoxs = new Dictionary<SdtContentCheckBox, string>();

            return textOfChecedbox;
        }

        public static List<SdtContentCheckBox> GetListOfCheckedBoxs(WordprocessingDocument doc)
        {
            if (doc == null)
            {
                Console.WriteLine($"Cannot find a document");
            }

            List<SdtContentCheckBox> listOfCheckedBoxs = new List<SdtContentCheckBox>();

            IEnumerable<SdtContentCheckBox> boxs = doc.MainDocumentPart.Document.Body.Descendants<SdtContentCheckBox>();
            foreach (SdtContentCheckBox cb in boxs)
            {
                if (cb.Checked.Val == "1")
                {
                    listOfCheckedBoxs.Add(cb);
                }
            }
            return listOfCheckedBoxs;
        }

        public static void PrintCheckboxStateAndName(WordprocessingDocument doc)
        {
            List<string> textOfChecedbox = GetTextofCheckbox(doc);
            foreach(string text in textOfChecedbox)
            {
                Console.WriteLine(text);
            }
        }
    }
}
