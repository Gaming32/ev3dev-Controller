using System;
using CLSTools;
using Renci.SshNet;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ev3dev_Controller.Properties;
using System.IO;
using ev3dev_Controller.Hardware;

namespace ev3dev_Controller
{
    public static class Program
    {
        private static object sender = null;
        public static SshClient connection;
        public static SftpClient sftp;
        public static string host = Settings.Default.host;
        public static string  username = "robot";
        public static string password = "maker";
        public static bool State => (connection == null || !connection.IsConnected) ? false : true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //try
            //{
                Trace.Listeners.Add(new TextWriterTraceListener(Console.OpenStandardOutput()));
                Trace.AutoFlush = true;

                Debug.Listeners.Add(new TextWriterTraceListener(Console.OpenStandardOutput()));
                Debug.AutoFlush = true;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                while (true)
                {
                    //try
                    //{
                        Console.Write("Enter Command: ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "exit" || input.ToLower() == "quit") break;
                        else
                        {
                            HandleInput(input);
                            Console.WriteLine();
                        }
                    //}
                    //catch (Exception ex)
                    //{
                    //    BasicTools.LogErr(ex);
                    //    Console.WriteLine(ex.Message);
                    //}
                }
                #region Dispose
                Console.WriteLine("Closing...");
                if (connection != null) connection.Disconnect();
                try { Application.OpenForms[0].Dispose(); }
                catch (ArgumentOutOfRangeException) { }
                Application.Exit();
                #endregion
            //}
            //catch (Exception ex)
            //{
            //    BasicTools.LogErr(ex);
            //    MessageBox.Show(ex.Message);
            //}
        }
        static void HandleArgs(string[] args)
        {
            if (args.Length == 1)
            {
                switch (args[0])
                {
                    case "/?":
                        Help();
                        break;
                    case "/g":
                        HandleInput("gui");
                        break;
                    default:
                        throw new NotSupportedException($"Unsupported Arg: {args[0]}");
                }
            }
        }
        public static void HandleInput(string input, object sender = null)
        {
            sender = Program.sender ?? sender;
            StartupForm form = null;
            if (sender != null)
            {
                form = (StartupForm)sender;
                form.prgBar.Style = ProgressBarStyle.Blocks;
                form.prgBar.Value = 0;
            }
            string[] args = input.Split(' ');
            switch (args[0].ToLower())
            {
                #region "help"
                case "help":
                    Help();
                    break;
                #endregion
                #region "connect"
                case "connect":
                    if (form != null) form.prgBar.Maximum = 6;
                    try
                    {
                        host = args[1]; if (form != null) form.prgBar.Value++;
                        Settings.Default.host = host; if (form != null) form.prgBar.Value++;
                        username = args[2]; if (form != null) form.prgBar.Value++;
                        password = args[3]; if (form != null) form.prgBar.Value++;
                    }
                    catch (IndexOutOfRangeException) { }
                    connection = new SshClient(
                                        host: host,
                                        username: username,
                                        password: password);    if (form != null) form.prgBar.Value++;
                    connection.Connect();   if (form != null) form.prgBar.Value++;
                    if(sender == null)
                    Console.WriteLine($"Connected to {host}'s user {username} with password {new string('*', password.Length)}");
                    username = "robot";
                    password = "maker";
                    break;
                #endregion
                #region "disconnect"
                case "disconnect":
                    if (form != null) form.prgBar.Maximum = 1;
                    connection.Disconnect();    if (form != null) form.prgBar.Value++;
                    break;
                #endregion
                #region "shutdown"
                case "shutdown":
                    if (form != null) form.prgBar.Maximum = 3;
                    using (ShellStream shellStream = connection.CreateShellStream("xterm", 255, 50, 800, 600, 1024,
                        new Dictionary<Renci.SshNet.Common.TerminalModes, uint>()))
                    {
                        shellStream.Write("sudo poweroff\n");   if (form != null) form.prgBar.Value++;
                        shellStream.Expect($"[sudo] password for {username}:"); if (form != null) form.prgBar.Value++;
                        shellStream.Write($"{password}\n"); if (form != null) form.prgBar.Value++;
                    }
                    break;
                #endregion
                #region "gui"
                case "gui":
                    FormTools.RunInNewThread(new StartupForm(), true);
                    break;
                #endregion
                #region "ssh"
                case "ssh":
                    if (form != null) form.prgBar.Maximum = 2;
                    using (ShellStream shellStream = connection.CreateShellStream("xterm", 255, 50, 800, 600, 2048,
                        new Dictionary<Renci.SshNet.Common.TerminalModes, uint>()))
                    {
                        Console.WriteLine(); if (form != null) form.prgBar.Value++;
                        Console.Write(shellStream.Read()); if (form != null) form.prgBar.Value++;
                        if (form != null) form.prgBar.Style = ProgressBarStyle.Marquee;
                        while (true)
                        {
                            string streamInput = Console.ReadLine();
                            if (streamInput == "exit") break;
                            shellStream.WriteLine(streamInput);
                            Console.Write(shellStream.Read().TrimStart(streamInput.ToCharArray()));
                        }
                    }
                    break;
                #endregion
                #region motor
                case "motor":
                    HardwareController.MoveMotor(address: args[1], action: args[2]);
                    break;
                #endregion
                case "run":
                    if(HardwareController.State)
                        HardwareController.MoveMotor(HardwareController.MotorList["outB"], MotorMoveActions.run_forever);
                    break;
                case "": break;
                default:
                    throw new NotSupportedException($"Unsupported Command: {input}");
            }
        }
        static void Help()
        {
            Console.WriteLine(@"SWITCHES
-------------------------------
/? this help
/g open gui (not working)

COMMANDS
-------------------------------
help: this help
disconnect: disconnect from the device
shutdown: poweroff the device
connect {host} [username='robot'] [password='maker']: connect to the device
ssh: open an ssh session with the connected device (not working properly)");
        }
    }
}
