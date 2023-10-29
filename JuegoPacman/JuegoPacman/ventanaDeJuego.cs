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
    public partial class ventanaDeJuego : Form
    {
        public ventanaDeJuego()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(ventanaDeJuego_Paint);
        }

        private void ventanaDeJuego_Paint(object sender, PaintEventArgs e)
        {
            /*Juego holick = Juego.ObtenerInstancia();
            Pixel[,] plano = new Pixel [16,26];
            plano = holick.ObtenerPlano();*/
            Juego holick = Juego.ObtenerInstancia();

            Pixel muro = holick.ObtenerMuro();
            Pixel vacio = holick.ObtenerVacio();
            Pixel moneda = holick.ObtenerMoneda();
            Pixel cereza = holick.ObtenerCereza();
            Pixel pastilla = holick.ObtenerPastilla();
            Pixel pinky = holick.ObtenerPinky();
            Pixel puerta = holick.ObtenerPuerta();
            Pixel pacman = holick.ObtenerPacman();

            Pixel [,] plano = new Pixel[16,26] {

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

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    Console.WriteLine(plano[i, j]);
                }
            }

            for (int i = 0; i < 16 ; i++)
            {
                for (int j = 0; j < 26 ; j++)
                {
                    Mapa.a = (j * (Pixel.tamanio + Mapa.margen)) + Mapa.ubicacion;
                    Mapa.b = (i * (Pixel.tamanio + Mapa.margen)) + Mapa.ubicacion;

                    if (plano != null && plano[i, j] != null)
                    {
                        int id = plano[i, j].id;
                        // Resto del código para dibujar el objeto según su ID
                        Console.WriteLine(plano[i, j] + " : " + i + " , " + j);

                        switch (id)
                        {
                            case 0:
                                e.Graphics.FillRectangle(Brushes.Navy, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                            case 1:
                                e.Graphics.FillRectangle(Brushes.Black, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                            case 2:
                                e.Graphics.FillRectangle(Brushes.Black, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                            case 3:
                                e.Graphics.FillRectangle(Brushes.Red, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                            case 4:
                                e.Graphics.FillRectangle(Brushes.Purple, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                            case 5:
                                e.Graphics.FillRectangle(Brushes.Green, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                            case 6:
                                e.Graphics.FillRectangle(Brushes.Aquamarine, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                            case 7:
                                e.Graphics.FillRectangle(Brushes.Black, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                // Dibuja el círculo amarillo para la cabeza de Pac-Man
                                e.Graphics.FillEllipse(Brushes.Yellow, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);

                                // Dibuja la boca abierta de Pac-Man
                                GraphicsPath path = new GraphicsPath();

                                path.AddPie(Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio, 270, 45); // 45 grados de inicio y 270 grados de extensión

                                // Rellena la boca con el color de fondo
                                e.Graphics.FillPath(Brushes.Black, path);

                                // Dibuja un círculo negro en el centro para representar el ojo
                                int radioOjo = Pixel.tamanio / 10; // Radio del círculo del ojo
                                int centroXOjo = Mapa.a + 8; // Coordenada X del centro del ojo (misma que el centro de Pac-Man)
                                int centroYOjo = Mapa.b + 8; // Coordenada Y del centro del ojo (ajustada hacia arriba)

                                e.Graphics.FillEllipse(Brushes.Black, centroXOjo, centroYOjo, 2 * radioOjo, 2 * radioOjo);

                                break;

                            default:
                                e.Graphics.FillRectangle(Brushes.White, Mapa.a, Mapa.b, Pixel.tamanio, Pixel.tamanio);
                                break;

                        }
                    }
                }
            }
        }
    }
}
