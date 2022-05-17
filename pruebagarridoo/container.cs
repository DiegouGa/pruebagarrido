using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static pruebagarridoo.buque;



namespace pruebagarridoo
{
    internal class container
    {
        private int capacidadMaxima;
        private bool losRefrigerado;
        private string codigo;
        private byte tamano;
        private int pesoA;
        private string marca;
        public buque Buque;

        
        public string Marca { get => marca; set => marca = value; }
        
        public byte Tamano { get => tamano; set => tamano = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public string Codigo { get => codigo; }
        public int PesoA { get => pesoA; set => pesoA = value; }

        public container(string codigocontainer)
        {this.codigo = codigocontainer;}

        public container(string codigo, string marca, int capacidadMaxima, byte tamano, bool losRefrigerado, int pesoA, buque Buque) : this(codigo)
        {
            this.capacidadMaxima = capacidadMaxima;
            this.marca = marca;
            this.losRefrigerado = losRefrigerado;
            this.tamano = tamano;
            
            if (pesoA < 0)
            {Console.WriteLine("Ingrese peso");}
            else if (pesoA > capacidadMaxima)
            { Console.WriteLine("Peso excede capacidad max");}
            else
            {this.pesoA = pesoA;}
            this.Buque = Buque;}

        public string Refri(bool esRefri)
        {
            string refrigerado = "";
            if (esRefri == true)
            {refrigerado = "Si";}
            else
            {refrigerado = "No";
            }return refrigerado;
        }
        public container()
        {}
        public bool puedeSubir(int nuevaCarga, int max, int actual)
        {bool res = true;
            max = CapacidadMaxima;
            actual = PesoA;
            if (nuevaCarga + actual > max)
            {
                res = false;
                Console.WriteLine("Peso excede capacidad max");
            }
            return res;
        }
public override string ToString()
        {return "Container: Codigo - " + Codigo + ", Marca - " + Marca + ", Capacidad Máxima - " + 
                CapacidadMaxima + " kilos, Tamaño - " + Tamano + " pies, Refrigeración - " + Refri(losRefrigerado) + ", Peso Actual - " + 
                PesoA + " kilos, Buque Asociado - " + Buque.Nombre;
        }

    }
}