using System.Text;

namespace MODELO_PARCIAL
{
    public class Vehiculo
    {
        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;
        public EVehiculos tipo;

        public string Patente { get { return this.patente; } } //solo para lectura 
        public EMarcas Marcas { get { return this.marca; } }

     
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendLine($"Cantidad de ruedas: {this.cantRuedas}");
            sb.AppendLine($"Marca: {this.marca}");
            return sb.ToString();
        }

        public Vehiculo(string patente, byte cantRuedas, EMarcas marca, EVehiculos tipo)
        {
            this.patente = patente;
            this.marca = marca;
            this.cantRuedas = cantRuedas;
            this.tipo = tipo;
        }



        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.marca == v2.marca && v1.patente == v2.patente);

        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)//dentro de un static no se usa el this
        {

            return !(v1 == v2);//usa el de arriba



        }
    }
}