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
    public partial class myFontPicker : Form
    {

        Font selectedFont;

        public myFontPicker()
        {
            InitializeComponent();
            //Remplit la comboBox avec les polices disponibles
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily font in family)
            {
                cmbSelectedFont.Items.Add(font.GetName(1).ToString());
            }
            //Remplit la comboBox avec les différentes tailles
            for (int i = 1; i <= 60; i++)
            {
                cmbSelectedSize.Items.Add(i);
            }
        }
        /// <summary>
        /// Retourne la police en fonction des paramètres sélectionnés.
        /// </summary>
        /// <returns></returns>
        public Font returnFont()
        {
            if (cmbSelectedFont.Text == "")
            {
                cmbSelectedFont.Text = "Arial";
            }
            if (cmbSelectedSize.Text == "")
            {
                cmbSelectedSize.Text = "20";
            }
            selectedFont = new Font(cmbSelectedFont.Text, Convert.ToInt32(cmbSelectedSize.Text));
            return selectedFont;
        }
    }
}
