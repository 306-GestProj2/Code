// : définit le point d'entrée pour l'application console.
/*****************************************************************************
** PROGRAMME   Tir balistique                                                **
**                                                                           **
** Lieu      : ETML - section informatique                                   **
** Auteur    : Maxime Pichonnat                                              **
** Date      : 04.05.2016                                                    **
**                                                                           **
** Modifications                                                             **
**   Auteur  :                                                               **
**   Version : X.X                                                           **
**   Date    :                                                               **
**   Raisons :                                                               **
**                                                                           **
**                                                                           **
******************************************************************************/

/******************************************************************************
** DESCRIPTION                                                               
** Programme qui calcul un tire balistique basique (vitesse, gravité et angle)                                                                        
**                                                                           
**                                                                           
******************************************************************************/

// ******************************************************************* 
// Nom   : Tir balistique 
// But   : Arriver à la fin 
// *******************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tire_balistique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool textButton = false;
        bool restart = false;

        double GravEarth = -9.81;

        double SpeedY;
        double SpeedX;

        double angle = 0;
        double speed = 0;

        double x, y;

        const int SIZE_X = 670;
        const int SIZE_Y = 445;

        Color colorShoot = Color.Red;
        SolidBrush myBrush;

        int X = 0;

        
        /// <summary>
        /// Appelle les méthodes et change le text des boutons  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (textButton == false)
            {
                buttonStop.Text = "Pause";
                textButton = true;
                textBoxDegrees.Enabled = false;
                textBoxSpeed.Enabled = false;

                calValues();
                timerTemp.Start();
            }
            else
            {
                buttonStop.Text = "Départ";
                textButton = false;
                timerTemp.Stop();
            }
        }

        
        //Timer 
        /// <summary>
        /// Calcul le tire balistique, affiche le tire balistique et affiche la distance et la hauteur à la quelle le tire se trouve
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTemp_Tick(object sender, EventArgs e)
        {
            x += 0.01;

            int Y = panelDraw.Height;

            //Vérifier que les cases soient bien ramplie 
                if (textBoxDegrees.Text == "")
                {
                    textButton = true;
                    textBoxDegrees.BackColor = Color.Red;
                }
                else
                {
                    textBoxDegrees.BackColor = Color.White;
                    angle = Convert.ToDouble(textBoxDegrees.Text);
                   
                }

                //Vérifier que les cases soient bien ramplie 
                if (textBoxSpeed.Text == "")
                {

                    textBoxSpeed.BackColor = Color.Red;
                }
                else
                {
                    textBoxSpeed.BackColor = Color.White;
                    speed = Convert.ToDouble(textBoxSpeed.Text);
                   
                }

            //Création du graphique
            //Bitmap pen = new Bitmap(30, 30);
            //pen.SetPixel(0, 0, colorShoot);
            myBrush = new SolidBrush(buttonColor.BackColor);
            System.Drawing.Graphics graphBali = panelDraw.CreateGraphics();

            if (restart == true)
            {
                graphBali.Clear(Color.White);
                restart = false;
            }
            

            //Vy Calcul la vitesse montante
            SpeedY = Math.Sin(Math.PI * (angle / 180)) * speed;

            //Vx Calcul la vitesse horizontale
            SpeedX = Math.Cos(Math.PI * (angle / 180)) * speed;

            
            y = SpeedY * x + ((0.5 * (GravEarth)) * (x * x));
            
            //Compteur de vitesse et de distance
            if (y < 0)
            {
                labelHautInst.Text = "0";
            }
            else
            {
                labelHautInst.Text = Convert.ToString(Math.Round(y, 2));
            }
            
            labelInstDist.Text = Convert.ToString(Math.Round(SpeedX * x, 2));

            //graphBali.DrawImageUnscaled(pen, X + Convert.ToInt32(SpeedX * x), Y - Convert.ToInt32(y));

            graphBali.FillRectangle(myBrush, X + Convert.ToInt32(SpeedX * x), Y - Convert.ToInt32(y) -6, 6, 6);
            
            
            if (Y - Convert.ToInt32(y) > SIZE_Y)
            {
                timerTemp.Stop();
                buttonStop.Text = "Départ";
                restart = true;
                textButton = false;
                x = 0;
                y = 0;
                SpeedY = 0;
                SpeedX = 0;

                textBoxDegrees.Enabled = true;
                textBoxSpeed.Enabled = true;
            }
        }
        /// <summary>
        /// Permet de changer la couleur du tire balistique 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog1.Color;
                colorShoot = colorDialog1.Color;
            }
        }

        /// <summary>
        /// Calcul en avance la distance max et la hauteur max
        /// </summary>
        private void calValues()
        {
            int Y = panelDraw.Height;

            double a;
            double b;

            double height = 0;
            double lenght = 0;

            angle = Convert.ToDouble(textBoxDegrees.Text);
            speed = Convert.ToDouble(textBoxSpeed.Text);

            //Vy Calcul la vitesse montante
            SpeedY = Math.Sin(Math.PI * (angle / 180)) * speed;


            for (double i = 0; ; i += 0.01)
            {
                //Vx Calcul la vitesse horizontale
                SpeedX = Math.Cos(Math.PI * (angle / 180)) * speed;

                a = i;
                b = SpeedY * i + ((0.5 * (GravEarth)) * (i * i));

                if (height <= (Math.Round(b, 2)))
                {
                    height = Math.Round(b, 2);
                }

                lenght = Math.Round(SpeedX * a, 2);

                if (Y - Convert.ToInt32(b) > SIZE_Y)
                {
                    break;
                }
            }
            //Affiche la distance Max et la hauteur Max
            labelMaxHight.Text = Convert.ToString(Math.Round(height, 2));
            labelMaxLenght.Text = Convert.ToString(Math.Round(lenght, 2));
        }

        private void textBoxDegrees_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxDegrees.Text, "^[0-9]+$")) { textBoxDegrees.Text = "0"; }
        }

        private void textBoxSpeed_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSpeed.Text, "^[0-9]+$")) { textBoxSpeed.Text = "0"; }
        }
    }
}
