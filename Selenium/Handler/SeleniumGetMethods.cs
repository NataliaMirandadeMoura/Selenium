using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace Selenium
{
    public class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
           
        }

        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
