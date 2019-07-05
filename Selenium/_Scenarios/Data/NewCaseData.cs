
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.Scenarios;
using Selenium.Screens;

namespace Selenium.Data
{
   public class NewCaseData:NewCaseScreen
    {
        public string Date { get; set; }
        public string Time { get; set; }
        //public string Antifoulant { get; set; }
        public string InjectionRate { get; set; }
        public string AntifoulantCost { get; set; }
        public string CrudeUnitMargin { get; set; }
        public string FurnaceFuelCost { get; set; }
        public string FurnaceEfficiency { get; set; }
        public string FuelCO2Equivalent { get; set; }

        public NewCaseData()
        {
            Date = "10/10/2018";
            Time = "10:10";
            AntifoulantCost = "10";
            InjectionRate = "10";
            CrudeUnitMargin = "10";
        }

        public enum Antifoulant
        {
            value1=10,
            value2=20,
            value3=30
        }
    }
}
