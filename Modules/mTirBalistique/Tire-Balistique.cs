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

  

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (textButton == false)
            {
                buttonStop.Text = "Pause";
                textButton = true;
                timerTemp.Start();
                calBalistique();
                
            }
            else
            {
                buttonStop.Text = "Départ";
                textButton = false;
                timerTemp.Stop();
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calcule le tire balistique de l'object
        /// </summary>
        private void calBalistique()
        {
            double GravEarth = -9.81;

            double SpeedY;
            double SpeedX;
            double x, y;

            int X = 0;
            int Y = panelDraw.Height;

            double speed = Convert.ToDouble(textBoxSpeed.Text);
            double angle = Convert.ToDouble(textBoxDegrees.Text);



            //Création du graphique
            Bitmap pen = new Bitmap(4, 4);
            pen.SetPixel(0, 0, Color.Red);
            System.Drawing.Graphics graphBali = panelDraw.CreateGraphics();

            //Vy Calcul la vitesse montante
            SpeedY = Math.Sin(Math.PI * (angle / 180)) * speed;
            

            //Calcul balistique du tire
            for (double i = 0; i < 10000; i += 0.01)
            {
                //Vx Calcul la vitesse horizontale
                SpeedX = Math.Cos(Math.PI * (angle / 180)) * speed;

                x = i;
                y = SpeedY * i + ((0.5 * (GravEarth)) * (i * i));

                graphBali.DrawImageUnscaled(pen, X + Convert.ToInt32(SpeedX * i), Y - Convert.ToInt32(y));

            }
        }

        //Timer 
        private void timerTemp_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
