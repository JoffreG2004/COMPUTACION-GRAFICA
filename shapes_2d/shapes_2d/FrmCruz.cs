using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmCruz : Form
    {
        private double tamaño;

        public FrmCruz()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TxtTamaño.Text, out tamaño) || tamaño <= 0)
            {
                MessageBox.Show("Tamaño debe ser un número válido mayor a 0");
                return;
            }

            // Calcular área y perímetro de la cruz
            // Una cruz se compone de 5 cuadrados
            double areaTotal = 5 * tamaño * tamaño;
            // Perímetro de una cruz: 12 lados de tamaño
            double perimetro = 12 * tamaño;

            LblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            LblArea.Text = $"Área: {areaTotal:F2}";

            pnlCruz.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            TxtTamaño.Text = "";
            LblPerimetro.Text = "Perimetro:";
            LblArea.Text = "Área:";
            tamaño = 0;
            pnlCruz.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCruz_Paint(object sender, PaintEventArgs e)
        {
            if (tamaño <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Clear panel background
            g.Clear(pnlCruz.BackColor);

            // Use panel client rectangle as drawing bounds
            Rectangle panelBounds = pnlCruz.ClientRectangle;
            RectangleF bounds = new RectangleF(panelBounds.X, panelBounds.Y, panelBounds.Width, panelBounds.Height);
            const float padding = 16f;

            float size = (float)tamaño;

            // Calcular dimensiones de la cruz
            float width = size * 3f;
            float height = size * 3f;

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
                float scaledSize = size * scale;

                // Rectángulo vertical (centro)
                g.FillRectangle(fill, offsetX + scaledSize, offsetY, scaledSize, scaledSize * 3);
                g.DrawRectangle(pen, offsetX + scaledSize, offsetY, scaledSize, scaledSize * 3);

                // Rectángulo horizontal (centro)
                g.FillRectangle(fill, offsetX, offsetY + scaledSize, scaledSize * 3, scaledSize);
                g.DrawRectangle(pen, offsetX, offsetY + scaledSize, scaledSize * 3, scaledSize);
            }
        }
    }
}
