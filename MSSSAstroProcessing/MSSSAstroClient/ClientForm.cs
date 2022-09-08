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
        private IAstroContract PipeProxy()
        {
            try
            {
                string address = "net.pipe://localhost/PipeMath";
                ChannelFactory<IAstroContract> pipeFactory =
                    new ChannelFactory<IAstroContract>(new NetNamedPipeBinding(), new EndpointAddress(address));
                return pipeFactory.CreateChannel();
            }
            catch
            {
                statusLabel.Text = "Connection failed.";
                return null;
            }

            //NetNamedPipeBinding binding = new NetNamedPipeBinding();
            //EndpointAddress ep = new EndpointAddress(address);
            //IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }

        private void DisplayCalculations()
        {
            listViewDisplay.Items.Clear();
            int count = 0;
            foreach (string calculation in calcList)
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
            if (pipeProxy != null && CheckTextBoxContents())
            {
                string velocity, distance, kelvin, horizon, infoStr;
                velocity = distance = kelvin = horizon = "None";

                if (IsValid(textBoxObserved, textBoxRest))
                    velocity = pipeProxy.StarVelocity(double.Parse(textBoxObserved.Text), double.Parse(textBoxRest.Text)).ToString();
                if (IsValid(textBoxDistance))
                    distance = pipeProxy.StarDistance(double.Parse(textBoxDistance.Text)).ToString();
                if (IsValid(textBoxKelvin))
                    kelvin = pipeProxy.TempKelvin(double.Parse(textBoxKelvin.Text)).ToString();
                if (IsValid(textBoxHorizon))
                    horizon = pipeProxy.EventHorizon(double.Parse(textBoxHorizon.Text)).ToString();

                infoStr = velocity + "," + distance + "," + kelvin + "," + horizon;
                if (!infoStr.Equals("None,None,None,None"))
                {
                    calcList.Add(infoStr);
                    DisplayCalculations();
                    statusLabel.Text = "Calculation Successful";
                }
                else
                    statusLabel.Text = "Incorrect input format! | Enter numeric values.";
                ClearTextBoxes();
                textBoxObserved.Text = "Observed:";
                textBoxRest.Text = "Rest:";
            }

        }
    
        
        #endregion

        #region Data Checking
        /// <summary>
        /// Checks if textbox contains appropriate input.
        /// </summary>
        /// <param name="textBox">TextBox control within the Form that will be checked for validity.</param>
        /// <returns>True or False boolean value</returns>
        private bool IsValid(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Equals("Observed:") && !textBox.Text.Equals("Rest:") && !textBox.Text.Equals("."))
                return true;
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
                foreach (TextBox textBox in grpBox.Controls)
                    if (!string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Equals("Observed:") && !textBox.Text.Equals("Rest:"))
                        return true;
                    else
                        continue;

            statusLabel.Text = "No input to calculate.";
            return false;
        }
        #endregion

        #region Form Utility
        /// <summary>
        /// Iterates through each of the controls inside the main groupBox.
        /// </summary>
        private void ClearTextBoxes()
        {
            foreach(GroupBox grpBox in groupBoxInput.Controls.OfType<GroupBox>())
                foreach (TextBox txtBox in grpBox.Controls)
                    txtBox.Clear();
        }

        private void PopulateLangComboBox()
        {
            string[] languages = new string[] {"eng", "fr-FR", "de-DE"};
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

        private void textBoxObserved_Enter(object sender, EventArgs e)
        {
            textBoxObserved.Clear();
        }

        private void textBoxRest_Enter(object sender, EventArgs e)
        {
            textBoxRest.Clear();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows one doouble values to be entered. Restrict values to one decimal point.
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar) 
                || (char.IsControl(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1));
            
            // Enable backspace
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        #endregion

        private void ClientForm_Load(object sender, EventArgs e)
        {
            PopulateLangComboBox(); 
        }

        private void buttonStyle_Click(object sender, EventArgs e)
        {
       
        }


    }
}
