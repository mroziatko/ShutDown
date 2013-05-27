using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vypinac
{
    public partial class Vypnut : Form
    {


        public Vypnut()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 23;
            numericUpDown1.Minimum = 0;
            numericUpDown2.Maximum = 59;
            numericUpDown2.Minimum = 0;
            numericUpDown3.Maximum = 59;
            numericUpDown3.Minimum = 0;
            comboBox1.SelectedIndex = 0;
           
        }
        private void Odomknutie()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hodiny = 0;
            int minuty = 0;
            int sekundy = 0;
            int miliseconds = 0;
                      
            //At Time
            if (comboBox1.SelectedIndex == 0)
            {
                DateTime teraz = new DateTime();
                teraz = DateTime.Now;

                if (teraz.Hour > (Convert.ToInt32(numericUpDown1.Value.ToString())))
                {
                    hodiny += 24 + (Convert.ToInt32(numericUpDown1.Value.ToString()));
                    hodiny -= teraz.Hour;                    
                }
                else
                {
                    hodiny = (Convert.ToInt32(numericUpDown1.Value.ToString())) - teraz.Hour;
                   
                }
                minuty = (Convert.ToInt32(numericUpDown2.Value.ToString())) - teraz.Minute;
                sekundy = (Convert.ToInt32(numericUpDown3.Value.ToString())) - teraz.Second;
                minuty += hodiny * 60; 
                sekundy += minuty * 60;               
                miliseconds = sekundy * 1000;
                
                Form1.milisekundy = miliseconds;
                   
            }
            //After Time
            if (comboBox1.SelectedIndex == 1)
            {
                hodiny = (Convert.ToInt32(numericUpDown1.Value.ToString())) ;
                minuty = (Convert.ToInt32(numericUpDown2.Value.ToString()));
                minuty += hodiny * 60;
                sekundy = (Convert.ToInt32(numericUpDown3.Value.ToString()));
                sekundy += minuty * 60;
                miliseconds = sekundy * 1000;
              
                Form1.milisekundy = miliseconds;  
            }

            this.Close();
        }

    }
}
