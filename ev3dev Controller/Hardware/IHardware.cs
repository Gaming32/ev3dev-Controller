using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev3dev_Controller.Hardware
{
    interface IHardware
    {
        string Path { get; }
        string Address { get; }
    }
}
