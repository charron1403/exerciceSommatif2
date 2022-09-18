using ExerciceSomatif2.Controles;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        Controleur controleur;
        public FormAffichageForme()
        {
            InitializeComponent();
            controleur = new Controleur();
            controleur.FormeCourantChanged += Controleur_FormeCourantChanged; ;
        }

        private void Controleur_FormeCourantChanged(object? sender, Models.Forme e)
        {
            affichageForme1.MettreAffichageAJour();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            affichageForme1.FormeCourante = controleur.ChangerForme();
            controleur.EventAfficherForme();
        }
    }
}