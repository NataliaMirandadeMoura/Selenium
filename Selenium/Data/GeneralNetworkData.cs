using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Data
{
    public class GeneralNetworkData: GeneralNetworkScreen
    {

        private string networkName;
        private string customer;
        private string location;
        private string unitName;

        public GeneralNetworkData()
        {
            var i = Guid.NewGuid().ToString();
            networkName = $"Test {i}";
            customer = "Client";
            location = "Brasil";
            unitName = "Moura";
        }

        public string NetworkName
        {
            set { networkName = value; }
            get { return networkName; }
        }

        public string Customer
        {
            set { customer = value; }
            get { return customer; }
        }

        public string Location { 
            set { location = value; }
            get { return location; }
        }

        public string UnitName
        {
            set { unitName = value; }
            get { return unitName; }
        }


    }
}
