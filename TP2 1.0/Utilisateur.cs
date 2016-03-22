using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_1._0
{
    public class Utilisateur
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
    

        public string ip { get; set; }
    }
}
