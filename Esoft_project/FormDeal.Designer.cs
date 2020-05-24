namespace Esoft_project
{
    partial class FormDeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeal));
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.labelSallerCompanyDeduction = new System.Windows.Forms.Label();
            this.labelAgentSallerDeduction = new System.Windows.Forms.Label();
            this.labelCustomerCompanyDeduction = new System.Windows.Forms.Label();
            this.labelAgentCustomerDeduction = new System.Windows.Forms.Label();
            this.textBoxSallerCompanyDeduction = new System.Windows.Forms.TextBox();
            this.textBoxAgentSallerDeduction = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCompanyDeduction = new System.Windows.Forms.TextBox();
            this.textBoxAgentCustomerDeduction = new System.Windows.Forms.TextBox();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.ClientSeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgentClientSeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientBuyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgentClientBuyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressRealEstate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSupply
            // 
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(34, 62);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(263, 23);
            this.comboBoxSupply.TabIndex = 0;
            this.comboBoxSupply.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSupply_SelectedIndexChanged);
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(34, 125);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(263, 23);
            this.comboBoxDemand.TabIndex = 1;
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDemand_SelectedIndexChanged);
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(30, 44);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(93, 15);
            this.labelSupply.TabIndex = 2;
            this.labelSupply.Text = "Предложения";
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Location = new System.Drawing.Point(30, 106);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(85, 15);
            this.labelDemand.TabIndex = 3;
            this.labelDemand.Text = "Потребность";
            // 
            // labelSallerCompanyDeduction
            // 
            this.labelSallerCompanyDeduction.AutoSize = true;
            this.labelSallerCompanyDeduction.Location = new System.Drawing.Point(30, 190);
            this.labelSallerCompanyDeduction.Name = "labelSallerCompanyDeduction";
            this.labelSallerCompanyDeduction.Size = new System.Drawing.Size(251, 15);
            this.labelSallerCompanyDeduction.TabIndex = 4;
            this.labelSallerCompanyDeduction.Text = "Стоимость услуг для клиента-продавца";
            // 
            // labelAgentSallerDeduction
            // 
            this.labelAgentSallerDeduction.AutoSize = true;
            this.labelAgentSallerDeduction.Location = new System.Drawing.Point(30, 240);
            this.labelAgentSallerDeduction.Name = "labelAgentSallerDeduction";
            this.labelAgentSallerDeduction.Size = new System.Drawing.Size(258, 15);
            this.labelAgentSallerDeduction.TabIndex = 5;
            this.labelAgentSallerDeduction.Text = "Отчисления риелтору клиента-продавца";
            // 
            // labelCustomerCompanyDeduction
            // 
            this.labelCustomerCompanyDeduction.AutoSize = true;
            this.labelCustomerCompanyDeduction.Location = new System.Drawing.Point(30, 313);
            this.labelCustomerCompanyDeduction.Name = "labelCustomerCompanyDeduction";
            this.labelCustomerCompanyDeduction.Size = new System.Drawing.Size(262, 15);
            this.labelCustomerCompanyDeduction.TabIndex = 6;
            this.labelCustomerCompanyDeduction.Text = "Стоимость услуг для клиента-покупателя";
            // 
            // labelAgentCustomerDeduction
            // 
            this.labelAgentCustomerDeduction.AutoSize = true;
            this.labelAgentCustomerDeduction.Location = new System.Drawing.Point(30, 362);
            this.labelAgentCustomerDeduction.Name = "labelAgentCustomerDeduction";
            this.labelAgentCustomerDeduction.Size = new System.Drawing.Size(269, 15);
            this.labelAgentCustomerDeduction.TabIndex = 7;
            this.labelAgentCustomerDeduction.Text = "Отчисления риелтору клиента-покупателя";
            // 
            // textBoxSallerCompanyDeduction
            // 
            this.textBoxSallerCompanyDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSallerCompanyDeduction.Location = new System.Drawing.Point(34, 209);
            this.textBoxSallerCompanyDeduction.Multiline = true;
            this.textBoxSallerCompanyDeduction.Name = "textBoxSallerCompanyDeduction";
            this.textBoxSallerCompanyDeduction.Size = new System.Drawing.Size(263, 27);
            this.textBoxSallerCompanyDeduction.TabIndex = 8;
            // 
            // textBoxAgentSallerDeduction
            // 
            this.textBoxAgentSallerDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAgentSallerDeduction.Location = new System.Drawing.Point(34, 258);
            this.textBoxAgentSallerDeduction.Multiline = true;
            this.textBoxAgentSallerDeduction.Name = "textBoxAgentSallerDeduction";
            this.textBoxAgentSallerDeduction.Size = new System.Drawing.Size(263, 27);
            this.textBoxAgentSallerDeduction.TabIndex = 9;
            // 
            // textBoxCustomerCompanyDeduction
            // 
            this.textBoxCustomerCompanyDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomerCompanyDeduction.Location = new System.Drawing.Point(34, 331);
            this.textBoxCustomerCompanyDeduction.Multiline = true;
            this.textBoxCustomerCompanyDeduction.Name = "textBoxCustomerCompanyDeduction";
            this.textBoxCustomerCompanyDeduction.Size = new System.Drawing.Size(263, 27);
            this.textBoxCustomerCompanyDeduction.TabIndex = 10;
            // 
            // textBoxAgentCustomerDeduction
            // 
            this.textBoxAgentCustomerDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAgentCustomerDeduction.Location = new System.Drawing.Point(34, 381);
            this.textBoxAgentCustomerDeduction.Multiline = true;
            this.textBoxAgentCustomerDeduction.Name = "textBoxAgentCustomerDeduction";
            this.textBoxAgentCustomerDeduction.Size = new System.Drawing.Size(263, 27);
            this.textBoxAgentCustomerDeduction.TabIndex = 11;
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientSeller,
            this.AgentClientSeller,
            this.ClientBuyer,
            this.AgentClientBuyer,
            this.AddressRealEstate,
            this.Price});
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(320, 62);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(961, 265);
            this.listViewDealSet.TabIndex = 12;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            this.listViewDealSet.SelectedIndexChanged += new System.EventHandler(this.ListViewDealSet_SelectedIndexChanged);
            // 
            // ClientSeller
            // 
            this.ClientSeller.Text = "Клиент-продавец";
            this.ClientSeller.Width = 130;
            // 
            // AgentClientSeller
            // 
            this.AgentClientSeller.Text = "Риелтор клиента-продавца";
            this.AgentClientSeller.Width = 194;
            // 
            // ClientBuyer
            // 
            this.ClientBuyer.Text = "Клиент-покупатель";
            this.ClientBuyer.Width = 142;
            // 
            // AgentClientBuyer
            // 
            this.AgentClientBuyer.Text = "Риелтор клиента-покупателя";
            this.AgentClientBuyer.Width = 196;
            // 
            // AddressRealEstate
            // 
            this.AddressRealEstate.Text = "Адрес объекта недвижимости";
            this.AddressRealEstate.Width = 206;
            // 
            // Price
            // 
            this.Price.Text = "Стоимость";
            this.Price.Width = 252;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(719, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(177, 52);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(912, 356);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(177, 52);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(1104, 356);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(177, 52);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 519);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.textBoxAgentCustomerDeduction);
            this.Controls.Add(this.textBoxCustomerCompanyDeduction);
            this.Controls.Add(this.textBoxAgentSallerDeduction);
            this.Controls.Add(this.textBoxSallerCompanyDeduction);
            this.Controls.Add(this.labelAgentCustomerDeduction);
            this.Controls.Add(this.labelCustomerCompanyDeduction);
            this.Controls.Add(this.labelAgentSallerDeduction);
            this.Controls.Add(this.labelSallerCompanyDeduction);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.comboBoxSupply);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSupply;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.Label labelSallerCompanyDeduction;
        private System.Windows.Forms.Label labelAgentSallerDeduction;
        private System.Windows.Forms.Label labelCustomerCompanyDeduction;
        private System.Windows.Forms.Label labelAgentCustomerDeduction;
        private System.Windows.Forms.TextBox textBoxSallerCompanyDeduction;
        private System.Windows.Forms.TextBox textBoxAgentSallerDeduction;
        private System.Windows.Forms.TextBox textBoxCustomerCompanyDeduction;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeduction;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader ClientSeller;
        private System.Windows.Forms.ColumnHeader AgentClientSeller;
        private System.Windows.Forms.ColumnHeader ClientBuyer;
        private System.Windows.Forms.ColumnHeader AgentClientBuyer;
        private System.Windows.Forms.ColumnHeader AddressRealEstate;
        private System.Windows.Forms.ColumnHeader Price;
    }
}