using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANDS_NAM
{
    public class Band
    {
        public string Name;
        public int Musicians;
        public void Announce()
        {
            Console.WriteLine("Welcome " + Name + " to the stage!");
        }
    }

    

        public class Venue
            {
                public string Name;
                public Band[] Bands = new Band[2];

                public void AddBand(string name)
                {
                    Band band = new Band();
                    band.Name = name;
                    Bands[0] = band;
                }

                public void Announce()
                {
                    Console.WriteLine(Name + " will have several bands playing tonight!");
                }
    }
 

        public class Venue1
    {
        public string Name;
        public List<Band> Bands = new List<Band>();

        public void AddBand(string name)
        {
            Band band = new Band();
            band.Name = name;
            Bands.Add(band);
        }
        public void AddBand(string[] names)
        {
            foreach (var name in names)
            {
                AddBand(name);
            }
        }
        public void Announce()
        {
            Console.WriteLine(Name + " will have several bands playing tonight!");
            foreach (var band in Bands)
            {
                band.Announce();
            }
        }
        
    }


}
