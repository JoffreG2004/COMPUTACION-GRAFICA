using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmFlecha : Form
    {
        private double ancho;
        private double largo;

        public FrmFlecha()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TxtAncho.Text, out ancho) || ancho <= 0)
            {
                MessageBox.Show("Ancho debe ser un número válido mayor a 0");
                return;
            }

            if (!double.TryParse(TxtLargo.Text, out largo) || largo <= 0)
            {
                MessageBox.Show("Largo debe ser un número válido mayor a 0");
                return;
            }

            // Calcular área y perímetro aproximado de la flecha
            double areaRectangulo = ancho * (largo * 0.6);
            double areaTriangulo = (ancho * 0.4 * largo) / 2.0;
            double areaTotal = areaRectangulo + areaTriangulo;

            double perimetro = ancho * 2 + largo * 2 + Math.Sqrt(ancho * ancho + (largo * 0.4) * (largo * 0.4));

            LblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            LblArea.Text = $"Área: {areaTotal:F2}";

            pnlFlecha.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            TxtAncho.Text = "";
            TxtLargo.Text = "";
            LblPerimetro.Text = "Perimetro:";
            LblArea.Text = "Área:";
            ancho = 0;
            largo = 0;
            pnlFlecha.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlFlecha_Paint(object sender, PaintEventArgs e)
        {
            if (ancho <= 0 || largo <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Clear panel background
            g.Clear(pnlFlecha.BackColor);

            // Use panel client rectangle as drawing bounds
            Rectangle panelBounds = pnlFlecha.ClientRectangle;
            RectangleF bounds = new RectangleF(panelBounds.X, panelBounds.Y, panelBounds.Width, panelBounds.Height);
            const float padding = 16f;

            float width = (float)ancho;
            float height = (float)largo;

            if (width <= 0f || height <= 0f)
            {
                return;
            }

            float scale = Math.Min((bounds.Width - padding * 2f) / width, (bounds.Height - padding * 2f) / height);
            scale = Math.Max(0.1f, scale);

            float offsetX = bounds.X + (bounds.Width - width * scale) / 2f;
            float offsetY = bounds.Y + (bounds.Height - height * scale) / 2f;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush fill = new SolidBrush(Color.FromArgb(150, Color.DeepSkyBlue)))
            {
                float scaledWidth = width * scale;
                float scaledHeight = height * scale;

                // Dibujar el cuerpo de la flecha (rectángulo)
                float bodyHeight = scaledHeight * 0.6f;
                g.FillRectangle(fill, offsetX, offsetY + (scaledHeight - bodyHeight) / 2f, scaledWidth * 0.7f, bodyHeight);
                g.DrawRectangle(pen, offsetX, offsetY + (scaledHeight - bodyHeight) / 2f, scaledWidth * 0.7f, bodyHeight);

                // Dibujar la punta de la flecha (triángulo)
                PointF[] arrowHead = new PointF[]
                {
                    new PointF(offsetX + scaledWidth * 0.7f, offsetY + (scaledHeight - bodyHeight) / 2f),
                    new PointF(offsetX + scaledWidth * 0.7f, offsetY + (scaledHeight - bodyHeight) / 2f + bodyHeight),
                    new PointF(offsetX + scaledWidth, offsetY + scaledHeight / 2f)
                };

                g.FillPolygon(fill, arrowHead);
                g.DrawPolygon(pen, arrowHead);
            }
        }
    }
}
