using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bases_Rutas
{
    public partial class Form1 : Form
    {
        Bases bases;
        Rutas rutas = new Rutas();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            rutas.Agregar(bases = new Bases(txtNombreAgregInicio.Text, Convert.ToInt32(txtAgregTiempIni.Text)));
            txtNombreAgregInicio.Clear(); txtAgregTiempIni.Clear();
        }

        private void btnAgregInicio_Click(object sender, EventArgs e)
        {
            rutas.AgregarInicio(bases = new Bases(txtNombreAgregInicio.Text, Convert.ToInt32(txtAgregTiempIni.Text)));
            txtNombreAgregInicio.Clear(); txtAgregTiempIni.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Bases busqueda = rutas.Buscar(txtBuscar.Text);

            if (busqueda != null)
            {
                txtReportOpe.Text = "Nombre: " + Convert.ToString(busqueda.nombre) + Environment.NewLine;
                txtReportOpe.Text += "Tiempo: " + Convert.ToString(busqueda.minutos) + Environment.NewLine;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            rutas.Eliminar(txtEliminar.Text);
        }

        private void btnEliminarIn_Click(object sender, EventArgs e)
        {
            rutas.EliminarInicio();
        }

        private void btnEliminarF_Click(object sender, EventArgs e)
        {
            rutas.EliminarFinal();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReportOpe.Text = rutas.Reporte();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            rutas.Insertar(txtInsertar.Text, bases = new Bases(txtInsertar.Text, Convert.ToInt32(txtAgregTiempIni.Text)));
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            txtReportOpe.Text = rutas.Recorrido(txtRecoNombre.Text, Convert.ToInt32(txtTI.Text), Convert.ToInt32(txtTF.Text));
        }
    }
    
}
