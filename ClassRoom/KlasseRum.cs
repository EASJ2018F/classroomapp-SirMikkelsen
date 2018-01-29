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



        public string Klasse
        {
            get { return _klasse; }
        }

        public List<Studerende> Klassliste
        {
            get { return _klasseListe; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
        }


        public KlasseRum(string klasse, List<Studerende> klasseListe, DateTime semesterStart)
        {
            _klasse = klasse;
            _klasseListe = klasseListe;
            _semesterStart = semesterStart;
        }



        public void AntallFødseldagÅrstid()
        {
            int efterår = 0;
            int vinter = 0;
            int forår = 0;
            int sommer = 0;

            foreach (var student in _klasseListe)
            {
                if (student.Årstid() == "Efterår")
                {
                    efterår += 1;
                }
                if (student.Årstid() == "Vinter")
                {
                    vinter += 1;
                }
                if (student.Årstid() == "Sommer")
                {
                    sommer += 1;
                }
                if (student.Årstid() == "Forår")
                {
                    forår += 1;
                }
            }

            Console.WriteLine("Født i Efterår: " + efterår);
            Console.WriteLine("Født i Vinter " + vinter);
            Console.WriteLine("Født i Sommer: " + sommer);
            Console.WriteLine("Født i Forår: " + forår);

        }

    }
}
