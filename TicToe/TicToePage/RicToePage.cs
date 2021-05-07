using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;


namespace TicToePage
{
    class RicToePage
    {
        public IWebDriver _webDriver;
        private static readonly By _twoPlayersButton = By.XPath("//div[@class='swap']");

        //All Cells:
        //First row:
        private static readonly By _topLeft = By.XPath("//div[@class='square top left']");
        private static readonly By _top = By.XPath("//div[@class='square top']");
        private static readonly By _topRight = By.XPath("//div[@class='square top right']");
        //Second row:
        private static readonly By _centrLeft = By.XPath("//div[@class='square left']");
        private static readonly By _centr = By.XPath("//div[@class='square']");
        private static readonly By _centrRight = By.XPath("//div[@class='square right']");
        //Third row:
        private static readonly By _bottomLeft = By.XPath("//div[@class='square bottom left']");
        private static readonly By _bottom = By.XPath("//div[@class='square bottom']");
        private static readonly By _bottomRight = By.XPath("//div[@class='square bottom right']");
        //Scores:
        private static readonly By _playerOneScore = By.XPath("//span[@class='score appear']");
        private static readonly By _playerTwoScore = By.XPath("//span[@class='score']");

        private static readonly By _resetGame = By.XPath("//div[@class='restart']");

        public RicToePage(IWebDriver driver)
        {
            this._webDriver = driver;
        }

        public RicToePage OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public RicToePage ChangePlayers()
        {
            _webDriver.FindElement(_twoPlayersButton).Click();
            return this;
        }
        //Click first row:
        public RicToePage ClickTopLeft()
        {
            _webDriver.FindElement(_topLeft).Click();
            return this;
        }

        public RicToePage ClickTop()
        {
            _webDriver.FindElement(_top).Click();
            return this;
        }

        public RicToePage ClickTopRight()
        {
            _webDriver.FindElement(_topRight).Click();
            return this;
        }
        //Click second row:
        public RicToePage ClickCentrLeft()
        {
            _webDriver.FindElement(_centrLeft).Click();
            return this;
        }
        public RicToePage ClickCenrt()
        {
            _webDriver.FindElement(_centr).Click();
            return this;
        }
        public RicToePage ClickCentrRight()
        {
            _webDriver.FindElement(_centrRight).Click();
            return this;
        }
        //Click Third Row:
        public RicToePage ClickBottomLeft()
        {
            _webDriver.FindElement(_bottomLeft).Click();
            return this;
        }
        public RicToePage ClickBottom()
        {
            _webDriver.FindElement(_bottom).Click();
            return this;
        }
        public RicToePage ClickBottomRight()
        {
            _webDriver.FindElement(_bottomRight).Click();
            return this;
        }
        //Get Player Scores
        public string GetPlayerOneScore()
        {
            var score = _webDriver.FindElement(_playerOneScore).Text;
            return score;
        }

        public string GetPlayerTwoScore()
        {
            var score = _webDriver.FindElement(_playerTwoScore).Text;
            return score;
        }
        //Restart Game:
        public RicToePage RestartGame()
        {
            _webDriver.FindElement(_resetGame).Click();
            return this;
        }
    }

}
