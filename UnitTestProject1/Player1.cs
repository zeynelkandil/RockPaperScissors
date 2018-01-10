using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Entities;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Player1
    {
        [TestMethod]
        public void EliTasRakipEliTasIseBerabere()
        {
            var player1 = new Player();
            player1.Hand = new Rock();

            var player2 = new Player();
            player2.Hand = new Rock();

            Assert.AreEqual(player1.Beat(player2), false);
            Assert.AreEqual(player2.Beat(player1), false);
        }

        [TestMethod]
        public void EliTasRakipEliKagitIseMalup()
        {
            var player1 = new Player();
            player1.Hand = new Rock();

            var player2 = new Player();
            player2.Hand = new Paper();

            Assert.AreEqual(player1.Beat(player2), false);
            Assert.AreEqual(player2.Beat(player1), true);
        }

        [TestMethod]
        public void EliTasRakipEliMakasIseGalip()
        {
            var player1 = new Player();
            player1.Hand = new Rock();

            var player2 = new Player();
            player2.Hand = new Scissors();

            Assert.AreEqual(player1.Beat(player2), true);
            Assert.AreEqual(player2.Beat(player1), false);
        }

        [TestMethod]
        public void EliMakasRakipEliTasIseMalup()
        {
            var player1 = new Player();
            player1.Hand = new Scissors();

            var player2 = new Player();
            player2.Hand = new Rock();

            Assert.AreEqual(player1.Beat(player2), false);
            Assert.AreEqual(player2.Beat(player1), true);
        }

        [TestMethod]
        public void EliMakasRakipEliKagitIseGalip()
        {
            var player1 = new Player();
            player1.Hand = new Scissors();

            var player2 = new Player();
            player2.Hand = new Paper();

            Assert.AreEqual(player1.Beat(player2), true);
            Assert.AreEqual(player2.Beat(player1), false);
        }

        [TestMethod]
        public void EliMakasRakipEliMakasIseBerabere()
        {
            var player1 = new Player();
            player1.Hand = new Scissors();

            var player2 = new Player();
            player2.Hand = new Scissors();

            Assert.AreEqual(player1.Beat(player2), false);
            Assert.AreEqual(player2.Beat(player1), false);
        }

        [TestMethod]
        public void EliKagitRakipEliTasIseGalip()
        {
            var player1 = new Player();
            player1.Hand = new Paper();

            var player2 = new Player();
            player2.Hand = new Rock();

            Assert.AreEqual(player1.Beat(player2), true);
            Assert.AreEqual(player2.Beat(player1), false);
        }

        [TestMethod]
        public void EliKagitRakipEliKagitIseBerabere()
        {
            var player1 = new Player();
            player1.Hand = new Paper();

            var player2 = new Player();
            player2.Hand = new Paper();

            Assert.AreEqual(player1.Beat(player2), false);
            Assert.AreEqual(player2.Beat(player1), false);
        }

        [TestMethod]
        public void EliKagitRakipEliMakasIseMalup()
        {
            var player1 = new Player();
            player1.Hand = new Paper();

            var player2 = new Player();
            player2.Hand = new Scissors();

            Assert.AreEqual(player1.Beat(player2), false);
            Assert.AreEqual(player2.Beat(player1), true);
        }
    }
}
