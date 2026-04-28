using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmCuadrado : Form
    {
        private int lado = 0;

        public FrmCuadrado()
        {
            InitializeComponent();
        }


        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLado.Text, out int parsedLado) &&
                parsedLado > 0)
            {
                lado = parsedLado;

                int perimetro = 4 * lado;
                int area = lado * lado;

                LblPerimetro.Text = $"Perímetro: {perimetro}";
                LblArea.Text = $"Área: {area}";

                // Redraw only the panel
                pnlCuadrado.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }


        private void BtnResetear_Click(object sender, EventArgs e)
        {
            txtLado.Text = "";

            lado = 0;

            LblPerimetro.Text = "Perímetro:";
            LblArea.Text = "Área:";

            pnlCuadrado.Invalidate();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCuadrado_Paint(object sender, PaintEventArgs e)
        {
            if (pnlCuadrado == null)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(pnlCuadrado.BackColor);

            if (lado > 0)
            {
                Rectangle boundsRect = pnlCuadrado.ClientRectangle;
                float boundsWidth = boundsRect.Width;
                float boundsHeight = boundsRect.Height;

                float maxAvailable = Math.Min(boundsWidth, boundsHeight) * 0.9f;

                float drawSide = lado;

                if (drawSide > maxAvailable)
                {
                    float scale = maxAvailable / drawSide;
                    drawSide = drawSide * scale;
                }

                float x = (boundsWidth - drawSide) / 2f;
                float y = (boundsHeight - drawSide) / 2f;

                using (Brush brush = new SolidBrush(Color.LightYellow))
                {
                    g.FillRectangle(brush, x, y, drawSide, drawSide);
                }

                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    g.DrawRectangle(pen, x, y, drawSide, drawSide);
                }

                using (Pen boundsPen = new Pen(Color.FromArgb(80, Color.Gray), 1))
                {
                    boundsPen.DashStyle = DashStyle.Dash;
                    g.DrawRectangle(boundsPen, 0, 0, boundsWidth - 1, boundsHeight - 1);
                }
            }
        }
    }
}
