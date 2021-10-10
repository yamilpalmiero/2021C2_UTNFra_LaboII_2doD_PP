using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Internacional : Llamada
    {
        //ATRIBUTOS
        protected float costo;


        //CONSTRUCTORES
        public Internacional(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.Destino)
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
