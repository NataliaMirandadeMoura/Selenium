using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Scenarios;
using Selenium.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium.Data
{
    public class KettleReboilerData : KettleReboilerScreen
    {


        public string ShellExitTemperature { get; set; }
        public string TubeExitTemperature { get; set; }
        public string ShellExit { get; set; }
        public string TubeExit { get; set; }

        public string ShellSideExitPressure { get; set; }
        public string TubeSideExitPressure { get; set; }

        public KettleReboilerData()
        {
            ShellExitTemperature = "20.0";
            TubeExitTemperature = "30";
            ShellExit = "40";
            TubeExit = "10";
            TubeSideExitPressure = "10.0";


        }

        public static void Explict(IWebDriver driver, string text)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.Id(text)));
        }



    }



}
