using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DodawanieLiczbCalkowitych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dodawanie Liczb Całkowitych");
            Console.WriteLine("Programik od Tatka dla Michałka");
            Console.WriteLine();
            Console.WriteLine("Podaj Pierwszą Liczbę i naciśnij enter");
            string A = Console.ReadLine();  //Pierwsza zmienna podawana z konsoli
            int a = int.Parse(A);           // Teraz powyższą pierwszą zmieną parsuję ze string na int
            Console.WriteLine("Podaj Drugą Liczbę i naciśnij enter");
            string B = Console.ReadLine();  // Druga zmienna podawana z konsoli
            int b = int.Parse(B);           // Teraz powyższą drugą zmieną parsuję ze string na int
            Console.WriteLine("Wynik = " + (a + b));
            Console.WriteLine();
            Console.WriteLine("dlatego, że: " + a + "+" + b + "=" + (a + b));
            Console.WriteLine();
            Console.WriteLine("Pasuje? - wpisz tak lub nie");
            Console.WriteLine();
            //tutaj potem napiszę warunek
           
            
            Console.ReadLine();
        
        }
    }
}
