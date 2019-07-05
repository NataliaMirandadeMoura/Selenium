using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Data;
using System.Threading;

namespace Selenium
{
    public class ShellAndTubeExchangerScreen
    {
        public ShellAndTubeExchangerScreen()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);

        }

        #region Atributos
        [FindsBy(How = How.Id, Using = "shell_temperature_1")]

        public IWebElement shellAndTube1 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_2")]

        public IWebElement shellAndTube2 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_4")]

        public IWebElement shellAndTube4 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_5")]

        public IWebElement shellAndTube5 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_6")]

        public IWebElement shellAndTube6 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_7")]

        public IWebElement shellAndTube7 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_8")]

        public IWebElement shellAndTube8 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_9")]

        public IWebElement shellAndTube9 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_temperature_10")]

        public IWebElement shellAndTube10 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature1")]

        public IWebElement tubeTemperature1 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature2")]

        public IWebElement tubeTemperature2 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature4")]

        public IWebElement tubeTemperature4 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature5")]

        public IWebElement tubeTemperature5 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature6")]

        public IWebElement tubeTemperature6 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature7")]

        public IWebElement tubeTemperature7 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature8")]

        public IWebElement tubeTemperature8 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature9")]

        public IWebElement tubeTemperature9 { get; set; }

        [FindsBy(How = How.Id, Using = "tubetemperature10")]

        public IWebElement tubeTemperature10 { get; set; }

        [FindsBy(How = How.Id, Using = "pressureSpecifications-link")]

        public IWebElement pressureSpecification { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure1")]

        public IWebElement shellPressure { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure2")]

        public IWebElement shellPressure2 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure4")]

        public IWebElement shellPressure4 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure5")]

        public IWebElement shellPressure5 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure6")]

        public IWebElement shellPressure6 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure7")]

        public IWebElement shellPressure7 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure8")]

        public IWebElement shellPressure8 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure9")]

        public IWebElement shellPressure9 { get; set; }

        [FindsBy(How = How.Id, Using = "shell_pressure10")]

        public IWebElement shellPressure10 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure1")]

        public IWebElement tubePressure1 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure2")]

        public IWebElement tubePressure2 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure4")]

        public IWebElement tubePressure4 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure5")]

        public IWebElement tubePressure5 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure6")]

        public IWebElement tubePressure6 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure7")]

        public IWebElement tubePressure7 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure8")]

        public IWebElement tubePressure8 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure9")]

        public IWebElement tubePressure9 { get; set; }

        [FindsBy(How = How.Id, Using = "tubepressure10")]

        public IWebElement tubePressure10 { get; set; }

        [FindsBy(How = How.Id, Using = "buttonCase2")]

        public IWebElement buttonCase2 { get; set; }

        [FindsBy (How=How.Id, Using = "new-case")]
        public IWebElement newCase { get; set; }

        [FindsBy (How=How.Id, Using = "buttonCase1")]
        public  IWebElement buttonShellAndTube { get; set; }

        #endregion = Atributos


        #region Métodos
        public void FillShellAndTube(ShellAndTubeData shellAndTubeData)
        {
            buttonShellAndTube.Click();
            Thread.Sleep(2500);
            shellAndTube1.SendKeys(shellAndTubeData.ShellAndTube1);
            shellAndTube2.SendKeys(shellAndTubeData.ShellAndTube2);
            shellAndTube4.SendKeys(shellAndTubeData.ShellAndTube4);
            shellAndTube5.SendKeys(shellAndTubeData.ShellAndTube5);
            shellAndTube6.SendKeys(shellAndTubeData.ShellAndTube6);
            shellAndTube7.SendKeys(shellAndTubeData.ShellAndTube7);
            shellAndTube8.SendKeys(shellAndTubeData.ShellAndTube8);
            shellAndTube9.SendKeys(shellAndTubeData.ShellAndTube9);
            shellAndTube10.SendKeys(shellAndTubeData.ShellAndTube10);
            Thread.Sleep(1500);

            tubeTemperature1.SendKeys(shellAndTubeData.TubeTemperature1);
            tubeTemperature2.SendKeys(shellAndTubeData.TubeTemperature2);
            tubeTemperature4.SendKeys(shellAndTubeData.TubeTemperature4);
            tubeTemperature5.SendKeys(shellAndTubeData.TubeTemperature5);
            tubeTemperature6.SendKeys(shellAndTubeData.TubeTemperature6);
            tubeTemperature7.SendKeys(shellAndTubeData.TubeTemperature7);
            tubeTemperature8.SendKeys(shellAndTubeData.TubeTemperature8);
            tubeTemperature9.SendKeys(shellAndTubeData.TubeTemperature9);
            tubeTemperature10.SendKeys(shellAndTubeData.TubeTemperature10);

            Thread.Sleep(3000);

            pressureSpecification.Click();

            Thread.Sleep(4000);


            //shellPressure.SendKeys(shellAndTubeData.ShellPressure1);
            shellPressure2.SendKeys(shellAndTubeData.ShellPressure2);
            shellPressure4.SendKeys(shellAndTubeData.ShellPressure4);
            shellPressure5.SendKeys(shellAndTubeData.ShellPressure5);
            shellPressure6.SendKeys(shellAndTubeData.ShellPressure6);
            shellPressure7.SendKeys(shellAndTubeData.ShellPressure7);
            shellPressure8.SendKeys(shellAndTubeData.ShellPressure8);
            shellPressure9.SendKeys(shellAndTubeData.ShellPressure9);
            shellPressure10.SendKeys(shellAndTubeData.ShellPressure10);


            //tubePressure1.SendKeys(shellAndTubeData.TubePressure1);
            tubePressure2.SendKeys(shellAndTubeData.TubePressure2);
            tubePressure4.SendKeys(shellAndTubeData.TubePressure4);
            tubePressure5.SendKeys(shellAndTubeData.TubePressure5);
            tubePressure6.SendKeys(shellAndTubeData.TubePressure6);
            tubePressure7.SendKeys(shellAndTubeData.TubePressure7);
            tubePressure8.SendKeys(shellAndTubeData.TubePressure8);
            tubePressure9.SendKeys(shellAndTubeData.TubePressure9);
            tubePressure10.SendKeys(shellAndTubeData.TubePressure10);











        }

        

       

       

     

            #endregion

        }

    }




