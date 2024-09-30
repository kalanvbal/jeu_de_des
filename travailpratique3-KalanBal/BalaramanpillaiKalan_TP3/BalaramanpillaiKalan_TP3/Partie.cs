using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BalaramanpillaiKalan_TP3
{
    internal class Partie
    {
        

        public int _nbJoueur { get; set; }
        public Thread[] _tabDes { get; set; } = new Thread[2];
        public Joueur[] _tabJoueur { get; set; } = new Joueur[2];
        public int _tour { get; set; }

        public Partie() { }

        public Partie(int nbJoueur, Thread[] tabDes, Joueur[] tabJoueur, int tour)
        {
            _nbJoueur = nbJoueur;
            _tabDes = tabDes;
            _tabJoueur = tabJoueur;
            _tour = tour;
        }

    }
}
