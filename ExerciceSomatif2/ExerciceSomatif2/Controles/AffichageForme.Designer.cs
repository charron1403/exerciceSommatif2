namespace ExerciceSomatif2.Controles
{
    partial class AffichageForme
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picboxForme = new System.Windows.Forms.PictureBox();
            this.txtTypeForme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForme)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxForme
            // 
            this.picboxForme.Location = new System.Drawing.Point(15, 15);
            this.picboxForme.Name = "picboxForme";
            this.picboxForme.Size = new System.Drawing.Size(238, 215);
            this.picboxForme.TabIndex = 0;
            this.picboxForme.TabStop = false;
            // 
            // txtTypeForme
            // 
            this.txtTypeForme.AutoSize = true;
            this.txtTypeForme.Location = new System.Drawing.Point(65, 235);
            this.txtTypeForme.Name = "txtTypeForme";
            this.txtTypeForme.Size = new System.Drawing.Size(0, 15);
            this.txtTypeForme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forme:";
            // 
            // AffichageForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeForme);
            this.Controls.Add(this.picboxForme);
            this.Name = "AffichageForme";
            this.Size = new System.Drawing.Size(268, 262);
            ((System.ComponentModel.ISupportInitialize)(this.picboxForme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picboxForme;
        private Label txtTypeForme;
        private Label label1;
    }
}
