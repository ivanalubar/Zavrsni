using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    public class Subject
    {
        private string _nm;
        private string _lection;
        private string _test;

        public string Nm
        {
            get
            {
                return _nm;
            }

            set
            {
                _nm = value;
            }
        }

        public string Lection
        {
            get
            {
                return _lection;
            }

            set
            {
                _lection = value;
            }
        }

        public string Test
        {
            get
            {
                return _test;
            }

            set
            {
                _test = value;
            }
        }
        public Subject(string n, string l, string t)
        {
            this.Nm = n;
            this.Lection = l;
            this.Test = t;
        }
    }
}
