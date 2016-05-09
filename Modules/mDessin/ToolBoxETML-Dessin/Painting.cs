//
// Auteur : Loïc Berdoz
// Résumé : Ceci est la fenêtre principale de mon programme. Elle contient la zone de dessin, les outils ainsi que une barre de menus en haut où on peut retrouver des fonctiones telles que l'enregistrement de l'image. 
// Date  : 12.04.2016
// ETML
//

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
        /////////////////////////////////////////////////
        private SolidBrush myBrush;                      //
        private SolidBrush eraser;                       //
        private Pen lePen;                               //
        private Graphics myGraphics;                     //
        private bool isDrawing = false;                    //
        private string stateTool = "pen";                    //
        private bool blnSave = true;                            //--------- Déclaration des variables / objets
        private string txtToAdd = null;                        //
        //private string selectedFont = "Arial";             //
        //private int selectedSize = 12;                   //
        Text formText = new Text();                      //
        private int intX;                                //
        private int intY;                                //
        private int nbOfTicks = 0;                       //
        About About = new About();                       //
        Color clrForm;                                   //
        Font myFont;                                     //
        myFontPicker fontPicker = new myFontPicker();    //
        /////////////////////////////////////////////////

        public Painting()
        {
            InitializeComponent();
            cmbSizeBrush.Text = "10";
            myBrush = new SolidBrush(lblColor.BackColor);
            myGraphics = picDrawingZone.CreateGraphics();
            pnlPen.BackColor = Color.LightGray;
            eraser = new SolidBrush(Color.White);
            lePen = new Pen(Color.White);
            clrForm = this.BackColor;

        }
        /// <summary>
        /// Affiche une fenêtre pour changer la couleur du pinceau / texte quand l'utilisateur clique sur le rectangle de couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblColor_Click(object sender, EventArgs e)
        {
            if (pickAColor.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = pickAColor.Color;
                myBrush.Color = lblColor.BackColor;
            }
        }
        /// <summary>
        /// Si l'utilisateur garde le bouton gauche enfoncé, la variable isDrawing passe à true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picDrawingZone_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            intX = e.X;
            intY = e.Y;
        }

        /// <summary>
        /// Quand l'utilisateur relache le bouton gauche de la souris, la variable isDrawing repasse à false et on appelle la méthode SaveDrawing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picDrawingZone_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            if (blnSave)
            {
                SaveDrawing();
            }
        }
         /// <summary>
         /// Action déclenchée quand l'utilisateur bouge la souris sur la zone de dessin.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void picDrawingZone_MouseMove(object sender, MouseEventArgs e)
        {
            //Vérification de si l'utilisateur clique sur le bouton gauche de la souris
            if (isDrawing)
            {
                //Créé une zone de dessin
                myGraphics = picDrawingZone.CreateGraphics();
                //Differentes actions en fonction de l'outil selectionné
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
                //Applique les modification à myGraphics
                myGraphics.Dispose();
            }
        }
        /// <summary>
        /// Option du menu Edition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toutEffacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fait un refresh de la zone de dessin et set l'image de la picturebox à null
            picDrawingZone.Refresh();
            picDrawingZone.Image = null;
        }

        /// <summary>
        /// Option du menu Fichier qui permet d'enregistrer le dessin en .png
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Action produite quand l'utilisateur clique sur l'outil pinceau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPen_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "pen";
            pnlPen.BackColor = Color.LightGray;
            pnlPencil.BackColor = Color.White;
            pnlEraser.BackColor = Color.White;

        }
        /// <summary>
        /// Action produite quand l'utilisateur clique sur l'outil crayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPencil_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "pencil";
            pnlPencil.BackColor = Color.LightGray;
            pnlPen.BackColor = Color.White;
            pnlEraser.BackColor = Color.White;
            pnlText.BackColor = Color.White;
        }
        /// <summary>
        /// Action produite quand l'utilisateur clique sur l'outil gomme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlEraser_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "eraser";
            pnlPencil.BackColor = Color.White;
            pnlPen.BackColor = Color.White;
            pnlEraser.BackColor = Color.LightGray;
            pnlText.BackColor = Color.White;
        }

        /// <summary>
        /// Méthode qui fait une copie du dessin en cours et l'applique à la picturebox
        /// </summary>
        private void SaveDrawing()
        {
            Bitmap pasPerdre = new Bitmap(picDrawingZone.Width, picDrawingZone.Height);
            Graphics g = Graphics.FromImage(pasPerdre);
            Rectangle rect = picDrawingZone.RectangleToScreen(picDrawingZone.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, picDrawingZone.Size);
            g.Dispose();
            picDrawingZone.Image = pasPerdre;
        }
        /// <summary>
        /// Option du menu Fichier qui permet d'importer une image en .png
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blnSave = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Png files|*.png";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               Image.FromFile(open.FileName);
               picDrawingZone.Image = Image.FromFile(open.FileName);
            }
        }
        /// <summary>
        /// Action produite quand l'utilisateur clique sur l'outil texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlText_MouseClick(object sender, MouseEventArgs e)
        {
            stateTool = "text";
            pnlPencil.BackColor = Color.White;
            pnlPen.BackColor = Color.White;
            pnlEraser.BackColor = Color.White;
            pnlText.BackColor = Color.LightGray;
        }
        /// <summary>
        /// Active le timer qui retarde l'écriture du texte écrit par l'utilisateur quand il clique sur la picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picDrawingZone_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("X: " + intX.ToString() + " // Y: " + intY.ToString() + " // Texte: " + txtToAdd);

                if (stateTool == "text")
                {
                    timAntiBug.Enabled = true;
                }
        }
        /// <summary>
        /// Vérifie que l'outil texte est selectionné et ouvre un form ou l'utilisateur entre le texte qu'il désire ajouter à son image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ouvre une fenêtre pour changer la police et la taille du texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fontDialog.ShowDialog();
            //if(fontDialog  System.Windows.Forms.DialogResult.OK)
            //{
            //    myFont = fontDialog.Font;
            //    //selectedfont = convert.tostring(fontdialog.font.name);
            //    //selectedsize = convert.toint32(fontdialog.font.size);
            //}
            if (fontPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                myFont = fontPicker.returnFont();
            }

           
        }

        /// <summary>
        /// Ajoute le texte écrit dans la form Text au graphics
        /// </summary>
        private void DrawText()
        {
            if (txtToAdd != null)
            {
                TextRenderer.DrawText(myGraphics, txtToAdd, myFont, new Point(intX, intY), lblColor.BackColor);
            }
            //myGraphics.DrawString(txtToAdd, new Font(selectedFont, selectedSize), myBrush, new Point(intX, intY));  
            txtToAdd = null;
            intX = 0;
            intY = 0;
            nbOfTicks = 0;
            timAntiBug.Enabled = false;
        }
        /// <summary>
        /// Incrémente nbOfTicks à chaque Tick du timer et si nbOfticks = 1, appelle la méthode DrawText.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timAntiBug_Tick(object sender, EventArgs e)
        {
            nbOfTicks++;

            if (nbOfTicks == 1)
            {
                DrawText();
            }
        }

        /// <summary>
        /// Passe le programme en plein écran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// Affiche une fenêtre d'informations sur le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.ShowDialog();
        }
        /// <summary>
        /// Passe le thème du programme en mode sombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            
            grpBxTools.BackColor = Color.Gray;
            grpTools.BackColor = Color.Gray;
            menuStrip.BackColor = Color.Gray;
            
            menuStrip.ForeColor = Color.LightGray;
            grpBxTools.ForeColor = Color.LightGray;
            grpTools.ForeColor = Color.LightGray;

        }
        /// <summary>
        /// Passe le thème du programme en mode normal (clair)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = btnValidateText.BackColor;

            grpBxTools.BackColor = clrForm;
            grpTools.BackColor = clrForm;
            menuStrip.BackColor = clrForm;
            this.BackColor = clrForm;

            menuStrip.ForeColor = Color.Black;
            grpBxTools.ForeColor = Color.Black;
            grpTools.ForeColor = Color.Black;
        }
    }
}
