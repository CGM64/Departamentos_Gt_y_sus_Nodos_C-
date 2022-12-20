using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class MetodosListaO
    {
        public ListaO PrimerNodo, UltimoNodo;

        public MetodosListaO()
        {
            PrimerNodo = null;
            UltimoNodo = null;
        }
        public string agregarDepartamento(int d, string nom)
        {
            ListaO nuevo = new ListaO(d, nom);

            if (estavacio())
            {
                PrimerNodo = UltimoNodo = nuevo;
            }
            else
            {
                nuevo.anterior = PrimerNodo;
                PrimerNodo.siguiente = nuevo;
                PrimerNodo = nuevo;
            }

            //CantidadNodos++;

            return "Nodo insertado";
        }
        //--------------------------
        //metodo para ver si esta vacia
        public bool estavacio()
        {
            return PrimerNodo == null;
        }
        //--------------------------
        //metodo inOrden
        public void inOrdenNS(ListaO r)
        {
            if (r != null)
            {
                Console.WriteLine(r.nombre);
                //inOrdenNS(r.final);
                inOrdenNS(r.anterior);
            }
        }
        public void inOrdenOE(ListaO r)
        {
            if (r != null)
            {
                inOrdenOE(r.siguiente);
                Console.WriteLine(" " + r.nombre + " ");
                //inOrdenOE(r.inicio);
            }
        }

        //buscar nodo
        public string buscarnodo(int d)
        {
            ListaO aux = PrimerNodo;

            while (aux.dato != d)
            {
                if (aux.dato == d)
                {
                    break;
                }
                if (aux == null)
                {
                    return null;
                }
            }

            return aux.nombre.ToString();
        }
    }
}
