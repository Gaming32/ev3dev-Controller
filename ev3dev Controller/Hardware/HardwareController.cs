using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace ev3dev_Controller.Hardware
{
    public static class HardwareController
    {
        /// <summary>
        /// Returns true if the class has been initialized, otherwise initializes it (always returns true)
        /// </summary>
        public static bool State => (Program.sftp == null || !Program.sftp.IsConnected) ? Initialize() : true;
        /// <summary>
        /// The list of motors connected to the device
        /// </summary>
        public static Dictionary<string, TachoMotor> MotorList { get; } = new Dictionary<string, TachoMotor>();

        /// <summary>
        /// Initializes the class by connecting to the device via sftp and populating MotorList
        /// </summary>
        /// <returns>True</returns>
        public static bool Initialize()
        {
            Program.sftp = new SftpClient(Program.connection.ConnectionInfo);
            Program.sftp.Connect();

            List<SftpFile> motorDirs = (List<SftpFile>)Program.sftp.ListDirectory("/sys/class/tacho-motor");
            motorDirs.RemoveRange(0, count: 2);
            foreach (SftpFile motorDir in motorDirs)
            {
                TachoMotor motor = new TachoMotor(motorDir.FullName);
                MotorList[motor.Address] = motor;
            }

            return true;
        }

        /// <summary>
        /// Moves the specied motor the specifed way
        /// </summary>
        /// <param name="motor">The motor to move</param>
        /// <param name="action">The way to move the motor</param>
        /// <param name="speed_sp">The speed to move the motor</param>
        /// <param name="stop_action">The way to stop the motor</param>
        /// <param name="position_sp">The amount to move the motor</param>
        public static void MoveMotor(TachoMotor motor, MotorMoveActions action, int speed_sp=500, string stop_action="coast", int position_sp=360)
        {
            switch (action)
            {
                case MotorMoveActions.run_forever:
                    motor.run_forever(speed_sp);
                    break;
                case MotorMoveActions.stop:
                    motor.stop(stop_action);
                    break;
                default:
                    throw new NotSupportedException($"Unsupported Action: {action.ToString()}");
            }
        }
        /// <summary>
        /// Moves the specied motor the specifed way
        /// </summary>
        /// <param name="address">The address of the motor to move</param>
        /// <param name="action">The way to move the motor</param>
        /// <param name="speed_sp">The speed to move the motor</param>
        /// <param name="stop_action">The way to stop the motor</param>
        /// <param name="position_sp">The amount to move the motor</param>
        public static void MoveMotor(string address, string action, int speed_sp = 500, string stop_action = "coast", int position_sp = 360)
        {
            TachoMotor motor = MotorList[address];
            switch (action)
            {
                case "run_forever":
                    motor.run_forever(speed_sp);
                    break;
                case "stop":
                    motor.stop(stop_action);
                    break;
                default:
                    throw new NotSupportedException($"Unsupported Action: {action}");
            }
        }
    }
}
