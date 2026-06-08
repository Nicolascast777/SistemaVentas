using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {

        private CD_Venta objcd_venta = new CD_Venta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcd_venta.SumarStock(idproducto, cantidad);
        }



        public int ObtenerCorrelativo()
        {
            return objcd_venta.ObtenerColerrativo();
        }

        //Metodo para registrar la venta, se le pasa el objeto venta y el detalle de la venta en un datatable
        public bool RegistrarVenta_(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.RegistrarVenta(obj, DetalleVenta, out Mensaje);

        }

    }
}
