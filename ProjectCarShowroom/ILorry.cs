using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    interface ILorry
    {
        string GearType { get; set; }

        int NumberOfWheels { get; set; }

        string TrailerType { get; set; }

    }
}
