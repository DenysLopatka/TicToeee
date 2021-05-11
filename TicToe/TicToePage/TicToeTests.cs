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

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
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
            var result = ticToeGame.IsMuted();             
            
            Assert.IsTrue(result);
        }

        [Test]
        public void IsLeftTopWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickTopLeft();
            var result = ticToeGame.IsTopLeftFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsTopWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickTop();
            var result = ticToeGame.IsTopFilled();

            Assert.IsTrue(result);
        }
        [Test]
        public void IsRightTopWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickTopRight();
            var result = ticToeGame.IsTopRightFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsCenterLeftWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickCentrLeft();
            var result = ticToeGame.IsCenterLeftFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsCenterWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickCenrt();
            var result = ticToeGame.IsCenterFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsCenterRightWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickCentrRight();
            var result = ticToeGame.IsCenterRightFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsBottomLeftWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickBottomLeft();
            var result = ticToeGame.IsBottomLeftFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsBottomWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickBottom();
            var result = ticToeGame.IsBottomFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void IsBottomRightWorks()
        {
            var ticToeGame = new TicToePage(_webDriver);

            ticToeGame.OpenPage()
                .ClickBottomRight();
            var result = ticToeGame.IsBottomRightFilled();

            Assert.IsTrue(result);
        }

        [Test]
        public void CheckComputerPlayer()
        {
            var ticToeGame = new TicToePage(_webDriver);
            ticToeGame.OpenPage();
            
            while (!Helpers.IsAllSqauersFilled(_webDriver))
            {
                if (!ticToeGame.IsTopLeftFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickTopLeft();

                    
                }

                else if (!ticToeGame.IsTopFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickTop();
                    
                }
                else if (!ticToeGame.IsTopRightFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickTopRight();
                    
                }
                else if (!ticToeGame.IsCenterLeftFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickCentrLeft();
                    
                }
                else if (!ticToeGame.IsCenterFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickCenrt();
                    
                }
                else if (!ticToeGame.IsCenterRightFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickCentrRight();
                    
                }
                else if (!ticToeGame.IsBottomLeftFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickBottomLeft();
                    
                }
                else if (!ticToeGame.IsBottomFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }
                    
                    ticToeGame.ClickBottom();
                    
                }
                else if (!ticToeGame.IsBottomRightFilled())
                {
                    System.Threading.Thread.Sleep(1000);
                    if (ticToeGame.IsRestartDisplated())
                    {
                        break;
                    }                    
                    ticToeGame.ClickBottomRight();
                    
                }    
            }

            if (ticToeGame.GetPlayerOneScoreVSComputer() == "1" | ticToeGame.GetPlayerTwoScoreVSComputer() == "1")
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}