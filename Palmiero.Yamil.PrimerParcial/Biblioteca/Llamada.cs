using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Llamada
    {
        //ENUMERADOS
        public enum TipoLlamada
        {
            Local,
            LargaDistacia,
            Internacional
        }


        //ATRIBUTOS
        protected float duracion;
        protected string destino;


        //CONSTRUCTORES
        protected Llamada(float duracion, string destino)
        {
            this.duracion = duracion;
            this.destino = destino;
        }


        //PROPIEDADES
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string Destino
        {
            get { return this.destino; }
        }

        public abstract float CostoLlamada { get; }


        //METODOS
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Destino: {this.Destino}");

            return sb.ToString();
        }
    }
}
