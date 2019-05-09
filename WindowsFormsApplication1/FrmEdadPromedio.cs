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
    public partial class FrmEdadPromedio : Form
    {
        Control objcontrol = new Control();
        public FrmEdadPromedio()
        {
            InitializeComponent();
        }

        private void FrmEdadPromedio_Load(object sender, EventArgs e)
        {
            List<Soldado> ListaAux = objcontrol.MostrarEdadPromedio();
            lbEspecialidad.DisplayMember = "ESPECIALIDAD";
            lbEspecialidad.DataSource = ListaAux;
            lbEdad.DisplayMember = "EDAD";
            lbEdad.DataSource = ListaAux;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
