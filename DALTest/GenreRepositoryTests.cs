using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DALTests
{
    [TestClass()]
    public class GenreRepositoryTests
    {
        private GenreRepository genreRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            genreRepository = new GenreRepository();
        }

        [TestMethod]
        public void TestLivreRepo_GetAll()
        {
            var genres = genreRepository.GetAll();
            // 8 genres dans le jeu de données de test
            Assert.AreEqual(8, genres.Count);
            var actual = genres.Select(genre => genre.Nom).ToList();
            var expected = new List<string> { "Drame", "Fantastique",
                "Polar/Thriller", "Suspense","Franco-Belge","Humour","Biographie","Aventure" };
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}