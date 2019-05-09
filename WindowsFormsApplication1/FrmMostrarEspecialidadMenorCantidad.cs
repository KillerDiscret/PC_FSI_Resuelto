using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMostrarEspecialidadMenorCantidad : Form
    {
        Control objcontrol = new Control();

        public FrmMostrarEspecialidadMenorCantidad()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbEspecialidades.Items.Clear();
            List<string> ListaAux = objcontrol.MostrarEspecialidadMenor();

            foreach(string x in ListaAux)
            {
                lbEspecialidades.Items.Add(x);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
