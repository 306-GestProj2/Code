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
        private SolidBrush eraser;
        private Pen lePen;
        private Graphics myGraphics;
        private bool isDrawing = false;
        private string stateTool = "pen";

        public Painting()
        {
            InitializeComponent();
            cmbSizeBrush.Text = "10";
            myBrush = new SolidBrush(lblColor.BackColor);
            myGraphics = picDrawingZone.CreateGraphics();
            pnlPen.BackColor = Color.LightGray;
            eraser = new SolidBrush(Color.White);
            lePen = new Pen(Color.White);
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

            Bitmap pasPerdre = new Bitmap(picDrawingZone.Width, picDrawingZone.Height);
            Graphics g = Graphics.FromImage(pasPerdre);
            Rectangle rect = picDrawingZone.RectangleToScreen(picDrawingZone.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, picDrawingZone.Size);
            g.Dispose();
            picDrawingZone.Image = pasPerdre;
        }

        private void picDrawingZone_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                myGraphics = picDrawingZone.CreateGraphics();
                switch (stateTool)
                {
                    case "pencil":
                        myGraphics.FillEllipse(myBrush, e.X, e.Y, Convert.ToInt64(cmbSizeBrush.Text), Convert.ToInt64(cmbSizeBrush.Text));
                        break;
                    case "pen":
                        myGraphics.FillRectangle(myBrush, e.X, e.Y, Convert.ToInt64(cmbSizeBrush.Text), Convert.ToInt64(cmbSizeBrush.Text));
                        break;
                    case "eraser":
                        myGraphics.FillRectangle(eraser, e.X, e.Y, Convert.ToInt64(cmbSizeBrush.Text), Convert.ToInt64(cmbSizeBrush.Text));
                        break;
                }
                myGraphics.Dispose();
            }
        }

        private void toutEffacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picDrawingZone.Refresh();
            picDrawingZone.Image = null;
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

        private void pnlPen_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "pen";
            pnlPen.BackColor = Color.LightGray;
            pnlPencil.BackColor = Color.White;
            pnlEraser.BackColor = Color.White;

        }

        private void pnlPencil_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "pencil";
            pnlPencil.BackColor = Color.LightGray;
            pnlPen.BackColor = Color.White;
            pnlEraser.BackColor = Color.White;
        }

        private void pnlEraser_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "eraser";
            pnlPencil.BackColor = Color.White;
            pnlPen.BackColor = Color.White;
            pnlEraser.BackColor = Color.LightGray;
        }
    }
}
