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
            db= int.Parse(Console.ReadLine());

            do {
                Console.WriteLine("adjon meg szamot: ");
                int szam1 = int.Parse(Console.ReadLine());
                szamok.Add(szam1);
                i++;

            }
            while (i < db);
            Console.WriteLine("a legnagyobb szam: "+szamok.Max());
            Console.ReadKey();

               
            
            
        }
    }
}
