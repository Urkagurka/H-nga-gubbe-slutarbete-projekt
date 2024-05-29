using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hänga_gubbe_slutarbete_projekt
{
    internal class OrdLista
    {
        List<string> Ord;
        public OrdLista()
        {
            Ord = new List<string>();
            Ord.Add("HÖGTALARE");
            Ord.Add("PROGRAMMERING");
            Ord.Add("DATOR");
            Ord.Add("TANDBORSTE");
            Ord.Add("MOTORVÄRMARE");
            Ord.Add("HÄNGMATTA");
            Ord.Add("KLOCKA");
            Ord.Add("SLUTPROJEKT");
            Ord.Add("UNGDOMSANSTALT");
            Ord.Add("VARMKORV");
            Ord.Add("HYPERNERVOKUSTISKADIAFRAGMAKONTRAVIBRATIONER");
            Ord.Add("AVKOMLINGSELEKTOR");
            Ord.Add("GRÄSHOPPA");
            Ord.Add("TVÄTTMASKIN");
            Ord.Add("DAMMSUGARE");
            Ord.Add("STEKPANNA");
            Ord.Add("TERIYAKISÅS");
            Ord.Add("MIKROVÅGSUGN");
            Ord.Add("KONSERVBURK");
            Ord.Add("OPPENHEIMER");
        }
        public string getOrd()
        {
            Random slumptal = new Random();
            int Ordnummer = slumptal.Next(0, Ord.Count-1);



            return Ord[Ordnummer].ToUpper();
        }

        public void nyttORd(string nytord)
        {
            Ord.Add(nytord);
        }

    }
}
