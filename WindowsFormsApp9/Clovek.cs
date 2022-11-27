using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        public void Vypis_jmeno()
        {
            MessageBox.Show("jmeno je " + T_jmeno);
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
                MessageBox.Show(T_jmeno + " je stary " + roky.Days/365.25 + " let a je plnolety");
                return null;
            }
            else
            {
                MessageBox.Show(T_jmeno + " je stary" + roky.Days/365.25 + " let a neni plnolety");
                return null;
            }
        }

        public void Starsi(string jmeno2, DateTime roky2)
        {
            if (T_narozen < roky2)
            {
                MessageBox.Show(T_jmeno + " je starsi");
            }
            else if (T_narozen == roky2)
            {
                MessageBox.Show("Oba jsou stejne stari");
            }
            else
            {
                MessageBox.Show(jmeno2 + " je starsi typek");
            }
        }
    }
}
