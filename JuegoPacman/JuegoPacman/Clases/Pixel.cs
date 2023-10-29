using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPacman
{
    public class Pixel
    {
        public const int tamanio = 48; // tamanio de cuadros, se imprimiran en pantalla un cuadrado de 50x50 pixeles
        public int id; // Identificador del tipo de pixel.
        protected string color; // Color de los pixeles
    
        public Pixel(int id, string color)
        {
            this.id = id;
            this.color = color;
        }
    
    }
    
    public class Muro : Pixel
    {
        private int x;
        private int y;
    
        public Muro(int n, string tone)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
        }
    }
    
    public class Vacio : Pixel
    {
        private int x;
        private int y;
    
        public Vacio(int n, string tone)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
        }
    }
    
    public class Puerta : Pixel
    {
        private int x;
        private int y;
    
        public Puerta(int n, string tone)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
        }
    }
    
    public class Pastilla : Pixel
    {
        private int x;
        private int y;
    
        public Pastilla(int n, string tone)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
        }
    }
    
    public class Moneda : Pixel
    {
        private int x;
        private int y;
    
        public Moneda(int n, string tone)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
        }
    }
    
    public class Pacman : Pixel
    {
        public const int xInicial = 12; // Posicion horizontal del pacman en el arreglo 
        public const int yInicial = 11; // Posicion vertical del pacman en el arreglo
        public int x = 12;
        public int y = 11;
        public bool superPacman = false;
    
        public Pacman(int n, string tone)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
    
        }
    }
    
    public class Ghost : Pixel
    {
        private double speed;
        private const int point = 100;
    
        public Ghost(int n, string tone, int vel)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
            this.speed = vel;
        }
    
    }
    
    public class Fruta : Pixel
    {
        private const int point = 100;
    
        public Fruta(int n, string tone)
            : base(n, tone)
        {
            this.id = n;
            this.color = tone;
        }
    
    }
}

