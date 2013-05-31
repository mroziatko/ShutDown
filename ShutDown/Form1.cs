/*
 * Author: Ladislav Oros, Livia Topolcanyova 
 * DogClock
 */
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
using System.Runtime.InteropServices;

namespace Vypinac
{
    public partial class Form1 : Form
    {
        DateTime time = new DateTime();
        int akcia = 0;
        public static int milisekundy = 0;
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();
        

        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 1000;
            timer1.Start();
            this.ShowInTaskbar = true;
        }
        
        private void Restart() 
        {
            if (akcia <= 2)
            {
                ManagementBaseObject mboShutdown = null;
                ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
                mcWin32.Get();

                // You can't shutdown without security privileges
                mcWin32.Scope.Options.EnablePrivileges = true;
                ManagementBaseObject mboShutdownParams =
                         mcWin32.GetMethodParameters("Win32Shutdown");

                // Flag 1 means we want to shut down the system. Use "2" to reboot.
                mboShutdownParams["Flags"] = akcia;
                mboShutdownParams["Reserved"] = "0";
                foreach (ManagementObject manObj in mcWin32.GetInstances())
                {
                    mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                                   mboShutdownParams, null);
                }
            }
            else if (akcia == 3)
            {
                akcia = 0;
                bool retVal = Application.SetSuspendState(PowerState.Hibernate, false, false);

                if (retVal == false)
                    MessageBox.Show("Could not hybernate the system.");
            }
            else if (akcia == 4)
            {
                akcia = 0;
                bool retVal = Application.SetSuspendState(PowerState.Suspend, false, false);

                if (retVal == false)
                    MessageBox.Show("Could not suspend the system.");
            }
            else if (akcia == 5)
            {
                akcia = 0;
                bool result = LockWorkStation();
 
            if (result == false)
            {
                // An error occured
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
            }
        }
 

        private void AktualnyCas(object sender, EventArgs e)
        {
           
            time = DateTime.Now;

            label4.Text = time.Second.ToString("D2");
            label5.Text = time.Minute.ToString("D2");
            label6.Text = time.Hour.ToString("D2");

            if (akcia != 0)
            {
                TimeSpan odpocet = TimeSpan.FromSeconds((milisekundy -1000) / 1000 );
                label3.Text = odpocet.Seconds.ToString("D2");
                label9.Text = odpocet.Minutes.ToString("D2");
                label10.Text = odpocet.Hours.ToString("D2");
                milisekundy -= 1000;
     
            }
        }

  

        private void shutDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypnut vypnut = new Vypnut();
            vypnut.ShowDialog();

            try
            {
                timer2.Interval = milisekundy;
                akcia = 1;
                timer2.Start();
            }
            catch
            {
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            Restart();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypnut vypnut = new Vypnut();
            vypnut.ShowDialog();

            // MessageBox.Show(milisekundy.ToString());
            try
            {
                timer2.Interval = milisekundy;
                akcia = 2;
                timer2.Start();
            }
            catch
            {
                //ak to len zavrieme
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.Show();
        }

        private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet.\r\nComming Soon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designer: Patuch\r\nCoder:mroziatko\r\nManager:Livuiq", "DogClock");
        }

        private void hybernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypnut hybernate = new Vypnut();
            hybernate.ShowDialog();
            try
            {
                timer2.Interval = milisekundy;
                akcia = 3;
                timer2.Start();
            }
            catch
            {
                //ak to len zavrieme
            }
        }

        private void sleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypnut hybernate = new Vypnut();
            hybernate.ShowDialog();
            try
            {
                timer2.Interval = milisekundy;
                akcia = 4;
                timer2.Start();
            }
            catch
            {
                //ak to len zavrieme
            }
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypnut hybernate = new Vypnut();
            hybernate.ShowDialog();
            try
            {
                timer2.Interval = milisekundy;
                akcia = 5;
                timer2.Start();
            }
            catch
            {
                //ak to len zavrieme
            }
        }

        

     


    }
}
