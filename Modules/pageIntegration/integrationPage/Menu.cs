using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolBoxETML_Dessin;
using FormCalculFunction;
using _042_campichele_ManipulationNomFichier;
using ModuleStructure;
using Module_Resistance;

namespace integrationPage
{
    public partial class integrationPage : Form
    {
        public integrationPage()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Ouvre le module de dessin
        /// </summary>
        private void Painting_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;//Fait dispartaître le menu
            Painting openPainting = new Painting();
            openPainting.ShowDialog();
            this.Opacity = 1;//Fait réaparaître le menu
        }


        /// <summary>
        /// Ouvre le module de création de parabole
        /// </summary>
        private void parabol_Click(object sender, EventArgs e)
        {
            CalculFunction openFormCalculFunction = new CalculFunction();
            this.Opacity = 0;
            openFormCalculFunction.ShowDialog();
            this.Opacity = 1;
        }


        /// <summary>
        /// Ouvre le module de modification de dossier
        /// </summary>
        private void modifDossier_Click(object sender, EventArgs e)
        {
            fileManipulationForm openfileManipulation = new fileManipulationForm();
            this.Opacity = 0;
            openfileManipulation.ShowDialog();
            this.Opacity = 1;
        }

        private void arborescence_Click(object sender, EventArgs e)
        {
            ModuleStructureDossier openModuleStructure = new ModuleStructureDossier();
            this.Opacity = 0;
            openModuleStructure.ShowDialog();
            this.Opacity = 1;
        }

        private void resistance_Click(object sender, EventArgs e)
        {
            FormResistance open = new FormResistance();
            this.Opacity = 0;
            open.ShowDialog();
            this.Opacity = 1;
        }

    }
}
