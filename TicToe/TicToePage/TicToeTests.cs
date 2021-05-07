using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TicToePage
{
    public class TicToeTests
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
        public void SimpleWinAgainstAnotherPlayer()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ChangePlayers()
                .ClickTopLeft()
                .ClickTop()
                .ClickCentrLeft()
                .ClickCenrt()
                .ClickBottomLeft();            

            Assert.AreEqual("1", ticToeGame.GetPlayerOneScore());
        }

        [Test]
        public void CheckMute()
        {
            var ticToeGame = new TicToePage(_webDriver);
            ticToeGame.OpenPage()
                .MuteGame();

            var element = _webDriver.FindElement(By.XPath("//div[@class='mute']//*[2]")).Displayed; 

            
            System.Threading.Thread.Sleep(500);

            Assert.IsFalse(element);
        }
    }

    
}