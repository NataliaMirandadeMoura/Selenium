using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium.Data;
using Selenium.Screens;
using System;
using System.Collections.Generic;
using System.Threading;
using static Selenium.PropertyCollection;
using Selenium.Scenarios;

namespace Selenium.Data
{
    public class AirCoolerData
    {
       



    [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            //Navigate to Execute automation 
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("localhost:56105/");
            Console.WriteLine("Opened URL");
        }

        [Test]

        public void FillAirCooler()
        {

            GeneralNetworkData generalNetworkData = new GeneralNetworkData();
            generalNetworkData.fillGeneralNetworkData(generalNetworkData);

            Thread.Sleep(4000);

            NewCaseData newCaseData = new NewCaseData();
            newCaseData.FillNewCase(newCaseData);

            Thread.Sleep(4000);

            ShellAndTubeData shellAndTubeData = new ShellAndTubeData();
            shellAndTubeData.FillShellAndTube(shellAndTubeData);

            Thread.Sleep(4000);

            KettleReboilerData kettleReboilerData = new KettleReboilerData();
            kettleReboilerData.FillKettleReboiler(kettleReboilerData);

            Thread.Sleep(4000);

            AirCoolerData airCoolerData = new AirCoolerData();
            airCoolerData.FillAirCoolerCase(airCoolerData);

        }

        [TearDown]
        public void CleanUp()
        {
            // PropertyCollection.driver.Close();
            Console.WriteLine("Closed the browser " + DateTime.Now);
            driver.Close();
        }



    }
}
