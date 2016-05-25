using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormCalculFunction
{
    public partial class FormCalculFunction : Form
    {
        public FormCalculFunction()
        {
            InitializeComponent();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            DrawPanel.Refresh();

            double ValueA = 0;
            double ValueB = 0;
            double ValueC = 0;
            double FirstX;
            double FirstY;

            int origo_x = DrawPanel.Width / 2;
            int origo_y = DrawPanel.Height / 2;
            Point origo = new Point(origo_x,origo_y);

            Bitmap pen = new Bitmap(1, 1);
            pen.SetPixel(0, 0, Color.Blue);
            System.Drawing.Graphics g = DrawPanel.CreateGraphics();

            if (TextBoxValueA.Text == "" || TextBoxValueB.Text == "" || TextBoxValueC.Text == "")
            {
                MessageBox.Show("Veuillez remplir toute les cellules (en cas de valeur nulle entrer la valeur 0 et ne laisser pas la cellule vide)");
            }
            else
            {
                //ValueA = Convert.ToDouble(TextBoxValueA.Text) * (-1);
                //ValueB = Convert.ToDouble(TextBoxValueB.Text) * (-1);
                //ValueC = Convert.ToDouble(TextBoxValueC.Text) * (-1);
                ValueA = Convert.ToDouble(TextBoxValueA.Text);
                ValueB = Convert.ToDouble(TextBoxValueB.Text);
                ValueC = Convert.ToDouble(TextBoxValueC.Text);

                if (ValueA >= -10 && ValueA <= 10)
                {
                    if (ValueB >= -10 && ValueB <= 10)
                    {
                        if (ValueC >= -10 && ValueC <= 10)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Veuiller entrer une valeur comprise entre -10 et 10");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuiller entrer une valeur comprise entre -10 et 10");
                    }
                }
                else
                {
                    MessageBox.Show("Veuiller entrer une valeur comprise entre -10 et 10");
                }

                //if ((Math.Pow(ValueB, 2) - (4 * ValueA * ValueC)) / (2 * ValueA) < 0) // Check if the discriminant is positiv
                //{
                //    FirstX = (-ValueB + Math.Sqrt(Math.Pow(ValueB, 2) - (4 * ValueA * ValueC))) / (2 * ValueA);
                //    SecondX = (-ValueB - Math.Sqrt(Math.Pow(ValueB, 2) - (4 * ValueA * ValueC))) / (2 * ValueA);
                //}
                //else if ((Math.Pow(ValueB, 2) - (4 * ValueA * ValueC)) / (2 * ValueA) == 0) // check if the discriminant is neutral
                //{
                //    FirstX = SecondX = -(ValueB / (2 * ValueA));
                //}
                //else
                //{

                //}

                //Début tableau
                Double[,] storePoint = new Double[201,2];

                double minY = 0;
                double maxY = 0;

                //store
                for (double j = 0, i = -10; i <= 10 && j < 201; i+= 0.1, j++)
                {
                    FirstX = i;
                    FirstY = (ValueA * (FirstX * FirstX)) + ((ValueB * FirstX) + ValueC);
                    storePoint[(int)j, 0] = FirstX;
                    storePoint[(int)j, 1] = FirstY;

                    //g.DrawImageUnscaled(pen, origo_x + (int)FirstX, origo_y - (int)FirstY);
                    //g.DrawImageUnscaled(pen, origo_x - (int)FirstX, origo_y - (int)FirstY);

                    if (maxY < storePoint[(int)j, 1] && storePoint[(int)j, 1] > 0)
                    {
                        maxY = storePoint[(int)j, 1];
                    }
                    if (minY > storePoint[(int)j, 1] && storePoint[(int)j, 1] < 0)
                    {
                        minY = storePoint[(int)j, 1];
                    }


                }
                

                if (Math.Abs(minY) > Math.Abs(maxY))
                {
                    maxY = minY;
                }

                double MaxYValue = maxY;
                MaxYValue = Math.Round(maxY);

                if (MaxYValue < 0)
                {
                    lblmaxY.Text = Convert.ToString(MaxYValue * (-1));
                    lblminY.Text = Convert.ToString(MaxYValue);
                }
                else if (MaxYValue > 0)
                {
                    lblmaxY.Text = Convert.ToString(MaxYValue);
                    lblminY.Text = "- " + Convert.ToString(MaxYValue);
                }
                maxY = Math.Abs(origo_y / maxY);




                //Draw
                for (int i = 0; i <= 200; i++)
                {
                    Point newpoint = new Point((int)((storePoint[i, 0] + 10) * (origo.X / 10)), 
                                               (int)(origo_y - (maxY * storePoint[i, 1])));

                    //g.DrawImageUnscaled(pen, origo_x + (int)FirstX, origo_y - (int)FirstY);
                    //g.DrawImageUnscaled(pen, origo_x - (int)FirstX, origo_y - (int)FirstY);
                    //g.DrawImageUnscaled(pen, origo);
                    g.DrawImageUnscaled(pen, newpoint);
                    
                }

                SaveDrawing();
            }

            
        }

        private void FormCalculFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter ce module ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen linepen;
            linepen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics g = DrawPanel.CreateGraphics();
            g.DrawLine(linepen, 0, DrawPanel.Height / 2, DrawPanel.Width, DrawPanel.Height / 2);
            g.DrawLine(linepen, DrawPanel.Width / 2, 0, DrawPanel.Width / 2, DrawPanel.Height);
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Ceci est ma dernière trace dans ce module inachevé");
        }

        private void SaveDrawing()
        {
            Bitmap pasPerdre = new Bitmap(DrawPanel.Width, DrawPanel.Height);
            Graphics g = Graphics.FromImage(pasPerdre);
            Rectangle rect = DrawPanel.RectangleToScreen(DrawPanel.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, DrawPanel.Size);
            g.Dispose();
            DrawPanel.BackgroundImage = pasPerdre;
        }

        private void FormCalculFunction_Leave(object sender, EventArgs e)
        {
            SaveDrawing();
        }


    }
}
