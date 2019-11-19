using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.DeviceSupport;

namespace InterfaceBuilder
{
    class TouchPanel
    {
        string projectName;


        //To Initialize this Touch Panel, a Crestron Processor, IP ID, and TouchPanel type will need to be defined
        public TouchPanel()
        {




        }

        //Additionally, the abilit to have the enumerations defined, will also be important

        // The enumerations will exist for use within the code, but will also automatically generate the switch case for the Touch Panel object

        // ** day 2 featureAdditionally, the enumerations will be tagged based upon one or more keywords related to them
        private void DefineEnumeration()
        {

        }

        private void Initialize()
        {
            //Initializes this class, with the supplied information
        }


    }
}
