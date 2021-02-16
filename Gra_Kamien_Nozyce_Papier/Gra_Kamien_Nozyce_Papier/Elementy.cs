using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Kamien_Nozyce_Papier
{
    public class Elementy
    {
        public static string[] wyborGracza = { "Nożyce", "Kamień", "Papier", "EXIT" };

        public static string[] wyborKomputera = { "Nożyce", "Kamień", "Papier" };

        public static string ruchGry = wyborKomputera[0];

        public static string ruchGracza = wyborGracza[0];

        public static int pozycjaMenu = 0;

        public static int remisy = 0;

        public static int wygrane = 0;

        public static int przegrane = 0;

        public static int iloscGier = 0;

        public static string nick;
    }
}
