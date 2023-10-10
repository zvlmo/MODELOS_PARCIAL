using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO_PARCIAL
{
    public class Auto : Vehiculo
    {
        protected int cantAsientos;
        protected EVehiculos tipo;

        public Auto(int cantAsientos, string patente, byte cantRuedas,EMarcas marca):base(patente, cantRuedas,marca, EVehiculos.Auto)
        {
            this.cantAsientos = cantAsientos;
        }
        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cantidad de asientos: {this.cantAsientos}");

            return sb.ToString();
        }
    }
}
