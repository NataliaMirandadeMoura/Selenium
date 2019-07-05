using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using Selenium.Data;
using OpenQA.Selenium.Support.UI;
using System;
using Selenium.Wait;

namespace Selenium.Screens
{
    public class KettleReboilerScreen
    {
        public KettleReboilerScreen()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        


        #region Atributos

        [FindsBy(How = How.Id, Using = "totalbypass1")]
        public IWebElement totalByPass { get; set; }


        [FindsBy(How = How.Id, Using = "shellTemperature12")]
        public IWebElement shellExitTemperature { get; set; }


        [FindsBy(How = How.Id, Using = "shell_temperature12")]
        public IWebElement shellExit { get; set; }

        [FindsBy(How = How.Id, Using = "tube_temperature12")]
        public IWebElement tubeExitTemperature { get; set; }

        [FindsBy(How = How.Id, Using = " tube_temperature_12")]
        public IWebElement tubeExit { get; set; }

        [FindsBy(How=How.Id, Using = "pressureSpecifications-link")]
        public IWebElement pressureSpecification { get; set; }

        [FindsBy(How = How.Id, Using = "shellpressure12")]
        public IWebElement shellSideExitPressure { get; set; }

        [FindsBy(How = How.Id, Using = "tube_pressure12")]
        public IWebElement tubeSideExitPressure { get; set; }

        [FindsBy(How = How.Id, Using = "buttonCase2")]
        public IWebElement ButtonCase2 { get; set; }


        #endregion
        
        public void FillKettleReboiler(KettleReboilerData kettleReboilerData)
        {

            ExplictWait.Explict(PropertyCollection.driver, "buttonCase2");
            ButtonCase2.Click();

            ExplictWait.Explict(PropertyCollection.driver, "shellTemperature12");
            shellExitTemperature.SendKeys(kettleReboilerData.ShellExitTemperature);

            tubeExitTemperature.SendKeys(kettleReboilerData.TubeExitTemperature);
            Thread.Sleep(2000);

            pressureSpecification.Click();

            ExplictWait.Explict(PropertyCollection.driver, "tube_pressure12");
            Thread.Sleep(2500);
            tubeSideExitPressure.SendKeys(kettleReboilerData.TubeSideExitPressure);

            
        }
    }
}
