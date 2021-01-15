using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using DALTests;
using System.Linq;

namespace DAL.Tests
{
    [TestClass()]
    public class UtilisateurRepositoryTests
    {
        private UtilisateurRepository utilisateurRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            utilisateurRepository = new UtilisateurRepository();
        }

        [TestMethod]
        public void TestLivreRepo_GetAll()
        {
            var utilisateurs = utilisateurRepository.GetAll();
            // 3 utilisateurs dans le jeu de données de test
            Assert.AreEqual(8, utilisateurs.Count);
            var actual = utilisateurs.Select(genre => genre.Login).ToList();
            var expected = new List<string> { "luludu31", "bpesquet",
                "dbrognart" };
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}