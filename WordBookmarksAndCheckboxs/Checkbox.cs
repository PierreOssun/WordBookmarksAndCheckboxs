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
    static class Checkbox
    {
        public static void AddCheckBox()
        {

        }

        public static Dictionary<SdtContentCheckBox, string> CheckboxState(WordprocessingDocument doc, SdtContentCheckBox checkBox)
        {
            Dictionary<SdtContentCheckBox, string> result = new Dictionary<SdtContentCheckBox, string>();
            return result;
        }

        public static void PrintCheckboxStateAndName()
        {

        }
    }
}
