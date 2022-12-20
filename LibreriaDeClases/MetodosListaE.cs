using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class MetodosListaE
    {
        public ListaE PrimerNodo { get; set; }
        public ListaE UltimoNodo { get; set; }

        public int CantidadNodos;

        public MetodosListaE()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            CantidadNodos = 0;
        }

        public void agregarDepartamento(int d, string nom)
        {
            ListaE nuevo = new ListaE(d, nom);

            if (PrimerNodo == null)
            {
                PrimerNodo = nuevo;
                PrimerNodo.siguiente = null;
                PrimerNodo.anterior = null;
                UltimoNodo = PrimerNodo;
            }
            else
            {
                UltimoNodo.siguiente = nuevo;
                nuevo.siguiente = null;
                nuevo.anterior = UltimoNodo;
                UltimoNodo = nuevo;
            }
            Console.Write("\n Nuevo nodo ingresado con exito");
        }

        //--------------------------
        //metodo para ver si esta vacia
        public bool estavacio()
        {
            return PrimerNodo == null;
        }

        //--------------------------

        public void desplegarListaEormal()
        {
            ListaE actual;
            actual = PrimerNodo;
            while (actual != null)
            {
                Console.Write(" " + actual.nombre + " <------->");
                actual = actual.siguiente;
            }
        }

        public void desplegarlistaAlContrario()
        {
            ListaE actual;
            actual = UltimoNodo;
            while (actual != null)
            {
                Console.Write(" " + actual.nombre + " <------->");
                actual = actual.anterior;
            }
        }

        public void buscarListaEormal(string nombre)
        {
            ListaE temporal = PrimerNodo;

            while (temporal != null && !temporal.nombre.Equals(nombre))
            {
                Console.Write(" [" + temporal.nombre + "]----> ");

                temporal = temporal.siguiente;

                if (temporal.nombre.Equals(nombre))
                {
                    Console.Write(" [" + temporal.nombre + "]----> ");
                }
            }
        }

        public void buscarListaAlContrario(string nombre)
        {
            ListaE temporal = UltimoNodo;

            while (temporal != null && !temporal.nombre.Equals(nombre))
            {
                Console.Write(temporal.nombre + " <----> ");

                temporal = temporal.anterior;

                if (temporal.nombre.Equals(nombre))
                {
                    Console.Write(temporal.nombre + " <----> ");
                }
            }
        }
    }
}
