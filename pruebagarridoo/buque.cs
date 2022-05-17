using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace pruebagarridoo
{
    internal class buque
    {


        private int transporte;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int containersCargados;
        private string codigo;
        
        public List<container> listaContainers;

        public buque(string codigo, string nombre, string pais, int cantidadContainers, int containersCargados, int gastoTransporte, List<container> listaContainers)
        {
            if (codigo.Length < 5)
            {
                Console.WriteLine("El código no valido");
            }
            else
            {
                this.codigo = codigo;
            }
            this.nombre = nombre;
            this.pais = pais;
            this.cantidadContainers = cantidadContainers;
            if (containersCargados > cantidadContainers)
            {
                Console.WriteLine("Se excede los containers max");
            }
            else
            {
                this.containersCargados = containersCargados;
            }
            this.transporte = transporte;
            this.listaContainers = listaContainers;
        }

        public string Codigo { get => codigo; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int CantidadContainers { get => cantidadContainers; set => cantidadContainers = value; }
        public int ContainersCargados { get => containersCargados; set => containersCargados = value; }

        public int Transporte { get => transporte; set => transporte = value; }
        public List<container> ListaContainers { get => listaContainers; set => listaContainers = value; }

        public override string ToString()
        {

            return "Buque: Codigo - " + Codigo + ", Nombre - " + Nombre + ", Pais - " + Pais + ", Capacidad maxima de Containers - " + CantidadContainers + ",Cantidad de Container - " + ContainersCargados + ", Costo de Transporte - " + Transporte;
        }
    }





}