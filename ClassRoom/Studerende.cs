using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class Studerende
    {
        public string Navn { get; set; }
        public int Fødselsmåned { get; set; }

        public int Fødselmåned { get; set; }

        public Studerende(string navn, int fødselsmåned, int fødselmåned)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselmåned = fødselmåned;
        }
    }
}
