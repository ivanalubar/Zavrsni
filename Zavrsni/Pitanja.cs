using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    public class Pitanja
    {
        private string _pitanje;
        private string _tocanOdgovor;
        private List<string> _odgovori;
        public string Pitanje
        {
            get { return _pitanje; }
            set { _pitanje = value; }
        }
        public string TocanOdgovor
        {
            get { return _tocanOdgovor; }
            set { _tocanOdgovor = value; }
        }
        public List<string> Odgovori
        {
            get { return _odgovori; }
            set { _odgovori = value; }
        }
        public  Pitanja(string p, string to, List<string> od)
        {
            this.Pitanje = p;
            this.Odgovori = od;
            this.TocanOdgovor = to;
        }
    }
}
