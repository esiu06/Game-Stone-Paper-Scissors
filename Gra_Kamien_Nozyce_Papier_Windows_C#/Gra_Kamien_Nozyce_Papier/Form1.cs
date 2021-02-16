using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GRA : Form
    {

        public GRA()
        {
            InitializeComponent();
        }
       

        public static string[] wyborGracza = { "Nożyce", "Kamień", "Papier" };

        public static string[] wyborKomputera = { "Nożyce", "Kamień", "Papier" };

        public static string ruchGry = wyborKomputera[0];

        public static string ruchGracza = wyborGracza[0];

        public static int pozycjaMenu = 0;

        public static int remisy = 0;

        public static int wygrane = 0;

        public static int przegrane = 0;

        public static int iloscGier = 0;

        public static string nick;

        public static string wynik;
        

        public static void StanGry()

        {

            if (ruchGracza.Equals(wyborKomputera[0]) && ruchGry.Equals(wyborGracza[0]))
            {
                wynik = "Remis";
                remisy++;
                iloscGier++;

            }
            if (ruchGracza.Equals(wyborKomputera[0]) && ruchGry.Equals(wyborGracza[1]))
            {
                wynik = "Przegrałeś!";
                przegrane++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[0]) && ruchGry.Equals(wyborGracza[2]))
            {
                wynik = "Wygrałeś!";
                wygrane++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[1]) && ruchGry.Equals(wyborGracza[1]))
            {
                wynik = "Remis!";
                remisy++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[1]) && ruchGry.Equals(wyborGracza[0]))
            {
                wynik = "Wygrałeś!";
                wygrane++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[1]) && ruchGry.Equals(wyborGracza[2]))
            {
                wynik = "Przegrałeś!";
                przegrane++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[2]) && ruchGry.Equals(wyborGracza[2]))
            {
                wynik = "Remis!";
                remisy++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[2]) && ruchGry.Equals(wyborGracza[1]))
            {
                wynik = "Wygrałeś!";
                wygrane++;
                iloscGier++;
            }
            if (ruchGracza.Equals(wyborKomputera[2]) && ruchGry.Equals(wyborGracza[0]))
            {
                wynik = "Przegrałeś!";
                przegrane++;
                iloscGier++;
            }
        }
        private void Zapis()
        {
            string[] statystyka = { "Ilość gier: " + iloscGier,
                "Wygranych: " + wygrane, "Przegranych: " + przegrane,
                "Remisy: " + remisy };

            string sciezkaPliku = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string nazwaPliku = "Statystyki.txt";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(sciezkaPliku, nazwaPliku)))
            {
                foreach (string linia in statystyka)
                    outputFile.WriteLine(linia);
                MessageBox.Show("Statystyka została zapisana w: " + sciezkaPliku);
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = wyborGracza[0];
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = wyborGracza[2];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = wyborGracza[1];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();

            switch (rand.Next(3))
            {
                case 0:

                    label4.Text  = wyborKomputera[0];
                    
                    break;
                case 1:
                    label4.Text  = wyborKomputera[1];
                    
                    break;
                case 2:
                    label4.Text  = wyborKomputera[2];
                    
                    break;

            }

            ruchGracza = label3.Text;
            ruchGry = label4.Text;
            StanGry();
            label5.Text = wynik;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ilość gier: " + iloscGier + "\n\nWygranych: " + wygrane + "\n\nPrzegrane: " + przegrane + "\n\nRemisy: " + remisy);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Zapis();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Zasady gry:\n\nGra składa się z kolejnych tur. W każdej turze obydwaj gracze," +
                "na umówiony sygnał, szybko wystawiają przed siebie dłoń, pokazującą symbol papieru," +
                "kamienia lub nożyc. Gracz, który pokazał silniejszy symbol, otrzymuje jeden punkt." +
                "W przypadku pokazania dwóch takich samych symboli następuje remis – punktu brak.\n\n" +
                "Oto hierarchia symboli:\n\n- nożyce są silniejsze od papieru, ponieważ go tną,\n" +
                "- kamień jest silniejszy od nożyc, ponieważ je tępi,\n" +
                "- papier jest silniejszy od kamienia, ponieważ go owija.\n\n" +
                "Gracz, który pierwszy uzyska umówioną wcześniej ilość punktów, wygrywa partię.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
