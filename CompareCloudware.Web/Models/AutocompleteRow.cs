using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace CompareCloudware.Web.Models
{
    public class AutocompleteRow
    {
        public string category { get; set; }
        public string label { get; set; }  // autocomplete plugin uses it
        public string labelShort { get; set; } 
        public string value { get; set; }  // autocomplete plugin uses it
        public int? vendorID { get; set; }
        public string labelAsURL { get; set; } 

        public TagModel tagModel { get; set; }

        public int setLabelShort(int ind) {
            int maxChars = 22;
            int wc = 0;
            labelShort = label;
            if (labelShort != null)
            {
                if (labelShort.Length > maxChars)
                {
                    string str;
                    int i = ind;
                    string[] arr = Regex.Split(labelShort, @"[ \t]+");
                    wc = arr.Length;
                    do
                    {
                        arr[i] = (arr[i].Length > 1) ? arr[i][0] + "." : arr[i];
                        str = string.Join(" ", arr);
                        i++;
                    } while (i < arr.Length && str.Length > maxChars);
                    labelShort = str.Replace(". ", ".");
                }
            }
            return wc;
        }

        static public void SetLabelShortToRows(List<AutocompleteRow> list) {
            for (int i=0; i < list.Count; i++) {
                AutocompleteRow row = list[i];
                int wc; 
                int ind = 0;
                do {
                    wc = row.setLabelShort(ind);
                }  while(++ind < wc && list.FindIndex(r => r.labelShort == row.labelShort) < i);
                if (ind >= wc)
                    row.labelShort = row.label; // leave unmodified
                    row.labelAsURL = row.label.ToLower().Replace(" ","-"); // leave unmodified
            }
        }
    }



    public class AutocompleteRowEx
    {
        public int Id { get; set; }
        public bool IsBrand { get; set; }
        public bool IsCategory { get; set; }
        public bool IsProduct { get; set; }
        public bool IsFreeTextSearch { get; set; }
        public bool isFirstLevel { get; set; }
        public int parentIndex { get; set; }
    }

}