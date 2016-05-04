namespace _042_campichele_ManipulationNomFichier
{
    partial class fileManipulationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileManipulationForm));
            this.selectFileButton = new System.Windows.Forms.Button();
            this.choosenFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.choosenFileListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearListButton = new System.Windows.Forms.Button();
            this.searchReplaceLabel = new System.Windows.Forms.Label();
            this.newTextReplaceLabel = new System.Windows.Forms.Label();
            this.searchReplaceTextBox = new System.Windows.Forms.TextBox();
            this.newTextReplaceTextBox = new System.Windows.Forms.TextBox();
            this.changeTextButton = new System.Windows.Forms.Button();
            this.typeTabControl = new System.Windows.Forms.TabControl();
            this.replaceTabPage = new System.Windows.Forms.TabPage();
            this.deletTabPage = new System.Windows.Forms.TabPage();
            this.searchDeletTextBox = new System.Windows.Forms.TextBox();
            this.searchDeletLabel = new System.Windows.Forms.Label();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.counterCheckBox = new System.Windows.Forms.CheckBox();
            this.tipsAddGroupBox = new System.Windows.Forms.GroupBox();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.RichTextBox();
            this.DisclamerButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.extCheckBox = new System.Windows.Forms.CheckBox();
            this.choosenFilesGroupBox.SuspendLayout();
            this.typeTabControl.SuspendLayout();
            this.replaceTabPage.SuspendLayout();
            this.deletTabPage.SuspendLayout();
            this.addTabPage.SuspendLayout();
            this.tipsAddGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileButton.Location = new System.Drawing.Point(12, 12);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(422, 46);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Choisir la liste des fichiers";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // choosenFilesGroupBox
            // 
            this.choosenFilesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.choosenFilesGroupBox.Controls.Add(this.choosenFileListBox);
            this.choosenFilesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.choosenFilesGroupBox.Location = new System.Drawing.Point(12, 64);
            this.choosenFilesGroupBox.Name = "choosenFilesGroupBox";
            this.choosenFilesGroupBox.Size = new System.Drawing.Size(422, 449);
            this.choosenFilesGroupBox.TabIndex = 1;
            this.choosenFilesGroupBox.TabStop = false;
            this.choosenFilesGroupBox.Text = "0 fichier(s) choisi(s)";
            // 
            // choosenFileListBox
            // 
            this.choosenFileListBox.FormattingEnabled = true;
            this.choosenFileListBox.Location = new System.Drawing.Point(6, 13);
            this.choosenFileListBox.Name = "choosenFileListBox";
            this.choosenFileListBox.Size = new System.Drawing.Size(410, 433);
            this.choosenFileListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(440, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 550);
            this.panel1.TabIndex = 2;
            // 
            // clearListButton
            // 
            this.clearListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearListButton.Location = new System.Drawing.Point(12, 519);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(422, 46);
            this.clearListButton.TabIndex = 3;
            this.clearListButton.Text = "Vider la liste";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // searchReplaceLabel
            // 
            this.searchReplaceLabel.AutoSize = true;
            this.searchReplaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchReplaceLabel.Location = new System.Drawing.Point(6, 77);
            this.searchReplaceLabel.Name = "searchReplaceLabel";
            this.searchReplaceLabel.Size = new System.Drawing.Size(117, 13);
            this.searchReplaceLabel.TabIndex = 5;
            this.searchReplaceLabel.Text = "Chaîne à chercher:";
            // 
            // newTextReplaceLabel
            // 
            this.newTextReplaceLabel.AutoSize = true;
            this.newTextReplaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTextReplaceLabel.Location = new System.Drawing.Point(6, 227);
            this.newTextReplaceLabel.Name = "newTextReplaceLabel";
            this.newTextReplaceLabel.Size = new System.Drawing.Size(105, 13);
            this.newTextReplaceLabel.TabIndex = 6;
            this.newTextReplaceLabel.Text = "Nouvelle chaîne:";
            // 
            // searchReplaceTextBox
            // 
            this.searchReplaceTextBox.Location = new System.Drawing.Point(9, 103);
            this.searchReplaceTextBox.Name = "searchReplaceTextBox";
            this.searchReplaceTextBox.Size = new System.Drawing.Size(400, 20);
            this.searchReplaceTextBox.TabIndex = 7;
            // 
            // newTextReplaceTextBox
            // 
            this.newTextReplaceTextBox.Location = new System.Drawing.Point(9, 254);
            this.newTextReplaceTextBox.Name = "newTextReplaceTextBox";
            this.newTextReplaceTextBox.Size = new System.Drawing.Size(400, 20);
            this.newTextReplaceTextBox.TabIndex = 8;
            // 
            // changeTextButton
            // 
            this.changeTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTextButton.Location = new System.Drawing.Point(467, 386);
            this.changeTextButton.Name = "changeTextButton";
            this.changeTextButton.Size = new System.Drawing.Size(375, 46);
            this.changeTextButton.TabIndex = 9;
            this.changeTextButton.Text = "Exécuter la modification";
            this.changeTextButton.UseVisualStyleBackColor = true;
            this.changeTextButton.Click += new System.EventHandler(this.changeTextButton_Click);
            // 
            // typeTabControl
            // 
            this.typeTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.typeTabControl.Controls.Add(this.replaceTabPage);
            this.typeTabControl.Controls.Add(this.deletTabPage);
            this.typeTabControl.Controls.Add(this.addTabPage);
            this.typeTabControl.Location = new System.Drawing.Point(467, 12);
            this.typeTabControl.Name = "typeTabControl";
            this.typeTabControl.SelectedIndex = 0;
            this.typeTabControl.Size = new System.Drawing.Size(423, 346);
            this.typeTabControl.TabIndex = 10;
            // 
            // replaceTabPage
            // 
            this.replaceTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.replaceTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replaceTabPage.Controls.Add(this.searchReplaceTextBox);
            this.replaceTabPage.Controls.Add(this.searchReplaceLabel);
            this.replaceTabPage.Controls.Add(this.newTextReplaceLabel);
            this.replaceTabPage.Controls.Add(this.newTextReplaceTextBox);
            this.replaceTabPage.Location = new System.Drawing.Point(4, 25);
            this.replaceTabPage.Name = "replaceTabPage";
            this.replaceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.replaceTabPage.Size = new System.Drawing.Size(415, 317);
            this.replaceTabPage.TabIndex = 0;
            this.replaceTabPage.Text = "Remplacement";
            // 
            // deletTabPage
            // 
            this.deletTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletTabPage.Controls.Add(this.searchDeletTextBox);
            this.deletTabPage.Controls.Add(this.searchDeletLabel);
            this.deletTabPage.Location = new System.Drawing.Point(4, 25);
            this.deletTabPage.Name = "deletTabPage";
            this.deletTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deletTabPage.Size = new System.Drawing.Size(415, 317);
            this.deletTabPage.TabIndex = 1;
            this.deletTabPage.Text = "Suppression";
            this.deletTabPage.UseVisualStyleBackColor = true;
            // 
            // searchDeletTextBox
            // 
            this.searchDeletTextBox.Location = new System.Drawing.Point(8, 171);
            this.searchDeletTextBox.Name = "searchDeletTextBox";
            this.searchDeletTextBox.Size = new System.Drawing.Size(400, 20);
            this.searchDeletTextBox.TabIndex = 9;
            // 
            // searchDeletLabel
            // 
            this.searchDeletLabel.AutoSize = true;
            this.searchDeletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDeletLabel.Location = new System.Drawing.Point(5, 145);
            this.searchDeletLabel.Name = "searchDeletLabel";
            this.searchDeletLabel.Size = new System.Drawing.Size(121, 13);
            this.searchDeletLabel.TabIndex = 8;
            this.searchDeletLabel.Text = "Chaîne à supprimer:";
            // 
            // addTabPage
            // 
            this.addTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTabPage.Controls.Add(this.locationTextBox);
            this.addTabPage.Controls.Add(this.locationLabel);
            this.addTabPage.Controls.Add(this.counterCheckBox);
            this.addTabPage.Controls.Add(this.tipsAddGroupBox);
            this.addTabPage.Controls.Add(this.addTextBox);
            this.addTabPage.Controls.Add(this.addLabel);
            this.addTabPage.Location = new System.Drawing.Point(4, 25);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(415, 317);
            this.addTabPage.TabIndex = 2;
            this.addTabPage.Text = "Ajout";
            this.addTabPage.UseVisualStyleBackColor = true;
            // 
            // counterCheckBox
            // 
            this.counterCheckBox.AutoSize = true;
            this.counterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterCheckBox.Location = new System.Drawing.Point(9, 104);
            this.counterCheckBox.Name = "counterCheckBox";
            this.counterCheckBox.Size = new System.Drawing.Size(140, 17);
            this.counterCheckBox.TabIndex = 13;
            this.counterCheckBox.Text = "Ajouter un compteur";
            this.counterCheckBox.UseVisualStyleBackColor = true;
            // 
            // tipsAddGroupBox
            // 
            this.tipsAddGroupBox.Controls.Add(this.tipsLabel);
            this.tipsAddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsAddGroupBox.Location = new System.Drawing.Point(9, 191);
            this.tipsAddGroupBox.Name = "tipsAddGroupBox";
            this.tipsAddGroupBox.Size = new System.Drawing.Size(398, 118);
            this.tipsAddGroupBox.TabIndex = 12;
            this.tipsAddGroupBox.TabStop = false;
            this.tipsAddGroupBox.Text = "Astuce :";
            // 
            // tipsLabel
            // 
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsLabel.Location = new System.Drawing.Point(7, 20);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(343, 91);
            this.tipsLabel.TabIndex = 0;
            this.tipsLabel.Text = resources.GetString("tipsLabel.Text");
            this.tipsLabel.Click += new System.EventHandler(this.tipsLabel_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(9, 65);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(400, 20);
            this.addTextBox.TabIndex = 11;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.Location = new System.Drawing.Point(6, 39);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(106, 13);
            this.addLabel.TabIndex = 10;
            this.addLabel.Text = "Chaîne à ajouter:";
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.resultLabel);
            this.resultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGroupBox.Location = new System.Drawing.Point(466, 452);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(424, 113);
            this.resultGroupBox.TabIndex = 11;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Résultats de l\'opération :";
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(6, 19);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(409, 88);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Aucun pour l\'instant ...";
            // 
            // DisclamerButton
            // 
            this.DisclamerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisclamerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisclamerButton.Location = new System.Drawing.Point(848, 386);
            this.DisclamerButton.Name = "DisclamerButton";
            this.DisclamerButton.Size = new System.Drawing.Size(38, 46);
            this.DisclamerButton.TabIndex = 12;
            this.DisclamerButton.Text = "?";
            this.DisclamerButton.UseVisualStyleBackColor = true;
            this.DisclamerButton.Click += new System.EventHandler(this.DisclamerButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(6, 141);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(74, 13);
            this.locationLabel.TabIndex = 14;
            this.locationLabel.Text = "Position N°:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(86, 138);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(46, 20);
            this.locationTextBox.TabIndex = 15;
            this.locationTextBox.Text = "0";
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // extCheckBox
            // 
            this.extCheckBox.AutoSize = true;
            this.extCheckBox.Location = new System.Drawing.Point(481, 364);
            this.extCheckBox.Name = "extCheckBox";
            this.extCheckBox.Size = new System.Drawing.Size(219, 17);
            this.extCheckBox.TabIndex = 13;
            this.extCheckBox.Text = "Cocher pour gérer l\'extension des fichiers";
            this.extCheckBox.UseVisualStyleBackColor = true;
            this.extCheckBox.CheckedChanged += new System.EventHandler(this.extCheckBox_CheckedChanged);
            // 
            // fileManipulationForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 577);
            this.Controls.Add(this.extCheckBox);
            this.Controls.Add(this.DisclamerButton);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.typeTabControl);
            this.Controls.Add(this.changeTextButton);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.choosenFilesGroupBox);
            this.Controls.Add(this.selectFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fileManipulationForm";
            this.Text = "Module: Noms de fichiers";
            this.Load += new System.EventHandler(this.fileManipulationForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileManipulationForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileManipulationForm_DragEnter);
            this.choosenFilesGroupBox.ResumeLayout(false);
            this.typeTabControl.ResumeLayout(false);
            this.replaceTabPage.ResumeLayout(false);
            this.replaceTabPage.PerformLayout();
            this.deletTabPage.ResumeLayout(false);
            this.deletTabPage.PerformLayout();
            this.addTabPage.ResumeLayout(false);
            this.addTabPage.PerformLayout();
            this.tipsAddGroupBox.ResumeLayout(false);
            this.tipsAddGroupBox.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.GroupBox choosenFilesGroupBox;
        private System.Windows.Forms.ListBox choosenFileListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.Label searchReplaceLabel;
        private System.Windows.Forms.Label newTextReplaceLabel;
        private System.Windows.Forms.TextBox searchReplaceTextBox;
        private System.Windows.Forms.TextBox newTextReplaceTextBox;
        private System.Windows.Forms.Button changeTextButton;
        private System.Windows.Forms.TabControl typeTabControl;
        private System.Windows.Forms.TabPage replaceTabPage;
        private System.Windows.Forms.TabPage deletTabPage;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.TextBox searchDeletTextBox;
        private System.Windows.Forms.Label searchDeletLabel;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.GroupBox tipsAddGroupBox;
        private System.Windows.Forms.Label tipsLabel;
        private System.Windows.Forms.CheckBox counterCheckBox;
        private System.Windows.Forms.RichTextBox resultLabel;
        private System.Windows.Forms.Button DisclamerButton;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.CheckBox extCheckBox;
    }
}

