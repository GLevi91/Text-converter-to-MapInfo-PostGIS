using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LST_Converter
{
    public sealed class Lists
    {
        private static readonly Lazy<Lists> lazy = new Lazy<Lists>(() => new Lists());

        public static Lists Instance
        {
            get { return lazy.Value; }
        }

        private Lists()
        {
        }

        public IEnumerable<string> allLines { get; set; }
        public List<string> hrszList { get; set; } = new List<string>();
        public List<string> coordList { get; set; } = new List<string>();
    }
}
