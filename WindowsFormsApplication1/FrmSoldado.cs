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
    public partial class FrmSoldado : Form
    {
        Control objcontrol = new Control();

        public FrmSoldado()
        {
            InitializeComponent();
        }

        private void lbCuarteles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSoldado_Load(object sender, EventArgs e)
        {
            lbCuarteles.DisplayMember = "CODIGO";
            lbCuarteles.DataSource = Control.Cuarteles;
            lbCuarteles.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtDNI.Text!=""&&txtNombre.Text!=""&&txtEdad.Text!=""&&cbEspecialidad.SelectedIndex>=0&&lbCuarteles.SelectedIndex>=0)
            {
                Soldado objsoldado = new Soldado();
                objsoldado.DNI = txtDNI.Text;
                objsoldado.NOMBRE = txtNombre.Text;
                objsoldado.EDAD = Convert.ToInt32(txtEdad.Text);
                objsoldado.ESPECIALIDAD = cbEspecialidad.SelectedItem.ToString();
                Cuartel cuartelaux = (Cuartel)lbCuarteles.SelectedItem;
                if (objcontrol.SoldadoExiste(objsoldado.DNI) == true)
                {
                    MessageBox.Show("El soldado ya existe");
                }
                else
                {
                    objcontrol.AgregarSoldado(cuartelaux.CODIGO, objsoldado);
                    txtDNI.Clear();
                    txtNombre.Clear();
                    txtEdad.Clear();
                    cbEspecialidad.SelectedIndex = -1;
                    lbCuarteles.SelectedIndex = -1;

                }
            }
            else
            {
                MessageBox.Show("Complete las casillas");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
