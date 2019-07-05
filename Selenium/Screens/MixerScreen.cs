using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Data;
using Selenium.Wait;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium.Screens
{
    public class MixerScreen
    {

        public MixerScreen()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);

        }

        [FindsBy(How = How.Id, Using = "MixerTemperature1")]
        public IWebElement TemperatureMixer1 { get; set; }

        [FindsBy(How = How.Id, Using = "MixerTemperature2")]
        public IWebElement TemperatureMixer2 { get; set; }

        [FindsBy(How = How.Id, Using = "buttonCase4")]
        public IWebElement ButtonCase4 { get; set; }



        public void FillMixer(MixerData mixerData)
        {
            ExplictWait.Explict(PropertyCollection.driver, "buttonCase4");
            ButtonCase4.Click();

            Thread.Sleep(3000);
            TemperatureMixer1.SendKeys(mixerData.MixerTemperature1);
            TemperatureMixer2.SendKeys(mixerData.MixerTemperature2);
        }
    }
}

