using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Famosetes
{
    class Program
    {
        static int contador = 0;
        static void Main(string[] args)
        {
            string cantante, disco,escape;
            List<CantanteFamoso> listasCantantesFamosos = new List<CantanteFamoso>();
            listasCantantesFamosos.Add(AñadirCantante("Extremoduro","Agila"));
            listasCantantesFamosos.Add(AñadirCantante("EoDM", "Death by Sexy"));
            do
            {
                do
                {
                    Console.WriteLine("Introduzca el cantante que desee añadir (para mostrar lista introduzca 0)\n");
                    cantante = Console.ReadLine();
                    Console.WriteLine("Y su disco con más ventas\n");
                    disco = Console.ReadLine();
                    if (cantante != "0" || disco != "0")
                    {
                        listasCantantesFamosos.Add(AñadirCantante(cantante, disco));
                    }
                } while (cantante != "0" || disco != "0");
                foreach (CantanteFamoso x in listasCantantesFamosos)
                {
                    Console.WriteLine("Cantante: " + x.GetCant() + "\t\tDisco más vendido:" + x.GetDisco());
                }
                Console.WriteLine("Para terminar de añadir cantantes a la lista introduzca 'salir', si no introduzca cualquier tecla");
                escape = Console.ReadLine().ToUpper();
            } while (escape!="SALIR");
            Console.ReadLine();         
        }
        public static CantanteFamoso AñadirCantante(string nombre, string discoMasVendido)
            {
            CantanteFamoso cantante = new CantanteFamoso(nombre,discoMasVendido);
            return cantante;
            }//TODO:meter todo en un do while que mientras no elija salir se repita
    }
}
        //Crea una Lista denominada ListaCantantesFamosos que disponga de objetos de la clase CantanteFamoso.
        //Program debe tener un método que permita añadir objetos de tipo CantanteFamoso a la lista.Un objeto de 
        //tipo CantanteFamoso tendrá como atributos nombre (String) y discoConMasVentas (String), y los métodos para 
        //obtener y establecer los atributos.Desde el main que inicializa la lista ListaCantantesFamosos y añade manualmente 
        //dos objetos de tipo CantanteFamoso a la la lista. Usando iterator muestra los nombres de cada cantante y su disco
        //con más ventas por pantalla. Se debe pedir al usuario un nombre y disco con más ventas de otro cantante famoso,
        //y una vez introducidos los datos mostrar la lista actualizada usando iterator. Una vez mostrada la lista actualizada,
        //se debe dar opción a elegir entre volver a introducir los datos de otro cantante o salir del programa.

