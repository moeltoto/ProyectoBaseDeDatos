using Pry_BaseDeDatos.Vista.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_BaseDeDatos
{
    public partial class PaginaInicio : Form
    {
        public PaginaInicio()
        {
            InitializeComponent();
  
            btnIngresar.Left = (this.ClientSize.Width - btnIngresar.Width) / 2;
            txtboxNombre.Left = (this.ClientSize.Width - txtboxNombre.Width) / 2;
            panelDcoNombre.Left = (this.ClientSize.Width - panelDcoNombre.Width) / 2;
            txtboxContrasena.Left = (this.ClientSize.Width - txtboxContrasena.Width)/2;
            panelDcoContrasena.Left = (this.ClientSize.Width - panelDcoContrasena.Width) / 2;
            labCrearCuenta.Left = (this.ClientSize.Width - labCrearCuenta.Width) / 2;
            txtboxNombre.AutoSize = false;
            txtboxNombre.Height = 18;
            txtboxContrasena.AutoSize = false;
            txtboxContrasena.Height = 18;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            PanelHelper.Abrir_Panel<PaginaPrincipal>(PaginaFrotal);
            PaginaPrincipal formulario = new PaginaPrincipal();
            this.Size = formulario.Size;


        }
        private void labCrearCuentaMouseMove(object sender, MouseEventArgs e)
        {
            labCrearCuenta.ForeColor = Color.Blue;
        }

        private void labCrearCuentaMouseLeave(object sender, EventArgs e)
        {
            labCrearCuenta.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Abrir_Panel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PaginaFrotal.Controls.OfType<MiForm>().FirstOrDefault();
            if(formulario == null)
            {

                formulario = new MiForm();
                
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PaginaFrotal.Controls.Add(formulario);
                PaginaFrotal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
