using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Kamien_Nozyce_Papier
{
    public class Gracz : Elementy
    {
       
        public Gracz()
        {
            Console.SetWindowSize(38, 18);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.WriteLine(">>>  Gra Kamień - Nożyce - Papier  <<<");

            Console.WriteLine();
            Console.CursorLeft = 11;
            Console.WriteLine("Podaj swój nick: ");
            Console.CursorLeft = 16;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorVisible = true;
            nick = Console.ReadLine();
           
        }

    }
}
