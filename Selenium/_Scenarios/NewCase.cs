using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Selenium.Data.NewCaseData;
using static Selenium.PropertyCollection;

namespace Selenium.Scenarios
{
    public class NewCase
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
        public void CreateACase()
        {
            GeneralNetworkData generalNetworkData = new GeneralNetworkData();
            generalNetworkData.fillGeneralNetworkData(generalNetworkData);

            Thread.Sleep(2500);
            NewCaseData newCaseData = new NewCaseData();
            
            
            newCaseData.FillNewCase(newCaseData);


        }

        [Test]
        public void CreateACaseWithoutFillDateField() {

            GeneralNetworkData generalNetworkData = new GeneralNetworkData();
            generalNetworkData.fillGeneralNetworkData(generalNetworkData);

            Thread.Sleep(2500);
            NewCaseData newCaseData = new NewCaseData();


            newCaseData.NotFillDateField(newCaseData);
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



