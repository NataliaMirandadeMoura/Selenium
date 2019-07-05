using Selenium.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium.Data
{
    public class AirCoolerData: AirCoolersScreen
    {

        private string processSideExitTemperature;
        private string airSideInletTemperature;
        private string airSideExitTemperature;
        private string airSideFouling;

        public AirCoolerData()
        {
            processSideExitTemperature = "10";
            airSideInletTemperature = "10";
            airSideExitTemperature = "10";
            airSideFouling = "10";
        }

        public string ProcessSideExiTemperature
        {
            set { processSideExitTemperature = value; }
            get { return processSideExitTemperature; }
        }

        public string AirSideInletTemperature
        {
            set { airSideInletTemperature = value; }
            get { return airSideInletTemperature; }
        }

        public string AirSideExitTemperature
        {
            set { airSideExitTemperature = value; }
            get { return airSideExitTemperature; }
        }

        public string AirSideFouling
        {
            set { airSideFouling = value; }
            get { return airSideFouling; }
        }

        
    }
}
