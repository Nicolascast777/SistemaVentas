using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
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
using static ClosedXML.Excel.XLPredefinedFormat;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        //Metodo para convertir array de bytes en un objeto tipo imagen
        public Image ByteToImage(byte[] imageBytes){
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);

            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            //se obtiene logo de la bd
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)  
                picLogo.Image = ByteToImage(byteimage);

            Negocio datos = new CN_Negocio().ObtenerDatos();
            
            txtnombre.Text = datos.Nombre;
            txtnit.Text = datos.NIT;
            txtdireccion.Text = datos.Direccion;


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK){
                //se abre cuadro de dialogo para busscar carpetas y archivos
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                
                //Se guarda logo en bd
                bool respuesta = new CN_Negocio().ActualizarLOgo(byteimage, out mensaje);

                if (respuesta)
                    picLogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        
        //Meotod para guardar los datos del negocio(compañia)
        private void iconButton2_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty ;
            //creo objeto tipo negocio, contiene los 3 atributos (nit, direccion, nombre)
            Negocio obj = new Negocio()
            {
                //asigno el contenido de mi objeto a los txt del form
                Nombre = txtnombre.Text,
                NIT = txtnit.Text,
                Direccion= txtdireccion.Text,
                PorcentajeRendimiento = txtPorcentaRendimiento.Value                
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                    MessageBox.Show("Los cambios fueron guardados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudieron guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
