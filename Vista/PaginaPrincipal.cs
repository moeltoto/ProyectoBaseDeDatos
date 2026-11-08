using Pry_BaseDeDatos.Vista;
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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMisCursos_Click(object sender, EventArgs e)
        {
            PanelHelper.Abrir_Panel<PaginaCursosComprados>(panelPantallaPrincipal);
            PaginaCursosComprados p = new PaginaCursosComprados();
            panelPantallaPrincipal = p.
        }
    }
}
