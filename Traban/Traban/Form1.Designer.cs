namespace Traban
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
            this.button1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.rbu14 = new System.Windows.Forms.RadioButton();
            this.rbu16 = new System.Windows.Forms.RadioButton();
            this.lblres = new System.Windows.Forms.Label();
            this.lblprix = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(254, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remettre le formulaire à zéro.";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ForeColor = System.Drawing.SystemColors.Window;
            this.but2.Location = new System.Drawing.Point(350, 389);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(106, 33);
            this.but2.TabIndex = 1;
            this.but2.Text = "Quitter";
            this.but2.UseVisualStyleBackColor = false;
            // 
            // rbu14
            // 
            this.rbu14.AutoSize = true;
            this.rbu14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbu14.FlatAppearance.BorderSize = 10;
            this.rbu14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbu14.Location = new System.Drawing.Point(79, 182);
            this.rbu14.Name = "rbu14";
            this.rbu14.Size = new System.Drawing.Size(242, 22);
            this.rbu14.TabIndex = 1;
            this.rbu14.TabStop = true;
            this.rbu14.Text = "1.4L : inclus dans le prix de base.";
            this.rbu14.UseVisualStyleBackColor = true;
            // 
            // rbu16
            // 
            this.rbu16.AutoSize = true;
            this.rbu16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbu16.FlatAppearance.BorderSize = 10;
            this.rbu16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbu16.Location = new System.Drawing.Point(79, 215);
            this.rbu16.Name = "rbu16";
            this.rbu16.Size = new System.Drawing.Size(110, 22);
            this.rbu16.TabIndex = 3;
            this.rbu16.TabStop = true;
            this.rbu16.Text = "1.6L : 2210 €";
            this.rbu16.UseVisualStyleBackColor = true;
            // 
            // lblres
            // 
            this.lblres.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.Yellow;
            this.lblres.Location = new System.Drawing.Point(124, 348);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(100, 35);
            this.lblres.TabIndex = 4;
            this.lblres.Text = "...";
            // 
            // lblprix
            // 
            this.lblprix.AutoSize = true;
            this.lblprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprix.Location = new System.Drawing.Point(12, 355);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(77, 18);
            this.lblprix.TabIndex = 5;
            this.lblprix.Text = "Prix FINAL";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(79, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Inclure la taxe de 6.8%";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 455);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblprix);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.rbu16);
            this.Controls.Add(this.rbu14);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " Traban 2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.RadioButton rbu14;
        private System.Windows.Forms.RadioButton rbu16;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblprix;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

