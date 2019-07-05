using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium.Data;
using Selenium.Screens;
using System;
using System.Collections.Generic;
using System.Threading;
using static Selenium.PropertyCollection;
using Selenium.Scenarios;


namespace Selenium.Scenarios
{
    public class FillGeneralData
    {
        static void Main(string[] args)
        {
        }







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
        public void FillAllFieldsGeneralData()
        {

            GeneralNetworkData generalNetworkData = new GeneralNetworkData();

            generalNetworkData.fillGeneralNetworkData(generalNetworkData);

        }

        [Test]
        public void FillFieldNetworkName()
        {
            GeneralNetworkData generalNetworkData = new GeneralNetworkData();
            generalNetworkData.fillNetworkName(generalNetworkData);
            
        }

        [Test]
         
        public void FillFieldNetworkNameAndCustomer()
        {
            GeneralNetworkData generalNetworkData = new GeneralNetworkData();
            generalNetworkData.fillNetworkNameandCustomer(generalNetworkData);
        }

        [Test]

        public void FillNetworkNameAndClickCancel()
        {
            GeneralNetworkData generalNetworkData = new GeneralNetworkData();
            generalNetworkData.FillNetworkNameAndCancel(generalNetworkData);
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

