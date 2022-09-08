using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace MSSSAstroClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        List<string> astroCalculations = new List<string>();

        #region Global Methods
        private static IAstroContract PipeProxy()
        {
            string address = "net.pipe://localhost/PipeMath";
            ChannelFactory<IAstroContract> pipeFactory = 
                new ChannelFactory<IAstroContract>(new NetNamedPipeBinding(), new EndpointAddress(address));
            return pipeFactory.CreateChannel();
            //NetNamedPipeBinding binding = new NetNamedPipeBinding();
            //EndpointAddress ep = new EndpointAddress(address);
            //IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }

        private void DisplayCalculations()
        {
            listViewDisplay.Items.Clear();
            int count = 0;
            foreach (string calculation in astroCalculations)
            {
                ListViewItem item = new ListViewItem(count.ToString());
                count++;
                string[] row = calculation.Split(',');
                item.SubItems.Add(row[0]);
                item.SubItems.Add(row[1]);
                item.SubItems.Add(row[2]);
                item.SubItems.Add(row[3]);
                listViewDisplay.Items.Add(item);
            }
        }
        #endregion


        #region Button Click Methods
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            IAstroContract pipeProxy = PipeProxy();
            string velocity, distance, kelvin, horizon, infoStr;
            velocity = distance = kelvin = horizon = "None";

            if (IsValid(textBoxObserved) && IsValid(textBoxRest))
                velocity = pipeProxy.StarVelocity(double.Parse(textBoxObserved.Text), double.Parse(textBoxRest.Text)).ToString();
            if (IsValid(textBoxDistance))
                distance = pipeProxy.StarDistance(double.Parse(textBoxDistance.Text)).ToString();
            if (IsValid(textBoxKelvin))
                kelvin = pipeProxy.TempKelvin(double.Parse(textBoxKelvin.Text)).ToString();
            if (IsValid(textBoxHorizon))
                horizon = pipeProxy.EventHorizon(double.Parse(textBoxHorizon.Text)).ToString();

            infoStr = velocity + "," + distance + "," + kelvin + "," + horizon;
            astroCalculations.Add(infoStr);
            DisplayCalculations();
            ClearTextBoxes();
            statusLabel.Text = "Calculation Successful";
        }
        #endregion

        #region Data Checking
        // Checks if textbox contains appropriate input.
        private bool IsValid(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text.Equals("Observed:") || textBox.Text.Equals("Rest:"))
                return false;
            else
                return true;
        }
        // Checks strings for validity, maybe format the output here.
        private string CheckValue(string value)
        {   // Un-needed code as values default to 'None'
            if (value.Equals("null"))
                return "None";
            else
                return value;
        }
        #endregion

        #region Form Utility
        // Iterates through each of the controls inside the main groupBox.
        private void ClearTextBoxes()
        {
            foreach(GroupBox grpBox in groupBoxInput.Controls.OfType<GroupBox>())
                foreach (TextBox txtBox in grpBox.Controls)
                    txtBox.Clear();
        }
        private void textBoxObserved_Enter(object sender, EventArgs e)
        {
            textBoxObserved.Clear();
        }

        private void textBoxRest_Enter(object sender, EventArgs e)
        {
            textBoxRest.Clear();
        }

        #endregion
    }
}
