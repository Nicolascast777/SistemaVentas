using CapaEntidad;
using CapaNegocio;
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
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            //Cargar el combo de tipo de documento
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Remision", Texto = "Remision" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;
            //cargar la fecha de la compra
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtideproducto.Text = "0";

            txtpagocon.Text = "";
            txtcambio.Text = "";
            txttotalpagar.Text = "0";
            txtCantidad.Value = 1;
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                //Se abre el modal de los proveedores
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //Si el resultado del modal es OK, se obtiene el proveedor seleccionado en el modal y se muestran sus datos en los campos correspondientes del formulario de compras
                    if (result == DialogResult.OK)
                    {
                        txtnombreCliente.Text = modal._Cliente.NombreCompleto.ToString();
                        txtdocumentoCliente.Text = modal._Cliente.Documento;
                        txtcodigoProducto.Select();
                    }
                    else
                    {
                        txtdocumentoCliente.Select();
                    }

                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            using (var modal = new mdProducto())
            {
                //Se abre el modal 
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Si el resultado del modal es OK
                    txtideproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodigoProducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtCantidad.Select();

                    txtcodigoProducto.BackColor = Color.LimeGreen;

                }
                else
                {
                    txtcodigoProducto.Select();
                    txtcodigoProducto.BackColor = Color.RosyBrown;

                }

            }
        }

        private void txtcodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            //se valida si presiona Enter
            if (e.KeyData == Keys.Enter)
            {
                //.Where es un metodo extensible de las listas o colecciones, como el Where en sql
                //=> es una expresion lambda, es decir, una funcion anonima que se puede usar para filtrar o proyectar datos en una lista o coleccion o a acceder a las propiedades de los objetos o clases. En este caso, se esta filtrando la lista de productos para obtener el producto que tiene el codigo igual al texto ingresado en el campo txtcodproducto.
                //  Es como los arrows function de javascript
                // en este caso 'p' representaria a una clase de '.Listar'
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodigoProducto.BackColor = Color.LimeGreen;
                    txtideproducto.Text = oProducto.IdProducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtprecio.Text = oProducto.PrecioVenta.ToString();
                    txtstock.Text = oProducto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtcodigoProducto.BackColor = Color.RosyBrown;
                    txtideproducto.Text = "0";
                    txtProducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtCantidad.Value = 1;

                }

            }
        }

        private void btnagregarProducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            //Primero se validan los campos necesarios para agregar el producto al detalle de la venta, como el id del producto, el precio y el stock disponible. Si alguna de estas validaciones falla, se muestra un mensaje de error y se detiene la ejecución del método.
            if (int.Parse(txtideproducto.Text) == 0)
            {
                MessageBox.Show("Seleccione un producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            if (Convert.ToUInt32(txtstock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
            {
                MessageBox.Show("Stock no disponible.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Si todas las validaciones son correctas, se procede a agregar el producto al detalle de la venta. Para esto, se recorre el datagridview que muestra los productos agregados al detalle de la venta para verificar si el producto que se esta intentando agregar ya existe en el detalle. Si el producto ya existe, se actualiza la cantidad y el total del producto en el datagridview. Si el producto no existe, se agrega una nueva fila al datagridview con los datos del producto, la cantidad y el total correspondiente.
            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtideproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[] {
                    txtideproducto.Text,
                    txtProducto.Text,
                    txtprecio.Text,
                    txtCantidad.Value.ToString(),
                    (txtCantidad.Value  * precio).ToString("0.00")
                });
                CalcularTotalPagar();
                limpiarProdcuto();
                txtcodigoProducto.Select();
            }

            //else
            //{
            //    foreach (DataGridViewRow fila in dgvdata.Rows)
            //    {
            //        if (fila.Cells["IdProducto"].Value.ToString() == txtideproducto.Text)
            //        {
            //            int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value) + Convert.ToInt32(txtCantidad.Value);
            //            decimal total = decimal.Parse(fila.Cells["Precio"].Value.ToString()) * cantidad;
            //            fila.Cells["Cantidad"].Value = cantidad.ToString();
            //            fila.Cells["Total"].Value = total.ToString("0.00");
            //            break;
            //        }
            //    }
            //}
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.borrar25px.Width;
                var h = Properties.Resources.borrar25px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.borrar25px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    CalcularTotalPagar();
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es un numero, no se activa el controlador
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {//se valida q no inicie con puntos
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {//se lehace excepcion a la tecla de borrar, y si ya tiene texto ahora si permite escribir un punto
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else { e.Handled = true; }

                }
            }
        }

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es un numero, no se activa el controlador
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {//se valida q no inicie con puntos
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {//se lehace excepcion a la tecla de borrar, y si ya tiene texto ahora si permite escribir un punto
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else { e.Handled = true; }

                }
            }
        }

        private void CalcularTotalPagar()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }
            //adicional
            if(total == 0)
            {
                txttotalpagar.Text = "0";
            }
            else
            //adicional<-
            {
                txttotalpagar.Text = total.ToString("0,00");
            }          
            

        }

        private void limpiarProdcuto()
        {
            txtideproducto.Text = "0";
            txtcodigoProducto.Text = "";
            txtProducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtCantidad.Value = 1;
            txtcodigoProducto.BackColor = Color.White;
        }
        //metodo para calcular la devuelta al cliente, se llama cada vez que se cambia el valor del campo txtpagocon, y se valida que el valor ingresado sea un numero decimal,
        //si el valor ingresado es menor al total a pagar, se muestra 0 en el campo de cambio, de lo contrario se calcula la devuelta restando el total a pagar al valor ingresado en el campo de pago con, y se muestra el resultado en el campo de cambio.
        private void calcularDeuvelta() { 
            if(txttotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No hay productos en lista para la venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagaCon;
            decimal total = Convert.ToDecimal((txttotalpagar.Text));

            if(txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "0";
            }

            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagaCon)) {
                
                if (pagaCon <  total) {
                    txtcambio.Text = "0";
                }
                else
                {
                    decimal Devuelta = pagaCon - total;
                    txtcambio.Text = Devuelta.ToString("0,00");
                }
            }

        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                calcularDeuvelta();
            }
        }

        private void btn_5k_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Adicional - Cuando el usuario presione alguno de los botones de los billetes, se asigna el valor del billete al textvos de pagacon y se llama al metodo encargado de calcular la devuelta.
        private void btn_5k_Click(object sender, EventArgs e)
        {
            txtpagocon.Text = "5.000";
            calcularDeuvelta();
        }

        private void btn_10k_Click(object sender, EventArgs e)
        {
            txtpagocon.Text = "10.000";
            calcularDeuvelta();
        }

        private void btn_20k_Click(object sender, EventArgs e)
        {
            txtpagocon.Text = "20.000";
            calcularDeuvelta();
        }

        private void btn_50k_Click(object sender, EventArgs e)
        {
            txtpagocon.Text = "50.000";
            calcularDeuvelta();
        }
        //Adicional<-
    }
}
