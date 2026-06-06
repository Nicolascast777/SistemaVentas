using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Wordprocessing;
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
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtbusqueda.Text);
            if(oCompra.IdCompra != 0)
            {
                txtnumerodocumento.Text = oCompra.NumeroDocumento.ToString();

                txtfecha.Text = oCompra.FechaRegistro;

                txttipodocumento.Text = oCompra.TipoDocumento;
                
                txtusuario.Text = oCompra.oUsuaio.NombreCompleto;

                txtdocproveedor.Text = oCompra.oProveedor.Documento;

                txtnombreproveedor.Text = oCompra.oProveedor.RazonSocial;

                dataGridView1.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.oDetalleCompra){
                    dataGridView1.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });

                }

                txtmontototal.Text = oCompra.MontoTotal.ToString("0.00");


            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";

            dataGridView1.Rows.Clear();
            txtmontototal.Text = "";
        }

        //descargar en pdf el detalle de la compra
        //se usa paquede de nuggets itextsharp
        //Como plantilla se usara una plantilla de html que se cargara y se reemplazaran los datos de la compra por los datos de la plantilla
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(txttipodocumento.Text == "")
            {
                MessageBox.Show("No hay datos para generar el PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            //Se carga la plantilla de html desde los recursos del proyecto. Basicamente toda la plantilla se convierte en texto
            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();

            //Se reemplazan los datos de la plantilla por los datos de la compra
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@nitnegocio", odatos.NIT.ToUpper());
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion.ToUpper());

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text.ToUpper());

            Texto_Html = Texto_Html.Replace("@docproveedor", txtdocproveedor.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreproveedor.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text.ToUpper());

            //Se recorre el datagridview para obtener las filas y se van concatenando en una variable de tipo string, basicamente se esta creando una tabla en html con los datos del datagridview
            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text.ToUpper());

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_a_Proveedor_{0}.PDF", txtnumerodocumento.Text);
            savefile.Filter = "PDF Files| *.pdf";
            
            //Se guarda el archivo pdf en la ruta seleccionada por el usuario
            if (savefile.ShowDialog() == DialogResult.OK){
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create)){

                    Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25,25,25,25 );

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    //cargo el logo del negocio
                    bool obtenido = true;
                    byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if(obtenido == true){

                        // se le asigna el logo a una variable de tipo image de itextsharp, se escala la imagen para que se ajuste al tamaño del pdf, se alinea a la izquierda y se posiciona en la parte superior del pdf
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    //Se convierte el texto de la plantilla en un objeto de tipo html para que itextsharp lo pueda interpretar y se agrega al pdf
                    using (StringReader sr = new StringReader(Texto_Html)){
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
