using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElaimetKirjasto;



namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {

            Hevonen eHevonen = new Hevonen();
            Hevonen bHevonen = new Hevonen();
            Console.Write("Hevosen paino: ");
            Console.WriteLine(eHevonen.Paino=500);
            Console.Write("Hevosen Nimi: ");
            Console.WriteLine(eHevonen.Nimi = "Vieskeri");
            Console.Write("2.Hevosen paino: ");
            Console.WriteLine(bHevonen.Paino = 600);
            Console.Write("2.Hevosen nimi: ");
            Console.WriteLine(bHevonen.Nimi = "Wilma");

            Kissa eKissa = new Kissa();
            Console.Write("Kissan ikä: ");
            Console.WriteLine(eKissa.Ika1 = 14);
            Console.Write("Kissan nimi: ");
            Console.WriteLine(eKissa.KissanNimi="Hertta");
            Kissa cKissa = new Kissa();
            Console.WriteLine("Kissan nimi: "+cKissa.KissanNimi);
            Console.WriteLine("Kissan ikä: "+cKissa.Ika1);
            Kissa dKissa = new Kissa(22,"Hemppa");
            Console.WriteLine(dKissa.Ika1+" "+dKissa.KissanNimi);
            Console.WriteLine("Kissan nimi?");           
            string kissaNimi = Convert.ToString (Console.ReadLine());
            dKissa.KissaNimi(kissaNimi);
            Kissa iKissa = new Kissa();
            Console.WriteLine(iKissa.KissanNimi = "Hilda");
            Console.WriteLine(iKissa.KissanNimi);
            Koira aKoira = new Koira();
            Console.WriteLine(aKoira.KoiranNimi="Max");
            Console.WriteLine(aKoira.KoiranNimi);


            Console.WriteLine("Kissan ikä?");

            int KissanIka =Convert.ToInt32(Console.ReadLine());

            if (KissanIka < 0)
            {
                Console.WriteLine("Ikä ei ole kelvollinen");
            }
            else
            {
                Console.WriteLine("Kissan ikä on:" + KissanIka);
            }

            

            Console.ReadKey();
    
        }
    }
}
