using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BalaramanpillaiKalan_TP3
{

    internal class Joueur
    {
        

        public string _name { get; set; }

        public Color _couleur { get; set; }

        public int _pointage { get; set; }

        public Joueur() {}
        public Joueur(string name, Color couleur, int pointage)
        {
            _name = name;
            _couleur = couleur;
            _pointage = pointage;
        }
        public override string ToString()
        {
            return _name + ">"  + _pointage;
        }
    }

   
}
