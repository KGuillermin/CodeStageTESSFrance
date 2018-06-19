using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptest.Samples
{
    public abstract class Personne
    {
        public string Nom { get; set; }
        public string  Prenom { get; set; }
        public short Age { get; set; }

        #region Constructeur
        public Personne()
        {

        }

        public Personne(string nom, string prenom, short age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }
        #endregion

    }
}
