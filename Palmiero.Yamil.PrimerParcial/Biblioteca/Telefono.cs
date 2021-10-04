using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Telefono
    {
        //ENUMERADO
        public enum TipoTelefono
        {
            Disco,
            Teclado
        }


        //ATRIBUTOS
        private string id;
        private string marca;
        private List<Llamada> llamadas;


        //CONSTRUCTORES
        private Telefono()
        {
            this.llamadas = new List<Llamada>();
        }

        public Telefono(string id, string marca)
        {
            this.id = id;
            this.marca = marca;
        }


        //PROPIEDADES
        public string Id
        {
            get { return this.id; }
        }
        public string Marca
        {
            get { return this.marca; }
        }
        public List<Llamada> Llamadas
        {
            get { return this.llamadas; }
        }


        //METODOS
        public string MostrarLlamadas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Llamadas: ");
            foreach (Llamada item in llamadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
