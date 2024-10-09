using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_Producto
    {
        Acceso acceso = new Acceso();

        public List<BE.Producto> ListaProductos()
        {
            List<BE.Producto> ls = new List<BE.Producto>();
            DataTable tabla = acceso.Leer("ListarProducto", null);
            foreach(DataRow Registro in tabla.Rows)
            {
                BE.Producto producto = new BE.Producto();
                producto.IdProdcuto = int.Parse(Registro["IdProducto"].ToString());
                producto.Descripcion = Registro["Description"].ToString();
                producto.PrecioUnit = int.Parse(Registro["PrecioUnit"].ToString());
                producto.Stock= int.Parse(Registro["Stock"].ToString());
                ls.Add(producto);
            }
            return ls;
        }

        public int AgregarProducto(BE.Producto product)
        {
            int fa =0;
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[1] = new SqlParameter("@Descripcion", product.Descripcion);
            parameters[2] = new SqlParameter("@PrecioUnit", product.PrecioUnit);
            parameters[3] = new SqlParameter("@Stock",product.Stock);
            fa= acceso.Escribir("InsertarProducto", parameters);

            return fa;
        }
        public int EditarProducto(BE.Producto product)
        {
            int fa =0;
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[1] = new SqlParameter("@Descripcion", product.Descripcion);
            parameters[2] = new SqlParameter("@PrecioUnit", product.PrecioUnit);
            parameters[3] = new SqlParameter("@Stock", product.Stock);
            parameters[0] = new SqlParameter("@IdProducto",product.IdProdcuto);
            fa = acceso.Escribir("EditarProducto", parameters);

            return fa;
        }
        public int EliminarProducto(BE.Producto product)
        {
            int fa = 0;

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@IdProducto", product.IdProdcuto);
            fa = acceso.Escribir("EliminarProdcuto", parameters);
            return fa;
        }

        public int ObtenerStock(BE.Producto prod)
        {
            int fa = 0;
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@IdProducto", prod.IdProdcuto);
            parameters[1] = new SqlParameter("@Stock", prod.Stock);

            return fa;
        }
    }
}
