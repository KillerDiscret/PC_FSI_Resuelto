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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crearCuartelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuartel frm = new FrmCuartel();
            frm.ShowDialog();
        }

        private void registrarSoldadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSoldado frm = new FrmSoldado();
            frm.ShowDialog();
        }

        private void listarCuartelesConSoldadosDeMayorEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarCuartelesMayorEdad frm = new FrmListarCuartelesMayorEdad();
            frm.ShowDialog();
        }

        private void listarCuartelesConMayorCantidadDeSoldadosDeUnaEspecialiadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarMayorCantidadxEspecialidad frm = new FrmListarMayorCantidadxEspecialidad();
            frm.ShowDialog();
        }

        private void mostrarEspecialidadesQueTienenMenorCantidadDeSoldadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarEspecialidadMenorCantidad frm = new FrmMostrarEspecialidadMenorCantidad();
            frm.ShowDialog();
        }

        private void mostrarEdadPromedioDeSoldadosPorEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEdadPromedio frm = new FrmEdadPromedio();
            frm.ShowDialog();
        }
    }
}
