using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebagarridoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir)
            {
                container contain = new container();
                List<container> lista1 = new List<container>();
                List<container> lista2 = new List<container>();   
                buque buque1 = new buque("35899", "buque1", "chile", 4, 0, 2000, null);
                Console.WriteLine("");
                buque buque2 = new buque("35877", "buque2", "ecuador", 4, 0, 5000, null);
                Console.WriteLine("");
                buque buque3 = new buque("35877", "buque3", "brasil", 4, 0, 2300, null);
                Console.WriteLine("");
                container container1 = new container("55774", "apple", 500, 20, true, 300, buque1);
                Console.WriteLine("");
                container container2 = new container("33664", "hp", 500, 40, false, 300, buque2);
                Console.WriteLine("");
                container container3 = new container("99446", "elite", 500, 20, true, 350, buque1);
                Console.WriteLine("");
                container container4 = new container("34345", "lg", 400, 20, false, 400, buque2);
                Console.WriteLine("");
                lista1.Add(container1);
                lista1.Add(container3);
                lista2.Add(container2);
                lista2.Add(container4);
                buque1.ListaContainers = lista1;
                buque2.ListaContainers = lista2;
                Console.WriteLine("Lista de los Buques:");
                Console.WriteLine(buque1);
                Console.WriteLine(buque2);
                Console.WriteLine(buque3);
                Console.WriteLine("");
                Console.WriteLine("Lista de los Containers:");
                Console.WriteLine(container1);
                Console.WriteLine(container2);
                Console.WriteLine(container3);
                Console.WriteLine(container4);
                Console.WriteLine("");
                Console.WriteLine("Se subirán los containers a los buques");

                subirContainer(buque1);
                subirContainer(buque2);
                Console.WriteLine("");
                
                int sacarpeso = 200;
                int pesoagregado = 1000;

                Console.WriteLine("Se calculará los costos de envío de los buques y sus containers: ");
                Console.WriteLine("");
                calcularEnvio(buque1);
                Console.WriteLine("");
                calcularEnvio(buque2);
                Console.WriteLine("");
                Console.WriteLine("costos de aduana del container 3");
                calcularAduana(container3);
                Console.WriteLine("");
                Console.WriteLine("Se agregara 2000 kilos al container 4");
                contain.puedeSubir(pesoagregado, container4.CapacidadMaxima, container4.PesoA);
                Console.WriteLine("");
                
                Console.WriteLine("Peso inicial de container 1: " + container1.PesoA);
                Console.WriteLine("Se removerá peso del Container 1: ");
                sacarPeso(sacarpeso, container1);
                Console.WriteLine("Peso de container 1: " + container1.PesoA);
                Console.WriteLine("apriete cualquier tecla para poder salir");
                Console.ReadKey();
                break;



            }
        }

        private static void calcularEnvio(buque b)
        {
            int small = 0;
            int big = 0;
            int div = b.Transporte / b.CantidadContainers;
            int total = 0;
            for (int i = 0; i < b.ListaContainers.Count; i++)
            {

                if (b.ListaContainers[i].Tamano == 20)
                {
                    small++;
                    Console.WriteLine("El container numero: " + b.ListaContainers[i].Codigo + " paga 3500 por envío");
                }
                if (b.ListaContainers[i].Tamano == 40)
                {
                    big++;
                    Console.WriteLine("El container numero: " + b.ListaContainers[i].Codigo + " paga 9000 por envio");
                }
            }
            total = div + (3500 * small) + (9000 * big);
            Console.WriteLine("gasto de envio de buque " + b.Nombre + " es de: " + total);
        }

        private static void sacarPeso(int pesoMenos, container cont)
        {
            int resultado = cont.PesoA - pesoMenos;
            if (resultado < 0)
            {
                Console.WriteLine("Peso invalido");
            }
            else
            {cont.PesoA = resultado;
                Console.WriteLine("peso removido");}
        }
        private static void calcularAduana(container cont)
        {
            int total = 0;
            int container = cont.PesoA * 5;
            total += container;
            Console.WriteLine("costo de aduanas del container " + cont.Codigo + " es: " + total);
        }
        private static void subirContainer(buque b)
        {
            int carga = b.ContainersCargados;
            int cantidad = 0;
            int big = 0;
            int small = 0;
            for (int i = 0; i < b.ListaContainers.Count; i++)
            {
                if (b.ListaContainers[i].Tamano == 20)
                {
                    small++;
                }
                else if (b.ListaContainers[i].Tamano == 40)
                {big++;}
            }
            cantidad = (small) + (big * 2);
            if (cantidad > b.CantidadContainers)
            {
                Console.WriteLine("cantidad excede");
            }
            else
            {
                carga = cantidad;
                Console.WriteLine("containers en el buque " + b.Nombre + " es: " + cantidad);
            }

        }

    }
}