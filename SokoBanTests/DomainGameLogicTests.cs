using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sokoban;
using NUnit.Framework;

namespace SokoBanTests
{
    [TestClass]
    public class DomainGameLogicTests
    {
        private Player player;
        private Box box1;
        private Box box2;

        MatrixItem hok1;
        MatrixItem hok2;
        MatrixItem hok3;

        #region Setup and tear down
        [SetUp]
        private void CreateGamestate(){
            player = new Player();
            box1 = new Box();
            box2 = new Box();
            hok1 = new MatrixItem();
            hok2 = new MatrixItem();
            hok3 = new MatrixItem();
        }
        #endregion

        #region Checking moveablility
        [TestMethod]
        public void CanMovePlayer()
        {
            player.location = hok1;

        }
        #endregion
    }
}