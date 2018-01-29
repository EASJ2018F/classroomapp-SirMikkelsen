using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Studerende s1 = new Studerende("Gordon,", 07, 06);
            Studerende s2 = new Studerende("Mikkel", 06, 07);
            Studerende s3 = new Studerende("Hans" , 09, 11);

          //  Studerende s4 = new Studerende("Karsten", 13, 5);


            List<Studerende> studerende = new List<Studerende>();

            studerende.Add(s1);
            studerende.Add(s2);
            studerende.Add(s3);
            



            DateTime dateTime = new DateTime(2017, 08, 28);

            KlasseRum klasseRum = new KlasseRum("3A", studerende, dateTime);

            Console.WriteLine( "Klassens navn " + klasseRum.Klasse);
            Console.WriteLine("Semester start "  +klasseRum.SemesterStart);

            foreach (var student in klasseRum.Klassliste)
            {

                Console.WriteLine("student" +student);
            }



            klasseRum.AntallFødseldagÅrstid();

            Console.ReadKey();

  
        }
    }
}
