using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class Studerende
   {

       private string _navn;
       private int _fødselsmåned;
       private int _fødseldag;

        public string Navn { get { return _navn; } }
        public int Fødselsmåned { get { return _fødselsmåned; }}
        public int Fødseldag { get { return _fødseldag; } }

       public Studerende(string navn, int fødselsmåned, int fødseldag)
       {
           _navn = navn;
           _fødselsmåned = fødselsmåned;
           _fødseldag = fødseldag;


       }


        public override string ToString()
       {
           return $" Navn: {Navn} , Fødselsmåned: {Fødseldag}, Fødselsdag: {Fødseldag}";
       }

       public string Årstid()
       {
           switch (Fødselsmåned)
           {
                case 1:
                    return ("Vinter");
                    
                case 2:
                        return ("Vinter");
                    
                case 3:
                    return ("Forår");
                    
                case 4:
                    return ("Forår");
                    
               case 5:
                   return ("Forår");
                   
               case 6:
                   return ("Sommer");
                   
               case 7:
                   return ("Sommer");
                   
               case 8:
                   return ("Sommer");
                   
               case 9:
                   return ("Efterår");
                   
               case 10:
                   return ("Efterår");
                  
               case 11:
                   return ("Efterår");
                   
               case 12:
                   return ("Vinter");
                  
               default:
                   return ("Ukendt");
                   
            }

            


       }
   }
}
