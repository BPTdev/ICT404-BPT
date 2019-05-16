namespace Deduction_fiscal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tcb1 = new System.Windows.Forms.TextBox();
            this.tcb2 = new System.Windows.Forms.TextBox();
            this.tcb3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenu annuel brut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coefficient familial";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.Location = new System.Drawing.Point(106, 134);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(168, 28);
            this.cb1.TabIndex = 2;
            this.cb1.Text = "Déduction jeune";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Checked = true;
            this.cb2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.Location = new System.Drawing.Point(106, 168);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(192, 28);
            this.cb2.TabIndex = 3;
            this.cb2.Text = "Déduction transport";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Checked = true;
            this.cb3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.Location = new System.Drawing.Point(106, 202);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(144, 28);
            this.cb3.TabIndex = 4;
            this.cb3.Text = "Rabais fidélité";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(307, 32);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(140, 20);
            this.tb1.TabIndex = 5;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(395, 83);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(52, 20);
            this.tb2.TabIndex = 6;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tcb1
            // 
            this.tcb1.Location = new System.Drawing.Point(395, 140);
            this.tcb1.Name = "tcb1";
            this.tcb1.Size = new System.Drawing.Size(52, 20);
            this.tcb1.TabIndex = 7;
            this.tcb1.Text = "900";
            this.tcb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tcb2
            // 
            this.tcb2.Location = new System.Drawing.Point(395, 174);
            this.tcb2.Name = "tcb2";
            this.tcb2.Size = new System.Drawing.Size(52, 20);
            this.tcb2.TabIndex = 8;
            this.tcb2.Text = "650";
            this.tcb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tcb3
            // 
            this.tcb3.Location = new System.Drawing.Point(395, 208);
            this.tcb3.Name = "tcb3";
            this.tcb3.Size = new System.Drawing.Size(52, 20);
            this.tcb3.TabIndex = 9;
            this.tcb3.Text = "0";
            this.tcb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(103, 317);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(33, 25);
            this.res.TabIndex = 11;
            this.res.Text = "...";
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(495, 358);
            this.Controls.Add(this.res);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcb3);
            this.Controls.Add(this.tcb2);
            this.Controls.Add(this.tcb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Déduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tcb1;
        private System.Windows.Forms.TextBox tcb2;
        private System.Windows.Forms.TextBox tcb3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label res;
    }
}

