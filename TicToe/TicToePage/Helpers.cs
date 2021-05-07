using OpenQA.Selenium;
using System;


namespace TicToePage
{
    public static class Helpers
    {
        public static bool IsAttributePresent(IWebElement element, String attribute)
        {
            Boolean result = false;
            try
            {
                String value = element.GetAttribute(attribute);
                if (value != null)
                {
                    result = true;
                }
            }
            catch (Exception e) { }

            return result;
        }

        
    }


}
