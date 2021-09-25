using System;

namespace Biblioteca
{
    public class Computadora
    {
        //ATRIBUTOS 
        private string software;
        private string periferico;
        private string juego;
        private string procesador;
        private short ram;
        private string placaVideo;

        //CONSTRUCTOR
        public Computadora(string software, string periferico, string juego, string procesador, short ram, string placaVideo)
        {
            this.software = software;
            this.periferico = periferico;
            this.juego = juego;
            this.procesador = procesador;
            this.ram = ram;
            this.placaVideo = placaVideo;
        }

    }
}
