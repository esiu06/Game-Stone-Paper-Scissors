using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Kamien_Nozyce_Papier
{
    class Gra
    {
        public Gra()
        {
            Console.Title = "Gra Kamień - Nożyce - Papier";
           // Console.CursorVisible = true;

            //Gracz.WyborGracza();

            Gracz gracz;
            gracz = new Gracz();

            while (true)
            {
                
                Menu.PokarzMenu();
                Opcje.WyborPozycji();
                Opcje.LosowanieOpcji();
                ZasadyGry.StanGry();
                Statystyka.Wynik();
            }
        }
    }
}
