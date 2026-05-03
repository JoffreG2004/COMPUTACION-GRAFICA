using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmElipse : Form
    {
        private double radio1;
        private double radio2;

        public FrmElipse()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRadio1.Text, out radio1) || radio1 <= 0)
            {
                MessageBox.Show("Radio (a) debe ser un número válido mayor a 0");
                return;
            }

            if (!double.TryParse(txtRadio2.Text, out radio2) || radio2 <= 0)
            {
                MessageBox.Show("Radio (b) debe ser un número válido mayor a 0");
                return;
            }

            double perimetro = Math.PI * (3 * (radio1 + radio2) - Math.Sqrt((3 * radio1 + radio2) * (radio1 + 3 * radio2)));
            double area = Math.PI * radio1 * radio2;

            lblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            lblArea.Text = $"Área: {area:F2}";

            this.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            txtRadio1.Text = "";
            txtRadio2.Text = "";
            lblPerimetro.Text = "Perimetro:";
            lblArea.Text = "Área:";
            radio1 = 0;
            radio2 = 0;
            this.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmElipse_Paint(object sender, PaintEventArgs e)
        {
            if (radio1 <= 0 || radio2 <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush fill = new SolidBrush(Color.FromArgb(128, Color.MediumPurple)))
            {
                float width = (float)radio1 * 2f * 10f;
                float height = (float)radio2 * 2f * 10f;

                g.FillEllipse(fill, 700f, 150f, width, height);
                g.DrawEllipse(pen, 700f, 150f, width, height);
            }
        }
    }
}
