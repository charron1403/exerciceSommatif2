using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = ExerciceSomatif2.Models.Rectangle;

namespace ExerciceSomatif2.Controles
{
    public class Controleur
    {
        List<Forme> formes = new List<Forme>();
        int index;

        public event EventHandler<Forme>? FormeCourantChanged;

        public Controleur()
        {
            formes.Add(new Rectangle(80, 60));
            formes.Add(new Cercle(70));
            formes.Add(new RectanglePlein(60, 80));
            formes.Add(new CerclePlein(80));
            index = 0;
        }

        public Forme ChangerForme()
        {
            if (index >= formes.Count)
            {
                index = 1;
            }
            else
            {
                index++;
            }
            return formes[index -1];
        }

        public void EventAfficherForme()
        {
            Forme nouvelleForme = formes[index - 1];
            FormeCourantChanged?.Invoke(this, nouvelleForme);
        }
    }
}