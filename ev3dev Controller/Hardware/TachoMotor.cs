using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace ev3dev_Controller.Hardware
{
    public class TachoMotor : IHardware
    {
        /// <summary>
        /// The motor class path
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// The motor's physical address
        /// </summary>
        public string Address { get; }
#pragma warning disable IDE1006 // Naming Styles
        /// <summary>
        /// The motor's maximum speed in dps
        /// </summary>
        public int max_speed => Convert.ToInt32(Program.sftp.ReadAllText($"{Path}/max_speed"));
        public int speed_sp { get => Convert.ToInt32(Program.sftp.ReadAllText($"{Path}/speed_sp"));
            set => Program.sftp.WriteAllText($"{Path}/speed_sp", value.ToString()); }
#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// Creates an instance of TachoMotor using the specified reference
        /// </summary>
        /// <param name="from">The class path or physical address to create the instance from</param>
        public TachoMotor(string from)
        {
            if (Program.sftp != null || Program.sftp.IsConnected)
            {
                if (from.Contains("/sys/class/tacho-motor/"))
                {
                    Path = from.TrimEnd('/');
                    Address = Program.sftp.ReadAllText($"{Path}/address").TrimEnd('\n');
                }
                else
                {
                    List<SftpFile> fileList = (List<SftpFile>)Program.sftp.ListDirectory("/sys/class/tacho-motor");
                    fileList.RemoveRange(0, count: 2);
                    foreach (SftpFile dir in fileList)
                    {
                        string file = Program.sftp.ReadAllText($"{dir.FullName}/address");
                        if (file.Contains(from))
                        {
                            Path = dir.FullName;
                            Address = file;
                        }
                    }
                }
            }
            else
            {
                if (Program.State)
                {
                    Program.sftp = new SftpClient(Program.connection.ConnectionInfo);
                    Program.sftp.Connect();
                }
                else throw new Renci.SshNet.Common.SshConnectionException("Unable to Create TachoMotor Instance: Target Device not Connected");
            }
        }
        
#pragma warning disable IDE1006 // Naming Styles
        /// <summary>
        /// Runs the motor forever
        /// </summary>
        /// <param name="speed_sp">The speed to run the motor at (between -max_speed and max_speed)</param>
        public void run_forever(int speed_sp)
        {
            Program.sftp.WriteAllText($"{Path}/speed_sp", ((speed_sp <= max_speed) ? speed_sp : max_speed).ToString());
            Program.sftp.WriteAllText($"{Path}/command", "run-forever");
        }
        /// <summary>
        /// Stops the motor
        /// </summary>
        /// <param name="stop_action">The way to stop the motor (can be "coast", "brake", or "hold")</param>
        public void stop(string stop_action)
        {
            Program.sftp.WriteAllText($"{Path}/stop_action", stop_action);
            Program.sftp.WriteAllText($"{Path}/command", "stop");
        }
#pragma warning restore IDE1006 // Naming Styles
    }
}
