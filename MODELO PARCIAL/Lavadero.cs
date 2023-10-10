using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO_PARCIAL
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        public string Detalle
        {
            get{
                return "";
               }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }
        public double MostrarTotalFacturado() {
            double total = 0;
            foreach(Vehiculo vehiculo in vehiculos) {
                total += ObtenerPrecioTipo(vehiculo.tipo);           
            }
            return total;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculoListado)
        {
            double totalEspecificoVehiculo = 0;

            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.tipo == vehiculoListado)
                {
                    switch (vehiculoListado)
                    {
                        case EVehiculos.Auto:
                            totalEspecificoVehiculo += precioAuto;
                            break;
                        case EVehiculos.Moto:
                            totalEspecificoVehiculo += precioMoto;
                            break;
                        case EVehiculos.Camion:
                            totalEspecificoVehiculo += precioCamion;
                            break;
                    }
                }
            }
            return totalEspecificoVehiculo;
        }


        private float ObtenerPrecioTipo(EVehiculos tipo)
        {
            switch (tipo)
            {
                case EVehiculos.Auto:
                    return precioAuto;
                case EVehiculos.Camion:
                    return precioCamion;
                case EVehiculos.Moto:
                    return precioMoto;
                default:
                    return 0;
            }
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            int resultado = v1.Patente.CompareTo(v2.Patente);
            if (resultado < 0)
            {
                return -1;
            }
            else if (resultado > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            int resultado = v1.Marcas.CompareTo(v2.Marcas);
            if (resultado < 0)
            {
                return -1;
            }
            else if (resultado > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //operadores
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            return lavadero.vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
            {
                lavadero.vehiculos.Add(vehiculo);
            }
            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero.vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }

    }
}
