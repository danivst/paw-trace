namespace PawTrace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Tab = new TabControl();
			lostTab = new TabPage();
			boxLostSpecies = new ComboBox();
			boxLostGender = new ComboBox();
			buttonLostImage = new Button();
			pictureBoxLost = new PictureBox();
			buttonSaveLost = new Button();
			lblLostDesc = new Label();
			lblLostGender = new Label();
			lblLostSpecies = new Label();
			lblLostLocation = new Label();
			lblDateLost = new Label();
			lblLostBreed = new Label();
			lblLostColour = new Label();
			lblLostAge = new Label();
			lblLostName = new Label();
			lblLostTitle = new Label();
			txtLostDesc = new TextBox();
			txtLostLocation = new TextBox();
			txtDateLost = new TextBox();
			txtLostBreed = new TextBox();
			txtLostColour = new TextBox();
			txtLostAge = new TextBox();
			txtLostName = new TextBox();
			lostAllTab = new TabPage();
			dataGridViewLostAll = new DataGridView();
			lblLostAllTitle = new Label();
			buttonLostSearch = new Button();
			boxLostAllSpecies = new ComboBox();
			boxLostAllGender = new ComboBox();
			lblLostAllGender = new Label();
			lblLostAllSpecies = new Label();
			lblLostAllLocation = new Label();
			lblDateFoundAll = new Label();
			label2 = new Label();
			lblLostAllBreed = new Label();
			lblLostAllColour = new Label();
			lblLostAllAge = new Label();
			lblLostAllName = new Label();
			txtLostAllLocation = new TextBox();
			txtDateFoundAll = new TextBox();
			txtLostAllBreed = new TextBox();
			txtLostAllColour = new TextBox();
			txtLostAllAge = new TextBox();
			txtLostAllName = new TextBox();
			foundAllTab = new TabPage();
			dataGridViewFoundAll = new DataGridView();
			lblFoundAllTitle = new Label();
			buttonFoundSearch = new Button();
			boxFoundAllSpecies = new ComboBox();
			boxFoundAllGender = new ComboBox();
			lblFoundAllGender = new Label();
			lblFoundAllSpecies = new Label();
			lblFoundAllLocation = new Label();
			lblDateLostAll = new Label();
			lblFoundAllBreed = new Label();
			lblFoundAllColour = new Label();
			lblFoundAllAge = new Label();
			lblFoundAllName = new Label();
			txtFoundAllLocation = new TextBox();
			txtDateLostAll = new TextBox();
			txtFoundAllBreed = new TextBox();
			txtFoundAllColour = new TextBox();
			txtFoundAllAge = new TextBox();
			txtFoundAllName = new TextBox();
			foundTab = new TabPage();
			lblDateFound = new Label();
			txtDateFound = new TextBox();
			boxFoundSpecies = new ComboBox();
			boxFoundGender = new ComboBox();
			buttonImageFound = new Button();
			pictureBoxFound = new PictureBox();
			buttonSaveFound = new Button();
			lblFoundDesc = new Label();
			lblFoundGender = new Label();
			lblFoundSpecies = new Label();
			lblFoundLocation = new Label();
			lblFoundBreed = new Label();
			lblFoundColour = new Label();
			lblFoundAge = new Label();
			lblFoundName = new Label();
			lblFoundTitle = new Label();
			txtFoundDesc = new TextBox();
			txtFoundLocation = new TextBox();
			txtFoundBreed = new TextBox();
			txtFoundColour = new TextBox();
			txtFoundAge = new TextBox();
			txtFoundName = new TextBox();
			Tab.SuspendLayout();
			lostTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxLost).BeginInit();
			lostAllTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewLostAll).BeginInit();
			foundAllTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewFoundAll).BeginInit();
			foundTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFound).BeginInit();
			SuspendLayout();
			// 
			// Tab
			// 
			Tab.Controls.Add(lostTab);
			Tab.Controls.Add(lostAllTab);
			Tab.Controls.Add(foundAllTab);
			Tab.Controls.Add(foundTab);
			Tab.Location = new Point(-5, 1);
			Tab.Name = "Tab";
			Tab.SelectedIndex = 0;
			Tab.Size = new Size(1119, 695);
			Tab.TabIndex = 0;
			Tab.SelectedIndexChanged += lostTab_SelectedIndexChanged;
			// 
			// lostTab
			// 
			lostTab.BackColor = Color.AntiqueWhite;
			lostTab.Controls.Add(boxLostSpecies);
			lostTab.Controls.Add(boxLostGender);
			lostTab.Controls.Add(buttonLostImage);
			lostTab.Controls.Add(pictureBoxLost);
			lostTab.Controls.Add(buttonSaveLost);
			lostTab.Controls.Add(lblLostDesc);
			lostTab.Controls.Add(lblLostGender);
			lostTab.Controls.Add(lblLostSpecies);
			lostTab.Controls.Add(lblLostLocation);
			lostTab.Controls.Add(lblDateLost);
			lostTab.Controls.Add(lblLostBreed);
			lostTab.Controls.Add(lblLostColour);
			lostTab.Controls.Add(lblLostAge);
			lostTab.Controls.Add(lblLostName);
			lostTab.Controls.Add(lblLostTitle);
			lostTab.Controls.Add(txtLostDesc);
			lostTab.Controls.Add(txtLostLocation);
			lostTab.Controls.Add(txtDateLost);
			lostTab.Controls.Add(txtLostBreed);
			lostTab.Controls.Add(txtLostColour);
			lostTab.Controls.Add(txtLostAge);
			lostTab.Controls.Add(txtLostName);
			lostTab.ForeColor = Color.Black;
			lostTab.Location = new Point(4, 29);
			lostTab.Name = "lostTab";
			lostTab.Padding = new Padding(3);
			lostTab.Size = new Size(1111, 662);
			lostTab.TabIndex = 0;
			lostTab.Text = "Add a lost animal";
			// 
			// boxLostSpecies
			// 
			boxLostSpecies.FormattingEnabled = true;
			boxLostSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
			boxLostSpecies.Location = new Point(483, 136);
			boxLostSpecies.Name = "boxLostSpecies";
			boxLostSpecies.Size = new Size(151, 28);
			boxLostSpecies.TabIndex = 25;
			// 
			// boxLostGender
			// 
			boxLostGender.FormattingEnabled = true;
			boxLostGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
			boxLostGender.Location = new Point(483, 220);
			boxLostGender.Name = "boxLostGender";
			boxLostGender.Size = new Size(151, 28);
			boxLostGender.TabIndex = 24;
			boxLostGender.SelectedIndexChanged += boxLostGender_SelectedIndexChanged;
			// 
			// buttonLostImage
			// 
			buttonLostImage.BackColor = Color.FromArgb(114, 125, 113);
			buttonLostImage.Font = new Font("Segoe UI", 10F);
			buttonLostImage.ForeColor = Color.White;
			buttonLostImage.Location = new Point(827, 136);
			buttonLostImage.Margin = new Padding(3, 4, 3, 4);
			buttonLostImage.Name = "buttonLostImage";
			buttonLostImage.Size = new Size(202, 57);
			buttonLostImage.TabIndex = 23;
			buttonLostImage.Text = "Upload an image";
			buttonLostImage.UseVisualStyleBackColor = false;
			buttonLostImage.Click += buttonLostImage_Click;
			// 
			// pictureBoxLost
			// 
			pictureBoxLost.Location = new Point(774, 220);
			pictureBoxLost.Margin = new Padding(3, 4, 3, 4);
			pictureBoxLost.Name = "pictureBoxLost";
			pictureBoxLost.Size = new Size(296, 359);
			pictureBoxLost.TabIndex = 22;
			pictureBoxLost.TabStop = false;
			// 
			// buttonSaveLost
			// 
			buttonSaveLost.BackColor = Color.FromArgb(114, 125, 113);
			buttonSaveLost.Font = new Font("Segoe UI", 10F);
			buttonSaveLost.ForeColor = Color.White;
			buttonSaveLost.Location = new Point(865, 595);
			buttonSaveLost.Margin = new Padding(3, 4, 3, 4);
			buttonSaveLost.Name = "buttonSaveLost";
			buttonSaveLost.Size = new Size(123, 46);
			buttonSaveLost.TabIndex = 21;
			buttonSaveLost.Text = "Save";
			buttonSaveLost.UseVisualStyleBackColor = false;
			buttonSaveLost.Click += buttonSaveLost_Click;
			// 
			// lblLostDesc
			// 
			lblLostDesc.AutoSize = true;
			lblLostDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostDesc.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostDesc.Location = new Point(359, 310);
			lblLostDesc.Name = "lblLostDesc";
			lblLostDesc.Size = new Size(89, 20);
			lblLostDesc.TabIndex = 20;
			lblLostDesc.Text = "Description";
			// 
			// lblLostGender
			// 
			lblLostGender.AutoSize = true;
			lblLostGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostGender.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostGender.Location = new Point(359, 228);
			lblLostGender.Name = "lblLostGender";
			lblLostGender.Size = new Size(67, 20);
			lblLostGender.TabIndex = 18;
			lblLostGender.Text = "Gender*";
			// 
			// lblLostSpecies
			// 
			lblLostSpecies.AutoSize = true;
			lblLostSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostSpecies.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostSpecies.Location = new Point(359, 140);
			lblLostSpecies.Name = "lblLostSpecies";
			lblLostSpecies.Size = new Size(67, 20);
			lblLostSpecies.TabIndex = 17;
			lblLostSpecies.Text = "Species*";
			// 
			// lblLostLocation
			// 
			lblLostLocation.AutoSize = true;
			lblLostLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostLocation.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostLocation.Location = new Point(39, 559);
			lblLostLocation.Name = "lblLostLocation";
			lblLostLocation.Size = new Size(76, 20);
			lblLostLocation.TabIndex = 16;
			lblLostLocation.Text = "Location*";
			// 
			// lblDateLost
			// 
			lblDateLost.AutoSize = true;
			lblDateLost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblDateLost.ForeColor = Color.FromArgb(109, 76, 61);
			lblDateLost.Location = new Point(39, 465);
			lblDateLost.Name = "lblDateLost";
			lblDateLost.Size = new Size(83, 20);
			lblDateLost.TabIndex = 15;
			lblDateLost.Text = "Date Lost*";
			// 
			// lblLostBreed
			// 
			lblLostBreed.AutoSize = true;
			lblLostBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostBreed.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostBreed.Location = new Point(39, 387);
			lblLostBreed.Name = "lblLostBreed";
			lblLostBreed.Size = new Size(50, 20);
			lblLostBreed.TabIndex = 14;
			lblLostBreed.Text = "Breed";
			// 
			// lblLostColour
			// 
			lblLostColour.AutoSize = true;
			lblLostColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostColour.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostColour.Location = new Point(39, 310);
			lblLostColour.Name = "lblLostColour";
			lblLostColour.Size = new Size(62, 20);
			lblLostColour.TabIndex = 13;
			lblLostColour.Text = "Colour*";
			lblLostColour.Click += lblLostColour_Click;
			// 
			// lblLostAge
			// 
			lblLostAge.AutoSize = true;
			lblLostAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAge.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAge.Location = new Point(39, 228);
			lblLostAge.Name = "lblLostAge";
			lblLostAge.Size = new Size(37, 20);
			lblLostAge.TabIndex = 12;
			lblLostAge.Text = "Age";
			// 
			// lblLostName
			// 
			lblLostName.AutoSize = true;
			lblLostName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostName.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostName.Location = new Point(39, 144);
			lblLostName.Name = "lblLostName";
			lblLostName.Size = new Size(58, 20);
			lblLostName.TabIndex = 11;
			lblLostName.Text = "Name*";
			// 
			// lblLostTitle
			// 
			lblLostTitle.AutoSize = true;
			lblLostTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
			lblLostTitle.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostTitle.Location = new Point(359, 32);
			lblLostTitle.Name = "lblLostTitle";
			lblLostTitle.Size = new Size(409, 63);
			lblLostTitle.TabIndex = 10;
			lblLostTitle.Text = "Have you lost your pet?";
			lblLostTitle.Click += label1_Click;
			// 
			// txtLostDesc
			// 
			txtLostDesc.Location = new Point(359, 351);
			txtLostDesc.Margin = new Padding(3, 4, 3, 4);
			txtLostDesc.Multiline = true;
			txtLostDesc.Name = "txtLostDesc";
			txtLostDesc.Size = new Size(348, 228);
			txtLostDesc.TabIndex = 9;
			// 
			// txtLostLocation
			// 
			txtLostLocation.Location = new Point(131, 552);
			txtLostLocation.Margin = new Padding(3, 4, 3, 4);
			txtLostLocation.Name = "txtLostLocation";
			txtLostLocation.Size = new Size(153, 27);
			txtLostLocation.TabIndex = 5;
			txtLostLocation.TextChanged += textBox6_TextChanged;
			// 
			// txtDateLost
			// 
			txtDateLost.Location = new Point(131, 465);
			txtDateLost.Margin = new Padding(3, 4, 3, 4);
			txtDateLost.Name = "txtDateLost";
			txtDateLost.Size = new Size(153, 27);
			txtDateLost.TabIndex = 4;
			// 
			// txtLostBreed
			// 
			txtLostBreed.Location = new Point(131, 380);
			txtLostBreed.Margin = new Padding(3, 4, 3, 4);
			txtLostBreed.Name = "txtLostBreed";
			txtLostBreed.Size = new Size(153, 27);
			txtLostBreed.TabIndex = 3;
			// 
			// txtLostColour
			// 
			txtLostColour.Location = new Point(131, 303);
			txtLostColour.Margin = new Padding(3, 4, 3, 4);
			txtLostColour.Name = "txtLostColour";
			txtLostColour.Size = new Size(153, 27);
			txtLostColour.TabIndex = 2;
			// 
			// txtLostAge
			// 
			txtLostAge.Location = new Point(131, 221);
			txtLostAge.Margin = new Padding(3, 4, 3, 4);
			txtLostAge.Name = "txtLostAge";
			txtLostAge.Size = new Size(153, 27);
			txtLostAge.TabIndex = 1;
			// 
			// txtLostName
			// 
			txtLostName.Location = new Point(131, 137);
			txtLostName.Margin = new Padding(3, 4, 3, 4);
			txtLostName.Name = "txtLostName";
			txtLostName.Size = new Size(153, 27);
			txtLostName.TabIndex = 0;
			// 
			// lostAllTab
			// 
			lostAllTab.BackColor = Color.AntiqueWhite;
			lostAllTab.Controls.Add(dataGridViewLostAll);
			lostAllTab.Controls.Add(lblLostAllTitle);
			lostAllTab.Controls.Add(buttonLostSearch);
			lostAllTab.Controls.Add(boxLostAllSpecies);
			lostAllTab.Controls.Add(boxLostAllGender);
			lostAllTab.Controls.Add(lblLostAllGender);
			lostAllTab.Controls.Add(lblLostAllSpecies);
			lostAllTab.Controls.Add(lblLostAllLocation);
			lostAllTab.Controls.Add(lblDateFoundAll);
			lostAllTab.Controls.Add(label2);
			lostAllTab.Controls.Add(lblLostAllBreed);
			lostAllTab.Controls.Add(lblLostAllColour);
			lostAllTab.Controls.Add(lblLostAllAge);
			lostAllTab.Controls.Add(lblLostAllName);
			lostAllTab.Controls.Add(txtLostAllLocation);
			lostAllTab.Controls.Add(txtDateFoundAll);
			lostAllTab.Controls.Add(txtLostAllBreed);
			lostAllTab.Controls.Add(txtLostAllColour);
			lostAllTab.Controls.Add(txtLostAllAge);
			lostAllTab.Controls.Add(txtLostAllName);
			lostAllTab.Location = new Point(4, 29);
			lostAllTab.Name = "lostAllTab";
			lostAllTab.Padding = new Padding(3);
			lostAllTab.Size = new Size(1111, 662);
			lostAllTab.TabIndex = 1;
			lostAllTab.Text = "View lost animals";
			// 
			// dataGridViewLostAll
			// 
			dataGridViewLostAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewLostAll.Location = new Point(340, 88);
			dataGridViewLostAll.Margin = new Padding(3, 4, 3, 4);
			dataGridViewLostAll.Name = "dataGridViewLostAll";
			dataGridViewLostAll.RowHeadersWidth = 51;
			dataGridViewLostAll.Size = new Size(728, 477);
			dataGridViewLostAll.TabIndex = 1;
			// 
			// lblLostAllTitle
			// 
			lblLostAllTitle.AutoSize = true;
			lblLostAllTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
			lblLostAllTitle.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllTitle.Location = new Point(616, 21);
			lblLostAllTitle.Name = "lblLostAllTitle";
			lblLostAllTitle.Size = new Size(169, 63);
			lblLostAllTitle.TabIndex = 38;
			lblLostAllTitle.Text = "Lost Pets";
			// 
			// buttonLostSearch
			// 
			buttonLostSearch.BackColor = Color.FromArgb(114, 125, 113);
			buttonLostSearch.Font = new Font("Segoe UI", 10F);
			buttonLostSearch.ForeColor = Color.White;
			buttonLostSearch.Location = new Point(340, 595);
			buttonLostSearch.Margin = new Padding(3, 4, 3, 4);
			buttonLostSearch.Name = "buttonLostSearch";
			buttonLostSearch.Size = new Size(123, 46);
			buttonLostSearch.TabIndex = 37;
			buttonLostSearch.Text = "Search";
			buttonLostSearch.UseVisualStyleBackColor = false;
			// 
			// boxLostAllSpecies
			// 
			boxLostAllSpecies.FormattingEnabled = true;
			boxLostAllSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
			boxLostAllSpecies.Location = new Point(129, 537);
			boxLostAllSpecies.Name = "boxLostAllSpecies";
			boxLostAllSpecies.Size = new Size(151, 28);
			boxLostAllSpecies.TabIndex = 36;
			// 
			// boxLostAllGender
			// 
			boxLostAllGender.FormattingEnabled = true;
			boxLostAllGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
			boxLostAllGender.Location = new Point(129, 613);
			boxLostAllGender.Name = "boxLostAllGender";
			boxLostAllGender.Size = new Size(151, 28);
			boxLostAllGender.TabIndex = 35;
			// 
			// lblLostAllGender
			// 
			lblLostAllGender.AutoSize = true;
			lblLostAllGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAllGender.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllGender.Location = new Point(37, 621);
			lblLostAllGender.Name = "lblLostAllGender";
			lblLostAllGender.Size = new Size(67, 20);
			lblLostAllGender.TabIndex = 34;
			lblLostAllGender.Text = "Gender*";
			// 
			// lblLostAllSpecies
			// 
			lblLostAllSpecies.AutoSize = true;
			lblLostAllSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAllSpecies.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllSpecies.Location = new Point(37, 545);
			lblLostAllSpecies.Name = "lblLostAllSpecies";
			lblLostAllSpecies.Size = new Size(67, 20);
			lblLostAllSpecies.TabIndex = 33;
			lblLostAllSpecies.Text = "Species*";
			// 
			// lblLostAllLocation
			// 
			lblLostAllLocation.AutoSize = true;
			lblLostAllLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAllLocation.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllLocation.Location = new Point(37, 475);
			lblLostAllLocation.Name = "lblLostAllLocation";
			lblLostAllLocation.Size = new Size(76, 20);
			lblLostAllLocation.TabIndex = 32;
			lblLostAllLocation.Text = "Location*";
			// 
			// lblDateFoundAll
			// 
			lblDateFoundAll.AutoSize = true;
			lblDateFoundAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblDateFoundAll.ForeColor = Color.FromArgb(109, 76, 61);
			lblDateFoundAll.Location = new Point(37, 390);
			lblDateFoundAll.Name = "lblDateFoundAll";
			lblDateFoundAll.Size = new Size(60, 40);
			lblDateFoundAll.TabIndex = 31;
			lblDateFoundAll.Text = " Date\r\nFound*";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(109, 76, 61);
			label2.Location = new Point(37, 390);
			label2.Name = "label2";
			label2.Size = new Size(60, 40);
			label2.TabIndex = 31;
			label2.Text = " Date\r\nFound*";
			// 
			// lblLostAllBreed
			// 
			lblLostAllBreed.AutoSize = true;
			lblLostAllBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAllBreed.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllBreed.Location = new Point(37, 315);
			lblLostAllBreed.Name = "lblLostAllBreed";
			lblLostAllBreed.Size = new Size(50, 20);
			lblLostAllBreed.TabIndex = 30;
			lblLostAllBreed.Text = "Breed";
			// 
			// lblLostAllColour
			// 
			lblLostAllColour.AutoSize = true;
			lblLostAllColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAllColour.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllColour.Location = new Point(37, 242);
			lblLostAllColour.Name = "lblLostAllColour";
			lblLostAllColour.Size = new Size(62, 20);
			lblLostAllColour.TabIndex = 29;
			lblLostAllColour.Text = "Colour*";
			// 
			// lblLostAllAge
			// 
			lblLostAllAge.AutoSize = true;
			lblLostAllAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAllAge.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllAge.Location = new Point(37, 172);
			lblLostAllAge.Name = "lblLostAllAge";
			lblLostAllAge.Size = new Size(37, 20);
			lblLostAllAge.TabIndex = 28;
			lblLostAllAge.Text = "Age";
			// 
			// lblLostAllName
			// 
			lblLostAllName.AutoSize = true;
			lblLostAllName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblLostAllName.ForeColor = Color.FromArgb(109, 76, 61);
			lblLostAllName.Location = new Point(37, 95);
			lblLostAllName.Name = "lblLostAllName";
			lblLostAllName.Size = new Size(51, 20);
			lblLostAllName.TabIndex = 27;
			lblLostAllName.Text = "Name";
			// 
			// txtLostAllLocation
			// 
			txtLostAllLocation.Location = new Point(129, 468);
			txtLostAllLocation.Margin = new Padding(3, 4, 3, 4);
			txtLostAllLocation.Name = "txtLostAllLocation";
			txtLostAllLocation.Size = new Size(153, 27);
			txtLostAllLocation.TabIndex = 26;
			// 
			// txtDateFoundAll
			// 
			txtDateFoundAll.Location = new Point(129, 390);
			txtDateFoundAll.Margin = new Padding(3, 4, 3, 4);
			txtDateFoundAll.Name = "txtDateFoundAll";
			txtDateFoundAll.Size = new Size(153, 27);
			txtDateFoundAll.TabIndex = 25;
			txtDateFoundAll.TextChanged += textBox8_TextChanged;
			// 
			// txtLostAllBreed
			// 
			txtLostAllBreed.Location = new Point(129, 308);
			txtLostAllBreed.Margin = new Padding(3, 4, 3, 4);
			txtLostAllBreed.Name = "txtLostAllBreed";
			txtLostAllBreed.Size = new Size(153, 27);
			txtLostAllBreed.TabIndex = 24;
			// 
			// txtLostAllColour
			// 
			txtLostAllColour.Location = new Point(129, 235);
			txtLostAllColour.Margin = new Padding(3, 4, 3, 4);
			txtLostAllColour.Name = "txtLostAllColour";
			txtLostAllColour.Size = new Size(153, 27);
			txtLostAllColour.TabIndex = 23;
			// 
			// txtLostAllAge
			// 
			txtLostAllAge.Location = new Point(129, 165);
			txtLostAllAge.Margin = new Padding(3, 4, 3, 4);
			txtLostAllAge.Name = "txtLostAllAge";
			txtLostAllAge.Size = new Size(153, 27);
			txtLostAllAge.TabIndex = 22;
			// 
			// txtLostAllName
			// 
			txtLostAllName.Location = new Point(129, 88);
			txtLostAllName.Margin = new Padding(3, 4, 3, 4);
			txtLostAllName.Name = "txtLostAllName";
			txtLostAllName.Size = new Size(153, 27);
			txtLostAllName.TabIndex = 21;
			// 
			// foundAllTab
			// 
			foundAllTab.BackColor = Color.AntiqueWhite;
			foundAllTab.Controls.Add(dataGridViewFoundAll);
			foundAllTab.Controls.Add(lblFoundAllTitle);
			foundAllTab.Controls.Add(buttonFoundSearch);
			foundAllTab.Controls.Add(boxFoundAllSpecies);
			foundAllTab.Controls.Add(boxFoundAllGender);
			foundAllTab.Controls.Add(lblFoundAllGender);
			foundAllTab.Controls.Add(lblFoundAllSpecies);
			foundAllTab.Controls.Add(lblFoundAllLocation);
			foundAllTab.Controls.Add(lblDateLostAll);
			foundAllTab.Controls.Add(lblFoundAllBreed);
			foundAllTab.Controls.Add(lblFoundAllColour);
			foundAllTab.Controls.Add(lblFoundAllAge);
			foundAllTab.Controls.Add(lblFoundAllName);
			foundAllTab.Controls.Add(txtFoundAllLocation);
			foundAllTab.Controls.Add(txtDateLostAll);
			foundAllTab.Controls.Add(txtFoundAllBreed);
			foundAllTab.Controls.Add(txtFoundAllColour);
			foundAllTab.Controls.Add(txtFoundAllAge);
			foundAllTab.Controls.Add(txtFoundAllName);
			foundAllTab.Location = new Point(4, 29);
			foundAllTab.Margin = new Padding(3, 4, 3, 4);
			foundAllTab.Name = "foundAllTab";
			foundAllTab.Size = new Size(1111, 662);
			foundAllTab.TabIndex = 2;
			foundAllTab.Text = "View found animals";
			// 
			// dataGridViewFoundAll
			// 
			dataGridViewFoundAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewFoundAll.Location = new Point(343, 88);
			dataGridViewFoundAll.Margin = new Padding(3, 4, 3, 4);
			dataGridViewFoundAll.Name = "dataGridViewFoundAll";
			dataGridViewFoundAll.RowHeadersWidth = 51;
			dataGridViewFoundAll.Size = new Size(728, 477);
			dataGridViewFoundAll.TabIndex = 40;
			// 
			// lblFoundAllTitle
			// 
			lblFoundAllTitle.AutoSize = true;
			lblFoundAllTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
			lblFoundAllTitle.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllTitle.Location = new Point(608, 21);
			lblFoundAllTitle.Name = "lblFoundAllTitle";
			lblFoundAllTitle.Size = new Size(200, 63);
			lblFoundAllTitle.TabIndex = 59;
			lblFoundAllTitle.Text = "Found Pets";
			// 
			// buttonFoundSearch
			// 
			buttonFoundSearch.BackColor = Color.FromArgb(114, 125, 113);
			buttonFoundSearch.Font = new Font("Segoe UI", 10F);
			buttonFoundSearch.ForeColor = Color.White;
			buttonFoundSearch.Location = new Point(343, 595);
			buttonFoundSearch.Margin = new Padding(3, 4, 3, 4);
			buttonFoundSearch.Name = "buttonFoundSearch";
			buttonFoundSearch.Size = new Size(123, 46);
			buttonFoundSearch.TabIndex = 58;
			buttonFoundSearch.Text = "Search";
			buttonFoundSearch.UseVisualStyleBackColor = false;
			// 
			// boxFoundAllSpecies
			// 
			boxFoundAllSpecies.FormattingEnabled = true;
			boxFoundAllSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
			boxFoundAllSpecies.Location = new Point(132, 537);
			boxFoundAllSpecies.Name = "boxFoundAllSpecies";
			boxFoundAllSpecies.Size = new Size(151, 28);
			boxFoundAllSpecies.TabIndex = 57;
			// 
			// boxFoundAllGender
			// 
			boxFoundAllGender.FormattingEnabled = true;
			boxFoundAllGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
			boxFoundAllGender.Location = new Point(132, 613);
			boxFoundAllGender.Name = "boxFoundAllGender";
			boxFoundAllGender.Size = new Size(151, 28);
			boxFoundAllGender.TabIndex = 56;
			// 
			// lblFoundAllGender
			// 
			lblFoundAllGender.AutoSize = true;
			lblFoundAllGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAllGender.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllGender.Location = new Point(40, 621);
			lblFoundAllGender.Name = "lblFoundAllGender";
			lblFoundAllGender.Size = new Size(67, 20);
			lblFoundAllGender.TabIndex = 55;
			lblFoundAllGender.Text = "Gender*";
			// 
			// lblFoundAllSpecies
			// 
			lblFoundAllSpecies.AutoSize = true;
			lblFoundAllSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAllSpecies.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllSpecies.Location = new Point(40, 545);
			lblFoundAllSpecies.Name = "lblFoundAllSpecies";
			lblFoundAllSpecies.Size = new Size(67, 20);
			lblFoundAllSpecies.TabIndex = 54;
			lblFoundAllSpecies.Text = "Species*";
			// 
			// lblFoundAllLocation
			// 
			lblFoundAllLocation.AutoSize = true;
			lblFoundAllLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAllLocation.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllLocation.Location = new Point(40, 475);
			lblFoundAllLocation.Name = "lblFoundAllLocation";
			lblFoundAllLocation.Size = new Size(76, 20);
			lblFoundAllLocation.TabIndex = 53;
			lblFoundAllLocation.Text = "Location*";
			// 
			// lblDateLostAll
			// 
			lblDateLostAll.AutoSize = true;
			lblDateLostAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblDateLostAll.ForeColor = Color.FromArgb(109, 76, 61);
			lblDateLostAll.Location = new Point(40, 397);
			lblDateLostAll.Name = "lblDateLostAll";
			lblDateLostAll.Size = new Size(83, 20);
			lblDateLostAll.TabIndex = 52;
			lblDateLostAll.Text = "Date Lost*\r\n";
			// 
			// lblFoundAllBreed
			// 
			lblFoundAllBreed.AutoSize = true;
			lblFoundAllBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAllBreed.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllBreed.Location = new Point(40, 315);
			lblFoundAllBreed.Name = "lblFoundAllBreed";
			lblFoundAllBreed.Size = new Size(50, 20);
			lblFoundAllBreed.TabIndex = 50;
			lblFoundAllBreed.Text = "Breed";
			// 
			// lblFoundAllColour
			// 
			lblFoundAllColour.AutoSize = true;
			lblFoundAllColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAllColour.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllColour.Location = new Point(40, 242);
			lblFoundAllColour.Name = "lblFoundAllColour";
			lblFoundAllColour.Size = new Size(62, 20);
			lblFoundAllColour.TabIndex = 49;
			lblFoundAllColour.Text = "Colour*";
			// 
			// lblFoundAllAge
			// 
			lblFoundAllAge.AutoSize = true;
			lblFoundAllAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAllAge.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllAge.Location = new Point(40, 172);
			lblFoundAllAge.Name = "lblFoundAllAge";
			lblFoundAllAge.Size = new Size(37, 20);
			lblFoundAllAge.TabIndex = 48;
			lblFoundAllAge.Text = "Age";
			// 
			// lblFoundAllName
			// 
			lblFoundAllName.AutoSize = true;
			lblFoundAllName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAllName.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAllName.Location = new Point(40, 95);
			lblFoundAllName.Name = "lblFoundAllName";
			lblFoundAllName.Size = new Size(58, 20);
			lblFoundAllName.TabIndex = 47;
			lblFoundAllName.Text = "Name*";
			// 
			// txtFoundAllLocation
			// 
			txtFoundAllLocation.Location = new Point(132, 468);
			txtFoundAllLocation.Margin = new Padding(3, 4, 3, 4);
			txtFoundAllLocation.Name = "txtFoundAllLocation";
			txtFoundAllLocation.Size = new Size(153, 27);
			txtFoundAllLocation.TabIndex = 46;
			// 
			// txtDateLostAll
			// 
			txtDateLostAll.Location = new Point(132, 390);
			txtDateLostAll.Margin = new Padding(3, 4, 3, 4);
			txtDateLostAll.Name = "txtDateLostAll";
			txtDateLostAll.Size = new Size(153, 27);
			txtDateLostAll.TabIndex = 45;
			// 
			// txtFoundAllBreed
			// 
			txtFoundAllBreed.Location = new Point(132, 308);
			txtFoundAllBreed.Margin = new Padding(3, 4, 3, 4);
			txtFoundAllBreed.Name = "txtFoundAllBreed";
			txtFoundAllBreed.Size = new Size(153, 27);
			txtFoundAllBreed.TabIndex = 44;
			// 
			// txtFoundAllColour
			// 
			txtFoundAllColour.Location = new Point(132, 235);
			txtFoundAllColour.Margin = new Padding(3, 4, 3, 4);
			txtFoundAllColour.Name = "txtFoundAllColour";
			txtFoundAllColour.Size = new Size(153, 27);
			txtFoundAllColour.TabIndex = 43;
			// 
			// txtFoundAllAge
			// 
			txtFoundAllAge.Location = new Point(132, 165);
			txtFoundAllAge.Margin = new Padding(3, 4, 3, 4);
			txtFoundAllAge.Name = "txtFoundAllAge";
			txtFoundAllAge.Size = new Size(153, 27);
			txtFoundAllAge.TabIndex = 42;
			// 
			// txtFoundAllName
			// 
			txtFoundAllName.Location = new Point(132, 88);
			txtFoundAllName.Margin = new Padding(3, 4, 3, 4);
			txtFoundAllName.Name = "txtFoundAllName";
			txtFoundAllName.Size = new Size(153, 27);
			txtFoundAllName.TabIndex = 41;
			// 
			// foundTab
			// 
			foundTab.BackColor = Color.AntiqueWhite;
			foundTab.Controls.Add(lblDateFound);
			foundTab.Controls.Add(txtDateFound);
			foundTab.Controls.Add(boxFoundSpecies);
			foundTab.Controls.Add(boxFoundGender);
			foundTab.Controls.Add(buttonImageFound);
			foundTab.Controls.Add(pictureBoxFound);
			foundTab.Controls.Add(buttonSaveFound);
			foundTab.Controls.Add(lblFoundDesc);
			foundTab.Controls.Add(lblFoundGender);
			foundTab.Controls.Add(lblFoundSpecies);
			foundTab.Controls.Add(lblFoundLocation);
			foundTab.Controls.Add(lblFoundBreed);
			foundTab.Controls.Add(lblFoundColour);
			foundTab.Controls.Add(lblFoundAge);
			foundTab.Controls.Add(lblFoundName);
			foundTab.Controls.Add(lblFoundTitle);
			foundTab.Controls.Add(txtFoundDesc);
			foundTab.Controls.Add(txtFoundLocation);
			foundTab.Controls.Add(txtFoundBreed);
			foundTab.Controls.Add(txtFoundColour);
			foundTab.Controls.Add(txtFoundAge);
			foundTab.Controls.Add(txtFoundName);
			foundTab.Location = new Point(4, 29);
			foundTab.Margin = new Padding(3, 4, 3, 4);
			foundTab.Name = "foundTab";
			foundTab.Size = new Size(1111, 662);
			foundTab.TabIndex = 3;
			foundTab.Text = "Add a found animal";
			// 
			// lblDateFound
			// 
			lblDateFound.AutoSize = true;
			lblDateFound.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblDateFound.ForeColor = Color.FromArgb(109, 76, 61);
			lblDateFound.Location = new Point(40, 458);
			lblDateFound.Name = "lblDateFound";
			lblDateFound.Size = new Size(60, 40);
			lblDateFound.TabIndex = 49;
			lblDateFound.Text = " Date\r\nFound*";
			// 
			// txtDateFound
			// 
			txtDateFound.Location = new Point(132, 458);
			txtDateFound.Margin = new Padding(3, 4, 3, 4);
			txtDateFound.Name = "txtDateFound";
			txtDateFound.Size = new Size(153, 27);
			txtDateFound.TabIndex = 48;
			// 
			// boxFoundSpecies
			// 
			boxFoundSpecies.FormattingEnabled = true;
			boxFoundSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
			boxFoundSpecies.Location = new Point(484, 131);
			boxFoundSpecies.Name = "boxFoundSpecies";
			boxFoundSpecies.Size = new Size(151, 28);
			boxFoundSpecies.TabIndex = 47;
			// 
			// boxFoundGender
			// 
			boxFoundGender.FormattingEnabled = true;
			boxFoundGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
			boxFoundGender.Location = new Point(484, 215);
			boxFoundGender.Name = "boxFoundGender";
			boxFoundGender.Size = new Size(151, 28);
			boxFoundGender.TabIndex = 46;
			// 
			// buttonImageFound
			// 
			buttonImageFound.BackColor = Color.FromArgb(114, 125, 113);
			buttonImageFound.Font = new Font("Segoe UI", 10F);
			buttonImageFound.ForeColor = Color.White;
			buttonImageFound.Location = new Point(828, 131);
			buttonImageFound.Margin = new Padding(3, 4, 3, 4);
			buttonImageFound.Name = "buttonImageFound";
			buttonImageFound.Size = new Size(202, 57);
			buttonImageFound.TabIndex = 45;
			buttonImageFound.Text = "Upload an image";
			buttonImageFound.UseVisualStyleBackColor = false;
			// 
			// pictureBoxFound
			// 
			pictureBoxFound.Location = new Point(775, 215);
			pictureBoxFound.Margin = new Padding(3, 4, 3, 4);
			pictureBoxFound.Name = "pictureBoxFound";
			pictureBoxFound.Size = new Size(296, 359);
			pictureBoxFound.TabIndex = 44;
			pictureBoxFound.TabStop = false;
			// 
			// buttonSaveFound
			// 
			buttonSaveFound.BackColor = Color.FromArgb(114, 125, 113);
			buttonSaveFound.Font = new Font("Segoe UI", 10F);
			buttonSaveFound.ForeColor = Color.White;
			buttonSaveFound.Location = new Point(866, 590);
			buttonSaveFound.Margin = new Padding(3, 4, 3, 4);
			buttonSaveFound.Name = "buttonSaveFound";
			buttonSaveFound.Size = new Size(123, 46);
			buttonSaveFound.TabIndex = 43;
			buttonSaveFound.Text = "Save";
			buttonSaveFound.UseVisualStyleBackColor = false;
			// 
			// lblFoundDesc
			// 
			lblFoundDesc.AutoSize = true;
			lblFoundDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundDesc.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundDesc.Location = new Point(360, 305);
			lblFoundDesc.Name = "lblFoundDesc";
			lblFoundDesc.Size = new Size(89, 20);
			lblFoundDesc.TabIndex = 42;
			lblFoundDesc.Text = "Description";
			// 
			// lblFoundGender
			// 
			lblFoundGender.AutoSize = true;
			lblFoundGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundGender.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundGender.Location = new Point(360, 223);
			lblFoundGender.Name = "lblFoundGender";
			lblFoundGender.Size = new Size(67, 20);
			lblFoundGender.TabIndex = 41;
			lblFoundGender.Text = "Gender*";
			// 
			// lblFoundSpecies
			// 
			lblFoundSpecies.AutoSize = true;
			lblFoundSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundSpecies.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundSpecies.Location = new Point(360, 135);
			lblFoundSpecies.Name = "lblFoundSpecies";
			lblFoundSpecies.Size = new Size(67, 20);
			lblFoundSpecies.TabIndex = 40;
			lblFoundSpecies.Text = "Species*";
			// 
			// lblFoundLocation
			// 
			lblFoundLocation.AutoSize = true;
			lblFoundLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundLocation.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundLocation.Location = new Point(40, 554);
			lblFoundLocation.Name = "lblFoundLocation";
			lblFoundLocation.Size = new Size(76, 20);
			lblFoundLocation.TabIndex = 39;
			lblFoundLocation.Text = "Location*";
			// 
			// lblFoundBreed
			// 
			lblFoundBreed.AutoSize = true;
			lblFoundBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundBreed.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundBreed.Location = new Point(40, 382);
			lblFoundBreed.Name = "lblFoundBreed";
			lblFoundBreed.Size = new Size(50, 20);
			lblFoundBreed.TabIndex = 37;
			lblFoundBreed.Text = "Breed";
			// 
			// lblFoundColour
			// 
			lblFoundColour.AutoSize = true;
			lblFoundColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundColour.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundColour.Location = new Point(40, 305);
			lblFoundColour.Name = "lblFoundColour";
			lblFoundColour.Size = new Size(62, 20);
			lblFoundColour.TabIndex = 36;
			lblFoundColour.Text = "Colour*";
			// 
			// lblFoundAge
			// 
			lblFoundAge.AutoSize = true;
			lblFoundAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundAge.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundAge.Location = new Point(40, 223);
			lblFoundAge.Name = "lblFoundAge";
			lblFoundAge.Size = new Size(37, 20);
			lblFoundAge.TabIndex = 35;
			lblFoundAge.Text = "Age";
			// 
			// lblFoundName
			// 
			lblFoundName.AutoSize = true;
			lblFoundName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblFoundName.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundName.Location = new Point(40, 139);
			lblFoundName.Name = "lblFoundName";
			lblFoundName.Size = new Size(51, 20);
			lblFoundName.TabIndex = 34;
			lblFoundName.Text = "Name";
			// 
			// lblFoundTitle
			// 
			lblFoundTitle.AutoSize = true;
			lblFoundTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
			lblFoundTitle.ForeColor = Color.FromArgb(109, 76, 61);
			lblFoundTitle.Location = new Point(360, 27);
			lblFoundTitle.Name = "lblFoundTitle";
			lblFoundTitle.Size = new Size(391, 63);
			lblFoundTitle.TabIndex = 33;
			lblFoundTitle.Text = "Have you found a pet?";
			// 
			// txtFoundDesc
			// 
			txtFoundDesc.Location = new Point(360, 346);
			txtFoundDesc.Margin = new Padding(3, 4, 3, 4);
			txtFoundDesc.Multiline = true;
			txtFoundDesc.Name = "txtFoundDesc";
			txtFoundDesc.Size = new Size(348, 228);
			txtFoundDesc.TabIndex = 32;
			// 
			// txtFoundLocation
			// 
			txtFoundLocation.Location = new Point(132, 547);
			txtFoundLocation.Margin = new Padding(3, 4, 3, 4);
			txtFoundLocation.Name = "txtFoundLocation";
			txtFoundLocation.Size = new Size(153, 27);
			txtFoundLocation.TabIndex = 31;
			// 
			// txtFoundBreed
			// 
			txtFoundBreed.Location = new Point(132, 375);
			txtFoundBreed.Margin = new Padding(3, 4, 3, 4);
			txtFoundBreed.Name = "txtFoundBreed";
			txtFoundBreed.Size = new Size(153, 27);
			txtFoundBreed.TabIndex = 29;
			// 
			// txtFoundColour
			// 
			txtFoundColour.Location = new Point(132, 298);
			txtFoundColour.Margin = new Padding(3, 4, 3, 4);
			txtFoundColour.Name = "txtFoundColour";
			txtFoundColour.Size = new Size(153, 27);
			txtFoundColour.TabIndex = 28;
			// 
			// txtFoundAge
			// 
			txtFoundAge.Location = new Point(132, 216);
			txtFoundAge.Margin = new Padding(3, 4, 3, 4);
			txtFoundAge.Name = "txtFoundAge";
			txtFoundAge.Size = new Size(153, 27);
			txtFoundAge.TabIndex = 27;
			// 
			// txtFoundName
			// 
			txtFoundName.Location = new Point(132, 132);
			txtFoundName.Margin = new Padding(3, 4, 3, 4);
			txtFoundName.Name = "txtFoundName";
			txtFoundName.Size = new Size(153, 27);
			txtFoundName.TabIndex = 26;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1109, 684);
			Controls.Add(Tab);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load_1;
			Tab.ResumeLayout(false);
			lostTab.ResumeLayout(false);
			lostTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxLost).EndInit();
			lostAllTab.ResumeLayout(false);
			lostAllTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewLostAll).EndInit();
			foundAllTab.ResumeLayout(false);
			foundAllTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewFoundAll).EndInit();
			foundTab.ResumeLayout(false);
			foundTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxFound).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl Tab;
        private TabPage lostTab;
        private TabPage lostAllTab;
        private TextBox txtLostLocation;
        private TextBox txtDateLost;
        private TextBox txtLostBreed;
        private TextBox txtLostColour;
        private TextBox txtLostAge;
        private TextBox txtLostName;
        private Label lblDateLost;
        private Label lblLostBreed;
        private Label lblLostColour;
        private Label lblLostAge;
        private Label lblLostName;
        private Label lblLostTitle;
        private TextBox txtLostDesc;
        private PictureBox pictureBoxLost;
        private Button buttonSaveLost;
        private Label lblLostDesc;
        private Label lblLostGender;
        private Label lblLostSpecies;
        private Label lblLostLocation;
        private LinkLabel linkLabel1;
        private DataGridView dataGridViewLostAll;
        private LinkLabel linkLabel2;
        private DataGridView dataGridView4;
        private Button button3;
        private Button buttonSaveFound;
        private TextBox textBox26;
        private TextBox textBox25;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox19;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private DataGridView dataGridView3;
        private TabPage foundTab;
		private ComboBox boxLostSpecies;
		private ComboBox boxLostGender;
		private Button buttonLostImage;
		private Button buttonLostSearch;
		private ComboBox boxLostAllSpecies;
		private ComboBox boxLostAllGender;
		private Label lblLostAllGender;
		private Label lblLostAllSpecies;
		private Label lblLostAllLocation;
		private Label label2;
		private Label lblLostAllBreed;
		private Label lblLostAllColour;
		private Label lblLostAllAge;
		private Label lblLostAllName;
		private TextBox txtLostAllLocation;
		private TextBox txtDateFoundAll;
		private TextBox txtLostAllBreed;
		private TextBox txtLostAllColour;
		private TextBox txtLostAllAge;
		private TextBox txtLostAllName;
		private Label lblDateFoundAll;
		private Label lblLostAllTitle;
		private TabPage foundAllTab;
		private Label lblFoundAllTitle;
		private DataGridView dataGridViewFoundAll;
		private Button buttonFoundSearch;
		private ComboBox boxFoundAllSpecies;
		private ComboBox boxFoundAllGender;
		private Label lblFoundAllGender;
		private Label lblFoundAllSpecies;
		private Label lblFoundAllLocation;
		private Label lblDateLostAll;
		private Label lblFoundAllBreed;
		private Label lblFoundAllColour;
		private Label lblFoundAllAge;
		private Label lblFoundAllName;
		private TextBox txtFoundAllLocation;
		private TextBox txtDateLostAll;
		private TextBox txtFoundAllBreed;
		private TextBox txtFoundAllColour;
		private TextBox txtFoundAllAge;
		private TextBox txtFoundAllName;
		private ComboBox boxFoundSpecies;
		private ComboBox boxFoundGender;
		private Button buttonImageFound;
		private PictureBox pictureBoxFound;
		private Label lblFoundDesc;
		private Label lblFoundGender;
		private Label lblFoundSpecies;
		private Label lblFoundLocation;
		private Label lblFoundBreed;
		private Label lblFoundColour;
		private Label lblFoundAge;
		private Label lblFoundName;
		private Label lblFoundTitle;
		private TextBox txtFoundDesc;
		private TextBox txtFoundLocation;
		private TextBox txtFoundBreed;
		private TextBox txtFoundColour;
		private TextBox txtFoundAge;
		private TextBox txtFoundName;
		private Label lblDateFound;
		private TextBox txtDateFound;
	}
}
