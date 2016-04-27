using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ToolBoxETML_Dessin
{
    public partial class Painting : Form
    {
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private bool isDrawing = false;

        public Painting()
        {
            InitializeComponent();
            cmbSizeBrush.Text = "10";
            myBrush = new SolidBrush(lblColor.BackColor);
            myGraphics = picDrawingZone.CreateGraphics();
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            if (pickAColor.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = pickAColor.Color;
                myBrush.Color = lblColor.BackColor;
            }
        }

        private void picDrawingZone_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void picDrawingZone_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void picDrawingZone_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                myGraphics = picDrawingZone.CreateGraphics();
                myGraphics.FillEllipse(myBrush, e.X, e.Y, Convert.ToInt64(cmbSizeBrush.Text), Convert.ToInt64(cmbSizeBrush.Text));
                myGraphics.Dispose();
            }
        }

        private void toutEffacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(Color.White);
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picDrawingZone.Width, picDrawingZone.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = picDrawingZone.RectangleToScreen(picDrawingZone.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, picDrawingZone.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bmp.Save(s.FileName, ImageFormat.Png);
            }
            
        }
    }
}
