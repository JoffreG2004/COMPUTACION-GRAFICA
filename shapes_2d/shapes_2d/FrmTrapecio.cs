using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmTrapecio : Form
    {
        private double B = 0; // base mayor
        private double b = 0; // base menor
        private double h = 0; // altura
        private double lateral1 = 0;
        private double lateral2 = 0;
        private bool lateralesEspecificados = false;

        public FrmTrapecio()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Parse required values
            if (!double.TryParse(txtBaseMay.Text, out B) || B <= 0)
            {
                MessageBox.Show("Ingrese una Base Mayor (B) válida.");
                return;
            }

            if (!double.TryParse(txtBaseMen.Text, out b) || b <= 0)
            {
                MessageBox.Show("Ingrese una Base Menor (b) válida.");
                return;
            }

            if (!double.TryParse(txtAltura.Text, out h) || h <= 0)
            {
                MessageBox.Show("Ingrese una Altura (h) válida.");
                return;
            }

            // Optional laterals
            bool l1OK = double.TryParse(txtLateral1.Text, out lateral1) && lateral1 > 0;
            bool l2OK = double.TryParse(txtLateral2.Text, out lateral2) && lateral2 > 0;

            lateralesEspecificados = l1OK && l2OK;

            // Area always uses B, b, h
            double area = (B + b) * h / 2.0;

            double perimetro;
            if (lateralesEspecificados)
            {
                perimetro = B + b + lateral1 + lateral2;
            }
            else
            {
                // assume isosceles: compute each lateral by Pythagoras
                // horizontal half-difference
                double halfDiff = Math.Abs(B - b) / 2.0;
                double lateralIso = Math.Sqrt(halfDiff * halfDiff + h * h);
                perimetro = B + b + 2 * lateralIso;

                // store the computed laterals for possible drawing/labeling
                lateral1 = lateral2 = lateralIso;
            }

            LblArea.Text = $"Área: {area:F2}";
            LblPerimetro.Text = $"Perimetro: {perimetro:F2}";

            // Redraw panel
            pnlTrapecio.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            txtBaseMen.Text = "";
            txtAltura.Text = "";
            txtLateral1.Text = "";
            txtBaseMay.Text = "";
            txtLateral2.Text = "";
            LblPerimetro.Text = "Perimetro:";
            LblArea.Text = "Área:";

            B = b = h = lateral1 = lateral2 = 0;
            lateralesEspecificados = false;

            pnlTrapecio.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTrapecio_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(pnlTrapecio.BackColor);

            // 1. Verificación de seguridad: Evitar NaN, infinitos o ceros
            if (double.IsNaN(B) || double.IsNaN(b) || double.IsNaN(h) || B <= 0 || b <= 0 || h <= 0)
                return;

            float panelW = pnlTrapecio.ClientSize.Width;
            float panelH = pnlTrapecio.ClientSize.Height;

            if (panelW < 10 || panelH < 10) return; // Si el panel es demasiado pequeño, no dibujar

            // 2. Lógica de escala mejorada
            double baseMayor = Math.Max(B, b);
            double baseMenor = Math.Min(B, b);
            float margin = 0.8f; // Reducimos un poco más el margen para etiquetas

            float scaleW = (float)((panelW * margin) / baseMayor);
            float scaleH = (float)((panelH * margin) / h);
            float scale = Math.Min(scaleW, scaleH);

            // Limitamos la escala para que no sea infinita si algo sale mal
            if (float.IsInfinity(scale) || scale <= 0) scale = 1.0f;

            float drawBottom = (float)(baseMayor * scale);
            float drawTop = (float)(baseMenor * scale);
            float drawHeight = (float)(h * scale);

            // 3. Posicionamiento
            float x0 = (panelW - drawBottom) / 2f;
            float y0 = (panelH - drawHeight) / 2f;
            float topLeftX = x0 + (drawBottom - drawTop) / 2f;

            PointF[] poly = new PointF[4];
            poly[0] = new PointF(x0, y0 + drawHeight);               // Abajo-Izquierda
            poly[1] = new PointF(x0 + drawBottom, y0 + drawHeight);  // Abajo-Derecha
            poly[2] = new PointF(topLeftX + drawTop, y0);            // Arriba-Derecha
            poly[3] = new PointF(topLeftX, y0);                     // Arriba-Izquierda

            // 4. Dibujo de la figura
            using (Brush brush = new SolidBrush(Color.LightSalmon))
                g.FillPolygon(brush, poly);

            using (Pen pen = new Pen(Color.DarkBlue, 2))
                g.DrawPolygon(pen, poly);

            // 5. Dibujo de etiquetas con validación de texto
            using (Font f = new Font("Segoe UI", 9F, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(Color.Black))
            {
                // Usamos variables locales de texto para evitar problemas con valores nulos
                string l1Text = $"L1: {lateral1:F1}";
                string l2Text = $"L2: {lateral2:F1}";

                // Dibujamos las etiquetas asegurándonos de que las coordenadas sean float válidos
                g.DrawString(l1Text, f, textBrush, poly[0].X - 20, poly[0].Y + 5);
                g.DrawString(l2Text, f, textBrush, poly[1].X - 20, poly[1].Y + 5);

                g.DrawString($"B: {baseMayor:F1}", f, textBrush, x0 + (drawBottom / 2) - 15, y0 + drawHeight + 5);
                g.DrawString($"b: {baseMenor:F1}", f, textBrush, topLeftX + (drawTop / 2) - 15, y0 - 20);
            }
        }
    }
}
