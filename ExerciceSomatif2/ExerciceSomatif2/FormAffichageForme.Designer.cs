namespace ExerciceSomatif2
{
    partial class FormAffichageForme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.affichageForme1 = new ExerciceSomatif2.Controles.AffichageForme();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // affichageForme1
            // 
            this.affichageForme1.FormeCourante = null;
            this.affichageForme1.Location = new System.Drawing.Point(12, 12);
            this.affichageForme1.Name = "affichageForme1";
            this.affichageForme1.Size = new System.Drawing.Size(268, 262);
            this.affichageForme1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Changer de forme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAffichageForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.affichageForme1);
            this.Name = "FormAffichageForme";
            this.Text = "Formes";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.AffichageForme affichageForme1;
        private Button button1;
    }
}