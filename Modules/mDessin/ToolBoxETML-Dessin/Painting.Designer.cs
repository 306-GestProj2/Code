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
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutEffacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleinÉcranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingZone)).BeginInit();
            this.grpBxTools.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDrawingZone
            // 
            this.picDrawingZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDrawingZone.BackColor = System.Drawing.Color.White;
            this.picDrawingZone.Location = new System.Drawing.Point(90, 38);
            this.picDrawingZone.Name = "picDrawingZone";
            this.picDrawingZone.Size = new System.Drawing.Size(737, 544);
            this.picDrawingZone.TabIndex = 0;
            this.picDrawingZone.TabStop = false;
            this.picDrawingZone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrawingZone_MouseDown);
            this.picDrawingZone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawingZone_MouseMove);
            this.picDrawingZone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawingZone_MouseUp);
            // 
            // grpBxTools
            // 
            this.grpBxTools.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.enregistrerSousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
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
            this.toutEffacerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toutEffacerToolStripMenuItem.Text = "Tout effacer";
            this.toutEffacerToolStripMenuItem.Click += new System.EventHandler(this.toutEffacerToolStripMenuItem_Click);
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
            this.pleinÉcranToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // Painting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 593);
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
    }
}

