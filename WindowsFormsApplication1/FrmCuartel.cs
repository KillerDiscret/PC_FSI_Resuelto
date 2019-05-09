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
    public partial class FrmCuartel : Form
    {
        Control objcontrol = new Control();


        public FrmCuartel()
        {
            InitializeComponent();
        }

        private void FrmCuartel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtCodigo.Text!=""&&txtNombre.Text!=""&&txtDireccion.Text!=""&&cbCiudad.SelectedIndex>=0)
            {
                Cuartel objcuartel = new Cuartel();
                objcuartel.CODIGO = txtCodigo.Text;
                objcuartel.NOMBRE = txtNombre.Text;
                objcuartel.DIRECCION = txtDireccion.Text;
                objcuartel.CIUDAD = cbCiudad.SelectedItem.ToString();
                if (objcontrol.CuartelExiste(objcuartel.CODIGO) == true)
                {
                    MessageBox.Show("El codigo ya existe");
                }
                else
                {
                    objcontrol.AgregarCuartel(objcuartel);
                }
                txtCodigo.Clear();
                txtNombre.Clear();
                txtDireccion.Clear();
                cbCiudad.SelectedIndex = -1;
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
