//Adicional
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class FormBase : Form
    {
        public FormBase()
        {
            // Fuente moderna
            this.Font = new Font("Segoe UI", 11F, FontStyle.Regular);

            // Fondo claro
            this.BackColor = Color.WhiteSmoke;

            // Aplicar estilos a todos los controles al cargar
            this.Load += (s, e) => AplicarEstilos(this);
        }

        private void AplicarEstilos(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Font = this.Font;

                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.SteelBlue;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
                }

                if (ctrl.HasChildren)
                    AplicarEstilos(ctrl);
            }
        }
    }
}

//Adicional