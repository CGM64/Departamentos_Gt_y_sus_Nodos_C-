using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class ListaO
    {
        public int dato;
        public string nombre;
        public ListaO anterior, siguiente;
        public ListaO(int d, string nom)
        {
            this.dato = d;
            this.nombre = nom;
            this.anterior = null;
            this.siguiente = null;
        }

        public string toString()
        {
            return " El departamento es " + nombre;
        }
    }
}
