import javax.swing.*;

/**
 * Created by DOM on 2019-12-12.
 */
public interface ZasadyGry {

//    ImageIcon wygranaImg = new ImageIcon("plik/you-win.gif");
//    ImageIcon przegraneImg = new ImageIcon("plik/giphy.gif");
//    ImageIcon remisImg = new ImageIcon("plik/dead_heat.png");


    static StanGry statystyka(RuchGry ruchGracza, RuchGry ruchKomputer){
        if (ruchGracza.equals(RuchGry.KAMIEN) && ruchKomputer.equals(RuchGry.KAMIEN)) {
            return StanGry.REMIS;

        }
        if (ruchGracza.equals(RuchGry.KAMIEN) && ruchKomputer.equals(RuchGry.PAPIER)) {
            return StanGry.PRZEGRANA;
        }
        if (ruchGracza.equals(RuchGry.KAMIEN) && ruchKomputer.equals(RuchGry.NOZYCE)) {
            return StanGry.WYGRANA;
        }
        if (ruchGracza.equals(RuchGry.PAPIER) && ruchKomputer.equals(RuchGry.PAPIER)) {
            return StanGry.REMIS;
        }
        if (ruchGracza.equals(RuchGry.PAPIER) && ruchKomputer.equals(RuchGry.KAMIEN)) {
            return StanGry.WYGRANA;
        }
        if (ruchGracza.equals(RuchGry.PAPIER) && ruchKomputer.equals(RuchGry.NOZYCE)) {
            return StanGry.PRZEGRANA;
        }
        if (ruchGracza.equals(RuchGry.NOZYCE) && ruchKomputer.equals(RuchGry.NOZYCE)) {
            return StanGry.REMIS;
        }
        if (ruchGracza.equals(RuchGry.NOZYCE) && ruchKomputer.equals(RuchGry.PAPIER)) {
            return StanGry.WYGRANA;
        }
        if (ruchGracza.equals(RuchGry.NOZYCE) && ruchKomputer.equals(RuchGry.KAMIEN)) {
            return StanGry.PRZEGRANA;
        }
        return StanGry.REMIS;
    }



    static StanGry ktoWygral(RuchGry ruchGracza, RuchGry ruchKomputer) {
        if (ruchGracza.equals(RuchGry.KAMIEN) && ruchKomputer.equals(RuchGry.KAMIEN)) {
            //return remisImg;
            return StanGry.REMIS;

        }
        if (ruchGracza.equals(RuchGry.KAMIEN) && ruchKomputer.equals(RuchGry.PAPIER)) {
            //return przegraneImg;
            return StanGry.PRZEGRANA;
        }
        if (ruchGracza.equals(RuchGry.KAMIEN) && ruchKomputer.equals(RuchGry.NOZYCE)) {
            //return wygranaImg;
            return StanGry.WYGRANA;
        }
        if (ruchGracza.equals(RuchGry.PAPIER) && ruchKomputer.equals(RuchGry.PAPIER)) {
            //return remisImg;
            return StanGry.REMIS;
        }
        if (ruchGracza.equals(RuchGry.PAPIER) && ruchKomputer.equals(RuchGry.KAMIEN)) {
            //return wygranaImg;
            return StanGry.WYGRANA;
        }
        if (ruchGracza.equals(RuchGry.PAPIER) && ruchKomputer.equals(RuchGry.NOZYCE)) {
            //return przegraneImg;
            return StanGry.PRZEGRANA;

        }
        if (ruchGracza.equals(RuchGry.NOZYCE) && ruchKomputer.equals(RuchGry.NOZYCE)) {
            //return remisImg;
            return StanGry.REMIS;
        }
        if (ruchGracza.equals(RuchGry.NOZYCE) && ruchKomputer.equals(RuchGry.PAPIER)) {
            //return wygranaImg;
            return StanGry.WYGRANA;
        }
        if (ruchGracza.equals(RuchGry.NOZYCE) && ruchKomputer.equals(RuchGry.KAMIEN)) {
            //return przegraneImg;
            return StanGry.PRZEGRANA;
        }
        //return remisImg;
        return StanGry.REMIS;
    }
}
