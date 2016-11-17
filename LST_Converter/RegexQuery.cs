using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LST_Converter
{
    public sealed class RegexQuery
    {
        private static readonly Lazy<RegexQuery> lazy = new Lazy<RegexQuery>(() => new RegexQuery());

        public static RegexQuery Instance
        {
            get { return lazy.Value; }
        }

        private RegexQuery()
        {
        }

        public Match hrsz { get; private set; }
        public Match blokkStart { get; private set; }
        public Match coord { get; private set; }
        public Match blokkEnd { get; private set; }
        public Match endRead { get; private set; }

        public void searchWithRegex(string _line)
        {
            hrsz = Regex.Match(_line, @"^[0-9]+\/?[0-9]+");
            blokkStart = Regex.Match(_line, @"^\*(?!\*)");
            coord = Regex.Match(_line, @"[0-9]+\.[0-9]+\t[0-9]+\.[0-9]+");
            blokkEnd = Regex.Match(_line, @"^\*{2}-+");
            endRead = Regex.Match(_line, @"\*{3}");
        }
    }
}
