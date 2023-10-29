using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPacman
{
    public class Juego //En esta clase se utiliza el patrón de disenio Singleton
    {
        private static Juego instancia;
        private Pixel muro, vacio, moneda, cereza, pastilla, pinky, puerta, pacman ;
        /*private Muro muro;
        private Vacio vacio;
        private Moneda moneda;
        private Fruta cereza;
        private Pastilla pastilla;
        private Ghost pinky;
        private Puerta puerta;
        private Pacman pacman;*/

        public Juego() 
        {
            muro = new Muro(0, "Blue");
            vacio = new Vacio(1, "Black");
            moneda = new Moneda(2, "Oranje");
            cereza = new Fruta(3, "Red");
            pastilla = new Pastilla(4, "Purple");
            pinky = new Ghost(5, "Pink", 3);
            puerta = new Puerta(6, "Aquamarine");
            pacman = new Pacman(7, "Yellow");
        }

        public static Juego ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Juego();
            }
            return instancia;
        }

       /*public Pixel[,] ObtenerPlano()
        {
            Mapa.IniciarArray(planoMain);
            return planoMain;
        }

        public void AsignarPlano ( Pixel[,] planoAux ) 
        {
            planoMain = planoAux;
        }*/

        public Pixel ObtenerMuro()
        {
            return muro;
        }

        public Pixel ObtenerVacio()
        {
            return vacio;
        }

        public Pixel ObtenerMoneda()
        {
            return moneda;
        }

        public Pixel ObtenerCereza()
        {
            return cereza;
        }

        public Pixel ObtenerPastilla()
        {
            return pastilla;
        }

        public Pixel ObtenerPinky()
        {
            return pinky;
        }

        public Pixel ObtenerPuerta()
        {
            return puerta;
        }

        public Pixel ObtenerPacman()
        {
            return pacman;
        }

    }
}
