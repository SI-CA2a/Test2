using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class CompteBancaire
    {
        public string numero;
        public string titulaire;
        public double solde;

        public void Crediter(double montant)
        {
            solde = solde + montant;
            //autre écriture possible
            //solde += montant;
        }
        public void Debiter(double montant)
        {
            solde = solde - montant;
            //autre écriture possible
            //solde -= montant;
        }

    }
}
