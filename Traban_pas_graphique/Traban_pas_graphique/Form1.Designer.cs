namespace Traban_pas_graphique
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
            this.tbxprix = new System.Windows.Forms.TextBox();
            this.rbu14 = new System.Windows.Forms.RadioButton();
            this.rbu16 = new System.Windows.Forms.RadioButton();
            this.cbxtaxe = new System.Windows.Forms.CheckBox();
            this.cmdreset = new System.Windows.Forms.Button();
            this.cmdquit = new System.Windows.Forms.Button();
            this.tbxprixfin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxprix
            // 
            this.tbxprix.Location = new System.Drawing.Point(12, 12);
            this.tbxprix.Name = "tbxprix";
            this.tbxprix.Size = new System.Drawing.Size(100, 20);
            this.tbxprix.TabIndex = 0;
            this.tbxprix.Text = "12300";
            this.tbxprix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxprix.TextChanged += new System.EventHandler(this.tbxprix_TextChanged);
            // 
            // rbu14
            // 
            this.rbu14.AutoSize = true;
            this.rbu14.Checked = true;
            this.rbu14.Location = new System.Drawing.Point(12, 38);
            this.rbu14.Name = "rbu14";
            this.rbu14.Size = new System.Drawing.Size(46, 17);
            this.rbu14.TabIndex = 1;
            this.rbu14.TabStop = true;
            this.rbu14.Text = "1.4L";
            this.rbu14.UseVisualStyleBackColor = true;
            // 
            // rbu16
            // 
            this.rbu16.AutoSize = true;
            this.rbu16.Location = new System.Drawing.Point(12, 61);
            this.rbu16.Name = "rbu16";
            this.rbu16.Size = new System.Drawing.Size(46, 17);
            this.rbu16.TabIndex = 1;
            this.rbu16.Text = "1.6L";
            this.rbu16.UseVisualStyleBackColor = true;
            // 
            // cbxtaxe
            // 
            this.cbxtaxe.AutoSize = true;
            this.cbxtaxe.Location = new System.Drawing.Point(12, 84);
            this.cbxtaxe.Name = "cbxtaxe";
            this.cbxtaxe.Size = new System.Drawing.Size(46, 17);
            this.cbxtaxe.TabIndex = 3;
            this.cbxtaxe.Text = "taxe";
            this.cbxtaxe.UseVisualStyleBackColor = true;
            // 
            // cmdreset
            // 
            this.cmdreset.Location = new System.Drawing.Point(12, 133);
            this.cmdreset.Name = "cmdreset";
            this.cmdreset.Size = new System.Drawing.Size(75, 23);
            this.cmdreset.TabIndex = 4;
            this.cmdreset.Text = "mettre a 0";
            this.cmdreset.UseVisualStyleBackColor = true;
            this.cmdreset.Click += new System.EventHandler(this.cmdreset_Click);
            // 
            // cmdquit
            // 
            this.cmdquit.Location = new System.Drawing.Point(12, 162);
            this.cmdquit.Name = "cmdquit";
            this.cmdquit.Size = new System.Drawing.Size(75, 23);
            this.cmdquit.TabIndex = 5;
            this.cmdquit.Text = "Quitter";
            this.cmdquit.UseVisualStyleBackColor = true;
            this.cmdquit.Click += new System.EventHandler(this.cmdquit_Click);
            // 
            // tbxprixfin
            // 
            this.tbxprixfin.Location = new System.Drawing.Point(12, 107);
            this.tbxprixfin.Name = "tbxprixfin";
            this.tbxprixfin.Size = new System.Drawing.Size(100, 20);
            this.tbxprixfin.TabIndex = 6;
            this.tbxprixfin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 187);
            this.Controls.Add(this.tbxprixfin);
            this.Controls.Add(this.cmdquit);
            this.Controls.Add(this.cmdreset);
            this.Controls.Add(this.cbxtaxe);
            this.Controls.Add(this.rbu16);
            this.Controls.Add(this.rbu14);
            this.Controls.Add(this.tbxprix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxprix;
        private System.Windows.Forms.RadioButton rbu14;
        private System.Windows.Forms.RadioButton rbu16;
        private System.Windows.Forms.CheckBox cbxtaxe;
        private System.Windows.Forms.Button cmdreset;
        private System.Windows.Forms.Button cmdquit;
        private System.Windows.Forms.TextBox tbxprixfin;
    }
}

