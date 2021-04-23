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
    public partial class msgBox_1 : Form
    {
        public msgBox_1()
        {
            InitializeComponent();
            this.Show();
        }

        private void goBack_Button_Click(object sender, EventArgs e)
        {
            Form1.ColourMessageResponse = 0;
            this.Close();
        }

        private void changeColour_Button_Click(object sender, EventArgs e)
        {
            Form1.ColourMessageResponse = 1;
            this.Close();
        }

        private void stop_Button_Click(object sender, EventArgs e)
        {
            Form1.ColourMessageResponse = 2;
            this.Close();
        }
    }
}
