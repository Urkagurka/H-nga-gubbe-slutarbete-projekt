using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hänga_gubbe_slutarbete_projekt
{
    internal class Spel
    {


        private string hemliga_ordet = string.Empty;

        private HashSet<char> gissade_bokstäver = new HashSet<char>();

        private string spel_ordet = string.Empty;

        private bool vinst = false;

        private int gissningarkvar = 10;

        public Spel(string hemlig_tord) 
        {
            hemliga_ordet = hemlig_tord;
            uppdatera_spelordet();
        }

        public string getSpelOrdet() 
        { 
            return spel_ordet; 
        }

        public bool getOrdetLöst()
        {
            return vinst;
        }

        public int getgissnigarkvar()
        {
            return gissningarkvar;
        }

        public string getgissade_bokstäver()
        {
            string qwertyu = string.Empty;

            foreach (char c in gissade_bokstäver)
            {
                if (finns_bokstav(c) == false )
                {
                    qwertyu += c;
                }
            }
            return qwertyu;
        }

        public void gissa(char bokstav)
        {
            gissade_bokstäver.Add(bokstav);


            if (finns_bokstav(bokstav))
            {
                uppdatera_spelordet();

                gissade_rätt(bokstav);
            }
            else
            {
                gissade_fel(bokstav);

                gissningarkvar--;
            }
        }

        private bool finns_bokstav(char bokstav)
        {
            return hemliga_ordet.Contains(bokstav);
        }

        private void gissade_rätt(char bokstav)
        {

        }

        private void gissade_fel(char bokstav)
        {

        }

        private void uppdatera_spelordet()
        {
            vinst = true;

            spel_ordet = string.Empty;
            foreach(char b in hemliga_ordet)
            {
                if (gissade_bokstäver.Contains(b))
                {
                    spel_ordet += b;
                }
                else
                {
                    spel_ordet += '_';
                    vinst = false;
                }
            }



        }


    }
}
