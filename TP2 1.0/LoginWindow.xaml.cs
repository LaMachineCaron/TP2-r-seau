using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TP2_1._0
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void boutonConnexion_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Nom = textboxUtilisateur.Text;
            utilisateur.ip = "0.0.0.0";
            Fenetre fenetre = new Fenetre(utilisateur);
            fenetre.Show();
            this.Close();
        }
    }
}
