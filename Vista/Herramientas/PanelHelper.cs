using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_BaseDeDatos.Vista.Herramientas
{
    public static class PanelHelper
    {

        public static void Abrir_Panel<MiForm>(Panel panel) where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                
        
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel.Controls.Add(formulario);
                panel.Tag = formulario;
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
