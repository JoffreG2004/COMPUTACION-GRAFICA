using System.Drawing;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmExample : Form
    {
        public FrmExample()
        {
            InitializeComponent();
        }

        private void FrmExample_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; Pen pen = new Pen(Color.Blue, 2);
            g.DrawLine(pen, 20, 50, 200, 100);
            g.DrawRectangle(Pens.Red, 50, 50, 100, 60);
            g.DrawString("Hola!", new Font("Arial", 16), Brushes.Green, new PointF(50, 150));
            g.DrawEllipse(Pens.Red, 150, 150, 80, 80);
        }
    }
}
