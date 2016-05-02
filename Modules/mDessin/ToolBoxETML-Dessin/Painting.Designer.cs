namespace ToolBoxETML_Dessin
{
    partial class Painting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painting));
            this.picDrawingZone = new System.Windows.Forms.PictureBox();
            this.grpBxTools = new System.Windows.Forms.GroupBox();
            this.cmbSizeBrush = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.pickAColor = new System.Windows.Forms.ColorDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutEffacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleinÉcranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.pnlEraser = new System.Windows.Forms.Panel();
            this.pnlPen = new System.Windows.Forms.Panel();
            this.pnlPencil = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidateText = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingZone)).BeginInit();
            this.grpBxTools.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.grpTools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDrawingZone
            // 
            this.picDrawingZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDrawingZone.BackColor = System.Drawing.Color.White;
            this.picDrawingZone.Cursor = System.Windows.Forms.Cursors.Default;
            this.picDrawingZone.Location = new System.Drawing.Point(90, 38);
            this.picDrawingZone.Name = "picDrawingZone";
            this.picDrawingZone.Size = new System.Drawing.Size(737, 544);
            this.picDrawingZone.TabIndex = 0;
            this.picDrawingZone.TabStop = false;
            this.picDrawingZone.Click += new System.EventHandler(this.picDrawingZone_Click);
            this.picDrawingZone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrawingZone_MouseDown);
            this.picDrawingZone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawingZone_MouseMove);
            this.picDrawingZone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawingZone_MouseUp);
            // 
            // grpBxTools
            // 
            this.grpBxTools.BackColor = System.Drawing.SystemColors.Control;
            this.grpBxTools.Controls.Add(this.cmbSizeBrush);
            this.grpBxTools.Controls.Add(this.lblColor);
            this.grpBxTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBxTools.Location = new System.Drawing.Point(7, 38);
            this.grpBxTools.Name = "grpBxTools";
            this.grpBxTools.Size = new System.Drawing.Size(77, 115);
            this.grpBxTools.TabIndex = 1;
            this.grpBxTools.TabStop = false;
            this.grpBxTools.Text = "Propriétés";
            // 
            // cmbSizeBrush
            // 
            this.cmbSizeBrush.FormattingEnabled = true;
            this.cmbSizeBrush.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbSizeBrush.Location = new System.Drawing.Point(5, 87);
            this.cmbSizeBrush.Name = "cmbSizeBrush";
            this.cmbSizeBrush.Size = new System.Drawing.Size(51, 21);
            this.cmbSizeBrush.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(5, 31);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(52, 41);
            this.lblColor.TabIndex = 0;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.policeToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(839, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir...";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous...";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toutEffacerToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // toutEffacerToolStripMenuItem
            // 
            this.toutEffacerToolStripMenuItem.Name = "toutEffacerToolStripMenuItem";
            this.toutEffacerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.toutEffacerToolStripMenuItem.Text = "Tout effacer";
            this.toutEffacerToolStripMenuItem.Click += new System.EventHandler(this.toutEffacerToolStripMenuItem_Click);
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.policeToolStripMenuItem.Text = "Police";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pleinÉcranToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // pleinÉcranToolStripMenuItem
            // 
            this.pleinÉcranToolStripMenuItem.Name = "pleinÉcranToolStripMenuItem";
            this.pleinÉcranToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pleinÉcranToolStripMenuItem.Text = "Plein écran";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // grpTools
            // 
            this.grpTools.BackColor = System.Drawing.SystemColors.Control;
            this.grpTools.Controls.Add(this.pnlEraser);
            this.grpTools.Controls.Add(this.pnlPen);
            this.grpTools.Controls.Add(this.pnlPencil);
            this.grpTools.Location = new System.Drawing.Point(7, 164);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(76, 100);
            this.grpTools.TabIndex = 4;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "Outils";
            // 
            // pnlEraser
            // 
            this.pnlEraser.BackColor = System.Drawing.Color.White;
            this.pnlEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEraser.BackgroundImage")));
            this.pnlEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEraser.Location = new System.Drawing.Point(3, 63);
            this.pnlEraser.Name = "pnlEraser";
            this.pnlEraser.Size = new System.Drawing.Size(32, 29);
            this.pnlEraser.TabIndex = 6;
            this.pnlEraser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlEraser_MouseClick);
            // 
            // pnlPen
            // 
            this.pnlPen.BackColor = System.Drawing.Color.White;
            this.pnlPen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPen.BackgroundImage")));
            this.pnlPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPen.Location = new System.Drawing.Point(3, 28);
            this.pnlPen.Name = "pnlPen";
            this.pnlPen.Size = new System.Drawing.Size(32, 29);
            this.pnlPen.TabIndex = 5;
            this.pnlPen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPen_MouseClick);
            // 
            // pnlPencil
            // 
            this.pnlPencil.BackColor = System.Drawing.Color.White;
            this.pnlPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPencil.BackgroundImage")));
            this.pnlPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPencil.Location = new System.Drawing.Point(41, 28);
            this.pnlPencil.Name = "pnlPencil";
            this.pnlPencil.Size = new System.Drawing.Size(32, 29);
            this.pnlPencil.TabIndex = 5;
            this.pnlPencil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPencil_MouseClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValidateText);
            this.groupBox1.Controls.Add(this.pnlText);
            this.groupBox1.Location = new System.Drawing.Point(7, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texte";
            // 
            // btnValidateText
            // 
            this.btnValidateText.Location = new System.Drawing.Point(6, 96);
            this.btnValidateText.Name = "btnValidateText";
            this.btnValidateText.Size = new System.Drawing.Size(67, 23);
            this.btnValidateText.TabIndex = 8;
            this.btnValidateText.Text = "Text";
            this.btnValidateText.UseVisualStyleBackColor = true;
            this.btnValidateText.Click += new System.EventHandler(this.btnValidateText_Click);
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.Color.White;
            this.pnlText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlText.BackgroundImage")));
            this.pnlText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlText.Location = new System.Drawing.Point(8, 19);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(32, 29);
            this.pnlText.TabIndex = 6;
            this.pnlText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlText_MouseClick);
            // 
            // Painting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTools);
            this.Controls.Add(this.grpBxTools);
            this.Controls.Add(this.picDrawingZone);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Painting";
            this.Text = "Dessin";
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingZone)).EndInit();
            this.grpBxTools.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpTools.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDrawingZone;
        private System.Windows.Forms.GroupBox grpBxTools;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ColorDialog pickAColor;
        private System.Windows.Forms.ComboBox cmbSizeBrush;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pleinÉcranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutEffacerToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.Panel pnlPen;
        private System.Windows.Forms.Panel pnlPencil;
        private System.Windows.Forms.Panel pnlEraser;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Button btnValidateText;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

