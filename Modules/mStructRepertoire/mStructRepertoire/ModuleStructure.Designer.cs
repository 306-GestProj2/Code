namespace ModuleStructure
{
    partial class ModuleStructure
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
            this.TextZonegrpBx = new System.Windows.Forms.GroupBox();
            this.FolderStructureRichTxtB = new System.Windows.Forms.RichTextBox();
            this.SearchFileGrpBx = new System.Windows.Forms.GroupBox();
            this.SelectedPathTxtBox = new System.Windows.Forms.TextBox();
            this.SearchFileBtn = new System.Windows.Forms.Button();
            this.HelpGrpBx = new System.Windows.Forms.GroupBox();
            this.HelpLbl = new System.Windows.Forms.Label();
            this.CreateStructureBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreationProgressPrB = new System.Windows.Forms.ProgressBar();
            this.SearchFileFBDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressionLbl = new System.Windows.Forms.Label();
            this.ProgressOfProgressBarLbl = new System.Windows.Forms.Label();
            this.TextZonegrpBx.SuspendLayout();
            this.SearchFileGrpBx.SuspendLayout();
            this.HelpGrpBx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextZonegrpBx
            // 
            this.TextZonegrpBx.Controls.Add(this.FolderStructureRichTxtB);
            this.TextZonegrpBx.Location = new System.Drawing.Point(22, 12);
            this.TextZonegrpBx.Name = "TextZonegrpBx";
            this.TextZonegrpBx.Size = new System.Drawing.Size(383, 302);
            this.TextZonegrpBx.TabIndex = 0;
            this.TextZonegrpBx.TabStop = false;
            this.TextZonegrpBx.Text = "Zone de saisie";
            // 
            // FolderStructureRichTxtB
            // 
            this.FolderStructureRichTxtB.Location = new System.Drawing.Point(16, 19);
            this.FolderStructureRichTxtB.Name = "FolderStructureRichTxtB";
            this.FolderStructureRichTxtB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.FolderStructureRichTxtB.Size = new System.Drawing.Size(361, 277);
            this.FolderStructureRichTxtB.TabIndex = 0;
            this.FolderStructureRichTxtB.Text = "";
            // 
            // SearchFileGrpBx
            // 
            this.SearchFileGrpBx.Controls.Add(this.SelectedPathTxtBox);
            this.SearchFileGrpBx.Controls.Add(this.SearchFileBtn);
            this.SearchFileGrpBx.Location = new System.Drawing.Point(22, 327);
            this.SearchFileGrpBx.Name = "SearchFileGrpBx";
            this.SearchFileGrpBx.Size = new System.Drawing.Size(383, 66);
            this.SearchFileGrpBx.TabIndex = 1;
            this.SearchFileGrpBx.TabStop = false;
            this.SearchFileGrpBx.Text = "Parcourir";
            // 
            // SelectedPathTxtBox
            // 
            this.SelectedPathTxtBox.Location = new System.Drawing.Point(6, 28);
            this.SelectedPathTxtBox.Name = "SelectedPathTxtBox";
            this.SelectedPathTxtBox.Size = new System.Drawing.Size(229, 20);
            this.SelectedPathTxtBox.TabIndex = 5;
            // 
            // SearchFileBtn
            // 
            this.SearchFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFileBtn.Location = new System.Drawing.Point(255, 28);
            this.SearchFileBtn.Name = "SearchFileBtn";
            this.SearchFileBtn.Size = new System.Drawing.Size(121, 22);
            this.SearchFileBtn.TabIndex = 4;
            this.SearchFileBtn.Text = "Parcourir";
            this.SearchFileBtn.UseVisualStyleBackColor = true;
            this.SearchFileBtn.Click += new System.EventHandler(this.SearchFileBtn_Click);
            // 
            // HelpGrpBx
            // 
            this.HelpGrpBx.Controls.Add(this.HelpLbl);
            this.HelpGrpBx.Location = new System.Drawing.Point(448, 13);
            this.HelpGrpBx.Name = "HelpGrpBx";
            this.HelpGrpBx.Size = new System.Drawing.Size(216, 295);
            this.HelpGrpBx.TabIndex = 2;
            this.HelpGrpBx.TabStop = false;
            this.HelpGrpBx.Text = "Aide";
            // 
            // HelpLbl
            // 
            this.HelpLbl.AutoSize = true;
            this.HelpLbl.Location = new System.Drawing.Point(11, 16);
            this.HelpLbl.Name = "HelpLbl";
            this.HelpLbl.Size = new System.Drawing.Size(190, 91);
            this.HelpLbl.TabIndex = 0;
            this.HelpLbl.Text = "Ceci est l\'endroit ou vous devez entrer \r\nl\'arborescence désirée\r\n\r\nSi vous désir" +
    "ez la créer directement, \r\nutilisez la combinaison\r\n\"Ctrl\" + \"tab\" pour faire le" +
    "s \r\ntabulations";
            // 
            // CreateStructureBtn
            // 
            this.CreateStructureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateStructureBtn.Location = new System.Drawing.Point(448, 327);
            this.CreateStructureBtn.Name = "CreateStructureBtn";
            this.CreateStructureBtn.Size = new System.Drawing.Size(216, 29);
            this.CreateStructureBtn.TabIndex = 1;
            this.CreateStructureBtn.Text = "Créer";
            this.CreateStructureBtn.UseVisualStyleBackColor = true;
            this.CreateStructureBtn.Click += new System.EventHandler(this.CreateStructureBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CreationProgressPrB);
            this.panel1.Location = new System.Drawing.Point(448, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 31);
            this.panel1.TabIndex = 3;
            // 
            // CreationProgressPrB
            // 
            this.CreationProgressPrB.Location = new System.Drawing.Point(-2, -2);
            this.CreationProgressPrB.Name = "CreationProgressPrB";
            this.CreationProgressPrB.Size = new System.Drawing.Size(216, 31);
            this.CreationProgressPrB.TabIndex = 4;
            // 
            // ProgressionLbl
            // 
            this.ProgressionLbl.AutoSize = true;
            this.ProgressionLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProgressionLbl.ForeColor = System.Drawing.Color.Black;
            this.ProgressionLbl.Location = new System.Drawing.Point(445, 396);
            this.ProgressionLbl.Name = "ProgressionLbl";
            this.ProgressionLbl.Size = new System.Drawing.Size(0, 13);
            this.ProgressionLbl.TabIndex = 4;
            // 
            // ProgressOfProgressBarLbl
            // 
            this.ProgressOfProgressBarLbl.AutoSize = true;
            this.ProgressOfProgressBarLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProgressOfProgressBarLbl.ForeColor = System.Drawing.Color.Black;
            this.ProgressOfProgressBarLbl.Location = new System.Drawing.Point(513, 396);
            this.ProgressOfProgressBarLbl.Name = "ProgressOfProgressBarLbl";
            this.ProgressOfProgressBarLbl.Size = new System.Drawing.Size(0, 13);
            this.ProgressOfProgressBarLbl.TabIndex = 5;
            // 
            // ModuleStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 414);
            this.Controls.Add(this.ProgressOfProgressBarLbl);
            this.Controls.Add(this.ProgressionLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateStructureBtn);
            this.Controls.Add(this.HelpGrpBx);
            this.Controls.Add(this.SearchFileGrpBx);
            this.Controls.Add(this.TextZonegrpBx);
            this.Name = "ModuleStructure";
            this.Text = "ModuleStructure";
            this.TextZonegrpBx.ResumeLayout(false);
            this.SearchFileGrpBx.ResumeLayout(false);
            this.SearchFileGrpBx.PerformLayout();
            this.HelpGrpBx.ResumeLayout(false);
            this.HelpGrpBx.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TextZonegrpBx;
        private System.Windows.Forms.RichTextBox FolderStructureRichTxtB;
        private System.Windows.Forms.GroupBox SearchFileGrpBx;
        private System.Windows.Forms.GroupBox HelpGrpBx;
        private System.Windows.Forms.Label HelpLbl;
        private System.Windows.Forms.Button CreateStructureBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchFileBtn;
        private System.Windows.Forms.FolderBrowserDialog SearchFileFBDialog;
        private System.Windows.Forms.TextBox SelectedPathTxtBox;
        private System.Windows.Forms.ProgressBar CreationProgressPrB;
        private System.Windows.Forms.Label ProgressionLbl;
        private System.Windows.Forms.Label ProgressOfProgressBarLbl;



    }
}

