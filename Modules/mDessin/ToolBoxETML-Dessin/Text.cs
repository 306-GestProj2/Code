//
// Auteur : Loïc Berdoz
// Résumé : Ceci est la fenêtre qui permet à l'utilisateur d'écrire du texte sur le dessin 
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

namespace ToolBoxETML_Dessin
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Retourne le texte entré dans la textBox
        /// </summary>
        /// <returns></returns>
        public string ReturnText()
        {
            return richTextBox1.Text;
        }
    }
}
