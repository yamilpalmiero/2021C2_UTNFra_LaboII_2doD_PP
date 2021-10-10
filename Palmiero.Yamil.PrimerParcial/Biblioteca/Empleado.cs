using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Empleado : Persona
    {
        //ATRIBUTOS
        private int legajo;


        //CONSTRUCTORES
        public Empleado(string nombre, string apellido, int legajo)
            : base(nombre, apellido)
        {
            this.legajo = legajo;
        }


        //PROPIEDADES
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }


        //METODOS   
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"Legajo: {this.legajo}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
