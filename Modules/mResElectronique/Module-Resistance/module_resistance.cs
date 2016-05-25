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

        double valueTot = 0;

        private void buttonValidate_Click(object sender, EventArgs e)
        {




        }

        private void buttonValidate_Click_1(object sender, EventArgs e)
        {

        }

  

        private void FormResistance_Load(object sender, EventArgs e)
        {

        }

        private void FormResistance_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void textBoxValueToCheck_TextChanged(object sender, EventArgs e)
        {
            string userValue = textBoxValueToCheck.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxValueToCheck.Text, "^[0-9]{1,3}$")) 
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
                                textBoxValueToCheck.Text = "";
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
                textBoxValueToCheck.Text = "";
                panelNumberOne.BackColor = Color.Tan;
                panelNumberTwo.BackColor = Color.Tan;
                panelNumberTree.BackColor = Color.Tan;
            }
        }

        private void cmbMultplicateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMultplicateur.Text)
            {
                case "0.01":
                    panelMultiplicator.BackColor = Color.Silver;
                    break;

                case "0.1":
                    panelMultiplicator.BackColor = Color.Gold;
                    break;

                case " ":
                    panelMultiplicator.BackColor = Color.Gray;
                    break;

                case "1":
                    panelMultiplicator.BackColor = Color.Black;
                    break;

                case "10":
                    panelMultiplicator.BackColor = Color.Brown;
                    break;

                case "100":
                    panelMultiplicator.BackColor = Color.Red;
                    break;

                case "1000":
                    panelMultiplicator.BackColor = Color.Orange;
                    break;

                case "10000":
                    panelMultiplicator.BackColor = Color.Yellow;
                    break;

                case "100000":
                    panelMultiplicator.BackColor = Color.Green;
                    break;

                case "1000000":
                    panelMultiplicator.BackColor = Color.Blue;
                    break;

                case "10000000":
                    panelMultiplicator.BackColor = Color.Purple;
                    break;
            }
            cmbTolerance_TextChanged(sender, e);
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

        /// <summary>
        /// Calcul la valeur de la résisatance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTolerance_TextChanged(object sender, EventArgs e)
        {
            if (textBoxValueToCheck.Text == "")
            {
                textBoxValueToCheck.Text = "0";
            }
            else
            {
                double valueMult = Convert.ToDouble(cmbMultplicateur.Text);
                double valueStart = Convert.ToDouble(textBoxValueToCheck.Text);

                valueTot = valueStart * valueMult;

                labelValue.Text = Convert.ToString(valueTot) + " Ohms " + cmbTolerance.Text;
            }
        }
    }
}
