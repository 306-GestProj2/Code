namespace integrationPage
{
    partial class integrationPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(integrationPage));
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arborescenceDescription = new System.Windows.Forms.Label();
            this.trajectoryDescription = new System.Windows.Forms.Label();
            this.parabolDescription = new System.Windows.Forms.Label();
            this.resistanceDescription = new System.Windows.Forms.Label();
            this.dossierDescription = new System.Windows.Forms.Label();
            this.paintDescrition = new System.Windows.Forms.Label();
            this.arborescence = new System.Windows.Forms.Button();
            this.traajectory = new System.Windows.Forms.Button();
            this.parabol = new System.Windows.Forms.Button();
            this.resistance = new System.Windows.Forms.Button();
            this.modifDossier = new System.Windows.Forms.Button();
            this.painting = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(89, 63);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(95, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Choix des modules";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arborescenceDescription);
            this.groupBox1.Controls.Add(this.trajectoryDescription);
            this.groupBox1.Controls.Add(this.parabolDescription);
            this.groupBox1.Controls.Add(this.resistanceDescription);
            this.groupBox1.Controls.Add(this.dossierDescription);
            this.groupBox1.Controls.Add(this.paintDescrition);
            this.groupBox1.Controls.Add(this.arborescence);
            this.groupBox1.Controls.Add(this.traajectory);
            this.groupBox1.Controls.Add(this.parabol);
            this.groupBox1.Controls.Add(this.resistance);
            this.groupBox1.Controls.Add(this.modifDossier);
            this.groupBox1.Controls.Add(this.painting);
            this.groupBox1.Location = new System.Drawing.Point(135, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // arborescenceDescription
            // 
            this.arborescenceDescription.Location = new System.Drawing.Point(263, 235);
            this.arborescenceDescription.Name = "arborescenceDescription";
            this.arborescenceDescription.Size = new System.Drawing.Size(100, 71);
            this.arborescenceDescription.TabIndex = 11;
            this.arborescenceDescription.Text = "Module permettant de créer une arborescence de fichiers";
            // 
            // trajectoryDescription
            // 
            this.trajectoryDescription.Location = new System.Drawing.Point(140, 235);
            this.trajectoryDescription.Name = "trajectoryDescription";
            this.trajectoryDescription.Size = new System.Drawing.Size(100, 71);
            this.trajectoryDescription.TabIndex = 10;
            this.trajectoryDescription.Text = "Module permettant d\'afficher la trajectoire d\'une balle en fonction de plusieurs " + "variables";
            // 
            // parabolDescription
            // 
            this.parabolDescription.Location = new System.Drawing.Point(-3, 235);
            this.parabolDescription.Name = "parabolDescription";
            this.parabolDescription.Size = new System.Drawing.Size(100, 54);
            this.parabolDescription.TabIndex = 9;
            this.parabolDescription.Text = "Module permettant d\'afficher une parabole à partir de 3 valeurs";
            // 
            // resistanceDescription
            // 
            this.resistanceDescription.Location = new System.Drawing.Point(263, 55);
            this.resistanceDescription.Name = "resistanceDescription";
            this.resistanceDescription.Size = new System.Drawing.Size(100, 54);
            this.resistanceDescription.TabIndex = 8;
            this.resistanceDescription.Text = "Module permettant de calculer la valeur d\'une résistance";
            // 
            // dossierDescription
            // 
            this.dossierDescription.Location = new System.Drawing.Point(140, 55);
            this.dossierDescription.Name = "dossierDescription";
            this.dossierDescription.Size = new System.Drawing.Size(100, 54);
            this.dossierDescription.TabIndex = 7;
            this.dossierDescription.Text = "Module permettant de modifier les noms de dossiers existants";
            // 
            // paintDescrition
            // 
            this.paintDescrition.Location = new System.Drawing.Point(0, 55);
            this.paintDescrition.Name = "paintDescrition";
            this.paintDescrition.Size = new System.Drawing.Size(100, 70);
            this.paintDescrition.TabIndex = 6;
            this.paintDescrition.Text = "Module permettant de dessiner puis d\'enregistrer son dessin à l\'endroit voulu";
            // 
            // arborescence
            // 
            this.arborescence.BackgroundImage = global::integrationPage.Properties.Resources.arborescence_ex;
            this.arborescence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arborescence.Location = new System.Drawing.Point(266, 180);
            this.arborescence.Name = "arborescence";
            this.arborescence.Size = new System.Drawing.Size(100, 52);
            this.arborescence.TabIndex = 5;
            this.arborescence.UseVisualStyleBackColor = true;
            this.arborescence.Click += new System.EventHandler(this.arborescence_Click);
            // 
            // traajectory
            // 
            this.traajectory.BackgroundImage = global::integrationPage.Properties.Resources.Graph3_93b15;
            this.traajectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.traajectory.Location = new System.Drawing.Point(140, 180);
            this.traajectory.Name = "traajectory";
            this.traajectory.Size = new System.Drawing.Size(100, 52);
            this.traajectory.TabIndex = 4;
            this.traajectory.UseVisualStyleBackColor = true;
            // 
            // parabol
            // 
            this.parabol.BackgroundImage = global::integrationPage.Properties.Resources.parabole_plot_64;
            this.parabol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.parabol.Location = new System.Drawing.Point(0, 180);
            this.parabol.Name = "parabol";
            this.parabol.Size = new System.Drawing.Size(100, 52);
            this.parabol.TabIndex = 3;
            this.parabol.UseVisualStyleBackColor = true;
            this.parabol.Click += new System.EventHandler(this.parabol_Click);
            // 
            // resistance
            // 
            this.resistance.BackgroundImage = global::integrationPage.Properties.Resources.resistor_32290_960_720;
            this.resistance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resistance.Location = new System.Drawing.Point(266, 0);
            this.resistance.Name = "resistance";
            this.resistance.Size = new System.Drawing.Size(100, 52);
            this.resistance.TabIndex = 2;
            this.resistance.UseVisualStyleBackColor = true;
            this.resistance.Click += new System.EventHandler(this.resistance_Click);
            // 
            // modifDossier
            // 
            this.modifDossier.BackgroundImage = global::integrationPage.Properties.Resources.dossier_windows;
            this.modifDossier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modifDossier.Location = new System.Drawing.Point(140, 0);
            this.modifDossier.Name = "modifDossier";
            this.modifDossier.Size = new System.Drawing.Size(100, 52);
            this.modifDossier.TabIndex = 1;
            this.modifDossier.UseVisualStyleBackColor = true;
            this.modifDossier.Click += new System.EventHandler(this.modifDossier_Click);
            // 
            // painting
            // 
            this.painting.BackgroundImage = global::integrationPage.Properties.Resources.Painting;
            this.painting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.painting.Location = new System.Drawing.Point(1, 0);
            this.painting.Name = "painting";
            this.painting.Size = new System.Drawing.Size(99, 52);
            this.painting.TabIndex = 0;
            this.painting.UseVisualStyleBackColor = true;
            this.painting.Click += new System.EventHandler(this.Painting_Click);
            // 
            // integrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "integrationPage";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button painting;
        private System.Windows.Forms.Button modifDossier;
        private System.Windows.Forms.Button resistance;
        private System.Windows.Forms.Button parabol;
        private System.Windows.Forms.Button arborescence;
        private System.Windows.Forms.Button traajectory;
        private System.Windows.Forms.Label arborescenceDescription;
        private System.Windows.Forms.Label trajectoryDescription;
        private System.Windows.Forms.Label parabolDescription;
        private System.Windows.Forms.Label resistanceDescription;
        private System.Windows.Forms.Label dossierDescription;
        private System.Windows.Forms.Label paintDescrition;
    }
}

