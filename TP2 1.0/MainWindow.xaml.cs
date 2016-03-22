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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP2_1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Fenetre : Window
    {
        public Fenetre(Utilisateur utilisateur)
        {
            InitializeComponent();
            string nom = utilisateur.Nom;
            string ip = utilisateur.ip;
            this.listviewUtilisateurs.Items.Add(utilisateur);
        }
    }
}
