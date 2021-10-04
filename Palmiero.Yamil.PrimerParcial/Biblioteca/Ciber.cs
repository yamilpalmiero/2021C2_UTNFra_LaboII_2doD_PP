using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ciber
    {
        //ATRIBUTOS
        private const string nombre = "El Vicio";
        private List<Telefono> telefonos;
        private List<Computadora> computadoras;


        //CONSTRUCTORES
        public Ciber(List<Telefono> telefonos, List<Computadora> computadoras)
        {
            this.telefonos = telefonos;
            this.computadoras = computadoras;
        }


        //PROPIEDADES
        public List<Llamada> Llamadas
        {
            get
        }
    }
}
