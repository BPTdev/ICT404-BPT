namespace test_comme_g
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
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.cboQuantite = new System.Windows.Forms.TextBox();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmdSuppr = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(12, 86);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(236, 173);
            this.lstCourses.TabIndex = 0;
            // 
            // cboQuantite
            // 
            this.cboQuantite.Location = new System.Drawing.Point(25, 25);
            this.cboQuantite.Name = "cboQuantite";
            this.cboQuantite.Size = new System.Drawing.Size(25, 20);
            this.cboQuantite.TabIndex = 1;
            // 
            // cboArticle
            // 
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Items.AddRange(new object[] {
            "Lait",
            "Oeuf",
            "Pain",
            "Confiture",
            "Salade",
            "Pomme",
            "Brosse à dent"});
            this.cboArticle.Location = new System.Drawing.Point(55, 25);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(193, 21);
            this.cboArticle.TabIndex = 2;
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Location = new System.Drawing.Point(12, 305);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(236, 23);
            this.cmdImprimer.TabIndex = 3;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmdSuppr
            // 
            this.cmdSuppr.Location = new System.Drawing.Point(12, 265);
            this.cmdSuppr.Name = "cmdSuppr";
            this.cmdSuppr.Size = new System.Drawing.Size(236, 23);
            this.cmdSuppr.TabIndex = 4;
            this.cmdSuppr.Text = "Suprimer";
            this.cmdSuppr.UseVisualStyleBackColor = true;
            this.cmdSuppr.Click += new System.EventHandler(this.cmdSuppr_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(12, 57);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(236, 23);
            this.cmdAdd.TabIndex = 5;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 376);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdSuppr);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.cboQuantite);
            this.Controls.Add(this.lstCourses);
            this.Name = "Form1";
            this.Text = "Liste de course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.TextBox cboQuantite;
        private System.Windows.Forms.ComboBox cboArticle;
        private System.Windows.Forms.Button cmdImprimer;
        private System.Windows.Forms.Button cmdSuppr;
        private System.Windows.Forms.Button cmdAdd;
    }
}

