using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Entities;

namespace UnitTestProject1
{
    [TestClass]
    public class when_testing_game_result
    {
        [TestMethod]
        public void rock_draws_against_rock()
        {
            Player player1 = new Player(nameof(player1), new Rock());
            Player player2 = new Player(nameof(player2), new Rock());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.IsTrue(result.Draw);
            Assert.IsNull(result.Winner);
        }

        [TestMethod]
        public void rock_loses_against_paper()
        {
            Player player1 = new Player(nameof(player1), new Rock());
            Player player2 = new Player(nameof(player2), new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player2, result.Winner);
        }

        [TestMethod]
        public void rock_wins_against_scissors()
        {
            Player player1 = new Player(nameof(player1), new Rock());
            Player player2 = new Player(nameof(player2), new Scissors());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player1, result.Winner);
        }

        [TestMethod]
        public void scissors_lose_against_rock()
        {
            Player player1 = new Player(nameof(player1), new Scissors());
            Player player2 = new Player(nameof(player2), new Rock());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player2, result.Winner);
        }

        [TestMethod]
        public void scissors_win_against_paper()
        {
            Player player1 = new Player(nameof(player1), new Scissors());
            Player player2 = new Player(nameof(player2), new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player1, result.Winner);
        }

        [TestMethod]
        public void scissors_draw_against_scissors()
        {
            Player player1 = new Player(nameof(player1), new Scissors());
            Player player2 = new Player(nameof(player2), new Scissors());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.IsTrue(result.Draw);
            Assert.IsNull(result.Winner);
        }

        [TestMethod]
        public void paper_wins_against_rock()
        {
            Player player1 = new Player(nameof(player1), new Paper());
            Player player2 = new Player(nameof(player2), new Rock());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player1, result.Winner);
        }

        [TestMethod]
        public void paper_draws_against_paper()
        {
            Player player1 = new Player(nameof(player1), new Paper());
            Player player2 = new Player(nameof(player2), new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.IsTrue(result.Draw);
            Assert.IsNull(result.Winner);

        }

        [TestMethod]
        public void paper_loses_against_scissors()
        {
            Player player1 = new Player(nameof(player1), new Paper());
            Player player2 = new Player(nameof(player2), new Scissors());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player2, result.Winner);
        }
    }
}
