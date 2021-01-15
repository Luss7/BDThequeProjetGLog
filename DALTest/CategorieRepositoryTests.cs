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
    public class CategorieRepositoryTests
    {
        private CategorieRepository categorieRepository;
        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            categorieRepository = new CategorieRepository();
        }

        [TestMethod]
        public void TestLivreRepo_GetAll()
        {
            var categories = categorieRepository.GetAll();
            // 2 catégories dans le jeu de données de test
            Assert.AreEqual(2, categories.Count);
            var actual = categories.Select(categorie => categorie.Nom ).ToList();
            var expected = new List<string> { "Manga", "BD"};
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}