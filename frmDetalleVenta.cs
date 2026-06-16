using CapaEntidad;
using CapaNegocio;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using Document = iTextSharp.text.Document;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;


                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[]
                        { dv.oProducto.Nombre,dv.PrecioVenta,dv.Cantidad,dv.PrecioVenta * dv.Cantidad });
                }
                txtmontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontoPago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontoCambio.Text = oVenta.MontoCambio.ToString("0.00");


            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            dgvdata.Rows.Clear();
            txtmontoTotal.Text = "0.00";
            txtmontoPago.Text = "0.00";
            txtmontoCambio.Text = "0.00";
        }

       

        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No hay datos para generar el PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            //Se carga la plantilla de html desde los recursos del proyecto. Basicamente toda la plantilla se convierte en texto
            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();

            //Se reemplazan los datos de la plantilla por los datos de la compra
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@nitnegocio", odatos.NIT.ToUpper());
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion.ToUpper());

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text.ToUpper());

            Texto_Html = Texto_Html.Replace("@doccliente", txtdoccliente.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text.ToUpper());

            //Se recorre el datagridview para obtener las filas y se van concatenando en una variable de tipo string, basicamente se esta creando una tabla en html con los datos del datagridview
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontoTotal.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@pagocon", txtmontoPago.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@cambio", txtmontoCambio.Text.ToUpper());

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_a_Proveedor_{0}.PDF", txtnumerodocumento.Text);
            savefile.Filter = "PDF Files| *.pdf";

            //Se guarda el archivo pdf en la ruta seleccionada por el usuario
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    //cargo el logo del negocio
                    bool obtenido = true;
                    byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido == true)
                    {

                        // se le asigna el logo a una variable de tipo image de itextsharp, se escala la imagen para que se ajuste al tamaño del pdf, se alinea a la izquierda y se posiciona en la parte superior del pdf
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    //Se convierte el texto de la plantilla en un objeto de tipo html para que itextsharp lo pueda interpretar y se agrega al pdf
                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("PDF generado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
    }
