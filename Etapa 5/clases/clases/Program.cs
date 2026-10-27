using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    class Program
    {
        public void Main(string[] args)
        {
            Mate mateF = new Mate(200,4,10,"Madera",true,true);
            Mate mateCuarzo = new Mate(100, 10, 16, "ceremica", false, false);
            Mate matinhoMetalico = new Mate(185, 15, 10, "metal", false, false);
            Mate mateRed = new Mate(250, 13, 15, "vidrio", false, false);
            //---------------------------
           

        }
    }
    class Mate
    {
        //Atributos
        private int capacidad;
        private int radio;
        private int alto;
        private int material;
        private bool estaLaqueado;
        private bool tieneBombilla;
        private int cant_de_agua = 0;
        //Constructor
        public Mate(int capacidad,int radio,int alto,string material,bool estaLaqueado,bool tieneBombilla)
        {
            this.capacidad = capacidad;
            this.radio = radio;
            this.alto = alto;
            this.material = material;
            this.estaLaqueado = estaLaqueado;
            this.tieneBombilla = tieneBombilla;
        }
        //Metodos
        public void Cebar()
        {
            cant_de_agua = capacidad;
        }
        public void Tomar(int cantidad)
        {
            cant_de_agua -= cantidad;
            if(cant_de_agua<0)
            {
                cant_de_agua = 0;
            }
        }
       
    }
}
