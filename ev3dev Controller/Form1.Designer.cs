namespace ev3dev_Controller
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbpMotors = new System.Windows.Forms.TabPage();
            this.lbl_outD = new System.Windows.Forms.Label();
            this.txt_outD = new System.Windows.Forms.TextBox();
            this.btn_outD = new System.Windows.Forms.Button();
            this.tkb_outD = new System.Windows.Forms.TrackBar();
            this.lbl_outC = new System.Windows.Forms.Label();
            this.txt_outC = new System.Windows.Forms.TextBox();
            this.btn_outC = new System.Windows.Forms.Button();
            this.tkb_outC = new System.Windows.Forms.TrackBar();
            this.lbl_outB = new System.Windows.Forms.Label();
            this.txt_outB = new System.Windows.Forms.TextBox();
            this.btn_outB = new System.Windows.Forms.Button();
            this.tkb_outB = new System.Windows.Forms.TrackBar();
            this.lbl_outA = new System.Windows.Forms.Label();
            this.txt_outA = new System.Windows.Forms.TextBox();
            this.btn_outA = new System.Windows.Forms.Button();
            this.tkb_outA = new System.Windows.Forms.TrackBar();
            this.tabControl.SuspendLayout();
            this.tbpMotors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(12, 9);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 25);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(216, 20);
            this.txtHost.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 129);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(216, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(12, 158);
            this.prgBar.MarqueeAnimationSpeed = 10;
            this.prgBar.Maximum = 0;
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(216, 23);
            this.prgBar.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbpMotors);
            this.tabControl.Location = new System.Drawing.Point(234, 9);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(353, 315);
            this.tabControl.TabIndex = 8;
            // 
            // tbpMotors
            // 
            this.tbpMotors.Controls.Add(this.lbl_outD);
            this.tbpMotors.Controls.Add(this.txt_outD);
            this.tbpMotors.Controls.Add(this.btn_outD);
            this.tbpMotors.Controls.Add(this.tkb_outD);
            this.tbpMotors.Controls.Add(this.lbl_outC);
            this.tbpMotors.Controls.Add(this.txt_outC);
            this.tbpMotors.Controls.Add(this.btn_outC);
            this.tbpMotors.Controls.Add(this.tkb_outC);
            this.tbpMotors.Controls.Add(this.lbl_outB);
            this.tbpMotors.Controls.Add(this.txt_outB);
            this.tbpMotors.Controls.Add(this.btn_outB);
            this.tbpMotors.Controls.Add(this.tkb_outB);
            this.tbpMotors.Controls.Add(this.lbl_outA);
            this.tbpMotors.Controls.Add(this.txt_outA);
            this.tbpMotors.Controls.Add(this.btn_outA);
            this.tbpMotors.Controls.Add(this.tkb_outA);
            this.tbpMotors.Location = new System.Drawing.Point(4, 22);
            this.tbpMotors.Name = "tbpMotors";
            this.tbpMotors.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMotors.Size = new System.Drawing.Size(345, 289);
            this.tbpMotors.TabIndex = 0;
            this.tbpMotors.Text = "Motors";
            this.tbpMotors.UseVisualStyleBackColor = true;
            // 
            // lbl_outD
            // 
            this.lbl_outD.Location = new System.Drawing.Point(291, 3);
            this.lbl_outD.Name = "lbl_outD";
            this.lbl_outD.Size = new System.Drawing.Size(45, 15);
            this.lbl_outD.TabIndex = 24;
            this.lbl_outD.Text = "outD";
            this.lbl_outD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_outD
            // 
            this.txt_outD.Location = new System.Drawing.Point(294, 234);
            this.txt_outD.Name = "txt_outD";
            this.txt_outD.Size = new System.Drawing.Size(45, 20);
            this.txt_outD.TabIndex = 23;
            this.txt_outD.Text = "500";
            this.txt_outD.TextChanged += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // btn_outD
            // 
            this.btn_outD.Location = new System.Drawing.Point(294, 260);
            this.btn_outD.Name = "btn_outD";
            this.btn_outD.Size = new System.Drawing.Size(45, 23);
            this.btn_outD.TabIndex = 22;
            this.btn_outD.Text = "Start";
            this.btn_outD.UseVisualStyleBackColor = true;
            this.btn_outD.Click += new System.EventHandler(this.MotorStart);
            // 
            // tkb_outD
            // 
            this.tkb_outD.LargeChange = 100;
            this.tkb_outD.Location = new System.Drawing.Point(294, 21);
            this.tkb_outD.Maximum = 1000;
            this.tkb_outD.Minimum = -1000;
            this.tkb_outD.Name = "tkb_outD";
            this.tkb_outD.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_outD.Size = new System.Drawing.Size(45, 209);
            this.tkb_outD.SmallChange = 10;
            this.tkb_outD.TabIndex = 21;
            this.tkb_outD.TickFrequency = 250;
            this.tkb_outD.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkb_outD.Value = 500;
            this.tkb_outD.Scroll += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // lbl_outC
            // 
            this.lbl_outC.Location = new System.Drawing.Point(200, 3);
            this.lbl_outC.Name = "lbl_outC";
            this.lbl_outC.Size = new System.Drawing.Size(45, 15);
            this.lbl_outC.TabIndex = 20;
            this.lbl_outC.Text = "outC";
            this.lbl_outC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_outC
            // 
            this.txt_outC.Location = new System.Drawing.Point(203, 234);
            this.txt_outC.Name = "txt_outC";
            this.txt_outC.Size = new System.Drawing.Size(45, 20);
            this.txt_outC.TabIndex = 19;
            this.txt_outC.Text = "500";
            this.txt_outC.TextChanged += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // btn_outC
            // 
            this.btn_outC.Location = new System.Drawing.Point(203, 260);
            this.btn_outC.Name = "btn_outC";
            this.btn_outC.Size = new System.Drawing.Size(45, 23);
            this.btn_outC.TabIndex = 18;
            this.btn_outC.Text = "Start";
            this.btn_outC.UseVisualStyleBackColor = true;
            this.btn_outC.Click += new System.EventHandler(this.MotorStart);
            // 
            // tkb_outC
            // 
            this.tkb_outC.LargeChange = 100;
            this.tkb_outC.Location = new System.Drawing.Point(203, 21);
            this.tkb_outC.Maximum = 1000;
            this.tkb_outC.Minimum = -1000;
            this.tkb_outC.Name = "tkb_outC";
            this.tkb_outC.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_outC.Size = new System.Drawing.Size(45, 209);
            this.tkb_outC.SmallChange = 10;
            this.tkb_outC.TabIndex = 17;
            this.tkb_outC.TickFrequency = 250;
            this.tkb_outC.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkb_outC.Value = 500;
            this.tkb_outC.Scroll += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // lbl_outB
            // 
            this.lbl_outB.Location = new System.Drawing.Point(104, 3);
            this.lbl_outB.Name = "lbl_outB";
            this.lbl_outB.Size = new System.Drawing.Size(45, 15);
            this.lbl_outB.TabIndex = 16;
            this.lbl_outB.Text = "outB";
            this.lbl_outB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_outB
            // 
            this.txt_outB.Location = new System.Drawing.Point(107, 234);
            this.txt_outB.Name = "txt_outB";
            this.txt_outB.Size = new System.Drawing.Size(45, 20);
            this.txt_outB.TabIndex = 15;
            this.txt_outB.Text = "500";
            this.txt_outB.TextChanged += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // btn_outB
            // 
            this.btn_outB.Location = new System.Drawing.Point(107, 260);
            this.btn_outB.Name = "btn_outB";
            this.btn_outB.Size = new System.Drawing.Size(45, 23);
            this.btn_outB.TabIndex = 14;
            this.btn_outB.Text = "Start";
            this.btn_outB.UseVisualStyleBackColor = true;
            this.btn_outB.Click += new System.EventHandler(this.MotorStart);
            // 
            // tkb_outB
            // 
            this.tkb_outB.LargeChange = 100;
            this.tkb_outB.Location = new System.Drawing.Point(107, 21);
            this.tkb_outB.Maximum = 1000;
            this.tkb_outB.Minimum = -1000;
            this.tkb_outB.Name = "tkb_outB";
            this.tkb_outB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_outB.Size = new System.Drawing.Size(45, 209);
            this.tkb_outB.SmallChange = 10;
            this.tkb_outB.TabIndex = 13;
            this.tkb_outB.TickFrequency = 250;
            this.tkb_outB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkb_outB.Value = 500;
            this.tkb_outB.Scroll += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // lbl_outA
            // 
            this.lbl_outA.Location = new System.Drawing.Point(3, 3);
            this.lbl_outA.Name = "lbl_outA";
            this.lbl_outA.Size = new System.Drawing.Size(45, 15);
            this.lbl_outA.TabIndex = 12;
            this.lbl_outA.Text = "outA";
            this.lbl_outA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_outA
            // 
            this.txt_outA.Location = new System.Drawing.Point(6, 234);
            this.txt_outA.Name = "txt_outA";
            this.txt_outA.Size = new System.Drawing.Size(45, 20);
            this.txt_outA.TabIndex = 11;
            this.txt_outA.Text = "500";
            this.txt_outA.TextChanged += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // btn_outA
            // 
            this.btn_outA.Location = new System.Drawing.Point(6, 260);
            this.btn_outA.Name = "btn_outA";
            this.btn_outA.Size = new System.Drawing.Size(45, 23);
            this.btn_outA.TabIndex = 10;
            this.btn_outA.Text = "Start";
            this.btn_outA.UseVisualStyleBackColor = true;
            this.btn_outA.Click += new System.EventHandler(this.MotorStart);
            // 
            // tkb_outA
            // 
            this.tkb_outA.LargeChange = 100;
            this.tkb_outA.Location = new System.Drawing.Point(6, 21);
            this.tkb_outA.Maximum = 1000;
            this.tkb_outA.Minimum = -1000;
            this.tkb_outA.Name = "tkb_outA";
            this.tkb_outA.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkb_outA.Size = new System.Drawing.Size(45, 209);
            this.tkb_outA.SmallChange = 10;
            this.tkb_outA.TabIndex = 9;
            this.tkb_outA.TickFrequency = 250;
            this.tkb_outA.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkb_outA.Value = 500;
            this.tkb_outA.Scroll += new System.EventHandler(this.MotorSpeedUpdate);
            // 
            // StartupForm
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 336);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.Text = "Startup Form";
            this.Activated += new System.EventHandler(this.StartupForm_Update);
            this.tabControl.ResumeLayout(false);
            this.tbpMotors.ResumeLayout(false);
            this.tbpMotors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_outA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbpMotors;
        private System.Windows.Forms.Label lbl_outA;
        private System.Windows.Forms.TextBox txt_outA;
        private System.Windows.Forms.Button btn_outA;
        private System.Windows.Forms.TrackBar tkb_outA;
        private System.Windows.Forms.Label lbl_outD;
        private System.Windows.Forms.TextBox txt_outD;
        private System.Windows.Forms.Button btn_outD;
        private System.Windows.Forms.TrackBar tkb_outD;
        private System.Windows.Forms.Label lbl_outC;
        private System.Windows.Forms.TextBox txt_outC;
        private System.Windows.Forms.Button btn_outC;
        private System.Windows.Forms.TrackBar tkb_outC;
        private System.Windows.Forms.Label lbl_outB;
        private System.Windows.Forms.TextBox txt_outB;
        private System.Windows.Forms.Button btn_outB;
        private System.Windows.Forms.TrackBar tkb_outB;
    }
}

