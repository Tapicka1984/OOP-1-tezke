using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp9
{
    class Clovek
    {
        private string T_jmeno;
        DateTime T_narozen;

        public Clovek(string jmeno, DateTime roky)
        {
            this.T_jmeno = jmeno;
            this.T_narozen = roky;
        }

        public string Vypis_jmeno()
        {
            return ("jmeno je " + T_jmeno);
        }

        TimeSpan Vek()
        {
            TimeSpan vek = DateTime.Now - T_narozen;
            return vek;
        }

        bool Plnolety()
        {
            TimeSpan vek = Vek();
            if(vek.Days/365.25 >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            bool ano_ne = Plnolety();
            DateTime ted = DateTime.Now;
            TimeSpan roky = ted - T_narozen;
            if (ano_ne == true)
            {
                return (T_jmeno + " je stary " + roky.Days/365.25 + " let a je plnolety");
            }
            else
            {
                return (T_jmeno + " je stary" + roky.Days / 365.25 + " let a neni plnolety");
            }
        }

        public string Starsi(string jmeno2, DateTime roky2)
        {
            jmeno2 = "Ahmed";
            if (T_narozen < roky2)
            {
                return (T_jmeno + " je starsi");
            }
            else if (T_narozen == roky2)
            {
                return ("Oba jsou stejne stari");
            }
            else
            {
                return (jmeno2 + " je starsi typek");
            }
        }
    }
}
