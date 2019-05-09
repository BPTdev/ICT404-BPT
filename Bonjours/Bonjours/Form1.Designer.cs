namespace Bonjours
{
    partial class FBonjour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBonjour));
            this.VNom = new System.Windows.Forms.Label();
            this.TBox = new System.Windows.Forms.TextBox();
            this.Bonjour = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VNom
            // 
            resources.ApplyResources(this.VNom, "VNom");
            this.VNom.ForeColor = System.Drawing.Color.Navy;
            this.VNom.Name = "VNom";
            // 
            // TBox
            // 
            resources.ApplyResources(this.TBox, "TBox");
            this.TBox.BackColor = System.Drawing.Color.Lavender;
            this.TBox.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.TBox.Name = "TBox";
            this.TBox.TextChanged += new System.EventHandler(this.TBox_TextChanged);
            // 
            // Bonjour
            // 
            resources.ApplyResources(this.Bonjour, "Bonjour");
            this.Bonjour.ForeColor = System.Drawing.Color.Navy;
            this.Bonjour.Name = "Bonjour";
            // 
            // Button
            // 
            resources.ApplyResources(this.Button, "Button");
            this.Button.BackColor = System.Drawing.Color.Silver;
            this.Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button.Name = "Button";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // FBonjour
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Bonjour);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.VNom);
            this.Name = "FBonjour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VNom;
        private System.Windows.Forms.TextBox TBox;
        private System.Windows.Forms.Label Bonjour;
        private System.Windows.Forms.Button Button;
    }
}

