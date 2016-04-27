namespace FormCalculFunction
{
    partial class FormCalculFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculFunction));
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxValueA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxValueB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxValueC = new System.Windows.Forms.TextBox();
            this.ButtonValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(12, 91);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(841, 418);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fonction Y =";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // TextBoxValueA
            // 
            this.TextBoxValueA.Location = new System.Drawing.Point(296, 36);
            this.TextBoxValueA.Name = "TextBoxValueA";
            this.TextBoxValueA.Size = new System.Drawing.Size(42, 20);
            this.TextBoxValueA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "x2 + ";
            // 
            // TextBoxValueB
            // 
            this.TextBoxValueB.Location = new System.Drawing.Point(373, 35);
            this.TextBoxValueB.Name = "TextBoxValueB";
            this.TextBoxValueB.Size = new System.Drawing.Size(42, 20);
            this.TextBoxValueB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "x + ";
            // 
            // TextBoxValueC
            // 
            this.TextBoxValueC.Location = new System.Drawing.Point(444, 36);
            this.TextBoxValueC.Name = "TextBoxValueC";
            this.TextBoxValueC.Size = new System.Drawing.Size(42, 20);
            this.TextBoxValueC.TabIndex = 6;
            // 
            // ButtonValidate
            // 
            this.ButtonValidate.Location = new System.Drawing.Point(511, 35);
            this.ButtonValidate.Name = "ButtonValidate";
            this.ButtonValidate.Size = new System.Drawing.Size(160, 23);
            this.ButtonValidate.TabIndex = 7;
            this.ButtonValidate.Text = "Valider la formule";
            this.ButtonValidate.UseVisualStyleBackColor = true;
            this.ButtonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // FormCalculFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 523);
            this.Controls.Add(this.ButtonValidate);
            this.Controls.Add(this.TextBoxValueC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxValueB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxValueA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculFunction";
            this.Text = "Module de création de fonctions du 2ème degrès par voie graphique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculFunction_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxValueA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxValueB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxValueC;
        private System.Windows.Forms.Button ButtonValidate;
    }
}

