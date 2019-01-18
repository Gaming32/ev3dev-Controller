using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ev3dev_Controller.Hardware;

namespace ev3dev_Controller
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            txtUsername.Text = Program.username;
            txtPassword.Text = Program.password;
            StartupForm_Update();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (!Program.State) Program.HandleInput($"connect {txtHost.Text} {txtUsername.Text} {txtPassword.Text}", this);
            else Program.HandleInput("disconnect", this);
            StartupForm_Update();
        }

        private void StartupForm_Update(object sender = null, EventArgs e = null)
        {
            btnConnect.Text = (!Program.State) ? "Connect" : "Disconnect";
            this.Size = (!Program.State) ? new Size(255, 230) : new Size(615, 375);
            if (Program.State && HardwareController.State)
            {
                if (HardwareController.MotorList.TryGetValue("ev3-ports:outA", out TachoMotor motor))
                {
                    tkb_outA.Maximum = motor.max_speed;
                    tkb_outA.Minimum = -tkb_outA.Maximum;
                    tkb_outA.Value = tkb_outA.Maximum / 2;
                }
                else
                {
                    tkb_outA.Enabled = false;
                    txt_outA.Enabled = false;
                }

                if (HardwareController.MotorList.TryGetValue("ev3-ports:outB", out motor))
                {
                    tkb_outB.Maximum = motor.max_speed;
                    tkb_outB.Minimum = -tkb_outB.Maximum;
                    tkb_outB.Value = tkb_outB.Maximum / 2;
                }
                else
                {
                    tkb_outB.Enabled = false;
                    txt_outB.Enabled = false;
                }

                if (HardwareController.MotorList.TryGetValue("ev3-ports:outC", out motor))
                {
                    tkb_outC.Maximum = motor.max_speed;
                    tkb_outC.Minimum = -tkb_outC.Maximum;
                    tkb_outC.Value = tkb_outC.Maximum / 2;
                }
                else
                {
                    tkb_outC.Enabled = false;
                    txt_outC.Enabled = false;
                }

                if (HardwareController.MotorList.TryGetValue("ev3-ports:outD", out motor))
                {
                    tkb_outD.Maximum = motor.max_speed;
                    tkb_outD.Minimum = -tkb_outD.Maximum;
                    tkb_outD.Value = tkb_outD.Maximum / 2;
                }
                else
                {
                    tkb_outD.Enabled = false;
                    txt_outD.Enabled = false;
                }
            }
        }

        private void MotorSpeedUpdate(object sender, EventArgs e)
        {
            string name = ((Control)sender).Name;
            if (name.StartsWith("txt"))
                ((TrackBar)Controls[0].Controls[0].Controls[name.Replace("txt", "tkb")]).Value = Convert.ToInt32(((TextBox)sender).Text);
            else
                ((TextBox)Controls[0].Controls[0].Controls[name.Replace("tkb", "txt")]).Text = ((TrackBar)sender).Value.ToString();
            if (HardwareController.State)
                HardwareController.MotorList["ev3-ports:" + name.Split('_')[1]].speed_sp = ((TrackBar)this.Controls[0].Controls[0].Controls["tkb_out" + name[7]]).Value;
        }

        private void MotorStart(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (HardwareController.State)
            {
                TachoMotor motor = HardwareController.MotorList["ev3-ports:" + btn.Name.TrimStart("btn_".ToCharArray())];
                if (btn.Text == "Start")
                    motor.run_forever(((TrackBar)btn.Parent.Controls[btn.Name.Replace("btn", "tkb")]).Value);
                else motor.stop("coast");
            }
        }
    }
}
