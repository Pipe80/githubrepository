﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luot luokasta olion
            //Tulosta olion nimi ja paino
            //Muuta olion nimeä ja painoa
            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            Hevonen eHevonen = new Hevonen();
            Hevonen bHevonen = new Hevonen();
            Console.WriteLine(eHevonen.Paino=500);
            Console.WriteLine(eHevonen.Nimi = "Vieskeri");
            Console.WriteLine(bHevonen.Paino = 600);
            Console.WriteLine(bHevonen.Nimi = "Wilma");

            Console.ReadKey();
    
        }
    }
}
