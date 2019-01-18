using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev3dev_Controller.Hardware
{
    public enum MotorMoveActions { reset, stop, run_forever, run_to_rel_pos, run_to_abs_pos}
    public enum MotorStopActions { coast, brake, hold }
}
