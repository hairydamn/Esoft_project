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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowDemands();
            ShowAgents();
            ShowClients();
        }
        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                string[] item = { agentSet.ID.ToString() + ".", agentSet.MiddleName };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (Client clientsSet in Program.wftDb.Client)
            {
                string[] item = { clientsSet.ID.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemands()
        {
            listViewApartment.Items.Clear();
            listViewHouse.Items.Clear();
            listViewLand.Items.Clear();

            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.IdAgent.ToString(), demand.IdClient.ToString(), demand.MinPrice.ToString(),
                        demand.MaxPrice.ToString(), demand.MinArea.ToString(), demand.MaxArea.ToString(),
                        demand.MinFloor.ToString(), demand.MaxFloor.ToString(), demand.MinRooms.ToString(),
                        demand.MaxRooms.ToString(),
                    });
                    item.Tag = demand;
                    listViewApartment.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.IdAgent.ToString(), demand.IdClient.ToString(), demand.MinPrice.ToString(),
                        demand.MaxPrice.ToString(), demand.MinArea.ToString(), demand.MaxArea.ToString(),
                        demand.MinFloors.ToString(), demand.MaxFloors.ToString(),
                    });
                    item.Tag = demand;
                    listViewHouse.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.IdAgent.ToString(), demand.IdClient.ToString(), demand.MinPrice.ToString(),
                        demand.MaxPrice.ToString(), demand.MinArea.ToString(), demand.MaxArea.ToString(),
                    });
                    item.Tag = demand;
                    listViewLand.Items.Add(item);
                }
            }
            listViewApartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxClient.SelectedItem != null && comboBoxType.SelectedItem != null)
            {
                DemandSet demand = new DemandSet();
                demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                if (comboBoxType.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    demand.Type = 1;
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                }
                else
                {
                    demand.Type = 2;
                }
                Program.wftDb.DemandSet.Add(demand);
                Program.wftDb.SaveChanges();
                ShowDemands();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewApartment.SelectedItems.Count == 1)
                {
                    DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                    demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                    demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemands();
                }
            }
            if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewHouse.SelectedItems.Count == 1)
                {
                    DemandSet demand = listViewHouse.SelectedItems[0].Tag as DemandSet;

                    demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                    demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                    demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemands();
                }
            }
            else
            {
                if (listViewLand.SelectedItems.Count == 1)
                {
                    DemandSet demand = listViewLand.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                    demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                    demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemands();
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewApartment.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemands();
                    }
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewHouse.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewHouse.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemands();
                    }
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else
                {
                    if (listViewLand.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewLand.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemands();
                    }
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewApartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApartment.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demand.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinRooms.Text = demand.MinRooms.ToString();
                textBoxMaxRooms.Text = demand.MaxRooms.ToString();
                textBoxMinFloor.Text = demand.MinFloor.ToString();
                textBoxMaxFloor.Text = demand.MaxFloor.ToString();
            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
        }

        private void ListViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewHouse.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demand.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinFloors.Text = demand.MinFloors.ToString();
                textBoxMaxFloors.Text = demand.MaxFloors.ToString();
            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void ListViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLand.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewLand.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demand.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
            }
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewApartment.Visible = true;
                labelMinPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinArea.Visible = true;
                labelMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMinFloor.Visible = true;
                labelMinFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMaxFloor.Visible = true;

                listViewHouse.Visible = false;
                listViewLand.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewHouse.Visible = true;
                labelMinPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinArea.Visible = true;
                labelMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;
                textBoxMinFloors.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMaxFloors.Visible = true;

                listViewApartment.Visible = false;
                listViewLand.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMaxRooms.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewLand.Visible = true;
                labelMinPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinArea.Visible = true;
                labelMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;

                listViewApartment.Visible = false;
                listViewHouse.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }

        private void ComboBoxAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMaxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMinPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMinArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMaxArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMinFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMaxFloor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
