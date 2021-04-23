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
    public partial class msgBox_2 : Form
    {
        public msgBox_2()
        {
            InitializeComponent();
            this.Show();
        }

        private void newVelocity_Click(object sender, EventArgs e)
        {
            Form1.VelocityMessageResponse = tempVelocity.Value;
            
            this.Close();
        }

        private void exVelocity_Click(object sender, EventArgs e)
        {
            Form1.VelocityMessageResponse = 6;
            this.Close();
        }
    }
}
