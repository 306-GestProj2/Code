namespace CalculFunctionSecondDegree
{
    partial class FormCalculFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonValidate = new System.Windows.Forms.Button();
            this.TextBoxValueC = new System.Windows.Forms.TextBox();
            this.TextBoxValueB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxValueA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonValidate);
            this.panel1.Controls.Add(this.TextBoxValueC);
            this.panel1.Controls.Add(this.TextBoxValueB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBoxValueA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 48);
            this.panel1.TabIndex = 0;
            // 
            // ButtonValidate
            // 
            this.ButtonValidate.Location = new System.Drawing.Point(361, 13);
            this.ButtonValidate.Name = "ButtonValidate";
            this.ButtonValidate.Size = new System.Drawing.Size(155, 25);
            this.ButtonValidate.TabIndex = 6;
            this.ButtonValidate.Text = "Valider la formule";
            this.ButtonValidate.UseVisualStyleBackColor = true;
            this.ButtonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // TextBoxValueC
            // 
            this.TextBoxValueC.Location = new System.Drawing.Point(282, 14);
            this.TextBoxValueC.Name = "TextBoxValueC";
            this.TextBoxValueC.Size = new System.Drawing.Size(38, 20);
            this.TextBoxValueC.TabIndex = 5;
            // 
            // TextBoxValueB
            // 
            this.TextBoxValueB.Location = new System.Drawing.Point(212, 14);
            this.TextBoxValueB.Name = "TextBoxValueB";
            this.TextBoxValueB.Size = new System.Drawing.Size(38, 20);
            this.TextBoxValueB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(256, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = " x + ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(179, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = " x2 + ";
            // 
            // TextBoxValueA
            // 
            this.TextBoxValueA.Location = new System.Drawing.Point(135, 14);
            this.TextBoxValueA.Name = "TextBoxValueA";
            this.TextBoxValueA.Size = new System.Drawing.Size(38, 20);
            this.TextBoxValueA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fonction : Y = f(x) = ";
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(12, 75);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(841, 418);
            this.DrawPanel.TabIndex = 1;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // FormCalculFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(866, 514);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCalculFunction";
            this.Text = "Tracage d\'une fonction du 2èeme degrès par voie graphique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculFunction_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxValueA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxValueC;
        private System.Windows.Forms.TextBox TextBoxValueB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonValidate;
        private System.Windows.Forms.Panel DrawPanel;
    }
}

