using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class CerclePlein : Cercle
    {
        public CerclePlein(int rayon) : base(rayon)
        {
        }

        protected override void Dessiner(Graphics graphics)
        {
            SolidBrush solidBrush = new SolidBrush(Couleur);
            graphics.FillEllipse(solidBrush, 0, 0, Rayon, Rayon);
        }

        public override string ObtenirType()
        {
            return "Cercle Plein";
        }
    }
}
