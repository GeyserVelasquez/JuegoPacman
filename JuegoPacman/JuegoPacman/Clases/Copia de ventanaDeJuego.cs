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

            int[,] matriz = {
                    {1, 0, 1},
                    {0, 1, 0},
                    {1, 0, 1}
                };


            for (int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    Mapa.a = (j * (Pixel.tamanio + Mapa.margen)) + Mapa.ubicacion;
                    Mapa.b = (i * (Pixel.tamanio + Mapa.margen)) + Mapa.ubicacion;

                    if (matriz != null && matriz[i, j] != null)
                    {
                        int id = matriz[i, j];
                        // Resto del código para dibujar el objeto según su ID
                        Console.WriteLine(matriz[i, j] + " : " + i + " , " + j);

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
