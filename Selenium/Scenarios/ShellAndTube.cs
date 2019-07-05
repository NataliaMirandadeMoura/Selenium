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
    public class ShellAndTube
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
            public void FillAllFieldsShellAndTube()
            {
             GeneralNetworkData generalNetwork = new GeneralNetworkData();

             Thread.Sleep(5000);
             generalNetwork.fillGeneralNetworkData(generalNetwork);

             Thread.Sleep(5000);
             NewCaseData newCaseData = new NewCaseData();
             newCaseData.FillNewCase(newCaseData);
             
             ShellAndTubeData shellAndTubeData = new ShellAndTubeData();
             Thread.Sleep(5000);
             shellAndTubeData.FillShellAndTube(shellAndTubeData);
            

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



