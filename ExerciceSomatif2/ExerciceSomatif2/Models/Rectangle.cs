using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Rectangle : Forme
    {
        private int hauteur;
        private int longueur;

        public int Hauteur { get => hauteur; }
        public int Longueur { get => longueur; }

        public Rectangle(int hauteur, int longueur) : base(Color.Green)
        {
            this.hauteur = hauteur;
            this.longueur = longueur;
        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen pen = new Pen(Couleur);
            graphics.DrawRectangle(pen, 0, 0, longueur, hauteur);
        }

        public override string ObtenirType()
        {
            return "Rectangle";
        }
    }
}
