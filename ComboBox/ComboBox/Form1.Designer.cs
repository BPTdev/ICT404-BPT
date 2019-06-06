namespace ComboBox
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
            this.lstEcole = new System.Windows.Forms.ListBox();
            this.cboSwiss = new System.Windows.Forms.ComboBox();
            this.cboGymnase = new System.Windows.Forms.ComboBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdEffacer = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lstArrivée = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEcole
            // 
            this.lstEcole.FormattingEnabled = true;
            this.lstEcole.Location = new System.Drawing.Point(46, 105);
            this.lstEcole.Name = "lstEcole";
            this.lstEcole.Size = new System.Drawing.Size(120, 212);
            this.lstEcole.TabIndex = 0;
            // 
            // cboSwiss
            // 
            this.cboSwiss.ForeColor = System.Drawing.Color.DarkRed;
            this.cboSwiss.FormattingEnabled = true;
            this.cboSwiss.Items.AddRange(new object[] {
            "Swisscom",
            "Arches"});
            this.cboSwiss.Location = new System.Drawing.Point(46, 38);
            this.cboSwiss.Name = "cboSwiss";
            this.cboSwiss.Size = new System.Drawing.Size(121, 21);
            this.cboSwiss.TabIndex = 1;
            // 
            // cboGymnase
            // 
            this.cboGymnase.FormattingEnabled = true;
            this.cboGymnase.Location = new System.Drawing.Point(46, 357);
            this.cboGymnase.Name = "cboGymnase";
            this.cboGymnase.Size = new System.Drawing.Size(121, 21);
            this.cboGymnase.TabIndex = 2;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(225, 35);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(95, 53);
            this.cmdAjouter.TabIndex = 3;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            // 
            // cmdEffacer
            // 
            this.cmdEffacer.Location = new System.Drawing.Point(225, 130);
            this.cmdEffacer.Name = "cmdEffacer";
            this.cmdEffacer.Size = new System.Drawing.Size(95, 53);
            this.cmdEffacer.TabIndex = 4;
            this.cmdEffacer.Text = "Effacer";
            this.cmdEffacer.UseVisualStyleBackColor = true;
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(225, 226);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(95, 53);
            this.cmdSupprimer.TabIndex = 5;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(225, 340);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(95, 53);
            this.cmdQuitter.TabIndex = 6;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            // 
            // lstArrivée
            // 
            this.lstArrivée.FormattingEnabled = true;
            this.lstArrivée.Location = new System.Drawing.Point(409, 53);
            this.lstArrivée.Name = "lstArrivée";
            this.lstArrivée.Size = new System.Drawing.Size(120, 264);
            this.lstArrivée.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "école sélectionnées";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstArrivée);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdEffacer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cboGymnase);
            this.Controls.Add(this.cboSwiss);
            this.Controls.Add(this.lstEcole);
            this.Name = "Form1";
            this.Text = "ListBox et ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEcole;
        private System.Windows.Forms.ComboBox cboSwiss;
        private System.Windows.Forms.ComboBox cboGymnase;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdEffacer;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ListBox lstArrivée;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

