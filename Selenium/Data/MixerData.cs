using Selenium.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Data
{
    public class MixerData: MixerScreen
    {
        public string MixerTemperature1 { get; set; }
        public string MixerTemperature2 { get; set; }


        public MixerData()
        {
            MixerTemperature1 = "10";
            MixerTemperature2 = "20";
        }
    }
}
