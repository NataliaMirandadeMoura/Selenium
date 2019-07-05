using OpenQA.Selenium;

namespace Selenium
{
    public class PropertyCollection
    {

        public enum PropertyType
        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName
        }

        public static IWebDriver driver { get; set; }
     
    }

     
}
 
