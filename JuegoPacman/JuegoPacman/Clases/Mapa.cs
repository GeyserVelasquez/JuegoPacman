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
    public class Mapa : Control
    {
        public static int margen = 1;// separacion entre cuadros
        public static int ubicacion = 0; // traslacion de cuadros
        public const int ancho = 27; // lado Y de cuadros
        public const int alto = 16; // lado X de cuadros
        public static int a, b; //Coordenadas

        public static void IniciarArray(Pixel[,] plano) 
        {
            Juego holick = Juego.ObtenerInstancia();

            Pixel muro = holick.ObtenerMuro();
            Pixel vacio = holick.ObtenerVacio();
            Pixel moneda = holick.ObtenerMoneda();
            Pixel cereza = holick.ObtenerCereza();
            Pixel pastilla = holick.ObtenerPastilla();
            Pixel pinky = holick.ObtenerPinky();
            Pixel puerta = holick.ObtenerPuerta();
            Pixel pacman = holick.ObtenerPacman();

            plano = new Pixel[,] {

                {muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro},
                {muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro},
                {muro,	moneda,	muro,	muro,	moneda,	muro,	moneda,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	moneda,	muro,	moneda,	muro,	muro,	moneda,	muro},
                {muro,	moneda,	muro,	cereza,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	cereza,	muro,	moneda,	muro},
                {muro,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	muro,	muro,	moneda,	muro,	muro,	muro,	muro,	moneda,	muro,	muro,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	muro},
                {muro,	moneda,	muro,	muro,	muro,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	pastilla,	moneda,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	muro,	muro,	muro,	moneda,	muro},
                {muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	moneda,	muro,	puerta,	puerta,	muro,	moneda,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro},
                {puerta,	moneda,	muro,	moneda,	moneda,	muro,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	pinky,	pinky,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	muro,	moneda,	moneda,	muro,	moneda,	puerta},
                {puerta,	moneda,	muro,	moneda,	moneda,	muro,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	pinky,	pinky,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	muro,	moneda,	moneda,	muro,	moneda,	puerta},
                {muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	moneda,	muro,	muro,	muro,	muro,	moneda,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro},
                {muro,	moneda,	muro,	muro,	muro,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	muro,	muro,	muro,	moneda,	muro},
                {muro,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	muro,	muro,	muro,	moneda,	muro,	muro,	muro,	muro,	pacman,	muro,	muro,	muro,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	muro},
                {muro,	moneda,	muro,	cereza,	moneda,	muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro,	moneda,	cereza,	muro,	muro,	muro},
                {muro,	moneda,	muro,	muro,	moneda,	muro,	moneda,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	moneda,	muro,	moneda,	muro,	muro,	moneda,	muro},
                {muro,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	moneda,	muro},
                {muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro,	muro}
            
                };

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        private void Mapa_KeyDown(object sender, KeyEventArgs e, Pacman pacman)
        {
            Console.WriteLine("Tecla presionada: " + e.KeyCode);
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                pacman.y += 1;
                Console.WriteLine("Coordenadas: " + pacman.x + " " + pacman.y);
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                pacman.y -= 1;
                Console.WriteLine("Coordenadas: " + pacman.x + " " + pacman.y);

            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                pacman.x += 1;
                Console.WriteLine("Coordenadas: " + pacman.x + " " + pacman.y);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                pacman.x -= 1;
                Console.WriteLine("Coordenadas: " + pacman.x + " " + pacman.y);
            }
        }
    }
}
         