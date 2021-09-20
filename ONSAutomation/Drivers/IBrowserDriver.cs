using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONSAutomation.Drivers
{
   public  interface IBrowserDriver
    {
        void Navigate(string urlPart);
    }
}
