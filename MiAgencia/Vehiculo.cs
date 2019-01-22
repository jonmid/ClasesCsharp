using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    public enum ColorVehiculo
    {
        Ninguno, Blanco, Gris, Rojo, Vino, Azul, Negro
    }

    public enum Estatus
    {
        Existencia, Vendido, Entregado
    }

    public class Vehiculo
    {
        #region Atributos
        int id;
        int llantas;
        string modelo;
        int anio;
        ColorVehiculo color;
        Estatus estatus;
        #endregion

        #region Constructor
        public Vehiculo()
        {
            id = 0;
            llantas = 4;
            modelo = "";
            anio = 2019;
            color = ColorVehiculo.Ninguno;
            estatus = Estatus.Existencia;
        }
        #endregion

        #region Metodos
        public string Capturar()
        {
            return "Vehiculo ingresado corectamente";
        }

        public string Vender()
        {
            return "El Vehiculo fue vendido con exito";
        }
        #endregion

        #region DescriptoresAcceso
        public int Id { get; set; }
        public int Llantas { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Color { get; set; }
        #endregion
    }
}
