using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEvents
{
    public partial class Form1 : Form
    {
        // declaración de delegado
        public delegate void EjemploDelegado();

        // declaración de evento
        public event EjemploDelegado ejemploEvento;

        // método para mostrar la suma de dos números
        public void Suma(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine("la suma es {0}", a + b);
            }
            else
            {
                Console.WriteLine("no estas suscrito a los eventos");
            }
        }

        // método para mostrar la resta de dos números
        public void Resta(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine("la resta es {0}", a - b);
            }
            else
            {
                Console.WriteLine("no estas suscrito a los eventos");
            }
        }



        public void EjemploEventHandler()
        {
            Console.WriteLine("la operacion va a ser efectuada");
        }

        public void EjemploEventHandler2()
        {
            Console.WriteLine("Ejemplo EventHandler 2");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ejemploEvento += this.EjemploEventHandler;
            this.ejemploEvento += this.EjemploEventHandler2;
            Suma(1, 5);
            Resta(8, 7);
        }
    }
}
