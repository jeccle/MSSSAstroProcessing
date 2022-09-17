using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace MSSSAstroClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        List<string> calcList = new List<string>();

        #region Global Methods
        /// <summary>
        /// Opens connection to available endpoint specified in the address.
        /// A ChannelFactory is used to create a channel using the NetNamedPipeBinding and EndpointAddress specification.
        /// </summary>
        /// <returns>Returns ChannelFactory<IAstroContract> channel</IAstroContract></returns>
        private IAstroContract ChannelProxy()
        {   // Points to a section of memory which is the endpoint.
            try
            {
                string address = "net.pipe://localhost/PipeMath";
                //NetNamedPipeBinding binding = new NetNamedPipeBinding();
                //EndpointAddress ep = new EndpointAddress(address);
                //IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
                ChannelFactory<IAstroContract> channelPipe = new ChannelFactory<IAstroContract>(new NetNamedPipeBinding(), new EndpointAddress(address));
                IAstroContract channel = channelPipe.CreateChannel();
                // Attempts kelvin calculation to determine whether connection was successful.
                channel.TempKelvin(1);                                                                                                                                  Trace.WriteLine("Connection Successful");
                return channel;
            }
            catch
            {
                statusLabel.Text = "Connection failed.";                                                                                                                Trace.WriteLine("Connection failed.");
                return null;
            }
        }
        /// <summary>
        /// Displays all values within calcList into the listView control.
        /// </summary>
        private void DisplayCalculations()
        {
            listViewDisplay.Items.Clear();
            int count = 0;
            foreach (string calculation in calcList)
            {
                var item = new ListViewItem(count.ToString());
                count++;
                string[] row = calculation.Split(',');
                item.SubItems.Add(row[0]);
                item.SubItems.Add(row[1]);
                item.SubItems.Add(row[2]);
                item.SubItems.Add(row[3]);
                listViewDisplay.Items.Add(item);
            }
            Trace.WriteLine(count + " items added to listView.");
        }
        #endregion


        #region Button Click Methods
        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            if (CheckTextBoxContents())                         // Checks if the textboxes have input before attempting a connection.
            {                              
                IAstroContract channelProxy = ChannelProxy();   // Attempts connection,
                if (channelProxy != null) //  && CheckTextBoxContents()
                {
                    string velocity, distance, kelvin, horizon, infoStr;
                    velocity = distance = kelvin = horizon = "None";

                    if (IsValid(textBoxObserved, textBoxRest))
                        velocity = FormatInput("velocity", channelProxy.StarVelocity(double.Parse(textBoxObserved.Text), double.Parse(textBoxRest.Text)));              Trace.WriteLine("Calculation Successful\t| " + velocity);
                    if (IsValid(textBoxDistance))
                        distance = FormatInput("distance", channelProxy.StarDistance(double.Parse(textBoxDistance.Text)));                                              Trace.WriteLine("Calculation Successful\t| " + distance);
                    if (IsValid(textBoxKelvin))
                        kelvin = FormatInput("kelvin", channelProxy.TempKelvin(double.Parse(textBoxKelvin.Text)));                                                      Trace.WriteLine("Calculation Successful\t| " + kelvin);
                    if (IsValid(textBoxHorizon))
                        horizon = FormatInput("horizon", channelProxy.EventHorizon(double.Parse(textBoxHorizon.Text) * Math.Pow(10, (double)numWheelHorizon.Value)));   Trace.WriteLine("Calculation Successful\t| " + horizon);

                    infoStr = velocity + "," + distance + "," + kelvin + "," + horizon; // Values Split by ','
                    if (IsNull(infoStr))    // Checks if the value contains "None,None,None,None" string. (This can only occur inputting '.')
                        return;             // Exits code path.
                                            // If a value was successful it is added to the list of values.
                    calcList.Add(infoStr);
                    DisplayCalculations();
                    statusLabel.Text = "Calculation Successful";
                    
                }
                ClearTextBoxes();
            }
        }
        #endregion

        #region Data Checking
        private bool IsNull(string value)
        {
            if (value.Equals("None,None,None,None"))
            {
                statusLabel.Text = "Incorrect input format! | Enter numeric values.";                                                                                   Trace.WriteLine("Input is null. Input: " + value);
                ClearTextBoxes();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Checks if textbox contains appropriate input.
        /// </summary>
        /// <param name="textBox">TextBox control within the Form that will be checked for validity.</param>
        /// <returns>True or False boolean value</returns>
        private bool IsValid(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Equals("Observed:") && !textBox.Text.Equals("Rest:") && !textBox.Text.Equals("."))
                return true;                                                                                                                                            Trace.WriteLine("Valid textBox Input. Input: " + textBox.Text);
            return false;

        }
        private bool IsValid(TextBox textBoxObserved, TextBox textBoxRest)
        {
            if (IsValid(textBoxObserved) && IsValid(textBoxRest))
                return true;
            return false;
        }
        /// <summary>
        /// Iterates through all textboxes inside the groupBox. 
        /// If any contain a value true is returned, else it will continue and return false and a message prompt.
        /// </summary>
        /// <returns>Returns a true bool value if a text box contains user input. Else returns a false bool and message.</returns>
        private bool CheckTextBoxContents()
        {
            foreach (GroupBox grpBox in groupBoxInput.Controls.OfType<GroupBox>())
                foreach (TextBox textBox in grpBox.Controls.OfType<TextBox>())
                    if (!string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Equals("Observed:") && !textBox.Text.Equals("Rest:"))
                        return true;
                    else
                        continue;

            statusLabel.Text = "No input to calculate.";                                                                                                                Trace.WriteLine("No input found.");
            return false;
        }

        private string FormatInput(string calculationID, double value)
        {
            var result = "";
            switch (calculationID)
            {
                case "distance":
                    result = value.ToString("#.##");
                    break;

                case "horizon":
                    result = value.ToString("#.#") + "e-10";
                    break;

                case "kelvin":
                    result = value + " K";
                    break;

                case "velocity":
                    result = value + " V";
                    break;
                default:
                    break;
                   
            }
            return result;                                                                                                                                              
        }
        #endregion

        #region Form Utility
        /// <summary>
        /// Iterates through each of the controls inside the main groupBox.
        /// </summary>
        private void ClearTextBoxes()
        {
            foreach (GroupBox grpBox in groupBoxInput.Controls.OfType<GroupBox>())
                foreach (TextBox txtBox in grpBox.Controls.OfType<TextBox>())
                    txtBox.Clear();
            textBoxObserved.Text = "Observed:";
            textBoxRest.Text = "Rest:";
        }
        /// <summary>
        /// Populates the language group box control with three language types. English/French/German
        /// </summary>
        private void PopulateLangComboBox()
        {
            string[] languages = new string[] { "eng", "fr-FR", "de-DE" };
            foreach (var lang in languages)
                comboBoxLang.Items.Add(lang);
        }
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    //this.BackgroundImage = Properties.Resources.Flag_of_UK;
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
                    //this.BackgroundImage = Properties.Resources.Flag_of_France;
                    break;
                case "Spanish":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
                    //this.BackgroundImage = Properties.Resources.Flag_of_Spain;
                    break;
            }
        }
        private void textBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows double values to be entered. Restrict values to one decimal point.
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)
                || (char.IsControl(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1));

            // Enable backspace
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }
        private void textBoxKelvin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows double values to be entered. Restrict values to one decimal point.
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)
                || (char.IsControl(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1));

            // Enable backspace
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;

            if (!(sender as TextBox).Text.StartsWith("-") && e.KeyChar == '-' && string.IsNullOrEmpty((sender as TextBox).Text)) // Checks if beginning characters represent negative value.
                e.Handled = true;                                                                                                // Handled if it doesn't start with a negative operator.

            if (e.KeyChar == '-' && !(sender as TextBox).Text.StartsWith("-") && !char.IsDigit(e.KeyChar) && (sender as TextBox).Text.IndexOf('-') < -1 // Of
                || (string.IsNullOrEmpty((sender as TextBox).Text)) && (e.KeyChar == '-'))      // If textBox doesn't contain a '-' at the start and '-' is not within the string                    
                e.Handled = false;                                                              // If empty string minus sign is entered
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            PopulateLangComboBox();
        }




        #endregion

        private void buttonStyle_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialogBox.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            colorDialogBox.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialogBox.Color = groupBoxInput.ForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialogBox.ShowDialog() == DialogResult.OK)
                this.BackColor = groupBoxInput.BackColor = statusStrip1.BackColor =  colorDialogBox.Color;
            
        }
    }
}
