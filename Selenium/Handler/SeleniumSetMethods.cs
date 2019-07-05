using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public static class SeleniumSetMethods
    {

        //EnterText

        public static void EnterText(this IWebElement element, string value)

        {
            element.SendKeys(value);
        }

        //Click into a button, Checkbox, option, etc

        public static void Click( this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        { 
           new SelectElement((element)).SelectByText(value);
          
        }

        
}
    }

