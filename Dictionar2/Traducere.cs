using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionar2
{
    [Serializable]
    public class Traducere
    {
        string cuvNecunoscut;
        public string CuvNecunoscut
        {
            get { return cuvNecunoscut; }
            set
            {
                if (value.Length > 0)
                    this.cuvNecunoscut = value;
                else
                    throw new Exception("Sir vid pentru cuvantul necunoscut!");
            }
        }

        public string CuvTradus { get; set; }
        public string Definitie { get; set; }

        public Traducere(string c = "N/A", string t="N/A", string d = "N/A")
        {
            cuvNecunoscut = c; CuvTradus = t; Definitie = d;
        }
        public override string ToString()
        {
            return "Cuvantul necunoscut: " + cuvNecunoscut + " Traducere: " + CuvTradus + " Definitie: " + Definitie;
        }
    }
}
