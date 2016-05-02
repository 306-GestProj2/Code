namespace Module_Resistance
{
    partial class FormResistance 
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.cmbTolerance = new System.Windows.Forms.ComboBox();
            this.cmbMultplicateur = new System.Windows.Forms.ComboBox();
            this.textBoxValueToCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNumberTwo = new System.Windows.Forms.Panel();
            this.panelMultiplicator = new System.Windows.Forms.Panel();
            this.panelTolerance = new System.Windows.Forms.Panel();
            this.decoPanel = new System.Windows.Forms.Panel();
            this.panelNumberOne = new System.Windows.Forms.Panel();
            this.panelNumberTree = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.decoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSearch.Controls.Add(this.cmbTolerance);
            this.panelSearch.Controls.Add(this.cmbMultplicateur);
            this.panelSearch.Controls.Add(this.textBoxValueToCheck);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Location = new System.Drawing.Point(14, 12);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(585, 55);
            this.panelSearch.TabIndex = 0;
            this.panelSearch.Tag = "";
            // 
            // cmbTolerance
            // 
            this.cmbTolerance.FormattingEnabled = true;
            this.cmbTolerance.Items.AddRange(new object[] {
            "20%",
            "10%",
            "5%",
            "2%",
            "1%",
            "0.5%",
            "0.25%",
            "0.10%",
            "0.05%"});
            this.cmbTolerance.Location = new System.Drawing.Point(409, 15);
            this.cmbTolerance.Name = "cmbTolerance";
            this.cmbTolerance.Size = new System.Drawing.Size(51, 21);
            this.cmbTolerance.TabIndex = 6;
            this.cmbTolerance.SelectedIndexChanged += new System.EventHandler(this.cmbTolerance_SelectedIndexChanged);
            // 
            // cmbMultplicateur
            // 
            this.cmbMultplicateur.FormattingEnabled = true;
            this.cmbMultplicateur.Items.AddRange(new object[] {
            "10^7",
            "10^6",
            "10^5",
            "10^4",
            "10^3",
            "10^2",
            "10^1",
            "10^0",
            "10^-1",
            "10^-2"});
            this.cmbMultplicateur.Location = new System.Drawing.Point(347, 15);
            this.cmbMultplicateur.Name = "cmbMultplicateur";
            this.cmbMultplicateur.Size = new System.Drawing.Size(56, 21);
            this.cmbMultplicateur.TabIndex = 5;
            this.cmbMultplicateur.SelectedIndexChanged += new System.EventHandler(this.cmbMultplicateur_SelectedIndexChanged);
            // 
            // textBoxValueToCheck
            // 
            this.textBoxValueToCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValueToCheck.Location = new System.Drawing.Point(241, 16);
            this.textBoxValueToCheck.Name = "textBoxValueToCheck";
            this.textBoxValueToCheck.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueToCheck.TabIndex = 4;
            this.textBoxValueToCheck.TextChanged += new System.EventHandler(this.textBoxValueToCheck_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valeur en Ohms :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelNumberTwo);
            this.panel2.Controls.Add(this.panelMultiplicator);
            this.panel2.Controls.Add(this.panelTolerance);
            this.panel2.Location = new System.Drawing.Point(172, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 64);
            this.panel2.TabIndex = 0;
            // 
            // panelNumberTwo
            // 
            this.panelNumberTwo.BackColor = System.Drawing.Color.Tan;
            this.panelNumberTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNumberTwo.Location = new System.Drawing.Point(60, -1);
            this.panelNumberTwo.Name = "panelNumberTwo";
            this.panelNumberTwo.Size = new System.Drawing.Size(25, 64);
            this.panelNumberTwo.TabIndex = 2;
            // 
            // panelMultiplicator
            // 
            this.panelMultiplicator.BackColor = System.Drawing.Color.Tan;
            this.panelMultiplicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMultiplicator.Location = new System.Drawing.Point(155, -1);
            this.panelMultiplicator.Name = "panelMultiplicator";
            this.panelMultiplicator.Size = new System.Drawing.Size(25, 64);
            this.panelMultiplicator.TabIndex = 3;
            // 
            // panelTolerance
            // 
            this.panelTolerance.BackColor = System.Drawing.Color.Tan;
            this.panelTolerance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTolerance.Location = new System.Drawing.Point(199, -1);
            this.panelTolerance.Name = "panelTolerance";
            this.panelTolerance.Size = new System.Drawing.Size(25, 64);
            this.panelTolerance.TabIndex = 4;
            // 
            // decoPanel
            // 
            this.decoPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.decoPanel.Controls.Add(this.panelNumberOne);
            this.decoPanel.Controls.Add(this.panelNumberTree);
            this.decoPanel.Controls.Add(this.panel2);
            this.decoPanel.Controls.Add(this.label3);
            this.decoPanel.Controls.Add(this.label2);
            this.decoPanel.Location = new System.Drawing.Point(14, 87);
            this.decoPanel.Name = "decoPanel";
            this.decoPanel.Size = new System.Drawing.Size(585, 200);
            this.decoPanel.TabIndex = 1;
            this.decoPanel.Tag = "";
            // 
            // panelNumberOne
            // 
            this.panelNumberOne.BackColor = System.Drawing.Color.Tan;
            this.panelNumberOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNumberOne.Location = new System.Drawing.Point(191, 60);
            this.panelNumberOne.Name = "panelNumberOne";
            this.panelNumberOne.Size = new System.Drawing.Size(25, 64);
            this.panelNumberOne.TabIndex = 1;
            // 
            // panelNumberTree
            // 
            this.panelNumberTree.BackColor = System.Drawing.Color.Tan;
            this.panelNumberTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNumberTree.Location = new System.Drawing.Point(282, 60);
            this.panelNumberTree.Name = "panelNumberTree";
            this.panelNumberTree.Size = new System.Drawing.Size(25, 64);
            this.panelNumberTree.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(384, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 5);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(1, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 5);
            this.label2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 23);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormResistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(613, 298);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.decoPanel);
            this.Name = "FormResistance";
            this.Text = "Module de resistance";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.decoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTolerance;
        private System.Windows.Forms.Panel panelNumberTwo;
        private System.Windows.Forms.Panel decoPanel;
        private System.Windows.Forms.Panel panelMultiplicator;
        private System.Windows.Forms.Panel panelNumberOne;
        private System.Windows.Forms.TextBox textBoxValueToCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelNumberTree;
        private System.Windows.Forms.ComboBox cmbTolerance;
        private System.Windows.Forms.ComboBox cmbMultplicateur;
        private System.Windows.Forms.Label label4;
    }
}

