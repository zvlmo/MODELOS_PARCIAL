using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO_PARCIAL
{
    public class Camion:Vehiculo
    {

        protected float tara;

        public Camion(float tara, string patente, byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca, EVehiculos.Camion)
        {
            this.tara = tara;
        }
        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Tara: {this.tara}");

            return sb.ToString();
        }
    }
}
