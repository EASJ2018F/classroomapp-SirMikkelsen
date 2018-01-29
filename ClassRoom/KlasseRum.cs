using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        private string _klasse;
        private List<Studerende> _klasseListe;
        private DateTime _semesterStart;


        
        public string Klasse { get { return _klasse; }  }
        public List<Studerende> Klassliste { get { return _klasseListe; }  }
        public DateTime SemesterStart { get { return _semesterStart; } }


        public KlasseRum(string klasse, List<Studerende> klasseListe, DateTime semesterStart)
        {
            _klasse = klasse;
            _klasseListe = klasseListe;
            _semesterStart = semesterStart;
        }
    }
}
