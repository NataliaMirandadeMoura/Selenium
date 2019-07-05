using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium.Data;
using Selenium.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Selenium.PropertyCollection;

namespace Selenium.Scenarios
{
    public class KettleReboiler
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

        public void FillKettleReboiler()
        {
            GeneralNetworkData generalNetworkData = new GeneralNetworkData();
            generalNetworkData.fillGeneralNetworkData(generalNetworkData);

            Thread.Sleep(4000);

            NewCaseData newCaseData = new NewCaseData();
            newCaseData.FillNewCase(newCaseData);

            Thread.Sleep(4000);
            ShellAndTubeData shellAndTubeData = new ShellAndTubeData();
            shellAndTubeData.FillShellAndTube(shellAndTubeData);

            
            KettleReboilerData kettleReboiler = new KettleReboilerData();
            kettleReboiler.FillKettleReboiler(kettleReboiler);

            
            
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
    

