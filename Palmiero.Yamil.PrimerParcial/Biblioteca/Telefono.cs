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
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }
        public float GananciasPorLargaDistancia
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.LargaDistacia); }
        }
        public float GananciasPorInternacional
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Internacional); }
        }


        //METODOS
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float totalLocal = 0;
            float totalLargaDistancia = 0;
            float totalInternacional = 0;

            foreach (Llamada llamada in this.llamadas)
            {
                if (llamada is Local)
                {
                    totalLocal += ((Local)llamada).CostoLlamada;
                }
                if (llamada is LargaDistancia)
                {
                    totalLargaDistancia += ((LargaDistancia)llamada).CostoLlamada;
                }
                if (llamada is Internacional)
                {
                    totalInternacional += ((Internacional)llamada).CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return totalLocal;
                case Llamada.TipoLlamada.LargaDistacia:
                    return totalLargaDistancia;
                case Llamada.TipoLlamada.Internacional:
                    return totalInternacional;
                default:
                    return 0;
            }
        }

        public string MostrarLlamadas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Detalle de las llamadas: ");
            foreach (Llamada item in llamadas)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Ganancias por llamadas locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancias por llamadas de larga distancia: {this.GananciasPorLargaDistancia}");
            sb.AppendLine($"Ganancias por llamadas internacionales: {this.GananciasPorInternacional}");

            return sb.ToString();
        }


        //SOBRECARGA DE OPERADORES
        public static bool operator ==(Telefono t, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada item in t.llamadas)
            {
                if (item == llamada)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Telefono t, Llamada llamada)
        {
            return !(t == llamada);
        }

        public static Telefono operator +(Telefono t, Llamada nuevaLlamada)
        {
            if (t != nuevaLlamada)
            {
                t.llamadas.Add(nuevaLlamada);
            }

            return t;
        }
    }
}
