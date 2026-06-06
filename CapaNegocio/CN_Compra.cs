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
    public class CN_Compra
    {

        private CD_Compra objcd_compra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerColerrativo();
        }

        //Metodo para registrar la compra, se le pasa el objeto compra y el detalle de la compra en un datatable
        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
                return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);

        }

        //16:00s
    }
}
