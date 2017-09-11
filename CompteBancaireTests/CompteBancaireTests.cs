using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire.Tests
{
    [TestClass()]
    public class CompteBancaireTests
    {
        CompteBancaire cptValentin;
        [TestInitialize]
        public void init()
        {
            cptValentin = new CompteBancaire();
            cptValentin.numero = "123456";
            cptValentin.solde = 1230.50;
            cptValentin.titulaire = "Valentin";
        }

        [TestMethod()]
        public void Crediter_MontantOK()
        {
            //prepare donnees
            double montantACrediter = 100.00;
            double montantAttendu = 1330.50;

            //exécution dela méthode
            cptValentin.Crediter(montantACrediter);
            double montantCalcule = cptValentin.solde;

            //test
            Assert.AreEqual(montantAttendu, montantCalcule);
              
        }

        [TestMethod()]
        public void Debiter_montantOK()
        {
            //Préparation des données
            double montantAttendu = 1130.50;

            double montantADebiter = 100;

            //Exécution du code à tester
            cptValentin.Debiter(montantADebiter);
            double montantCalcule = cptValentin.solde;

            //Test
            Assert.AreEqual(montantAttendu, montantCalcule);
        }
    }
}