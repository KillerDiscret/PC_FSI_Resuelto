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
    public partial class FrmListarMayorCantidadxEspecialidad : Form
    {
        Control objcontrol = new Control();

        public FrmListarMayorCantidadxEspecialidad()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(cbEspecialidad.SelectedIndex>=0)
            {
                List<Cuartel> listaAux = objcontrol.ListarCuartelesMayorSoldados(cbEspecialidad.SelectedItem.ToString());
                lbCuarteles.DisplayMember = "NOMBRE";
                lbCuarteles.DataSource = listaAux;
                cbEspecialidad.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Elija una especialidad");
            }


        }

        private void FrmListarMayorCantidadxEspecialidad_Load(object sender, EventArgs e)
        {
            cbEspecialidad.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
