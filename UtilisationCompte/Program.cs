using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire.CompteBancaire cpt = new CompteBancaire.CompteBancaire();
            cpt.numero = "234567";
            cpt.solde = 789.00;
            cpt.titulaire = "Melvyn";

            cpt.Debiter(5);
            Console.WriteLine("Voici mon nouveau solde " + cpt.solde);
            Console.Read();
        }
    }
}
