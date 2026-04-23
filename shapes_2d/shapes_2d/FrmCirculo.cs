using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmCirculo : Form
    {
        private double radio;

        public FrmCirculo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TxtRadio.Text, out radio) || radio <= 0)
            {
                MessageBox.Show("Radio (a) debe ser un número válido mayor a 0");
                return;
            }

            double perimetro = 2 * Math.PI * radio;
            double area = Math.PI * radio * radio;

            LblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            LblArea.Text = $"Área: {area:F2}";

            this.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            TxtRadio.Text = "";
            LblPerimetro.Text = "Perimetro:";
            LblArea.Text = "Área:";
            radio = 0;
            this.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCirculo_Paint(object sender, PaintEventArgs e)
        {
            if (radio <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush fill = new SolidBrush(Color.FromArgb(128, Color.GreenYellow)))
            {
                float diameter = (float)radio * 2f * 10f;


                g.FillEllipse(fill, 700, 150, diameter, diameter);
                g.DrawEllipse(pen, 700, 150, diameter, diameter);
            }
        }
    }
}
