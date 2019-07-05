using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Selenium.Data;
using System;
using System.Threading;

namespace Selenium
{
    public class NewCaseScreen

    {
        public NewCaseScreen()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);

        }

        [FindsBy(How = How.Id, Using = "new-case")]
        public IWebElement buttonNewCase { get; set; }


        [FindsBy(How = How.Name, Using = "dateTime")]
        public IWebElement date { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_time_input")]
        public IWebElement time { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_antifoulant_input")]

        public IWebElement antifoulantElement { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_furnace_injection_rate_input")]
        public IWebElement injectionRate { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_anti_foulant_cost_input")]
        public IWebElement antifoulantCost { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_fuel_crude_unit_margin_input")]
        public IWebElement crudeUnitMargin { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_furnace_fuel_cost_input")]
        public IWebElement furnaceFuelCost { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_furnace_efficiency_input")]
        public IWebElement furnaceEfficienty { get; set; }

        [FindsBy(How = How.Id, Using = "general_case_fuel_co2_equivalent_input")]
        public IWebElement fuelEquivalent { get; set; }

        [FindsBy(How = How.Id, Using = "buttonCase1")]
        public IWebElement shellAndTube { get; set; }

        [FindsBy(How = How.Id, Using = "errorMessageId")]
        public IWebElement validationErrorMessage { get; set; }

        [FindsBy(How = How.Id, Using = "buttonCase1")]
        public IWebElement buttonShellAndTube { get; set; }



        public void FillNewCase(NewCaseData newCaseData)
        {
            WebDriverWait wait = new WebDriverWait(PropertyCollection.driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until((d) =>
            {
                return (buttonNewCase);
            });

            buttonNewCase.Click();
            Thread.Sleep(200);
            date.SendKeys(newCaseData.Date);
            time.SendKeys(newCaseData.Time);
            antifoulantElement.SendKeys(((int)NewCaseData.Antifoulant.value1).ToString());
            injectionRate.SendKeys(newCaseData.InjectionRate);
            antifoulantCost.SendKeys(newCaseData.AntifoulantCost);
            crudeUnitMargin.SendKeys(newCaseData.AntifoulantCost);


        }

        public void NotFillDateField(NewCaseData newCaseData)
        {

            Thread.Sleep(2500);

            buttonNewCase.Click();
            Thread.Sleep(2000);
            
            buttonShellAndTube.Click();

            Thread.Sleep(2500);
            Assert.IsTrue(validationErrorMessage.Displayed);


        }
    }
}
