using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
                StatusMessage("connError");                                                                                    Trace.WriteLine("Connection failed.");
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
        /// <summary>
        /// Intializes connection to server and validates input within text boxes. Formats calcuation inputs
        /// and inserts calcuation into the listView and displays the calcuations.
        /// Displays appropriate status message.
        /// </summary>
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
                    StatusMessage("calcSuccess");
                    
                }
                ClearTextBoxes();
            }
        }
        // possibly add colour presets, aka themes.
        /// <summary>
        /// Adds colour picker control to change the colour of the form.
        /// Form text color is altered to contrast the background color.
        /// </summary>
        private void buttonStyle_Click(object sender, EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            colorDialogBox.AllowFullOpen = true;
            colorDialogBox.FullOpen = true;
            // Allows the user to get help. (The default is false.)
            colorDialogBox.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialogBox.Color = groupBoxControls.ForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialogBox.ShowDialog() == DialogResult.OK)
                this.BackColor = groupBoxControls.BackColor = statusStrip1.BackColor = colorDialogBox.Color;

            if (colorDialogBox.Color.R < 127 || colorDialogBox.Color.G < 127 || colorDialogBox.Color.B < 127)   // Could do with some improvements
            {
                SetTextColour("light");
            }
            else
                SetTextColour("dark");
            

        }
        /// <summary>
        /// Determines the current used language and uses switch case to output a specific messageType to the status lable in the asscoiated language.
        /// </summary>
        /// <param name="lang">CultureInfo Culture language type.</param>
        /// <param name="messageType">Type of status strip message.</param>
        private void StatusMessage(string messageType)
        {
            string lang = CultureInfo.CurrentUICulture.ToString();
            switch (messageType)
            {
                case "connError":
                    switch (lang)
                    {
                        case "en":
                            statusLabel.Text = "Connection failed.";
                            break;
                        case "fr":
                            statusLabel.Text = "La connexion a échoué.";
                            break;
                        case "de":
                            statusLabel.Text = "Verbindung fehlgeschlagen.";
                            break;
                    }
                    break;
                case "calcSuccess":
                    switch (lang)
                    {
                        case "en":
                            statusLabel.Text = "Calculation Successful.";
                            break;
                        case "fr":
                            statusLabel.Text = "Connexion réussie.";
                            break;
                        case "de":
                            statusLabel.Text = "Berechnung erfolgreich.";
                            break;
                    }
                    break;
                case "formatError":

                    switch (lang)
                    {
                        case "en":
                            statusLabel.Text = "Incorrect input format. | Enter numeric values.";
                            break;
                        case "fr":
                            statusLabel.Text = "Format d'entrée incorrect. | Saisissez des valeurs numériques.";
                            break;
                        case "de":
                            statusLabel.Text = "Falsches Eingabeformat. | Geben Sie numerische Werte ein.";
                            break;
                    }
                    break;
                case "inputError":
                    switch (lang)
                    {
                        case "en":
                            statusLabel.Text = "Incorrect input.";
                            break;
                        case "fr":
                            statusLabel.Text = "Erreur d'entrée.";
                            break;
                        case "de":
                            statusLabel.Text = "Eingabe Fehler.";
                            break;
                    }
                    break;
                case "noInputError":
                    switch (lang)
                    {
                        case "en":
                            statusLabel.Text = "No input.";
                            break;
                        case "fr":
                            statusLabel.Text = "Pas d'entrée.";
                            break;
                        case "de":
                            statusLabel.Text = "Keine Eingabe.";
                            break;
                    }
                    break;
                case "colourChanged":
                    switch (lang)
                    {
                        case "en":
                            statusLabel.Text = "Colours have been changed.";
                            break;
                        case "fr":
                            statusLabel.Text = "Les couleurs ont été changées.";
                            break;
                        case "de":
                            statusLabel.Text = "Farben wurden geändert.";
                            break;
                    }
                    break;
                case "incorrectChar":
                    switch (lang)
                    {
                        case "en":
                            statusLabel.Text = "Enter Numeric Values Only.";
                            break;
                        case "fr":
                            statusLabel.Text = "Saisir uniquement des valeurs numériques.";
                            break;
                        case "de":
                            statusLabel.Text = "Geben Sie nur numerische Werte ein.";
                            break;
                    }
                    break;
            }
        }
        #endregion

        #region Data Checking
        /// <summary>
        /// Checks if the value is a null/empty value.
        /// </summary>
        /// <param name="value">Value to be checked.</param>
        /// <returns>Boolean determining result of Check.</returns>
        private bool IsNull(string value)
        {
            if (value.Equals("None,None,None,None"))
            {
                StatusMessage("formatError");                                                                                  Trace.WriteLine("Input is null. Input: " + value);
                ClearTextBoxes();
                return true;
            } 
            else if (value.Equals("None,None,Null,None"))
            {
                StatusMessage("inputError");                                                                                   Trace.WriteLine("Input is null. Input: " + value);
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
            if (DefaultValuesExist(textBox) && !textBox.Text.Equals("."))
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
            foreach (GroupBox grpBox in groupBoxControls.Controls.OfType<GroupBox>())
                foreach (TextBox textBox in grpBox.Controls.OfType<TextBox>())
                    if (DefaultValuesExist(textBox))
                        return true;
                    else
                        continue;

            StatusMessage("noInputError");                                                                                       Trace.WriteLine("No input found.");
            return false;
        }
        /// <summary>
        /// Checks if the default load values are still present within the form.
        /// Checks for multiple languages are implemented.
        /// </summary>
        /// <param name="textBox">Input textbox to check for default values.</param>
        /// <returns>Boolean determining result of the check.</returns>
        private bool DefaultValuesExist(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Equals("Observed:") && !textBox.Text.Equals("Rest:")
                && !textBox.Text.Equals("Observé:") && !textBox.Text.Equals("Repos:")
                && !textBox.Text.Equals("Beobachtet:") && !textBox.Text.Equals("Sich ausruhen:"))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Formats the input based on which calculation is having its output formatted. Switch case statement is used to
        /// apply the appropriate formatting for each given calculation.
        /// </summary>
        /// <param name="calculationID">Calculation type</param>
        /// <param name="value">Double number value to format based on calcuation type.</param>
        /// <returns>Returns the formatted string.</returns>
        private string FormatInput(string calculationID, double value)
        {
            var result = "";
            switch (calculationID)
            {
                case "distance":
                    result = value.ToString("#.##" + " parsecs");
                    break;
                case "horizon":
                    result = value.ToString("F6") + "e-10m";
                    break;
                case "kelvin":
                    if (value < 0)
                    {
                        StatusMessage("inputError");
                        result = "Null";
                        break;
                    }
                    result = value + " K";
                    break;
                case "velocity":
                    result = value.ToString("#.##") + " m/s";
                    break;
                default:
                    break;
            }
            return result;                                                                                                                                              
        }
        #endregion

        #region Form Utility
        /// <summary>
        /// Sets the text for each of the controls to a light or dark mode.
        /// Changes text to black if the colour is lighter, and changes text to white if the colour is darker.
        /// </summary>
        /// <param name="mode"></param>
        private void SetTextColour(string mode)
        {
            var color = new System.Drawing.Color();
            if (mode == "light")
                color = System.Drawing.Color.White;
            else
                color = System.Drawing.Color.Black;

            foreach (GroupBox grpBox in this.Controls.OfType<GroupBox>())
            {
                grpBox.ForeColor = color;
                foreach (GroupBox subGrpBox in grpBox.Controls.OfType<GroupBox>())
                {
                    subGrpBox.ForeColor = color;
                    foreach (Label label in subGrpBox.Controls.OfType<Label>())
                        label.ForeColor = color;
                }
                foreach (Label label in grpBox.Controls.OfType<Label>())
                    label.ForeColor = color;
            }
            buttonStyle.ForeColor = System.Drawing.Color.Black;
        }
        /// <summary>
        /// Iterates through each of the controls inside the main groupBox.
        /// </summary>
        private void ClearTextBoxes()
        {
            foreach (GroupBox grpBox in groupBoxControls.Controls.OfType<GroupBox>())
                foreach (TextBox txtBox in grpBox.Controls.OfType<TextBox>())
                    txtBox.Clear();
            switch (CultureInfo.CurrentUICulture.ToString())
            {
                case "en":
                    textBoxObserved.Text = "Observed:";
                    textBoxRest.Text = "Rest:"; 
                    break;

                case "fr":
                    textBoxObserved.Text = "Observé:";
                    textBoxRest.Text = "Repos:";
                    break;

                case "de":
                    textBoxObserved.Text = "Beobachtet:";
                    textBoxRest.Text = "Sich ausruhen:";
                    break;
            }
            
        }
        /// <summary>
        /// Matches input language with switch case statements to set the current culture.
        /// Languages are altered through the combobox and accommodations for alternative languages are made.
        /// </summary>
        /// <param name="language">Specify language to select.</param>
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                // English
                default:
                case "English | EN":
                case "Englisch | EN":
                case "Anglais | EN":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    break;

                // French
                case "French | FR":
                case "Französisch | FR":
                case "Français | FR":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
                    break;

                // German
                case "German | DE":
                case "Deutsch | DE":
                case "Allemand | DE":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
                    break;
            }
            Controls.Clear();
            InitializeComponent();

        }
        /// <summary>
        /// Clear input as the textbox focus is entered.
        /// </summary>
        private void textBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
        }
        /// <summary>
        /// Keypress event restricts input text boxes to contain only numeric values and '.'.
        /// </summary>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows double values to be entered. Restrict values to one decimal point.
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)
                || (char.IsControl(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1));

            // Enable backspace
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;

            if (e.Handled)
                StatusMessage("incorrectChar");
        }
        /// <summary>
        /// Keypress event restricts input text boxes to contain only numeric values and '.'.
        /// Also has specific restrictions for the textBoxKelvin input box, allows for negatives, and only allows one '-' character at the start
        /// of the input.
        /// </summary>
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

            if ((string.IsNullOrEmpty((sender as TextBox).Text)) && (e.KeyChar == '-'))      // If textBox doesn't contain a '-' at the start and '-' is not within the string                    
                e.Handled = false;                                                              // If empty string minus sign is entered

            if (e.Handled)
                StatusMessage("incorrectChar");

        }
        /// <summary>
        /// Set default language on load.
        /// </summary>
        private void ClientForm_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }
        /// <summary>
        /// When the comboBox changes current value, the language of the form is changed accordingly.
        /// </summary>
        private void comboBoxLang_TextChanged(object sender, EventArgs e)
        {
            ChangeLanguage(comboBoxLang.Text);
        }

        #endregion


    }
}
