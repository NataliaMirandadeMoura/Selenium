using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using Selenium.Data;
using NUnit.Framework;
using System;

namespace Selenium.Data
{
    public class GeneralNetworkScreen
    {
        public GeneralNetworkScreen()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "new-net")]
        public IWebElement newNet { get; set; }

        [FindsBy(How = How.Id, Using = "NetworkNameId")]

        public IWebElement networkName1 { get; set; }

        [FindsBy(How = How.Id, Using = "CustomerNameId")]

        public IWebElement customerName1 { get; set; }

        [FindsBy(How = How.Id, Using = "LocationId")]
        public IWebElement locationNetwork1 { get; set; }

        [FindsBy(How=How.Id, Using ="UnitNameId")]

        public IWebElement unitNameNetwork1 { get; set; }

        [FindsBy(How=How.Id, Using = "OkButtonGeneralData")]
        public IWebElement buttonOk { get; set; }

        [FindsBy(How = How.Id, Using = "errorMessageId")]
        public IWebElement errorMessage { get; set; }

        [FindsBy(How = How.Id, Using = "mandatoryFieldsIdError")]
        public IWebElement mandatoryFields { get; set; }
        
        [FindsBy(How=How.Id, Using = "ButtonOk")]
        
        public IWebElement OkButton { get; set; }

        [FindsBy(How = How.Id, Using = "CancelGeneralData")]

        public IWebElement cancelButton{ get; set; }

        



        public void fillGeneralNetworkData(GeneralNetworkData generalNetworkData)
        {
            while (PropertyCollection.driver.FindElement(By.TagName("angular-loader")).FindElements(By.TagName("div")).Count > 0)
            {

            }
            newNet.Click();
            networkName1.SendKeys(generalNetworkData.NetworkName);
            customerName1.SendKeys(generalNetworkData.Customer);
            locationNetwork1.SendKeys(generalNetworkData.Location);
            unitNameNetwork1.SendKeys(generalNetworkData.UnitName);

            buttonOk.Click();
        }

        public void fillNetworkName (GeneralNetworkData generalNetworkData)
        {
            while (PropertyCollection.driver.FindElement(By.TagName("angular-loader")).FindElements(By.TagName("div")).Count > 0)
            {

            }

            newNet.Click();
            networkName1.SendKeys(generalNetworkData.NetworkName);
            buttonOk.Click();

            Thread.Sleep(2000);
            Assert.IsTrue(mandatoryFields.Displayed);
            Thread.Sleep(2000);

            OkButton.Click();


        }

        public void fillNetworkNameandCustomer (GeneralNetworkData generalNetworkData)
        {
            while (PropertyCollection.driver.FindElement(By.TagName("angular-loader")).FindElements(By.TagName("div")).Count > 0)
            {

            }
            newNet.Click();
            networkName1.SendKeys(generalNetworkData.NetworkName);
            customerName1.SendKeys(generalNetworkData.Location);
            buttonOk.Click();

            Thread.Sleep(2000);
            Assert.IsTrue(mandatoryFields.Displayed);
            Thread.Sleep(2000);

            OkButton.Click();

        }

        public void FillNetworkNameAndCancel(GeneralNetworkData generalNetworkData)
        {

            while (PropertyCollection.driver.FindElement(By.TagName("angular-loader")).FindElements(By.TagName("div")).Count > 0)
            {

            }
            newNet.Click();
            networkName1.SendKeys(generalNetworkData.NetworkName);

            Thread.Sleep(1500);

            cancelButton.Click();

            newNet.Click();

            Thread.Sleep(1500);

            //Console.WriteLine("network name" + networkName1.);
            Assert.IsTrue(networkName1.Text == string.Empty);

        }

    }
}

