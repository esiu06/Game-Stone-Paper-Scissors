

import javax.swing.*;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

/**
 * Created by DOM on 2019-12-27.
 */
public class Plansza extends JFrame implements ActionListener, ZasadyGry{

    RuchGry ruchKomputer = RuchGry.KAMIEN;
    RuchGry ruchGracza = RuchGry.KAMIEN;

    int remisy = 0;
    int zwyciestwa = 0;
    int przegrane = 0;
    int iloscGier = 0;

    public int getIloscGier() {
        return iloscGier;
    }

    public void setIloscGier(int iloscGier) {
        this.iloscGier = iloscGier;
    }

    private JLabel ruchGraczaLabel, ruchGryLabel, wynikGryLabel;
    private JButton przyciskWyboruKamien, przyciskWyboruPapier, przyciskWyboruNozyce, przyciskStart;
    private JLabel wynikGracza, wynikGry, iloscGierLabel, zagrajmyLabel, twojRuchLabel, mojRuchLabel, rezultatLabel;


    ImageIcon kamienImgPryzcisk = new ImageIcon("plik/kamien.PNG");
    ImageIcon papierImgPrzycisk = new ImageIcon("plik/papier.PNG");
    ImageIcon nozyceImgPrzycisk = new ImageIcon("plik/nozyce.PNG");
    ImageIcon kamienImg = new ImageIcon("plik/rock.jpg");
    ImageIcon papierImg = new ImageIcon("plik/paper.jpg");
    ImageIcon nozyceImg = new ImageIcon("plik/scissors.jpg");
    ImageIcon wynikImg = new ImageIcon("plik/death_heat.png");
//    ImageIcon tlo = new ImageIcon("plik/tlo.png");

    JMenuBar gorneMenu;
    JMenu plik, pomoc;
    JMenuItem start, zakoncz, statystyki, zasadyGry;



    Plansza(){
        JFrame plansza = new JFrame("GRA KAMIEŃ-NOŻYCE-PAPIER");
        JPanel menu = new JPanel();
        JPanel panel = new JPanel();
        JLabel tlo = new JLabel(new ImageIcon("plik/tlo.png"));
        tlo.setOpaque(true);
        tlo.setBounds(0,0,800,600);
        panel.setLayout(null);
        panel.setBounds(0, 0, 800, 600);

        start = new JMenuItem("Start");
        start.addActionListener(this);
        zakoncz = new JMenuItem("Zakończ");
        zakoncz.addActionListener(this);
        statystyki = new JMenuItem("Statystyki");
        statystyki.addActionListener(this);
        zasadyGry = new JMenuItem("Zasady gry");
        zasadyGry.addActionListener(this);

        gorneMenu = new JMenuBar();
        plik = new JMenu("Plik");
        pomoc = new JMenu("Pomoc");

        plik.add(start);
        plik.add(statystyki);
        plik.add(zakoncz);
        pomoc.add(zasadyGry);

        gorneMenu.add(plik);
        gorneMenu.add(pomoc);
        menu.add(gorneMenu);
        plansza.setJMenuBar(gorneMenu);

        przyciskStart = new JButton("START");
        przyciskStart.setBackground(Color.YELLOW);
        przyciskStart.setFont(new Font("", Font.CENTER_BASELINE | Font.BOLD, 34));
        przyciskStart.setBounds(297, 315, 190, 80);
        przyciskStart.setForeground(Color.red);
        przyciskStart.addActionListener(this);

        przyciskWyboruKamien = new JButton(kamienImgPryzcisk);
        przyciskWyboruKamien.setBounds(210, 430, 79,92);
        przyciskWyboruKamien.setBackground(Color.YELLOW);
        przyciskWyboruKamien.addActionListener(this);

        przyciskWyboruNozyce = new JButton(nozyceImgPrzycisk);
        przyciskWyboruNozyce.setBounds(350, 430, 79,92);
        przyciskWyboruNozyce.setBackground(Color.YELLOW);
        przyciskWyboruNozyce.addActionListener(this);;

        przyciskWyboruPapier = new JButton(papierImgPrzycisk);
        przyciskWyboruPapier.setBounds(490, 430, 79,92);
        przyciskWyboruPapier.setBackground(Color.YELLOW);
        przyciskWyboruPapier.addActionListener(this);

        JLabel tytul = new JLabel("GRA KAMIEŃ - NOŻYCE - PAPIER");
        tytul.setBounds(86, 5, 650, 80);
        tytul.setFont(new Font("", Font.CENTER_BASELINE | Font.ITALIC ,  38));
        tytul.setForeground(Color.WHITE);



        ruchGraczaLabel = new JLabel(kamienImg);
        ruchGraczaLabel.setOpaque(true);
        ruchGraczaLabel.setBounds(72, 180, 150, 150);
        ruchGraczaLabel.setBackground(Color.WHITE);
        ruchGraczaLabel.setBorder(BorderFactory.createLoweredBevelBorder());

        ruchGryLabel = new JLabel(kamienImg);
        ruchGryLabel.setOpaque(true);
        ruchGryLabel.setBounds(560, 180, 150, 150);
        ruchGryLabel.setBackground(Color.WHITE);
        ruchGryLabel.setBorder(BorderFactory.createLoweredBevelBorder());

        wynikGryLabel = new JLabel(new ImageIcon("plik/dead_heat.png"));
        wynikGryLabel.setOpaque(true);
        wynikGryLabel.setBounds(273, 200, 230, 127);
        wynikGryLabel.setBorder(BorderFactory.createLoweredBevelBorder());
        wynikGryLabel.setBackground(Color.RED);

        wynikGracza = new JLabel();
        wynikGracza.setOpaque(true);
        wynikGracza.setBounds(260, 230, 39, 39);
        wynikGracza.setText(String.valueOf(zwyciestwa));
        wynikGracza.setFont(new Font("",Font.BOLD,26 ));
        wynikGracza.setVerticalAlignment(JLabel.CENTER);
        wynikGracza.setHorizontalAlignment(JLabel.CENTER);
        wynikGracza.setBorder(BorderFactory.createLoweredBevelBorder());


        wynikGry = new JLabel(String.valueOf(przegrane));
        wynikGry.setOpaque(true);
        wynikGry.setBounds(495, 230, 39, 39);
        wynikGry.setText(String.valueOf(przegrane));
        wynikGry.setFont(new Font("",Font.BOLD,26 ));
        wynikGry.setHorizontalAlignment(JLabel.CENTER);
        wynikGry.setBorder(BorderFactory.createLoweredBevelBorder());

        iloscGierLabel = new JLabel();
        iloscGierLabel.setOpaque(true);
        iloscGierLabel.setBounds(720, 500,39,39);
        iloscGierLabel.setText(String.valueOf(iloscGier));
        iloscGierLabel.setForeground(Color.RED);
        iloscGierLabel.setFont(new Font("",Font.BOLD,26 ));
        iloscGierLabel.setHorizontalAlignment(JLabel.CENTER);
        iloscGierLabel.setBorder(BorderFactory.createLoweredBevelBorder());

        zagrajmyLabel = new JLabel("ZAGRAJMY!!!");
        zagrajmyLabel.setHorizontalAlignment(JLabel.CENTER);
        zagrajmyLabel.setBounds(245,90, 300, 60);
        zagrajmyLabel.setFont(new Font("", Font.BOLD | Font.ITALIC ,  38));
        zagrajmyLabel.setForeground(Color.RED);
        zagrajmyLabel.setBorder(BorderFactory.createLoweredBevelBorder());

        twojRuchLabel = new JLabel("TWOJ RUCH");
        twojRuchLabel.setHorizontalAlignment(JLabel.CENTER);
        twojRuchLabel.setBounds(72, 323, 150, 40);
        twojRuchLabel.setForeground(Color.WHITE);

        mojRuchLabel = new JLabel("MOJ RUCH");
        mojRuchLabel.setHorizontalAlignment(JLabel.CENTER);
        mojRuchLabel.setBounds(560, 323, 150, 40);
        mojRuchLabel.setForeground(Color.WHITE);

        rezultatLabel = new JLabel("WYNIK");
        rezultatLabel.setHorizontalAlignment(SwingConstants.CENTER);
        rezultatLabel.setFont(new Font("", Font.BOLD, 38));
        rezultatLabel.setBounds(266, 220, 250, 60);
        rezultatLabel.setForeground(Color.RED);

        panel.add(tytul);
        panel.add(przyciskWyboruKamien);
        panel.add(przyciskWyboruNozyce);
        panel.add(przyciskWyboruPapier);
        panel.add(ruchGraczaLabel);
        panel.add(ruchGryLabel);
        //panel.add(wynikGracza);
        //panel.add(wynikGry);
        panel.add(iloscGierLabel);
        panel.add(zagrajmyLabel);
        panel.add(twojRuchLabel);
        panel.add(mojRuchLabel);
        panel.add(przyciskStart);
        panel.add(rezultatLabel);
        //panel.add(wynikGryLabel);

        panel.add(tlo);
        plansza.setLocation(530,210);
        plansza.add(panel);
        plansza.setSize(800,630);
        plansza.setLayout(null);
        plansza.setVisible(true);
        plansza.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        Toolkit zdjecie = Toolkit.getDefaultToolkit();
        Image img = zdjecie.getImage("plik/papier.PNG");
        plansza.setIconImage(img);

    }


    public static void main(String[] args) {
        new Plansza();
    }


    @Override
    public void actionPerformed(ActionEvent e) {

        if(e.getSource()==start){

            zagrajmyLabel.setText("ZACZYNAMY");
        }
        if (e.getSource()==statystyki){

            JFrame statystykiJFrame = new JFrame("Statystyki");
            JLabel tloStatystyki = new JLabel(new ImageIcon("plik/tlo.png"));
            tloStatystyki.setBounds(0, 0, 350,420);

            JLabel iloscGierStatystyka, wygraneStatystyka, przegraneStatystyka, remisyStatystyka, liczbaGier, liczbaWygranych, liczbaPrzegranych, liczbaRemisow;

            iloscGierStatystyka = new JLabel("Liczba gier:");
            iloscGierStatystyka.setForeground(Color.WHITE);
            iloscGierStatystyka.setBounds(45,40, 180,50);
            iloscGierStatystyka.setFont(new Font("", 1, 22));

            liczbaGier = new JLabel(String.valueOf(getIloscGier()));
            liczbaGier.setBounds(230, 40, 180,50);
            liczbaGier.setFont(new Font("", 1, 22));
            liczbaGier.setForeground(Color.WHITE);

            wygraneStatystyka = new JLabel("Wygranych:");
            wygraneStatystyka.setForeground(Color.WHITE);
            wygraneStatystyka.setBounds(45, 110, 180,50);
            wygraneStatystyka.setFont(new Font("", 1, 22));

            liczbaWygranych = new JLabel(String.valueOf(zwyciestwa));
            liczbaWygranych.setBounds(230, 110, 180,50);
            liczbaWygranych.setFont(new Font("", 1, 22));
            liczbaWygranych.setForeground(Color.WHITE);

            przegraneStatystyka = new JLabel("Przegranych:");
            przegraneStatystyka.setForeground(Color.WHITE);
            przegraneStatystyka.setBounds(45, 180, 180,50);
            przegraneStatystyka.setFont(new Font("", 1, 22));

            liczbaPrzegranych = new JLabel(String.valueOf(przegrane));
            liczbaPrzegranych.setBounds(230, 180, 180,50);
            liczbaPrzegranych.setFont(new Font("", 1, 22));
            liczbaPrzegranych.setForeground(Color.WHITE);

            remisyStatystyka = new JLabel("Remisy:");
            remisyStatystyka.setForeground(Color.WHITE);
            remisyStatystyka.setBounds(45, 250, 180,50);
            remisyStatystyka.setFont(new Font("", 1, 22));

            liczbaRemisow = new JLabel(String.valueOf(remisy));
            liczbaRemisow.setBounds(230, 250, 180,50);
            liczbaRemisow.setFont(new Font("", 1, 22));
            liczbaRemisow.setForeground(Color.WHITE);

            statystykiJFrame.add(iloscGierStatystyka);
            statystykiJFrame.add(liczbaGier);
            statystykiJFrame.add(wygraneStatystyka);
            statystykiJFrame.add(liczbaWygranych);
            statystykiJFrame.add(przegraneStatystyka);
            statystykiJFrame.add(liczbaPrzegranych);
            statystykiJFrame.add(remisyStatystyka);
            statystykiJFrame.add(liczbaRemisow);

            statystykiJFrame.add(tloStatystyki);
            statystykiJFrame.setSize(350,420);
            statystykiJFrame.setLocation(755,380);

            statystykiJFrame.setVisible(true);
        }
        if(e.getSource()==zakoncz){
           System.exit(0);
        }
        if (e.getSource()==zasadyGry){
            JFrame zasadyGryFrame = new JFrame("Zasady gry");
            zasadyGryFrame.setBounds(600, 330, 656, 400);
            JLabel tloZasadyGry = new JLabel(new ImageIcon("plik/tlo.png"));
            tloZasadyGry.setBounds(0,0, 600, 340);

            JLabel zasadyGryText = new JLabel("<html>Gra składa się z kolejnych tur. W każdej turze obydwaj gracze, \n" +
                    "na umówiony sygnał, szybko wystawiają przed siebie dłoń, \n" +
                    "pokazującą symbol papieru, kamienia lub nożyc. Gracz, \n" +
                    "który pokazał silniejszy symbol, otrzymuje jeden punkt. \n" +
                    "W przypadku pokazania dwóch takich samych symboli następuje\n" +
                    " remis – punktu brak. Oto hierarchia symboli:<br>" +
                    "\n" +
                    "\n" +
                    "\t  * nożyce są silniejsze od papieru, ponieważ go tną,<br>" +
                    "\n" +
                    "\t  * kamień jest silniejszy od nożyc, ponieważ je tępi,<br>\n" +
                    "\t  * papier jest silniejszy od kamienia, ponieważ go owija.<br>" +
                    "\n" +
                    "\n" +
                    "Gracz, który pierwszy uzyska umówioną wcześniej ilość punktów, \n" +
                    "wygrywa partię.</html>");
            zasadyGryText.setBounds(70,15, 500, 300);
            zasadyGryText.setForeground(Color.WHITE);
            zasadyGryText.setFont(new Font("", 1, 16));
            zasadyGryFrame.add(zasadyGryText);
            zasadyGryFrame.add(tloZasadyGry);
            zasadyGryFrame.setVisible(true);
        }
        if(e.getSource()==przyciskStart){

            Random rand = new Random();

            switch (rand.nextInt(3)) {
                case 0:
                    ruchKomputer = RuchGry.NOZYCE;
                    ruchGryLabel.setIcon(nozyceImg);
                    break;
                case 1:
                    ruchKomputer = RuchGry.KAMIEN;
                    ruchGryLabel.setIcon(kamienImg);
                    break;
                case 2:
                    ruchKomputer = RuchGry.PAPIER;
                    ruchGryLabel.setIcon(papierImg);
                    break;

            }
            StanGry wynik = ZasadyGry.ktoWygral(ruchGracza, ruchKomputer);

            rezultatLabel.setText(String.valueOf(wynik));

        }


        StanGry rezultat = ZasadyGry.statystyka(ruchGracza, ruchKomputer);

        if (rezultat.equals(StanGry.REMIS)){
            remisy++;

        }else if (rezultat.equals(StanGry.WYGRANA)){
            zwyciestwa++;
            wynikGracza.setText(String.valueOf(zwyciestwa));

        }else{
            przegrane++;
            wynikGry.setText(String.valueOf(przegrane));
        }

        Object akcja = e.getSource();

        if (akcja == przyciskWyboruKamien) {
            ruchGracza = RuchGry.KAMIEN;
            ruchGraczaLabel.setIcon(kamienImg);

        }else if (akcja == przyciskWyboruNozyce) {
            ruchGracza = RuchGry.NOZYCE;
            ruchGraczaLabel.setIcon(nozyceImg);

        }else if (akcja == przyciskWyboruPapier) {
            ruchGracza = RuchGry.PAPIER;
            ruchGraczaLabel.setIcon(papierImg);
        }

        iloscGier++;
        iloscGierLabel.setText(String.valueOf(iloscGier));

    }

}

