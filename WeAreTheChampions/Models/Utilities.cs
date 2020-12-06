using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public static class Utilities
    {
        public static string UpperCaseFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
        }
    }
}
