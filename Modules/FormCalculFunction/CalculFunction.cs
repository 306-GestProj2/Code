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
    public partial class CalculFunction : Form
    {
        public CalculFunction()
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
            double SecondX;
            double FirstY;

            int origo_x = DrawPanel.Width / 2;
            int origo_y = DrawPanel.Height / 2;


            Bitmap pen = new Bitmap(1, 1);
            pen.SetPixel(0, 0, Color.Black);
            System.Drawing.Graphics g = DrawPanel.CreateGraphics();


            if (TextBoxValueA.Text == "" || TextBoxValueB.Text == "" || TextBoxValueC.Text == "")
            {
                MessageBox.Show("Veuillez remplir toute les cellules (en cas de valeur nulle entrer la valeur 0 et ne laisser pas la cellule vide)");
            }
            else
            {
                ValueA = Convert.ToDouble(TextBoxValueA.Text);
                ValueB = Convert.ToDouble(TextBoxValueB.Text);
                ValueC = Convert.ToDouble(TextBoxValueC.Text);

                if ((Math.Pow(ValueB, 2) - (4 * ValueA * ValueC)) / (2 * ValueA) < 0) // Check if the discriminant is positiv
                {
                    FirstX = (-ValueB + Math.Sqrt(Math.Pow(ValueB, 2) - (4 * ValueA * ValueC))) / (2 * ValueA);
                    SecondX = (-ValueB - Math.Sqrt(Math.Pow(ValueB, 2) - (4 * ValueA * ValueC))) / (2 * ValueA);
                }
                else if ((Math.Pow(ValueB, 2) - (4 * ValueA * ValueC)) / (2 * ValueA) == 0) // check if the discriminant is neutral
                {
                    FirstX = SecondX = -(ValueB / (2 * ValueA));
                }
                else
                {

                }

                for (double i = 0; i <= 10000; i += 0.01)
                {
                    FirstX = i;
                    FirstY = (ValueA * (FirstX * FirstX)) + ((ValueB * FirstX) + ValueC);

                    g.DrawImageUnscaled(pen, origo_x + (int)FirstX, origo_y - (int)FirstY);
                    g.DrawImageUnscaled(pen, origo_x - (int)FirstX, origo_y - (int)FirstY);


                }
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


    }
}
