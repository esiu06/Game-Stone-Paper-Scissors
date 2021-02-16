using Gra_Kamien_Nozyce_Papier_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Kamien_Nozyce_Papier_
{
    public partial class Menu_Glowne : Form
    {
        Image jeden = Resources._1;
        Image dwa = Resources._2;
        Image trzy = Resources._3;
       
        public Menu_Glowne()
        {
            InitializeComponent();
        }
        

        private void bWyjscie(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
           
            
            Okno_Gra okno_Gra = new Okno_Gra();
            
            
           /* if(Okno_Ustawienia.nick == "")
            {
                MessageBox.Show("Pole \"Podaj swój nick\" jest puste. Uzupełnij pole w oknie \"Ustawienia\"");
            }
            if(Okno_Ustawienia.sciezkaPliku == "")
            {
                MessageBox.Show("Pole \"Podaj katalog zapisu\" jest puste. Uzupełnij pole w oknie \"Ustawienia\"");
            }*/if (Okno_Gra.stanMeczu == 0)
            {
                MessageBox.Show("Ilość gier jest \"0\". Ustaw ilość gier w oknie \"Ustawienia\" ");
            }
            else
                
                okno_Gra.ShowDialog();
               
        }

        private void bZasady_Click(object sender, EventArgs e)
        {
            Okno_Zasady okno_Zasady = new Okno_Zasady();
            okno_Zasady.ShowDialog();
           
        }

        private void bUstawienia(object sender, EventArgs e)
        {
            Okno_Ustawienia okno_Ustawienia = new Okno_Ustawienia();
            okno_Ustawienia.ShowDialog();
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            Okno_Statystyki okno_Statystyki = new Okno_Statystyki();
            okno_Statystyki.wyswietl_statystyke();
            okno_Statystyki.ShowDialog();
        }*/

        
    }
}
