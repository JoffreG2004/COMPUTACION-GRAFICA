using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmRectangulo : Form
    {
        public FrmRectangulo()
        {
            InitializeComponent();
        }

        int ancho, alto;

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtAncho.Text, out ancho) &&
                int.TryParse(TxtLargo.Text, out alto) &&
                ancho > 0 && alto > 0)
            {
                this.Invalidate();

                int perimetro = 2 * (ancho + alto);
                int area = ancho * alto;

                LblPerimetro.Text = $"Perímetro: {perimetro}";
                LblArea.Text = $"Área: {area}";
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }




        private void BtnResetear_Click(object sender, EventArgs e)
        {

            TxtAncho.Text = "";
            TxtLargo.Text = "";


            LblPerimetro.Text = "Perímetro:";
            LblArea.Text = "Área:";


            ancho = 0;
            alto = 0;


            this.Invalidate();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRectangulo_Paint(object sender, PaintEventArgs e)
        {

            {
                if (ancho > 0 && alto > 0)
                {
                    RectangleF bounds = new RectangleF(560f, 80f, 380f, 360f);

                    float width = ancho;
                    float height = alto;



                    float drawWidth = width * 5;
                    float drawHeight = height * 5;
                    float x = bounds.X + (bounds.Width - drawWidth) / 2f;
                    float y = bounds.Y + (bounds.Height - drawHeight) / 2f;


                    Graphics g = e.Graphics;
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.FillRectangle(Brushes.LightYellow, x, y, drawWidth, drawHeight);
                    using (Pen pen = new Pen(Color.Blue, 2))
                        g.DrawRectangle(pen, x, y, drawWidth, drawHeight);
                }
            }
        }
    }
}
