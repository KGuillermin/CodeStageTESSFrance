using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptest.Samples
{
    public class Ryze : Personne
    {
        public string Classe { get; set; } = "Mage";


        public Ryze(string nom, string prenom, short age) : base(nom, prenom, age)
        {
            
        }
    }
}
