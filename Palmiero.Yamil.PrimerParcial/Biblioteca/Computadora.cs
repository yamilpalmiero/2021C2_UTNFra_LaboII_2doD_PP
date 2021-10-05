using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Computadora
    {
        //ATRIBUTOS 
        private string id;
        private List<string> programas;
        private List<string> perifericos;
        private List<string> juegos;
        private string procesador;
        private short ram;
        private string placa;


        //CONSTRUCTORES
        private Computadora()
        {
            this.programas = new List<string>();
            this.perifericos = new List<string>();
            this.juegos = new List<string>();
        }
        public Computadora(string id, string procesador, short ram, string placa)
            : this()
        {
            this.id = id;
            this.procesador = procesador;
            this.ram = ram;
            this.placa = placa;
        }

        //PROPIEDADES
        public string Id
        {
            get { return this.id; }
        }
        public string Procesador
        {
            get { return this.procesador; }
            set { this.procesador = value; }
        }
        public short Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public string Placa
        {
            get { return this.placa; }
            set { this.placa = value; }
        }
    }
}
