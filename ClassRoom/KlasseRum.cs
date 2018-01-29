using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        public string Klasse { get; set; }
        public List<Studerende> Klassliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }
    }
}
