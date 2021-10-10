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
        public Ciber()
        {
            this.telefonos = new List<Telefono>();
            this.computadoras = new List<Computadora>();
        }


        //PROPIEDADES
        public List<Telefono> Telefonos
        {
            get { return this.telefonos; }
        }
        public List<Computadora> Computadoras
        {
            get { return this.computadoras; }
        }


        //METODOS
    }
}
