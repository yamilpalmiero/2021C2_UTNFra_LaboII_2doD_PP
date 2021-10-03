using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class LargaDistancia : Llamada
    {
        //ATRIBUTOS
        protected float costo;


        //CONSTRUCTORES
        public LargaDistancia(Llamada llamada, float costo)
            : this(llamada.Origen, llamada.Duracion, llamada.Destino, costo)
        {

        }
        public LargaDistancia(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        //PROPIEDADES
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }


        //METODOS
        private float CalcularCosto()
        {
            return this.duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Costo: {0}", this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
