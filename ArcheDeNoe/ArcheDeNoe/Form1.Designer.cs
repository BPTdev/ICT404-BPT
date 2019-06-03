namespace ArcheDeNoe
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
            this.butterrebord = new System.Windows.Forms.Button();
            this.butbordterre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbterre = new System.Windows.Forms.ListBox();
            this.ltbbord = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // butterrebord
            // 
            this.butterrebord.Location = new System.Drawing.Point(214, 12);
            this.butterrebord.Name = "butterrebord";
            this.butterrebord.Size = new System.Drawing.Size(227, 233);
            this.butterrebord.TabIndex = 0;
            this.butterrebord.Text = "=====>";
            this.butterrebord.UseVisualStyleBackColor = true;
            this.butterrebord.Click += new System.EventHandler(this.butterrebord_Click);
            // 
            // butbordterre
            // 
            this.butbordterre.Enabled = false;
            this.butbordterre.Location = new System.Drawing.Point(301, 303);
            this.butbordterre.Name = "butbordterre";
            this.butbordterre.Size = new System.Drawing.Size(75, 23);
            this.butbordterre.TabIndex = 1;
            this.butbordterre.Text = "<=====";
            this.butbordterre.UseVisualStyleBackColor = true;
            this.butbordterre.Click += new System.EventHandler(this.butbordterre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encore à terre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "A bord";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ltbterre
            // 
            this.ltbterre.FormattingEnabled = true;
            this.ltbterre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Chien",
            "Cobra",
            "Coccinelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.ltbterre.Location = new System.Drawing.Point(51, 71);
            this.ltbterre.Name = "ltbterre";
            this.ltbterre.Size = new System.Drawing.Size(140, 264);
            this.ltbterre.Sorted = true;
            this.ltbterre.TabIndex = 7;
            // 
            // ltbbord
            // 
            this.ltbbord.FormattingEnabled = true;
            this.ltbbord.Location = new System.Drawing.Point(475, 62);
            this.ltbbord.Name = "ltbbord";
            this.ltbbord.Size = new System.Drawing.Size(140, 264);
            this.ltbbord.TabIndex = 8;
            this.ltbbord.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltbbord);
            this.Controls.Add(this.ltbterre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butbordterre);
            this.Controls.Add(this.butterrebord);
            this.Name = "Form1";
            this.Text = "Arche de Noé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butterrebord;
        private System.Windows.Forms.Button butbordterre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbterre;
        private System.Windows.Forms.ListBox ltbbord;
    }
}

