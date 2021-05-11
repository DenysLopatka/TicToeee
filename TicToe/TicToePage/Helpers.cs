using OpenQA.Selenium;
using System;


namespace TicToePage
{
    public static class Helpers
    {
        public static IWebDriver _webDriver;

        public static bool IsAllSqauersFilled(IWebDriver driver)
        {
            _webDriver = driver;
            var ticToeGame = new TicToePage(driver);
            
            var counter = 0;

            if (ticToeGame.IsTopLeftFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsTopFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsTopRightFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsCenterLeftFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsCenterRightFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsCenterLeftFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsBottomLeftFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsBottomFilled())
            {
                counter += 1;
            }

            if (ticToeGame.IsBottomRightFilled())
            {
                counter += 1;
            }

            if (counter == 9)
            {
                return true;
            }
            return false;
        }    
    }
}
