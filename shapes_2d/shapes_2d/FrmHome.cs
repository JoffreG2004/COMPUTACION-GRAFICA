using System;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formularioActual = null;

            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is T)
                {
                    formularioActual = hijo;
                }
                else
                {
                    hijo.Close();
                }
            }

            if (formularioActual != null)
            {
                formularioActual.BringToFront();
                return;
            }

            T formulario = new T();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ExampletoolStripMenuItem2_Click(object sender, EventArgs e)
        {

            AbrirFormulario<FrmExample>(); ;

        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCirculo>();
        }

        private void óvaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmOvalo>();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmElipse>();
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmTriangle>();

        }

        private void cuadriláteroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRectangulo>();
        }

        private void polígonosRegularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPoligonos>();


        }

        private void paralelogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmParalelogramo>();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRombo>();
        }

        private void cometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCometa>();
        }

        private void estrellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEstrella>();
        }

        private void corazónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCorazon>();
        }

        private void lunaCrecienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario <FrmLunaCreciente>();
        }
    }
}
