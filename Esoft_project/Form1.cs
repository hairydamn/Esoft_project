using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormUsers.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Здравствуйте, " + FormUsers.users.login + "!";
        }
        private void ButtonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void ButtonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgentSet = new Agent();
            formAgentSet.Show();
        }

        private void ButtonOpenRealEstates_Click(object sender, EventArgs e)
        {
            Form formRealEstateSet = new RealEstate();
            formRealEstateSet.Show();
        }

        private void ButtonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void ButtonOpenSupplies_Click(object sender, EventArgs e)
        {
            Form formDemand = new FormDemand();
            formDemand.Show();
        }

        private void ButtonOpenDeals_Click(object sender, EventArgs e)
        {
            Form formDeal = new FormDeal();
            formDeal.Show();
                
        }
    }
}
