using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ToolBoxETML_Dessin;

namespace ToolBoxETML_Dessin
{
    public partial class Painting : Form
    {
        private SolidBrush myBrush;
        private SolidBrush eraser;
        private Pen lePen;
        private Graphics myGraphics;
        private Graphics recoveryGraphics;
        private bool isDrawing = false;
        private string stateTool = "pen";
        private bool blnSave = true;
        private string txtToAdd = null;
        private string selectedFont = "Arial";
        private int selectedSize = 12;
        Text formText = new Text();
        private int intX;
        private int intY;
        private int nbOfTicks = 0;
        About About = new About();

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
            intX = e.X;
            intY = e.Y;
        }

        private void picDrawingZone_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            if (blnSave)
            {
                SaveDrawing();
            }
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
                    //case "text":

                    //    break;
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
            blnSave = false;
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
            blnSave = true;
            
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
            pnlText.BackColor = Color.White;
        }

        private void pnlEraser_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "eraser";
            pnlPencil.BackColor = Color.White;
            pnlPen.BackColor = Color.White;
            pnlEraser.BackColor = Color.LightGray;
            pnlText.BackColor = Color.White;
        }


        private void SaveDrawing()
        {
            Bitmap pasPerdre = new Bitmap(picDrawingZone.Width, picDrawingZone.Height);
            Graphics g = Graphics.FromImage(pasPerdre);
            Rectangle rect = picDrawingZone.RectangleToScreen(picDrawingZone.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, picDrawingZone.Size);
            g.Dispose();
            picDrawingZone.Image = pasPerdre;
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blnSave = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Png files|*.png";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               Image.FromFile(open.FileName);
            }
            picDrawingZone.Image = Image.FromFile(open.FileName);
        }

        private void pnlText_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "text";
            pnlPencil.BackColor = Color.White;
            pnlPen.BackColor = Color.White;
            pnlEraser.BackColor = Color.White;
            pnlText.BackColor = Color.LightGray;
        }

        private void picDrawingZone_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("X: " + intX.ToString() + " // Y: " + intY.ToString() + " // Texte: " + txtToAdd);

                if (stateTool == "text")
                {
                    timAntiBug.Enabled = true;
                }
        }

        private void btnValidateText_Click(object sender, EventArgs e)
        {
            if (stateTool == "text")
            {
                Text Text = new Text();
                if (txtToAdd == null)
                {
                    if (Text.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        txtToAdd = Text.ReturnText();
                    }
                }
            }
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFont = Convert.ToString(fontDialog.Font.Name);
                selectedSize = Convert.ToInt32(fontDialog.Font.Size);
            }
        }

        private void DrawText()
        {
                if (txtToAdd != null)
                    TextRenderer.DrawText(myGraphics, txtToAdd, new Font(selectedFont, selectedSize), new Point(intX, intY), lblColor.BackColor);
                //myGraphics.DrawString(txtToAdd, new Font(selectedFont, selectedSize), myBrush, new Point(intX, intY));  
                txtToAdd = null;
                intX = 0;
                intY = 0;
                nbOfTicks = 0;
                timAntiBug.Enabled = false;
        }

        private void timAntiBug_Tick(object sender, EventArgs e)
        {
            nbOfTicks++;

            if (nbOfTicks == 1)
            {
                DrawText();
            }
        }

        private void pleinÉcranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.TopMost = false;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.ShowDialog();
        }

        private void sombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            
            grpBxTools.BackColor = Color.Gray;
            grpTools.BackColor = Color.Gray;
            menuStrip.BackColor = Color.Gray;
            
            menuStrip.ForeColor = Color.White;
            grpBxTools.ForeColor = Color.White;
            grpTools.ForeColor = Color.White;

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = btnValidateText.BackColor;

            grpBxTools.BackColor = Color.Gray;
            grpTools.BackColor = Color.Gray;
            menuStrip.BackColor = Color.Gray;

            menuStrip.ForeColor = Color.White;
            grpBxTools.ForeColor = Color.White;
            grpTools.ForeColor = Color.White;
        }
    }
}
