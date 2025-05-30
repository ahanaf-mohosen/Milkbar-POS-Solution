using System;
using System.Drawing;
using System.Windows.Forms;

namespace MilkbarPOS
{
    public partial class Form1 : Form
    {
        private bool _dragging;
        private Point _dragStartPoint;

        public Form1()
        {
            InitializeComponent();

            // Make form draggable from any control
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;

            // Optional: Make all controls trigger form dragging
            foreach (Control control in this.Controls)
            {
                control.MouseDown += Form_MouseDown;
                control.MouseMove += Form_MouseMove;
                control.MouseUp += Form_MouseUp;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point screenPosition = PointToScreen(
                    new Point(e.X - _dragStartPoint.X, e.Y - _dragStartPoint.Y));
                this.Location = screenPosition;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}