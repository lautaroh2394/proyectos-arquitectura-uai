using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
        MP_Producto mapper = new MP_Producto();

        public int AgregarProducto(BE.Producto prod)
        {
            return mapper.AgregarProducto(prod);
        }
    }
}
