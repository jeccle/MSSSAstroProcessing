using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSSAstroClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            


        }

        private void buttonStarDistance_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Client Started");
            ChannelFactory<IAstroContract> pipeFactory =
            new ChannelFactory<IAstroContract>(
            new NetNamedPipeBinding(),
            new EndpointAddress("net.pipe://localhost/PipeMath"));
            IAstroContract pipeProxy = pipeFactory.CreateChannel();
            string infoStr = pipeProxy.StarVelocity(double.Parse(textBoxObserved.Text), double.Parse(textBoxRest.Text)).ToString();
            textBoxDisplay.Text = infoStr;
        }
    }
}
