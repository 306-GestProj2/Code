using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Module_Resistance
{
    public partial class FormResistance : Form
    {
        public FormResistance()
        {
            InitializeComponent();
        }
        int OnClique = 0;
        private void FormResistance_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("This is my super Easter Egg !");
        }

        private void textBoxValueToCheck_TextChanged(object sender, EventArgs e)
        {
            textBoxValueToCheck.MaxLength = 3;

            string userValue = textBoxValueToCheck.Text;

            if (textBoxValueToCheck.Text == "Dadié" || textBoxValueToCheck.Text == "dadié" || textBoxValueToCheck.Text == "dadier" || textBoxValueToCheck.Text == "Dadier")
            {
                
            }
            else if (textBoxValueToCheck.Text != "")
            {

                for (int j = 0; j < userValue.Length; j++)
                {
                    if (j == 0)
                    {
                        switch (userValue[j])
                        {
                            case '0':
                                panelNumberOne.BackColor = Color.Black;
                                break;

                            case '1':
                                panelNumberOne.BackColor = Color.Brown;
                                break;

                            case '2':
                                panelNumberOne.BackColor = Color.Red;
                                break;
                            case '3':
                                panelNumberOne.BackColor = Color.Orange;
                                break;
                            case '4':
                                panelNumberOne.BackColor = Color.Yellow;
                                break;
                            case '5':
                                panelNumberOne.BackColor = Color.Green;
                                break;
                            case '6':
                                panelNumberOne.BackColor = Color.Blue;
                                break;
                            case '7':
                                panelNumberOne.BackColor = Color.Purple;
                                break;
                            case '8':
                                panelNumberOne.BackColor = Color.Gray;
                                break;
                            case '9':
                                panelNumberOne.BackColor = Color.White;
                                break;
                            default:
                                MessageBox.Show("Valeur non valide");
                                break;


                        }
                    }


                    if (j == 1)
                    {
                        switch (userValue[j])
                        {
                            case '0':
                                panelNumberTwo.BackColor = Color.Black;
                                break;

                            case '1':
                                panelNumberTwo.BackColor = Color.Brown;
                                break;

                            case '2':
                                panelNumberTwo.BackColor = Color.Red;
                                break;
                            case '3':
                                panelNumberTwo.BackColor = Color.Orange;
                                break;
                            case '4':
                                panelNumberTwo.BackColor = Color.Yellow;
                                break;
                            case '5':
                                panelNumberTwo.BackColor = Color.Green;
                                break;
                            case '6':
                                panelNumberTwo.BackColor = Color.Blue;
                                break;
                            case '7':
                                panelNumberTwo.BackColor = Color.Purple;
                                break;
                            case '8':
                                panelNumberTwo.BackColor = Color.Gray;
                                break;
                            case '9':
                                panelNumberTwo.BackColor = Color.White;
                                break;
                            default:
                                MessageBox.Show("Valeur non valide");
                                break;

                        }
                    }

                    if (j == 2)
                    {
                        switch (userValue[j])
                        {
                            case '0':
                                panelNumberTree.BackColor = Color.Black;
                                break;

                            case '1':
                                panelNumberTree.BackColor = Color.Brown;
                                break;

                            case '2':
                                panelNumberTree.BackColor = Color.Red;
                                break;
                            case '3':
                                panelNumberTree.BackColor = Color.Orange;
                                break;
                            case '4':
                                panelNumberTree.BackColor = Color.Yellow;
                                break;
                            case '5':
                                panelNumberTree.BackColor = Color.Green;
                                break;
                            case '6':
                                panelNumberTree.BackColor = Color.Blue;
                                break;
                            case '7':
                                panelNumberTree.BackColor = Color.Purple;
                                break;
                            case '8':
                                panelNumberTree.BackColor = Color.Gray;
                                break;
                            case '9':
                                panelNumberTree.BackColor = Color.White;
                                break;
                            default:
                                MessageBox.Show("Valeur non valide");
                                break;



                        }
                    }


                }
            }
            else
            {
                panelNumberOne.BackColor = Color.Tan;
                panelNumberTwo.BackColor = Color.Tan;
                panelNumberTree.BackColor = Color.Tan;
            }
        }

        private void cmbMultplicateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMultplicateur.Text)
            {
                case "10^-2":
                    panelMultiplicator.BackColor = Color.Silver;
                    break;

                case "10^-1":
                    panelMultiplicator.BackColor = Color.Gold;
                    break;

                case "10^0":
                    panelMultiplicator.BackColor = Color.Black;
                    break;

                case "10^1":
                    panelMultiplicator.BackColor = Color.Brown;
                    break;

                case "10^2":
                    panelMultiplicator.BackColor = Color.Red;
                    break;

                case "10^3":
                    panelMultiplicator.BackColor = Color.Orange;
                    break;

                case "10^4":
                    panelMultiplicator.BackColor = Color.Yellow;
                    break;

                case "10^5":
                    panelMultiplicator.BackColor = Color.Green;
                    break;

                case "10^6":
                    panelMultiplicator.BackColor = Color.Blue;
                    break;

                case "10^7":
                    panelMultiplicator.BackColor = Color.Purple;
                    break;
            }
        }

        private void cmbTolerance_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTolerance.Text)
            {
                case "20%":
                    panelTolerance.BackColor = Color.Black;
                    break;

                case "10%":
                    panelTolerance.BackColor = Color.Silver;
                    break;

                case "5%":
                    panelTolerance.BackColor = Color.Gold;
                    break;

                case "2%":
                    panelTolerance.BackColor = Color.Red;
                    break;

                case "1%":
                    panelTolerance.BackColor = Color.Brown;
                    break;

                case "0.5%":
                    panelTolerance.BackColor = Color.Yellow;
                    break;

                case "0.25%":
                    panelTolerance.BackColor = Color.Blue;
                    break;

                case "0.10%":
                    panelTolerance.BackColor = Color.Purple;
                    break;

                case "0.05%":
                    panelTolerance.BackColor = Color.Gray;
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OnClique++;

            if (OnClique == 3)
            {
                this.WindowState = FormWindowState.Maximized;
                this.BackColor = Color.LimeGreen;
                this.Opacity = 0.5666;
                PictureBox picDadié = new PictureBox();
                picDadié.Height = this.Height;
                picDadié.Width = this.Width;
                picDadié.BackColor = Color.Red;
                this.Controls.Add(picDadié);
                OnClique = 0;
            }
        }
    }
}
