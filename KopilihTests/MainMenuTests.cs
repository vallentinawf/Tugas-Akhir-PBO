using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kopilih;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopilih.Tests
{
    [TestClass()]
    public class MainMenuTests
    {
        [TestMethod()]
        public void ConclusingTest()
        {
            
            MainMenu mainMenu = new MainMenu();
            var totalEx = 60000;
            mainMenu.Conclusing(totalEx);
            Assert.AreEqual(60000, totalEx);
           
        }

    }
}