﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedTellerMachine.Controllers;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1ReturnsAboutView()
        {
            Console.WriteLine("AAAAA");
            System.Diagnostics.Debug.WriteLine("BBBBB");
            Console.Out.WriteLine("CCCCC");

            var homeController = new HomeController();
            var result = homeController.Foo() as ViewResult;
            Assert.AreEqual("About", result.ViewName);
        }

        [TestMethod]
        public void ContactFormSaysThanks()
        {
            var homeController = new HomeController();
            var result = homeController.Contact("I love your bank.") as ViewResult;
            Assert.IsNotNull(result.ViewBag.TheMessage);
        }
    }
}
