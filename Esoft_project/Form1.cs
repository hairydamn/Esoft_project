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
        }
        private void ButtonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void ButtonOpenAgents_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenRealEstates_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenDemands_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenSupplies_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenDeals_Click(object sender, EventArgs e)
        {

        }
    }
}
