using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium.Screens
{
    public class AirCoolersScreen
    {
       

        public AirCoolersScreen() {

            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "buttonCase3")]
        public IWebElement buttonAirColler { get; set; }

        [FindsBy(How = How.Id, Using = "ProcessSideExitTemperature13")]
        public IWebElement processSideExit { get; set; }

        [FindsBy(How = How.Id, Using = "AirSideInletTemperature13")]
        public IWebElement airSideInlet { get; set; }

        [FindsBy(How=How.Id, Using = "AirSideExitTemperature13")]
        public IWebElement airSideExit { get; set; }

        [FindsBy(How = How.Id, Using = "AirSideExitFouling13")]
        public IWebElement airSideFouling { get; set; }


        [FindsBy(How = How.Id, Using = "pressureSpecifications-link")]
        public IWebElement pressureSpecification { get; set; }

        [FindsBy(How = How.Id, Using = "tubeExitPressure13")]
        public IWebElement TubeExitPressure1 { get; set; }






        public void FillAirCoolerCase(AirCoolerData airCoolerData)
        {
            Thread.Sleep(2500);
            buttonAirColler.Click();

            Thread.Sleep(3500);
            processSideExit.SendKeys(airCoolerData.ProcessSideExiTemperature);
            airSideInlet.SendKeys(airCoolerData.AirSideInletTemperature);
            airSideExit.SendKeys(airCoolerData.AirSideExitTemperature);
            airSideFouling.SendKeys(airCoolerData.AirSideFouling);

            Thread.Sleep(3000);

            pressureSpecification.Click();

            Thread.Sleep(3000);

            TubeExitPressure1.SendKeys(airCoolerData.TubeExitPressure);
            
        }

        
               
        

       



    }

   
}

