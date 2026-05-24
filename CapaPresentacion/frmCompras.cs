using CapaEntidad;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{

    
    public partial class frmCompras : Form
    {
        //Seccion para recibir el usuario logueado desde el formulario de inicio, esto es para mostrar el nombre del usuario en la barra de estado y para controlar los permisos de acceso a los diferentes formularios del sistema
        private Usuario _Usuario;



        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            //Cargar el combo de tipo de documento
            cbotiposoporte.Items.Add(new OpcionCombo() { Valor = "Remision", Texto = "Remision" });
            cbotiposoporte.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotiposoporte.DisplayMember = "Texto";
            cbotiposoporte.ValueMember = "Valor";
            cbotiposoporte.SelectedIndex = 0;
            //cargar la fecha de la compra
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproveedor.Text = "0";
            txtidcodproducto.Text = "0";


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                //Se abre el modal de los proveedores
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Si el resultado del modal es OK, se obtiene el proveedor seleccionado en el modal y se muestran sus datos en los campos correspondientes del formulario de compras
                    if (modal._Proveedor != null)
                    {
                        txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                        txtnumerodocproveedor.Text = modal._Proveedor.Documento;
                        txtrazonsocialproveedor.Text = modal._Proveedor.RazonSocial;
                    }
                    else {
                        txtnumerodocproveedor.Select();
                    }

                }

            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {

            using (var modal = new mdProducto())
            {
                //Se abre el modal de los proveedores
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Si el resultado del modal es OK, se obtiene el proveedor seleccionado en el modal y se muestran sus datos en los campos correspondientes del formulario de compras
                    txtidcodproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtnombreprodcuto.Text = modal._Producto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }

                }

            }


        }
    }


