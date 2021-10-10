using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        //ATRIBUTOS
        private short edad;
        private int dni;


        //CONSTRUCTORES
        public Cliente(string nombre, string apellido, short edad, int dni)
            : base(nombre, apellido)
        {
            this.edad = edad;
            this.dni = dni;
        }


        //PROPIEDADES
        public short Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }


        //METODOS
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
