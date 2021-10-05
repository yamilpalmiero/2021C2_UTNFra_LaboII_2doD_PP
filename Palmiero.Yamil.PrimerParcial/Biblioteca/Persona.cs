using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        //ATRIBUTOS 
        private string nombre;
        private string apellido;
        private short edad;
        private int dni;


        //CONSTRUCTOR
        public Persona(string nombre, string apellido, short edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }


        //PROPIEDADES
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
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
        protected string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre} {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }
    }
}
