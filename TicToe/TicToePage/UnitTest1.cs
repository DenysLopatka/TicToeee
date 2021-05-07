using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TicToePage
{
    public class Tests
    {
        private ChromeDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();

            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }

        [Test]
        public void Test1()
        {
            var ticToeGame = new RicToePage(_webDriver);
            ticToeGame.OpenPage()
                .ChangePlayers()
                .ClickTopLeft()
                .ClickTop()
                .ClickCentrLeft()
                .ClickCenrt()
                .ClickBottomLeft();

            Assert.AreEqual("1", ticToeGame.GetPlayerOneScore());
        }
    }
}