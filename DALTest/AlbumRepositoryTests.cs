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
    public class AlbumRepositoryTests
    {
        private AlbumRepository albumRepository;

        [TestInitialize()]
        public void Initialize()
        {
            TestRepository.InitDB();

            albumRepository = new AlbumRepository();
        }

        [TestMethod]
        public void TestLivreRepo_GetAll()
        {
            var albums = albumRepository.GetAll();
            // 5 album dans le jeu de données de test
            Assert.AreEqual(5, albums.Count);
            var actual = albums.Select(genre => genre.Titre).ToList();
            var expected = new List<string> { "Death Note - Tome 1", "Les archives de Lagaffe",
                "Tintin au Tibet", "Persepolis - Tome 1","Astérix le Gaulois - Astérix Tome 1" };
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}