using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OdeToFood.Controllers;

namespace OdeToFood.Tests
{
    //[TestClass]
    [TestFixture]
    public class HomeControllerIndexTests
    {
        [Test]
        public void Puts_Message_In_ViewBag()
        {
            var controller = new HomeController();
            var result = controller.Index();
            //NUnit.Framework.Assert.IsNotNull(result.ViewBag.Message);



        }
        public void TestMethod1()
        {
        }
    }
}
