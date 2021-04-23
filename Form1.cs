using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;



namespace ColourInvestigatorCar
{
    public partial class Form1 : Form
    {
        bool test = false;

        //public static custom form message responses
        public static int ColourMessageResponse = -1;
        public static int VelocityMessageResponse = -1;
        public static int DangerMessageResponse = -1;

        //Serial Data Variables
        string[] ports = SerialPort.GetPortNames();
        string UART_Data = " ";

        //Robot Variables
        int currentColour = 1;
        int[] colourVelocities = new int[3];

        //Flags
        bool lightFlag = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add existing serial ports to "SerialPorts" ComboBox
            foreach (string port in ports)
            {
                SerialPorts.Items.Add(port);
            }
        }


        //Main Program Starts Here
        //UART_Timer Timer
        private void UART_Timer_Tick(object sender, EventArgs e)
        {
            //Get UART Data and do stuff depending on it
            try
            {
                switch (UART_Data.Substring(0, 1))  
                {
                    //Status Case
                    case "S":
                        //Update Lights and Noise
                        LightsLabel.Text = "Lights\n%" + UART_Data.Substring(1, 2);
                        LightsPanel.BackColor = Color.FromArgb(55 + (Int32.Parse(UART_Data.Substring(1, 2)) * 2),  
                                                               55 + (Int32.Parse(UART_Data.Substring(1, 2)) * 2),
                                                                255);

                        NoiseLabel.Text = "Noise\n%" + UART_Data.Substring(3, 2);
                        NoisePanel.BackColor = Color.FromArgb(100,
                                                              200 - (Int32.Parse(UART_Data.Substring(3, 2)) * 1),
                                                              100);

                        UART_Rx_Label.Text = "UART Rx\n" + UART_Data.Substring(0, 5);

                        //Ask for Lights
                        if (Int32.Parse(UART_Data.Substring(1, 2)) > 15 && lightFlag) lightFlag = false;
                        if (Int32.Parse(UART_Data.Substring(1, 2)) < 15 && !lightFlag)
                            if ((lightFlag = true) &&
                                MessageBox.Show("Low enviroment lightning.\nWanna open lights?", "Low Light",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SerialPort.Write("L");
                                UART_Rx_Label.Text = "UART Rx\n" + "L";
                            }
                        break;

                    //ColourMessage case (msgBox_1)
                    case "M":
                        msgBox_1 ColourMessage = new msgBox_1();    //Show ColourMessage form
                                                                    //This object shows and destroys itself
                        currentColour = Int16.Parse(UART_Data.Substring(1, 1)); //Location Update
                        UART_Rx_Label.Text = "UART Rx\n" + "M" + UART_Data.Substring(1, 1);
                        break;

                    //VelocityMessage case (msgBox_2)
                    case "N":
                        msgBox_2 VeclocityMessage = new msgBox_2(); //Show ColourMessage form
                                                                    //This object shows and destroys itself
                        currentColour = Int16.Parse(UART_Data.Substring(1, 1)); //Location Update
                        UART_Rx_Label.Text = "UART Rx\n" + "N" + UART_Data.Substring(1, 1);
                        break;

                    //Danger Message Response (msgBox_3)
                    case "D":
                        msgBox_3 DangerMessage = new msgBox_3();    //Show ColourMessage form
                                                                    //This object shows and destroys itself
                        try     //Set DangerBar Value 
                        {
                            DangerBar.Value = Int16.Parse(UART_Rx_Label.Text.Substring(3, 2)) * 5;  
                        }   catch(Exception) { DangerBar.Value = 100; }
                        UART_Rx_Label.Text = "UART Rx\n" + "D";

                        break;
                }
            }
            catch (Exception) { }


            //Update Speed Indicators
            SpeedPanel.BackColor = Color.FromArgb(  255,
                                                    255 - (colourVelocities[currentColour] * 25 * 2 ),
                                                    255 - (colourVelocities[currentColour] * 25 * 2 ));
            SpeedLabel.Text = "Speed\n%" + (colourVelocities[currentColour] * 10 * 2).ToString();


            //Update Location Indicators
            try
            { 
                switch (currentColour)
                {
                    case 0:
                        Colour0_Button.BackColor = Color.White;
                        Colour1_Button.BackColor = Color.Gainsboro;
                        Colour2_Button.BackColor = Color.Gainsboro;
                        Colour0_Button.Text = "";
                        break;
                    case 1:
                        Colour0_Button.BackColor = Color.Gainsboro;
                        Colour1_Button.BackColor = Color.Black;
                        Colour2_Button.BackColor = Color.Gainsboro;
                        Colour1_Button.Text = "";
                        break;
                    case 2:
                        Colour0_Button.BackColor = Color.Gainsboro;
                        Colour1_Button.BackColor = Color.Gainsboro;
                        Colour2_Button.BackColor = Color.Purple;
                        Colour2_Button.Text = "";
                        break;
                    }
                    
            }
            catch { }

            //Custom Winform Responses (msgBox_1)
            if (ColourMessageResponse != -1)
            {
                SerialPort.Write(String.Format("A{0}", ColourMessageResponse));
                UART_Tx_Label.Text = "UART Tx\n" + "A" + ColourMessageResponse;
                ColourMessageResponse = -1;

            }

            //Custom Winform Responses (msgBox_2)
            if (VelocityMessageResponse != -1)
            {
                if (VelocityMessageResponse < 6) { 
                    switch (currentColour)      //Update Trackbars
                    {
                        case 0: Colour0_TrackBar.Value = VelocityMessageResponse; break;
                        case 1: Colour1_TrackBar.Value = VelocityMessageResponse; break;
                        case 2: Colour2_TrackBar.Value = VelocityMessageResponse; break;
                    }
                    colourVelocities[currentColour] = VelocityMessageResponse;
                    SerialPort.Write(String.Format("A{0}", VelocityMessageResponse));
                    UART_Tx_Label.Text = "UART Tx\n" + "A" + VelocityMessageResponse;

                }

                else
                SerialPort.Write("A-");
                UART_Tx_Label.Text = "UART Tx\n" + "A-";
                VelocityMessageResponse = -1;
            }

            //Custom Winform Responses (msgBox_3)
            if (DangerMessageResponse != -1)
            {
                //Update Velocities
                if (Colour0_TrackBar.Value + DangerMessageResponse > 5) Colour0_TrackBar.Value = 5;
                else Colour0_TrackBar.Value += DangerMessageResponse;
                colourVelocities[0] = Colour0_TrackBar.Value;

                if (Colour1_TrackBar.Value + DangerMessageResponse > 5) Colour1_TrackBar.Value = 5;
                else Colour1_TrackBar.Value += DangerMessageResponse;
                colourVelocities[1] = Colour0_TrackBar.Value;

                if (Colour2_TrackBar.Value + DangerMessageResponse > 5) Colour2_TrackBar.Value = 5;
                else Colour2_TrackBar.Value += DangerMessageResponse;
                colourVelocities[2] = Colour0_TrackBar.Value;

                SerialPort.Write(String.Format("D", ColourMessageResponse));
                DangerMessageResponse = -1;
            }

            //Reset UART_Data
            UART_Data = " ";
        }


    // trackbar value updates
    private void Colour0_TrackBar_Scroll(object sender, EventArgs e)
        {
            colourVelocities[0] = (int)Colour0_TrackBar.Value;
            if (SerialPort.IsOpen)
                SerialPort.Write(String.Format("V{0}{1}{2}", colourVelocities[0],
                                                             colourVelocities[1],
                                                             colourVelocities[2]));
            //Write to Tx Label
            UART_Tx_Label.Text = "UART Tx\n" + String.Format("V{0}{1}{2}", colourVelocities[0],
                                                                           colourVelocities[1],
                                                                           colourVelocities[2]);
        }
        private void Colour1_TrackBar_Scroll(object sender, EventArgs e)
        {
            colourVelocities[1] = (int)Colour1_TrackBar.Value;
            if (SerialPort.IsOpen)
                SerialPort.Write(String.Format("V{0}{1}{2}", colourVelocities[0],
                                                             colourVelocities[1],
                                                             colourVelocities[2]));
            //Write to Tx Label
            UART_Tx_Label.Text = "UART Tx\n" + String.Format("V{0}{1}{2}", colourVelocities[0],
                                                                           colourVelocities[1],
                                                                           colourVelocities[2]);
        }
        private void Colour2_TrackBar_Scroll(object sender, EventArgs e)
        {
            colourVelocities[2] = (int)Colour2_TrackBar.Value;
            if (SerialPort.IsOpen)
                SerialPort.Write(String.Format("V{0}{1}{2}", colourVelocities[0], 
                                                             colourVelocities[1],
                                                             colourVelocities[2]));
            //Write to Tx Label
            UART_Tx_Label.Text = "UART Tx\n" + String.Format("V{0}{1}{2}", colourVelocities[0],
                                                                           colourVelocities[1],
                                                                           colourVelocities[2]);
        }

        //Colour Buttons
        private void Colour0_Button_Click(object sender, EventArgs e)
        {
            if (currentColour != 0)
            {
                try
                {
                    SerialPort.Write("G0");
                    Colour0_Button.Text = "X";
                    Colour1_Button.Text = "";
                    Colour2_Button.Text = "";
                    UART_Tx_Label.Text = "UART Tx\nG0";
                }
                catch (Exception) { }
            }
        }

        private void Colour1_Button_Click(object sender, EventArgs e)
        {
                if (currentColour != 1)
                {
                    try
                    {
                        SerialPort.Write("G1");
                        Colour0_Button.Text = "";
                        Colour1_Button.Text = "X";
                        Colour2_Button.Text = "";
                        UART_Tx_Label.Text = "UART Tx\nG1";
                    }
                    catch (Exception) { }
                }
        } 

        private void Colour2_Button_Click(object sender, EventArgs e)
        {
            if (currentColour != 2)
            {
                try
                {
                    SerialPort.Write("G2");
                    Colour0_Button.Text = "";
                    Colour1_Button.Text = "";
                    Colour2_Button.Text = "X";
                    UART_Tx_Label.Text = "UART Tx\nG2";
                }
                catch (Exception) { }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Read UART Data and write on "UART_Rx_Label" Label
            //Check if COM Port is connected
            try
            {
                UART_Data = SerialPort.ReadExisting();
            }
            catch (Exception ReadEx)
            {
                SerialPort.Close();
                UART_Timer.Stop();
                MessageBox.Show(ReadEx.Message);
                return;
            }
        }

        //SerialPorts Combobox
        private void SerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check for SerialPorts ComboBox select is not empty
            if (SerialPorts.Text == "") return;

            //Close serial port and reconnect
            SerialPort.Close();
            UART_Timer.Stop();

            SerialPort.PortName = (string)SerialPorts.Text;
            SerialPort.BaudRate = 9600;

            try
            {
                UART_Timer.Start();
                SerialPort.Open();
                Colour0_Button.BackColor = Color.White;
            }
            catch (Exception UART_Ex)
            {
                MessageBox.Show("Error" + UART_Ex.Message);
            }
        }

        //ReScan Com Ports
        private void ReScan_Button_Click(object sender, EventArgs e)
        {
            SerialPorts.Items.Clear();
            SerialPort.Close();
            UART_Timer.Stop();

            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                SerialPorts.Items.Add(port);
                SerialPorts.SelectedIndex = -1;
                SerialPorts.Text = "Select COM Port";
            }
        }
    }
}

