using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourInvestigatorCar
{
    public partial class msgBox_3 : Form
    {
        int timerCounter = 0;
        public msgBox_3()
        {
            InitializeComponent();
            this.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dangerLevelBar.Value = 5 - timerCounter;
            if (timerCounter == 5)
            {
                Form1.DangerMessageResponse = 0;
                this.Close();
            }
            timerCounter++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.DangerMessageResponse = 5 - timerCounter;
            this.Close();
        }
    }
}
