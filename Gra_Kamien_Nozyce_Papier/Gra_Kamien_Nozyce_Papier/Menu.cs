using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Kamien_Nozyce_Papier
{
    class Menu : Elementy
    {
        
        public static void PokarzMenu()
        {
            Console.SetWindowSize(38, 18);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(">>>  Gra Kamień - Nożyce - Papier  <<<");
            Console.WriteLine();
            Console.CursorLeft = 4;
            Console.WriteLine(">>> Witaj " + nick + ", Zagrajmy! <<<");
            Console.WriteLine();
            Console.CursorLeft = 11;
            Console.WriteLine(">> Twój wybór <<");
            Console.WriteLine();
            

            for (int i = 0; i < wyborGracza.Length; i++)
            {
                Console.CursorLeft = 16;
                if (i == pozycjaMenu)
                {

                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("{0, -38}", wyborGracza[i]);
                   
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    
                }
                else
                {
                    Console.WriteLine(wyborGracza[i]);
                }
            }
        }
    }
}
