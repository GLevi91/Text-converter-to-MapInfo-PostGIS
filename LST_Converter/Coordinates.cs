using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LST_Converter
{
    public sealed class Coordinates
    {
        private static readonly Lazy<Coordinates> lazy = new Lazy<Coordinates>(() => new Coordinates());

        public static Coordinates Instance
        {
            get { return lazy.Value; }
        }

        private Coordinates()
        {
        }

        public int index { get; set; }
        private string[] coords { get; set; }
        public string xCoord { get; private set; }
        public string yCoord { get; private set; }
        public string spacing { get; private set; }
        public StringBuilder hrszBuilder { get; set; } = new StringBuilder();
        public StringBuilder coordBuilder { get; set; } = new StringBuilder();
        public string finalHrszString { get; set; }
        public string finalCoordString { get; set; }

        public void getCoordinates(Match _coord)
        {
            index++;

            coords = _coord.Value.Split('\t');
            xCoord = coords[0].Substring(0, 9).TrimEnd('0', '.');
            yCoord = coords[1].TrimEnd('0', '.');
            var yCoordRound = Math.Round(Double.Parse(yCoord, CultureInfo.InvariantCulture), 1, MidpointRounding.AwayFromZero);
            yCoord = Convert.ToString(yCoordRound);
            yCoord = yCoord.Replace(',', '.').TrimEnd('0', '.');

            if (xCoord.Length == 9)
            {
                spacing = "     ";
            }

            else if (xCoord.Length == 8)
            {
                spacing = "      ";
            }

            else
            {
                spacing = "        ";
            }
        }
    }
}
