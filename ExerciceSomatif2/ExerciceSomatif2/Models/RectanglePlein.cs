using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class RectanglePlein : Rectangle
    {
        public RectanglePlein(int hauteur, int longueur) : base(hauteur, longueur)
        {
        }

        protected override void Dessiner(Graphics graphics)
        {
            SolidBrush solidBrush = new SolidBrush(Couleur);
            graphics.FillRectangle(solidBrush, 0, 0, Longueur, Hauteur);
        }

        public override string ObtenirType()
        {
            return "Rectangle Plein";
        }
    }
}
