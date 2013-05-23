using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;
using System.Management;
using System.Threading;

namespace Vypinac
{
    public partial class Form1 : Form
    {
        int milisecends;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thread odpocet;
            int hodiny;
            if (richTextBox1.Text.Count() != 0)
            {
                hodiny = Convert.ToInt32(richTextBox1.Text);
            }
            else
            {
                hodiny = 0;
            }
            int minuty ;
            if (richTextBox2.Text.Count() != 0)
            {
                minuty = Convert.ToInt32(richTextBox2.Text);
            }
            else
            {
                minuty = 0;
            }
            minuty += hodiny * 60;

            int sekundy;
            if (richTextBox3.Text.Count() != 0)
            {
                sekundy = Convert.ToInt32(richTextBox3.Text);
            }
            else
                sekundy = 0;

            int milisekundy;
            sekundy += minuty * 60;
            milisekundy = sekundy * 1000;
            milisecends = milisekundy;
            timer1.Interval = milisekundy;
            timer2.Interval = 1000;
            timer1.Start();           
            timer2.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (radioButton1.Checked == true)
            {
                ShutDown();
            }
            if (radioButton2.Checked == true)
            {
                Restart();
            }
        }

        private void Restart() 
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system. Use "2" to reboot.
            mboShutdownParams["Flags"] = "2";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }

        private void ShutDown()
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds((milisecends/1000)-1);
            label6.Text = time.Hours.ToString();
            label5.Text = time.Minutes.ToString();
            label4.Text = time.Seconds.ToString();
            milisecends -= 1000;
            if (milisecends == 0)
            {
                timer2.Stop();
            }

        }
    }
}
