using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Entities;

namespace UnitTestProject1
{
    [TestClass]
    public class Player1
    {
        [TestMethod]
        public void EliTasRakipEliTasIseBerabere()
        {
            Player player1 = new Player(nameof(player1), new Rock());
            Player player2 = new Player(nameof(player2), new Rock());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.IsTrue(result.Draw);
            Assert.IsNull(result.Winner);
        }

        [TestMethod]
        public void EliTasRakipEliKagitIseMalup()
        {
            Player player1 = new Player(nameof(player1), new Rock());
            Player player2 = new Player(nameof(player2), new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player2, result.Winner);
        }

        [TestMethod]
        public void EliTasRakipEliMakasIseGalip()
        {
            Player player1 = new Player(nameof(player1), new Rock());
            Player player2 = new Player(nameof(player2), new Scissors());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player1, result.Winner);
        }

        [TestMethod]
        public void EliMakasRakipEliTasIseMalup()
        {
            Player player1 = new Player(nameof(player1), new Scissors());
            Player player2 = new Player(nameof(player2), new Rock());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player2, result.Winner);
        }

        [TestMethod]
        public void EliMakasRakipEliKagitIseGalip()
        {
            Player player1 = new Player(nameof(player1), new Scissors());
            Player player2 = new Player(nameof(player2), new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player1, result.Winner);
        }

        [TestMethod]
        public void EliMakasRakipEliMakasIseBerabere()
        {
            Player player1 = new Player(nameof(player1), new Scissors());
            Player player2 = new Player(nameof(player2), new Scissors());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.IsTrue(result.Draw);
            Assert.IsNull(result.Winner);
        }

        [TestMethod]
        public void EliKagitRakipEliTasIseGalip()
        {
            Player player1 = new Player(nameof(player1), new Paper());
            Player player2 = new Player(nameof(player2), new Rock());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player1, result.Winner);
        }

        [TestMethod]
        public void EliKagitRakipEliKagitIseBerabere()
        {
            Player player1 = new Player(nameof(player1), new Paper());
            Player player2 = new Player(nameof(player2), new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.IsTrue(result.Draw);
            Assert.IsNull(result.Winner);

        }

        [TestMethod]
        public void EliKagitRakipEliMakasIseMalup()
        {
            Player player1 = new Player(nameof(player1), new Paper());
            Player player2 = new Player(nameof(player2), new Scissors());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player2, result.Winner);
        }
    }
}
