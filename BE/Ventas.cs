using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class Ventas
    {
        private int idVentas;
        public int IdVentas
        {
            get { return idVentas; }
            set { idVentas = value; }
        }
        private int idSurcursal;
        public int IdSucursal
        {
            get { return idSurcursal; }
            set { idSurcursal = value; }
        }
        private int idProductos;

        public int IdProductos
        {
            get { return idProductos; }
            set { idProductos = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int cantidad;
        public int Cantidad 
        { 
            get { return cantidad; } 
            set { cantidad = value; } 
        }
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int precioUnit;

        public int PrecioUnit
        {
            get { return precioUnit; }
            set { precioUnit = value; }
        }

    }
}
