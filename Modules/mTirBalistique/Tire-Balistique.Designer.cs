namespace Tire_balistique
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxDegrees = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelDegrees = new System.Windows.Forms.Label();
            this.timerTemp = new System.Windows.Forms.Timer(this.components);
            this.panelDraw = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaxLenght = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInstDist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaxHight = new System.Windows.Forms.Label();
            this.labelHight = new System.Windows.Forms.Label();
            this.labelHautInst = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.panelDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonColor);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.textBoxSpeed);
            this.groupBox1.Controls.Add(this.textBoxDegrees);
            this.groupBox1.Controls.Add(this.labelSpeed);
            this.groupBox1.Controls.Add(this.labelDegrees);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie des paramètre du tire balistique";
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Red;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Location = new System.Drawing.Point(620, 30);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(18, 33);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(489, 30);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(125, 32);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Départ";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(283, 37);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(57, 20);
            this.textBoxSpeed.TabIndex = 3;
            this.textBoxSpeed.Text = "0";
            this.textBoxSpeed.TextChanged += new System.EventHandler(this.textBoxSpeed_TextChanged);
            // 
            // textBoxDegrees
            // 
            this.textBoxDegrees.Location = new System.Drawing.Point(123, 37);
            this.textBoxDegrees.Name = "textBoxDegrees";
            this.textBoxDegrees.Size = new System.Drawing.Size(59, 20);
            this.textBoxDegrees.TabIndex = 2;
            this.textBoxDegrees.Text = "0";
            this.textBoxDegrees.TextChanged += new System.EventHandler(this.textBoxDegrees_TextChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(188, 40);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(89, 13);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Vitesse [en m/s]  ";
            // 
            // labelDegrees
            // 
            this.labelDegrees.AutoSize = true;
            this.labelDegrees.Location = new System.Drawing.Point(36, 40);
            this.labelDegrees.Name = "labelDegrees";
            this.labelDegrees.Size = new System.Drawing.Size(81, 13);
            this.labelDegrees.TabIndex = 0;
            this.labelDegrees.Text = "Angle [en Deg] ";
            // 
            // timerTemp
            // 
            this.timerTemp.Interval = 1;
            this.timerTemp.Tick += new System.EventHandler(this.timerTemp_Tick);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Controls.Add(this.label4);
            this.panelDraw.Controls.Add(this.labelMaxLenght);
            this.panelDraw.Controls.Add(this.label2);
            this.panelDraw.Controls.Add(this.labelInstDist);
            this.panelDraw.Controls.Add(this.label1);
            this.panelDraw.Controls.Add(this.labelMaxHight);
            this.panelDraw.Controls.Add(this.labelHight);
            this.panelDraw.Controls.Add(this.labelHautInst);
            this.panelDraw.Location = new System.Drawing.Point(12, 119);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(670, 445);
            this.panelDraw.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distance Max [m] :";
            // 
            // labelMaxLenght
            // 
            this.labelMaxLenght.AutoSize = true;
            this.labelMaxLenght.Location = new System.Drawing.Point(606, 115);
            this.labelMaxLenght.Name = "labelMaxLenght";
            this.labelMaxLenght.Size = new System.Drawing.Size(0, 13);
            this.labelMaxLenght.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distance Inst [m] :";
            // 
            // labelInstDist
            // 
            this.labelInstDist.AutoSize = true;
            this.labelInstDist.Location = new System.Drawing.Point(606, 88);
            this.labelInstDist.Name = "labelInstDist";
            this.labelInstDist.Size = new System.Drawing.Size(0, 13);
            this.labelInstDist.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hauteur Max [m] :";
            // 
            // labelMaxHight
            // 
            this.labelMaxHight.AutoSize = true;
            this.labelMaxHight.Location = new System.Drawing.Point(606, 47);
            this.labelMaxHight.Name = "labelMaxHight";
            this.labelMaxHight.Size = new System.Drawing.Size(0, 13);
            this.labelMaxHight.TabIndex = 2;
            // 
            // labelHight
            // 
            this.labelHight.AutoSize = true;
            this.labelHight.Location = new System.Drawing.Point(496, 19);
            this.labelHight.Name = "labelHight";
            this.labelHight.Size = new System.Drawing.Size(88, 13);
            this.labelHight.TabIndex = 1;
            this.labelHight.Text = "Hauteur Inst [m] :";
            // 
            // labelHautInst
            // 
            this.labelHautInst.AutoSize = true;
            this.labelHautInst.Location = new System.Drawing.Point(606, 19);
            this.labelHautInst.Name = "labelHautInst";
            this.labelHautInst.Size = new System.Drawing.Size(0, 13);
            this.labelHautInst.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 572);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tire Balistique";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDraw.ResumeLayout(false);
            this.panelDraw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxDegrees;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelDegrees;
        private System.Windows.Forms.Timer timerTemp;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelHautInst;
        private System.Windows.Forms.Label labelHight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaxHight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMaxLenght;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInstDist;
    }
}

