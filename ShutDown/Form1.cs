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
        DateTime time = new DateTime();
        int akcia = 0;
        public static int milisekundy = 0;
        

        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 1000;
            timer1.Start();
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
            mboShutdownParams["Flags"] = akcia;
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
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
                TimeSpan odpocet = TimeSpan.FromSeconds(milisekundy / 1000);
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


    }
}
