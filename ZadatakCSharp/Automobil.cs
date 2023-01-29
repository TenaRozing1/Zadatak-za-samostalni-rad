using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakCSharp
{
    internal class Automobil
    {
  
        public delegate void NaPromjenuGodineProizvodnjeDelegat(object sender, EventArgs e);
        public event NaPromjenuGodineProizvodnjeDelegat NaPromjenuGodineProizvodnje;
        private string naziv;
        private int godinaProizvodnje;
        private double osnovnaCijena;

    
        public string Naziv { get => naziv; set => naziv = value; }
        public int GodinaProizvodnje
        {
            get { return godinaProizvodnje; }
            set
            {
                godinaProizvodnje = value;
                if (NaPromjenuGodineProizvodnje != null)
                {
                    NaPromjenuGodineProizvodnje(this, new EventArgs());
                }
            }

        }
        public double OsnovnaCijena { get => osnovnaCijena; set => osnovnaCijena = value; }

        #region Metode
        public int Starost()
        {
            DateTime trenutniDatum = DateTime.Now;
            int trenutnaGodina = int.Parse(trenutniDatum.Year.ToString());

            return (trenutnaGodina - GodinaProizvodnje);
        }

        public string UkupnaCijena()
        {
            if (OsnovnaCijena <= 70000)
            {
                return "Ukupna cijena: " + OsnovnaCijena * 1.3;
            }
            else if (OsnovnaCijena > 70000 && OsnovnaCijena < 100000)
            {
                return "Ukupna cijena: " + OsnovnaCijena * 1.4;
            }
            else
            {
                return "Ukupna cijena: " + OsnovnaCijena * 1.5;
            }
        }

        #endregion
    }
}