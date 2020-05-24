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
    public partial class Agent : Form
    {
        public Agent()
        {
            InitializeComponent();
            ShowAgent();
        }

        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentSet.ID.ToString(), agentSet.FirstName, agentSet.MiddleName,
                    agentSet.LastName, agentSet.DealShare.ToString()
                });
                item.Tag = agentSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
            private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AgentSet agentSet = new AgentSet();
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
            Program.wftDb.AgentSet.Add(agentSet);
            Program.wftDb.SaveChanges();
            ShowAgent();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                Program.wftDb.SaveChanges();
                ShowAgent();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    Program.wftDb.AgentSet.Remove(agentSet);
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, так как эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxDealShare_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDealShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelLastName_Click(object sender, EventArgs e)
        {

        }

        private void LabelDealShare_Click(object sender, EventArgs e)
        {

        }
    }
}
