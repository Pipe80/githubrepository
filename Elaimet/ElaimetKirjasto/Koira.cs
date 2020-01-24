using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Elaimet
{
    public class Koira
    {
        private string koiranNimi;
        private int ika1;
        private int koiranIka;


        public Koira()
        {
            koiranNimi = "Haukkuli";
            Ika1 = 10;
           
        }
   
        public Koira(int ika, String nimi)
        {
            this.Ika = ika;
            this.koiranNimi = nimi;
        }

        public void KoiraNimi(string nimi)
        {
            while (nimi == "Musti")
            {
                
                    Console.WriteLine("Musti ei ei käy, " + false);
                break;
                
                //else
               
            }
            {
                Console.WriteLine("Sopiva kissan nimi, " + true);
            }
        }
        public string KoiranNimi
        {

            get
            {
                return koiranNimi;
            }

            set
            {
                koiranNimi = value;
            }
        }
        public int KoiranIka
        {           
            get
            {
                return koiranIka;
            }

            set
            {
                koiranIka = value;
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
