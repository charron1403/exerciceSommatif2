using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceSomatif2.Controles
{
    public partial class AffichageForme : UserControl
    {

        private Forme? formeCourante;

        public AffichageForme()
        {
            InitializeComponent();
        }

        public void MettreAffichageAJour(Forme forme)
        {
            formeCourante = forme;

            if (formeCourante != null)
            {
                picboxForme.Image = formeCourante.Dessiner();
                txtTypeForme.Text = formeCourante.ObtenirType();
            }
        }
    }
}
