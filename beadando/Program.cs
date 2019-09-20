using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando {
    class Program {
        static void Main(string[] args) {
            int i = 0;

            int db = 0;
            
            List<int> szamok = new List<int>();
            Console.WriteLine("hany darab szamot akar megadni? ");
            if (int.TryParse(Console.ReadLine(), out db)) {
                // its a number
                db += db;
            }
            else {
                // it isn't a number
                Console.WriteLine("ez nem szam! ");
                Console.ReadKey();
                System.Environment.Exit(0);
            }


            do {


                Console.WriteLine("adjon meg szamot: ");
                int szam1 = 0;
                if (int.TryParse(Console.ReadLine(), out szam1)) {
                    // its a number
                    szam1 = szam1;
                }
                else {
                    // it isn't a number
                    Console.WriteLine("ez nem szam! ");
                    System.Environment.Exit(0);
                }
                
                    szamok.Add(szam1);
                    i++;

                }
                while (i < (db/2));
                Console.WriteLine("a legnagyobb szam: " + szamok.Max());
                Console.WriteLine("a legkisseb szam: " + szamok.Min());
                Console.ReadKey();
           

               
            
            
        }
    }
}
