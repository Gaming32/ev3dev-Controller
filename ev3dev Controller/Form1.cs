using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev3dev_Controller
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            txtUsername.Text = Program.username;
            txtPassword.Text = Program.password;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Program.Send($"connect {txtHost.Text} {txtUsername.Text} {txtPassword.Text}", this);
        }
    }
}
