using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ChildrenInCircle.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
         public void ChildrenGameCheckCorrectness()
        {
            var currentchildren = new Children(5, 3);
            var winner = currentchildren.FindWinner();

            Assert.AreEqual(winner, 4);
        }
        [TestMethod]
        public void ChildrenGame_nlarge()
        {
            try
            {
                var currentchildren = new Children(1000, 3);
                var winner = currentchildren.FindWinner();
                Console.WriteLine(winner);
            }

            catch (Exception exception)
            {
                Assert.Fail("Got Exception: " + exception.Message);
            }




        }
        [TestMethod]
        public void ChildrenGame_klargerthanN()
        {
             var currentchildren = new Children(3, 5);
                var winner = currentchildren.FindWinner();
                Console.WriteLine(winner);
                Assert.AreEqual(winner, 1);
            

        }
    }
}
