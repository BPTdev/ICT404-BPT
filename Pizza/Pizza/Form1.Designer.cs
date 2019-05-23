namespace Pizza
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
            this.nbtable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xfine = new System.Windows.Forms.RadioButton();
            this.fine = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.epaisse = new System.Windows.Forms.RadioButton();
            this.anchois = new System.Windows.Forms.CheckBox();
            this.capres = new System.Windows.Forms.CheckBox();
            this.jambon = new System.Windows.Forms.CheckBox();
            this.crevette = new System.Windows.Forms.CheckBox();
            this.tbocommande = new System.Windows.Forms.Label();
            this.butcommander = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nbtable
            // 
            this.nbtable.Location = new System.Drawing.Point(88, 32);
            this.nbtable.Name = "nbtable";
            this.nbtable.Size = new System.Drawing.Size(56, 20);
            this.nbtable.TabIndex = 0;
            this.nbtable.TextChanged += new System.EventHandler(this.nbtable_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // xfine
            // 
            this.xfine.AutoSize = true;
            this.xfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xfine.Location = new System.Drawing.Point(59, 107);
            this.xfine.Name = "xfine";
            this.xfine.Size = new System.Drawing.Size(88, 22);
            this.xfine.TabIndex = 2;
            this.xfine.TabStop = true;
            this.xfine.Text = "Extra-fine";
            this.xfine.UseVisualStyleBackColor = true;
            // 
            // fine
            // 
            this.fine.AutoSize = true;
            this.fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fine.Location = new System.Drawing.Point(59, 143);
            this.fine.Name = "fine";
            this.fine.Size = new System.Drawing.Size(54, 22);
            this.fine.TabIndex = 2;
            this.fine.TabStop = true;
            this.fine.Text = "Fine";
            this.fine.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normal.Location = new System.Drawing.Point(59, 180);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(75, 22);
            this.normal.TabIndex = 2;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // epaisse
            // 
            this.epaisse.AutoSize = true;
            this.epaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epaisse.Location = new System.Drawing.Point(59, 214);
            this.epaisse.Name = "epaisse";
            this.epaisse.Size = new System.Drawing.Size(79, 22);
            this.epaisse.TabIndex = 2;
            this.epaisse.TabStop = true;
            this.epaisse.Text = "Epaisse";
            this.epaisse.UseVisualStyleBackColor = true;
            // 
            // anchois
            // 
            this.anchois.AutoSize = true;
            this.anchois.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchois.Location = new System.Drawing.Point(216, 107);
            this.anchois.Name = "anchois";
            this.anchois.Size = new System.Drawing.Size(80, 22);
            this.anchois.TabIndex = 3;
            this.anchois.Text = "Anchois";
            this.anchois.UseVisualStyleBackColor = true;
            // 
            // capres
            // 
            this.capres.AutoSize = true;
            this.capres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capres.Location = new System.Drawing.Point(216, 144);
            this.capres.Name = "capres";
            this.capres.Size = new System.Drawing.Size(75, 22);
            this.capres.TabIndex = 4;
            this.capres.Text = "Câpres";
            this.capres.UseVisualStyleBackColor = true;
            // 
            // jambon
            // 
            this.jambon.AutoSize = true;
            this.jambon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jambon.Location = new System.Drawing.Point(216, 181);
            this.jambon.Name = "jambon";
            this.jambon.Size = new System.Drawing.Size(81, 22);
            this.jambon.TabIndex = 5;
            this.jambon.Text = "Jambon";
            this.jambon.UseVisualStyleBackColor = true;
            // 
            // crevette
            // 
            this.crevette.AutoSize = true;
            this.crevette.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crevette.Location = new System.Drawing.Point(216, 215);
            this.crevette.Name = "crevette";
            this.crevette.Size = new System.Drawing.Size(90, 22);
            this.crevette.TabIndex = 6;
            this.crevette.Text = "Crevettes";
            this.crevette.UseVisualStyleBackColor = true;
            // 
            // tbocommande
            // 
            this.tbocommande.AutoSize = true;
            this.tbocommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbocommande.Location = new System.Drawing.Point(50, 274);
            this.tbocommande.Name = "tbocommande";
            this.tbocommande.Size = new System.Drawing.Size(86, 18);
            this.tbocommande.TabIndex = 7;
            this.tbocommande.Text = "Commande";
            // 
            // butcommander
            // 
            this.butcommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcommander.Location = new System.Drawing.Point(216, 266);
            this.butcommander.Name = "butcommander";
            this.butcommander.Size = new System.Drawing.Size(126, 36);
            this.butcommander.TabIndex = 8;
            this.butcommander.Text = "Commander";
            this.butcommander.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 323);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 448);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.butcommander);
            this.Controls.Add(this.tbocommande);
            this.Controls.Add(this.crevette);
            this.Controls.Add(this.jambon);
            this.Controls.Add(this.capres);
            this.Controls.Add(this.anchois);
            this.Controls.Add(this.epaisse);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.fine);
            this.Controls.Add(this.xfine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbtable);
            this.Name = "Form1";
            this.Text = "Pidza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nbtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton xfine;
        private System.Windows.Forms.RadioButton fine;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton epaisse;
        private System.Windows.Forms.CheckBox anchois;
        private System.Windows.Forms.CheckBox capres;
        private System.Windows.Forms.CheckBox jambon;
        private System.Windows.Forms.CheckBox crevette;
        private System.Windows.Forms.Label tbocommande;
        private System.Windows.Forms.Button butcommander;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

