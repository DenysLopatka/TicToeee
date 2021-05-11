using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;


namespace TicToePage
{
    class TicToePage
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

        //ScoresAgainstComputer:        
        private static readonly By _playerOneScoreVSComputer = By.XPath("//p[@class = 'player1']/child::span[starts-with(@class, 'score')]");
        private static readonly By _playerTwoScoreVSComputer = By.XPath("//p[@class = 'player2']/child::span[starts-with(@class, 'score')]");
        //Restart Game:
        private static readonly By _resetGame = By.XPath("//div[@class='restart']");
        //Mute:
        private static readonly By _muteButtonLocator = By.XPath("//div[@class='mute']");
        private static readonly By _checkMutedLocator = By.XPath("//div[@class='mute']//*[2]");
        //FirstRowFilled
        private static readonly By _topLeftFilled = By.XPath("//div[@class = 'square top left']/div");
        private static readonly By _topFilled = By.XPath("//div[@class = 'square top']/div");
        private static readonly By _topRightFilled = By.XPath("//div[@class = 'square top right']/div");
        //SecondRowFilled
        private static readonly By _centerLeftFilled= By.XPath("//div[@class = 'square left']/div");
        private static readonly By _centerFilled = By.XPath("//div[@class = 'square']/div");
        private static readonly By _centerRightFilled = By.XPath("//div[@class = 'square right']/div");
        //ThirdRowFilled
        private static readonly By _bottomLeftFilled = By.XPath("//div[@class = 'square bottom left']/div");
        private static readonly By _bottomFilled = By.XPath("//div[@class = 'square bottom']/div");
        private static readonly By _bottomRightFilled = By.XPath("//div[@class = 'square bottom right']/div");




        public TicToePage(IWebDriver driver)
        {
            _webDriver = driver;
        }

        public TicToePage OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public TicToePage ChangePlayers()
        {
            _webDriver.FindElement(_twoPlayersButton).Click();
            return this;
        }

        //Click first row:
        public TicToePage ClickTopLeft()
        {
            _webDriver.FindElement(_topLeft).Click();
            return this;
        }

        public TicToePage ClickTop()
        {
            _webDriver.FindElement(_top).Click();
            return this;
        }

        public TicToePage ClickTopRight()
        {
            _webDriver.FindElement(_topRight).Click();
            return this;
        }

        //Click second row:
        public TicToePage ClickCentrLeft()
        {
            _webDriver.FindElement(_centrLeft).Click();
            return this;
        }

        public TicToePage ClickCenrt()
        {
            _webDriver.FindElement(_centr).Click();
            return this;
        }

        public TicToePage ClickCentrRight()
        {
            _webDriver.FindElement(_centrRight).Click();
            return this;
        }

        //Click Third Row:
        public TicToePage ClickBottomLeft()
        {
            _webDriver.FindElement(_bottomLeft).Click();
            return this;
        }
        public TicToePage ClickBottom()
        {
            _webDriver.FindElement(_bottom).Click();
            return this;
        }
        public TicToePage ClickBottomRight()
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

        public string GetPlayerOneScoreVSComputer()
        {
            var score = _webDriver.FindElement(_playerOneScoreVSComputer).Text;
            return score;
        }

        public string GetPlayerTwoScoreVSComputer()
        {
            var score = _webDriver.FindElement(_playerTwoScoreVSComputer).Text;
            return score;
        }


        //Restart Game:
        public TicToePage RestartGame()
        {
            _webDriver.FindElement(_resetGame).Click();
            return this;
        }

        public bool IsRestartDisplated()
        {
            var result = _webDriver.FindElement(_resetGame).Displayed;
            return result;
        }

        //MuteGame:
        public TicToePage MuteGame()
        {
            _webDriver.FindElement(_muteButtonLocator).Click();
            return this;
        }

        public bool IsMuted()
        {
            var result = _webDriver.FindElement(_checkMutedLocator).Displayed;
            return !result;
        }

        //FirstRowFilled:
        public bool IsTopLeftFilled()
        {
            var result = _webDriver.FindElement(_topLeftFilled).Displayed;
            return result;
        }

        public bool IsTopFilled()
        {
            var result = _webDriver.FindElement(_topFilled).Displayed;
            return result;
        }

        public bool IsTopRightFilled()
        {
            var result = _webDriver.FindElement(_topRightFilled).Displayed;
            return result;
        }

        //SecondRowFilled:
        public bool IsCenterLeftFilled()
        {
            var result = _webDriver.FindElement(_centerLeftFilled).Displayed;
            return result;
        }
        public bool IsCenterFilled()
        {
            var result = _webDriver.FindElement(_centerFilled).Displayed;
            return result;
        }
        public bool IsCenterRightFilled()
        {
            var result = _webDriver.FindElement(_centerRightFilled).Displayed;
            return result;
        }

        //ThirdRowFilled:
        public bool IsBottomLeftFilled()
        {
            var result = _webDriver.FindElement(_bottomLeftFilled).Displayed;
            return result;
        }
        public bool IsBottomFilled()
        {
            var result = _webDriver.FindElement(_bottomFilled).Displayed;
            return result;
        }
        public bool IsBottomRightFilled()
        {
            var result = _webDriver.FindElement(_bottomRightFilled).Displayed;
            return result;
        }

        



    }

}
