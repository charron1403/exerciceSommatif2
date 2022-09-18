using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Cercle : Forme
    {
        private int rayon;

        public int Rayon { get => rayon; }

        public Cercle(int rayon) : base(Color.Orange)
        {
            this.rayon = rayon;
        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(Couleur);
            graphics.DrawEllipse(pen, 0, 0, rayon, rayon);
        }

        public override string ObtenirType()
        {
            return "Cercle";
        }
    }
}
