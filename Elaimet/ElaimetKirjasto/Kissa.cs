using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Elaimet
{
    public class Kissa
    {
        private string kissanNimi;
        private int ika1;
        private int kissanIka;


        public Kissa()
        {
            kissanNimi = "Hurri";
            Ika1 = 10;
           
        }
   
        public Kissa(int ika, String nimi)
        {
            this.Ika = ika;
            this.kissanNimi = nimi;
        }

        public void KissaNimi(string nimi)
        {
            while (nimi == "Hilda")
            {

                //if (nimi == "Hilda")
                
                    Console.WriteLine("Hilda ei käy, " + false);
                break;
                
                //else
               
            }
            {
                Console.WriteLine("Sopiva kissan nimi, " + true);
            }
        }
        public string KissanNimi
        {

            get
            {
                return kissanNimi;
            }

            set
            {
                kissanNimi = value;
            }
        }
        public int KissanIka
        {           
            get
            {
                return kissanIka;
            }

            set
            {
                kissanIka = value;
            }

        }

        public int Ika
        {
            get
            {
                return Ika1;
            }

            set
            {
                Ika1 = value;
            }
        }

        public int Ika1 { get => ika1; set => ika1 = value; }

    }
}
