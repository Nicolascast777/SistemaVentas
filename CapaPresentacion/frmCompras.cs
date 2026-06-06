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
                    else
                    {
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
        //Metodo para buscar un producto al presionar la tecla Enter.
        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        { //se valida si presiona Enter
            if (e.KeyData == Keys.Enter)
            {
                //.Where es un metodo extensible de las listas o colecciones, como el Where en sql
                //=> es una expresion lambda, es decir, una funcion anonima que se puede usar para filtrar o proyectar datos en una lista o coleccion o a acceder a las propiedades de los objetos o clases. En este caso, se esta filtrando la lista de productos para obtener el producto que tiene el codigo igual al texto ingresado en el campo txtcodproducto.
                //  Es como los arrows function de javascript
                // en este caso 'p' representaria a una clase de '.Listar'
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = Color.LimeGreen;
                    txtidcodproducto.Text = oProducto.IdProducto.ToString();
                    txtnombreprodcuto.Text = oProducto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.RosyBrown;
                    txtidcodproducto.Text = "0";
                    txtnombreprodcuto.Text = "";

                }

            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {


            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool productoExiste = false; //para no repetir un producto en la lista

            //A continuacion, validaciones de los valores digitados.
            if (int.Parse(txtidcodproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out precioCompra))
            {
                MessageBox.Show("El precio de compra no es un valor valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioVenta))
            {
                MessageBox.Show("El precio de venta no es un valor valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;

            }

            //Validacion para que no se repita un producto en la lista, se recorre el datagridview para verificar si el producto ya existe en la lista, si existe, se actualiza la cantidad y el precio de compra y venta, si no existe, se agrega una nueva fila al datagridview con los datos del producto.

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                //Se valida si la columna no es null y recorriendo el foreach encuentra la que estoy agregando 
                if (fila.Cells["IdProducto"].Value != null && fila.Cells["IdProducto"].Value.ToString() == txtidcodproducto.Text)
                {
                    productoExiste = true;
                    break;//Si encuentra el prodcuto sale del foreach

                }
            }

            if (!productoExiste)
            {
                // Con ToString("N2") o tambien ("0,00")manejo la cantidad de decimales
                dgvdata.Rows.Add(new object[] {
                    txtidcodproducto.Text,
                    txtcodproducto.Text,
                    precioCompra.ToString("N2"),
                    precioVenta.ToString("N2"),
                    nudcantidad.Value.ToString(),
                    (nudcantidad.Value * precioCompra).ToString("N2")
                });

                calcularTotal();
                limpiarCamposProducto();
                txtcodproducto.Select();

            }

        }

        private void limpiarCamposProducto()
        {
            txtidcodproducto.Text = "0";
            txtcodproducto.Text = "";
            txtnombreprodcuto.Text = "";
            txtcodproducto.BackColor = Color.White;
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            nudcantidad.Value = 1;
            txtcodproducto.Select();
        }
        private void limpiarCamposProve()
        {
            txtidproveedor.Text = "0";
            txtnumerodocproveedor.Text = "";
            txtrazonsocialproveedor.Text = "";
            dgvdata.Rows.Clear();
            calcularTotal();
            
        }

        //Metodo para calcular el total de la compra, se recorre el datagridview para sumar el total de cada fila y mostrar el resultado en el campo txttotal.
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvdata.Rows)
                {
                    total = Convert.ToDecimal(fila.Cells["SubTotal"].Value) + total;
                }
                txttotalpagar.Text = total.ToString("N2");

            }
        }

        //metodo para mostrar el icono de eliminar en el datagridview, se valida si la columna es la de eliminar y se dibuja el icono en el centro de la celda.
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
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
        //Funcion para eliminar una fila del datagridview al hacer click en el icono de eliminar, se valida si la columna es la de eliminar y se elimina la fila correspondiente, luego se recalcula el total de la compra.
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();


                }
            }

        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es un numero, no se activa el controlador
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {//se valida q no inicie con puntos
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es un numero, no se activa el controlador
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {//se valida q no inicie con puntos
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        //Metodo del boton para agregar la compra. Se validan los datos necesarios para registrar la compra, como el proveedor y los productos agregados a la compra, luego se crea datatable para el detalle de la compra y se llena con los datos del datagridview, finalmente se llama al metodo Registrar de la clase CN_Compra para guardar la compra en la base de datos.
        private void btnregistrarcompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar productos a la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();
            //columnas y tipo de datos del dataTable
            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("SubTotal", typeof(decimal));

            //Se itera el datagridview con sus celdas y filas para llenar el datatable que se enviara con el detalle de la compra y todos los       
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                    });
            }

            //Se obtiene idCorrelativo o id autoincrementable

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            //El formato sera de 5 digitos, con ceros a la izquierda. Al futuro se puede agregar un prefijo para identificar el tipo de documento, por ejemplo, CMP para compras, y luego el numero correlativo con el formato de 5 digitos.
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            //Se registra la compra, se crea un objeto compra con los datos necesarios para registrar la compra. Luego se llama al metodo Registrar de la clase CN_Compra para guardar la compra en la base de datos, enviando el objeto compra y el datatable con el detalle de la compra.
            Compra oCompra = new Compra()
            {
                oUsuaio = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbotiposoporte.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };
            
            string mensaje = string.Empty;
            //Se hace el llamado al metodo de registrar la compra en la bd, se le pasa el objeto compra, el detalle como dataTable y el mensaje q ddevolvera la ejecucion
            bool respuesta  = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Compra registrada exitosamente. Número de compra:\n" + numeroDocumento + "\n\n" + "¿Desea copiar el numero de la compra " +
                    "al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { 
                    Clipboard.SetText(numeroDocumento);
                }
                limpiarCamposProve();
            }
            else{
                MessageBox.Show("No se pudo registrar la compra. Mensaje de error:\n\n" + mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


