namespace Esoft_project
{
    partial class FormDemand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemand));
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.textBoxMinFloors = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloors = new System.Windows.Forms.TextBox();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewApartment = new System.Windows.Forms.ListView();
            this.Agent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHouse = new System.Windows.Forms.ListView();
            this.Client1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Agent1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPrice1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinArea1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxArea1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinFloors1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxFloors1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewLand = new System.Windows.Forms.ListView();
            this.Agent2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPrice2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinArea2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxArea2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(24, 84);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(141, 23);
            this.comboBoxAgent.TabIndex = 0;
            this.comboBoxAgent.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAgent_SelectedIndexChanged);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(189, 84);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(141, 23);
            this.comboBoxClient.TabIndex = 1;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClient_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(352, 84);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(175, 23);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinPrice.Location = new System.Drawing.Point(290, 151);
            this.textBoxMinPrice.Multiline = true;
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(202, 27);
            this.textBoxMinPrice.TabIndex = 3;
            this.textBoxMinPrice.TextChanged += new System.EventHandler(this.TextBoxMinPrice_TextChanged);
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxPrice.Location = new System.Drawing.Point(24, 151);
            this.textBoxMaxPrice.Multiline = true;
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(202, 27);
            this.textBoxMaxPrice.TabIndex = 4;
            this.textBoxMaxPrice.TextChanged += new System.EventHandler(this.TextBoxMaxPrice_TextChanged);
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinArea.Location = new System.Drawing.Point(24, 212);
            this.textBoxMinArea.Multiline = true;
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(202, 27);
            this.textBoxMinArea.TabIndex = 5;
            this.textBoxMinArea.TextChanged += new System.EventHandler(this.TextBoxMinArea_TextChanged);
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxArea.Location = new System.Drawing.Point(290, 212);
            this.textBoxMaxArea.Multiline = true;
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(202, 27);
            this.textBoxMaxArea.TabIndex = 6;
            this.textBoxMaxArea.TextChanged += new System.EventHandler(this.TextBoxMaxArea_TextChanged);
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinFloor.Location = new System.Drawing.Point(24, 282);
            this.textBoxMinFloor.Multiline = true;
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(202, 27);
            this.textBoxMinFloor.TabIndex = 7;
            this.textBoxMinFloor.TextChanged += new System.EventHandler(this.TextBoxMinFloor_TextChanged);
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxFloor.Location = new System.Drawing.Point(290, 282);
            this.textBoxMaxFloor.Multiline = true;
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(202, 27);
            this.textBoxMaxFloor.TabIndex = 8;
            this.textBoxMaxFloor.TextChanged += new System.EventHandler(this.TextBoxMaxFloor_TextChanged);
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.Location = new System.Drawing.Point(24, 282);
            this.textBoxMinFloors.Multiline = true;
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(202, 27);
            this.textBoxMinFloors.TabIndex = 9;
            this.textBoxMinFloors.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.Location = new System.Drawing.Point(290, 282);
            this.textBoxMaxFloors.Multiline = true;
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(202, 27);
            this.textBoxMaxFloors.TabIndex = 10;
            this.textBoxMaxFloors.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinRooms.Location = new System.Drawing.Point(24, 355);
            this.textBoxMinRooms.Multiline = true;
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(202, 27);
            this.textBoxMinRooms.TabIndex = 11;
            this.textBoxMinRooms.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxRooms.Location = new System.Drawing.Point(290, 355);
            this.textBoxMaxRooms.Multiline = true;
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(202, 27);
            this.textBoxMaxRooms.TabIndex = 12;
            this.textBoxMaxRooms.TextChanged += new System.EventHandler(this.TextBox10_TextChanged);
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(21, 65);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(58, 15);
            this.labelAgent.TabIndex = 13;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(185, 61);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(52, 15);
            this.labelClient.TabIndex = 14;
            this.labelClient.Text = "Клиент";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(348, 65);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(179, 15);
            this.labelType.TabIndex = 15;
            this.labelType.Text = "Тип объекта недвижимости";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(21, 132);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(129, 15);
            this.labelMinPrice.TabIndex = 16;
            this.labelMinPrice.Text = "Минимальная цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(287, 132);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(134, 15);
            this.labelMaxPrice.TabIndex = 17;
            this.labelMaxPrice.Text = "Максимальная цена";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(21, 191);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(155, 15);
            this.labelMinArea.TabIndex = 18;
            this.labelMinArea.Text = "Минимальная площадь";
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(287, 189);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(160, 15);
            this.labelMaxArea.TabIndex = 19;
            this.labelMaxArea.Text = "Максимальная площадь";
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Location = new System.Drawing.Point(21, 264);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(132, 15);
            this.labelMinFloor.TabIndex = 20;
            this.labelMinFloor.Text = "Минимальный этаж";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Location = new System.Drawing.Point(287, 264);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(137, 15);
            this.labelMaxFloor.TabIndex = 21;
            this.labelMaxFloor.Text = "Максимальный этаж";
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Location = new System.Drawing.Point(21, 264);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(186, 15);
            this.labelMinFloors.TabIndex = 22;
            this.labelMinFloors.Text = "Минимальное кол-во этажей";
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Location = new System.Drawing.Point(287, 261);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(191, 15);
            this.labelMaxFloors.TabIndex = 23;
            this.labelMaxFloors.Text = "Максимальное кол-во этажей";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Location = new System.Drawing.Point(21, 335);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(187, 15);
            this.labelMinRooms.TabIndex = 24;
            this.labelMinRooms.Text = "Минимальное кол-во комнат";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Location = new System.Drawing.Point(287, 336);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(192, 15);
            this.labelMaxRooms.TabIndex = 25;
            this.labelMaxRooms.Text = "Максимальное кол-во комнат";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(544, 422);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(198, 59);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(750, 422);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(198, 59);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(954, 422);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(198, 59);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // listViewApartment
            // 
            this.listViewApartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewApartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Agent,
            this.Client,
            this.MinPrice,
            this.MaxPrice,
            this.MinArea,
            this.MaxArea,
            this.MinFloor,
            this.MaxFloor,
            this.MinRooms,
            this.MaxRooms});
            this.listViewApartment.FullRowSelect = true;
            this.listViewApartment.GridLines = true;
            this.listViewApartment.HideSelection = false;
            this.listViewApartment.Location = new System.Drawing.Point(544, 51);
            this.listViewApartment.MultiSelect = false;
            this.listViewApartment.Name = "listViewApartment";
            this.listViewApartment.Size = new System.Drawing.Size(960, 351);
            this.listViewApartment.TabIndex = 29;
            this.listViewApartment.UseCompatibleStateImageBehavior = false;
            this.listViewApartment.View = System.Windows.Forms.View.Details;
            this.listViewApartment.SelectedIndexChanged += new System.EventHandler(this.ListViewApartment_SelectedIndexChanged);
            // 
            // Agent
            // 
            this.Agent.Text = "Риелтор";
            this.Agent.Width = 70;
            // 
            // Client
            // 
            this.Client.Text = "Клиент";
            // 
            // MinPrice
            // 
            this.MinPrice.Text = "Мин. Цена";
            this.MinPrice.Width = 83;
            // 
            // MaxPrice
            // 
            this.MaxPrice.Text = "Макс. Цена";
            this.MaxPrice.Width = 83;
            // 
            // MinArea
            // 
            this.MinArea.Text = "Мин. Площадь";
            this.MinArea.Width = 110;
            // 
            // MaxArea
            // 
            this.MaxArea.Text = "Макс. Площадь";
            this.MaxArea.Width = 111;
            // 
            // MinFloor
            // 
            this.MinFloor.Text = "Мин. Этаж";
            this.MinFloor.Width = 79;
            // 
            // MaxFloor
            // 
            this.MaxFloor.Text = "Макс. Этаж";
            this.MaxFloor.Width = 99;
            // 
            // MinRooms
            // 
            this.MinRooms.Text = "Мин. Кол-во комнат";
            this.MinRooms.Width = 118;
            // 
            // MaxRooms
            // 
            this.MaxRooms.Text = "Макс. Кол-во комнат";
            this.MaxRooms.Width = 144;
            // 
            // listViewHouse
            // 
            this.listViewHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Client1,
            this.Agent1,
            this.MinPrice1,
            this.MaxPrice1,
            this.MinArea1,
            this.MaxArea1,
            this.MinFloors1,
            this.MaxFloors1});
            this.listViewHouse.FullRowSelect = true;
            this.listViewHouse.GridLines = true;
            this.listViewHouse.HideSelection = false;
            this.listViewHouse.Location = new System.Drawing.Point(544, 51);
            this.listViewHouse.MultiSelect = false;
            this.listViewHouse.Name = "listViewHouse";
            this.listViewHouse.Size = new System.Drawing.Size(960, 284);
            this.listViewHouse.TabIndex = 30;
            this.listViewHouse.UseCompatibleStateImageBehavior = false;
            this.listViewHouse.View = System.Windows.Forms.View.Details;
            this.listViewHouse.SelectedIndexChanged += new System.EventHandler(this.ListViewHouse_SelectedIndexChanged);
            // 
            // Client1
            // 
            this.Client1.Text = "Клиент";
            // 
            // Agent1
            // 
            this.Agent1.Text = "Риелтор";
            // 
            // MinPrice1
            // 
            this.MinPrice1.Text = "Мин. Цена";
            this.MinPrice1.Width = 86;
            // 
            // MaxPrice1
            // 
            this.MaxPrice1.Text = "Макс. Цена";
            this.MaxPrice1.Width = 112;
            // 
            // MinArea1
            // 
            this.MinArea1.Text = "Мин. Площадь";
            this.MinArea1.Width = 115;
            // 
            // MaxArea1
            // 
            this.MaxArea1.Text = "Макс. Площадь";
            this.MaxArea1.Width = 145;
            // 
            // MinFloors1
            // 
            this.MinFloors1.Text = "Мин. Кол-во этажей";
            this.MinFloors1.Width = 185;
            // 
            // MaxFloors1
            // 
            this.MaxFloors1.Text = "Макс. Кол-во этажей";
            this.MaxFloors1.Width = 178;
            // 
            // listViewLand
            // 
            this.listViewLand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Agent2,
            this.Client2,
            this.MinPrice2,
            this.MaxPrice2,
            this.MinArea2,
            this.MaxArea2});
            this.listViewLand.FullRowSelect = true;
            this.listViewLand.GridLines = true;
            this.listViewLand.HideSelection = false;
            this.listViewLand.Location = new System.Drawing.Point(544, 51);
            this.listViewLand.MultiSelect = false;
            this.listViewLand.Name = "listViewLand";
            this.listViewLand.Size = new System.Drawing.Size(960, 284);
            this.listViewLand.TabIndex = 31;
            this.listViewLand.UseCompatibleStateImageBehavior = false;
            this.listViewLand.View = System.Windows.Forms.View.Details;
            this.listViewLand.SelectedIndexChanged += new System.EventHandler(this.ListViewLand_SelectedIndexChanged);
            // 
            // Agent2
            // 
            this.Agent2.Text = "Риелтор";
            this.Agent2.Width = 56;
            // 
            // Client2
            // 
            this.Client2.Text = "Клиент";
            this.Client2.Width = 116;
            // 
            // MinPrice2
            // 
            this.MinPrice2.Text = "Мин. Цена";
            this.MinPrice2.Width = 179;
            // 
            // MaxPrice2
            // 
            this.MaxPrice2.Text = "Макс. Цена";
            this.MaxPrice2.Width = 177;
            // 
            // MinArea2
            // 
            this.MinArea2.Text = "Мин. Площадь";
            this.MinArea2.Width = 154;
            // 
            // MaxArea2
            // 
            this.MaxArea2.Text = "Макс. Площадь";
            this.MaxArea2.Width = 331;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 519);
            this.Controls.Add(this.listViewApartment);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.textBoxMinArea);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.listViewHouse);
            this.Controls.Add(this.listViewLand);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.textBoxMinFloors);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDemand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.TextBox textBoxMinFloors;
        private System.Windows.Forms.TextBox textBoxMaxFloors;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewApartment;
        private System.Windows.Forms.ListView listViewHouse;
        private System.Windows.Forms.ListView listViewLand;
        private System.Windows.Forms.ColumnHeader Agent;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader MinPrice;
        private System.Windows.Forms.ColumnHeader MaxPrice;
        private System.Windows.Forms.ColumnHeader MinArea;
        private System.Windows.Forms.ColumnHeader MaxArea;
        private System.Windows.Forms.ColumnHeader MinFloor;
        private System.Windows.Forms.ColumnHeader MaxFloor;
        private System.Windows.Forms.ColumnHeader MinRooms;
        private System.Windows.Forms.ColumnHeader MaxRooms;
        private System.Windows.Forms.ColumnHeader Client1;
        private System.Windows.Forms.ColumnHeader Agent1;
        private System.Windows.Forms.ColumnHeader MinPrice1;
        private System.Windows.Forms.ColumnHeader MaxPrice1;
        private System.Windows.Forms.ColumnHeader MinArea1;
        private System.Windows.Forms.ColumnHeader MaxArea1;
        private System.Windows.Forms.ColumnHeader MinFloors1;
        private System.Windows.Forms.ColumnHeader MaxFloors1;
        private System.Windows.Forms.ColumnHeader Agent2;
        private System.Windows.Forms.ColumnHeader Client2;
        private System.Windows.Forms.ColumnHeader MinPrice2;
        private System.Windows.Forms.ColumnHeader MaxPrice2;
        private System.Windows.Forms.ColumnHeader MinArea2;
        private System.Windows.Forms.ColumnHeader MaxArea2;
    }
}