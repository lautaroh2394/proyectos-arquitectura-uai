using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        private int idProducto;
        public int IdProdcuto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private int precioUnit;
        public int PrecioUnit
        {
            get { return precioUnit; }
            set { precioUnit = value; }
        }
    }
}
