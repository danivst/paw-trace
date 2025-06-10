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
            buttonMarkFound = new Button();
            buttonViewAllLost = new Button();
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
            buttonMarkLost = new Button();
            buttonViewAllFound = new Button();
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
            Tab.Location = new Point(-4, 1);
            Tab.Margin = new Padding(3, 2, 3, 2);
            Tab.Name = "Tab";
            Tab.SelectedIndex = 0;
            Tab.Size = new Size(979, 521);
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
            lostTab.Location = new Point(4, 24);
            lostTab.Margin = new Padding(3, 2, 3, 2);
            lostTab.Name = "lostTab";
            lostTab.Padding = new Padding(3, 2, 3, 2);
            lostTab.Size = new Size(971, 493);
            lostTab.TabIndex = 0;
            lostTab.Text = "Add a lost animal";
            // 
            // boxLostSpecies
            // 
            boxLostSpecies.FormattingEnabled = true;
            boxLostSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
            boxLostSpecies.Location = new Point(423, 102);
            boxLostSpecies.Margin = new Padding(3, 2, 3, 2);
            boxLostSpecies.Name = "boxLostSpecies";
            boxLostSpecies.Size = new Size(133, 23);
            boxLostSpecies.TabIndex = 25;
            // 
            // boxLostGender
            // 
            boxLostGender.FormattingEnabled = true;
            boxLostGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
            boxLostGender.Location = new Point(423, 165);
            boxLostGender.Margin = new Padding(3, 2, 3, 2);
            boxLostGender.Name = "boxLostGender";
            boxLostGender.Size = new Size(133, 23);
            boxLostGender.TabIndex = 24;
            boxLostGender.SelectedIndexChanged += boxLostGender_SelectedIndexChanged;
            // 
            // buttonLostImage
            // 
            buttonLostImage.BackColor = Color.FromArgb(114, 125, 113);
            buttonLostImage.Font = new Font("Segoe UI", 10F);
            buttonLostImage.ForeColor = Color.White;
            buttonLostImage.Location = new Point(724, 102);
            buttonLostImage.Name = "buttonLostImage";
            buttonLostImage.Size = new Size(177, 43);
            buttonLostImage.TabIndex = 23;
            buttonLostImage.Text = "Upload an image";
            buttonLostImage.UseVisualStyleBackColor = false;
            buttonLostImage.Click += buttonLostImage_Click;
            // 
            // pictureBoxLost
            // 
            pictureBoxLost.Location = new Point(677, 165);
            pictureBoxLost.Name = "pictureBoxLost";
            pictureBoxLost.Size = new Size(259, 269);
            pictureBoxLost.TabIndex = 22;
            pictureBoxLost.TabStop = false;
            // 
            // buttonSaveLost
            // 
            buttonSaveLost.BackColor = Color.FromArgb(114, 125, 113);
            buttonSaveLost.Font = new Font("Segoe UI", 10F);
            buttonSaveLost.ForeColor = Color.White;
            buttonSaveLost.Location = new Point(757, 446);
            buttonSaveLost.Name = "buttonSaveLost";
            buttonSaveLost.Size = new Size(108, 34);
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
            lblLostDesc.Location = new Point(314, 232);
            lblLostDesc.Name = "lblLostDesc";
            lblLostDesc.Size = new Size(71, 15);
            lblLostDesc.TabIndex = 20;
            lblLostDesc.Text = "Description";
            // 
            // lblLostGender
            // 
            lblLostGender.AutoSize = true;
            lblLostGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostGender.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostGender.Location = new Point(314, 171);
            lblLostGender.Name = "lblLostGender";
            lblLostGender.Size = new Size(54, 15);
            lblLostGender.TabIndex = 18;
            lblLostGender.Text = "Gender*";
            // 
            // lblLostSpecies
            // 
            lblLostSpecies.AutoSize = true;
            lblLostSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostSpecies.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostSpecies.Location = new Point(314, 105);
            lblLostSpecies.Name = "lblLostSpecies";
            lblLostSpecies.Size = new Size(54, 15);
            lblLostSpecies.TabIndex = 17;
            lblLostSpecies.Text = "Species*";
            // 
            // lblLostLocation
            // 
            lblLostLocation.AutoSize = true;
            lblLostLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostLocation.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostLocation.Location = new Point(34, 419);
            lblLostLocation.Name = "lblLostLocation";
            lblLostLocation.Size = new Size(59, 15);
            lblLostLocation.TabIndex = 16;
            lblLostLocation.Text = "Location*";
            // 
            // lblDateLost
            // 
            lblDateLost.AutoSize = true;
            lblDateLost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateLost.ForeColor = Color.FromArgb(109, 76, 61);
            lblDateLost.Location = new Point(34, 349);
            lblDateLost.Name = "lblDateLost";
            lblDateLost.Size = new Size(65, 15);
            lblDateLost.TabIndex = 15;
            lblDateLost.Text = "Date Lost*";
            // 
            // lblLostBreed
            // 
            lblLostBreed.AutoSize = true;
            lblLostBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostBreed.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostBreed.Location = new Point(34, 290);
            lblLostBreed.Name = "lblLostBreed";
            lblLostBreed.Size = new Size(41, 15);
            lblLostBreed.TabIndex = 14;
            lblLostBreed.Text = "Breed";
            // 
            // lblLostColour
            // 
            lblLostColour.AutoSize = true;
            lblLostColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostColour.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostColour.Location = new Point(34, 232);
            lblLostColour.Name = "lblLostColour";
            lblLostColour.Size = new Size(48, 15);
            lblLostColour.TabIndex = 13;
            lblLostColour.Text = "Colour*";
            lblLostColour.Click += lblLostColour_Click;
            // 
            // lblLostAge
            // 
            lblLostAge.AutoSize = true;
            lblLostAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAge.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAge.Location = new Point(34, 171);
            lblLostAge.Name = "lblLostAge";
            lblLostAge.Size = new Size(29, 15);
            lblLostAge.TabIndex = 12;
            lblLostAge.Text = "Age";
            // 
            // lblLostName
            // 
            lblLostName.AutoSize = true;
            lblLostName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostName.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostName.Location = new Point(34, 108);
            lblLostName.Name = "lblLostName";
            lblLostName.Size = new Size(45, 15);
            lblLostName.TabIndex = 11;
            lblLostName.Text = "Name*";
            // 
            // lblLostTitle
            // 
            lblLostTitle.AutoSize = true;
            lblLostTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
            lblLostTitle.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostTitle.Location = new Point(314, 24);
            lblLostTitle.Name = "lblLostTitle";
            lblLostTitle.Size = new Size(330, 50);
            lblLostTitle.TabIndex = 10;
            lblLostTitle.Text = "Have you lost your pet?";
            lblLostTitle.Click += label1_Click;
            // 
            // txtLostDesc
            // 
            txtLostDesc.Location = new Point(314, 263);
            txtLostDesc.Multiline = true;
            txtLostDesc.Name = "txtLostDesc";
            txtLostDesc.Size = new Size(305, 172);
            txtLostDesc.TabIndex = 9;
            // 
            // txtLostLocation
            // 
            txtLostLocation.Location = new Point(115, 414);
            txtLostLocation.Name = "txtLostLocation";
            txtLostLocation.Size = new Size(134, 23);
            txtLostLocation.TabIndex = 5;
            txtLostLocation.TextChanged += textBox6_TextChanged;
            // 
            // txtDateLost
            // 
            txtDateLost.Location = new Point(115, 349);
            txtDateLost.Name = "txtDateLost";
            txtDateLost.Size = new Size(134, 23);
            txtDateLost.TabIndex = 4;
            // 
            // txtLostBreed
            // 
            txtLostBreed.Location = new Point(115, 285);
            txtLostBreed.Name = "txtLostBreed";
            txtLostBreed.Size = new Size(134, 23);
            txtLostBreed.TabIndex = 3;
            // 
            // txtLostColour
            // 
            txtLostColour.Location = new Point(115, 227);
            txtLostColour.Name = "txtLostColour";
            txtLostColour.Size = new Size(134, 23);
            txtLostColour.TabIndex = 2;
            // 
            // txtLostAge
            // 
            txtLostAge.Location = new Point(115, 166);
            txtLostAge.Name = "txtLostAge";
            txtLostAge.Size = new Size(134, 23);
            txtLostAge.TabIndex = 1;
            // 
            // txtLostName
            // 
            txtLostName.Location = new Point(115, 103);
            txtLostName.Name = "txtLostName";
            txtLostName.Size = new Size(134, 23);
            txtLostName.TabIndex = 0;
            // 
            // lostAllTab
            // 
            lostAllTab.BackColor = Color.AntiqueWhite;
            lostAllTab.Controls.Add(buttonMarkFound);
            lostAllTab.Controls.Add(buttonViewAllLost);
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
            lostAllTab.Location = new Point(4, 24);
            lostAllTab.Margin = new Padding(3, 2, 3, 2);
            lostAllTab.Name = "lostAllTab";
            lostAllTab.Padding = new Padding(3, 2, 3, 2);
            lostAllTab.Size = new Size(971, 493);
            lostAllTab.TabIndex = 1;
            lostAllTab.Text = "View lost animals";
            // 
            // buttonMarkFound
            // 
            buttonMarkFound.BackColor = Color.FromArgb(114, 125, 113);
            buttonMarkFound.Font = new Font("Segoe UI", 10F);
            buttonMarkFound.ForeColor = Color.White;
            buttonMarkFound.Location = new Point(558, 446);
            buttonMarkFound.Name = "buttonMarkFound";
            buttonMarkFound.Size = new Size(108, 34);
            buttonMarkFound.TabIndex = 40;
            buttonMarkFound.Text = "Mark as found";
            buttonMarkFound.UseVisualStyleBackColor = false;
            buttonMarkFound.Click += buttonMarkFound_Click;
            // 
            // buttonViewAllLost
            // 
            buttonViewAllLost.BackColor = Color.FromArgb(114, 125, 113);
            buttonViewAllLost.Font = new Font("Segoe UI", 10F);
            buttonViewAllLost.ForeColor = Color.White;
            buttonViewAllLost.Location = new Point(827, 446);
            buttonViewAllLost.Name = "buttonViewAllLost";
            buttonViewAllLost.Size = new Size(108, 34);
            buttonViewAllLost.TabIndex = 39;
            buttonViewAllLost.Text = "View all";
            buttonViewAllLost.UseVisualStyleBackColor = false;
            buttonViewAllLost.Click += buttonViewAllLost_Click;
            // 
            // dataGridViewLostAll
            // 
            dataGridViewLostAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLostAll.Location = new Point(298, 66);
            dataGridViewLostAll.Name = "dataGridViewLostAll";
            dataGridViewLostAll.RowHeadersWidth = 51;
            dataGridViewLostAll.Size = new Size(637, 358);
            dataGridViewLostAll.TabIndex = 1;
            dataGridViewLostAll.CellContentClick += dataGridViewLostAll_CellContentClick;
            // 
            // lblLostAllTitle
            // 
            lblLostAllTitle.AutoSize = true;
            lblLostAllTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
            lblLostAllTitle.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllTitle.Location = new Point(539, 16);
            lblLostAllTitle.Name = "lblLostAllTitle";
            lblLostAllTitle.Size = new Size(137, 50);
            lblLostAllTitle.TabIndex = 38;
            lblLostAllTitle.Text = "Lost Pets";
            // 
            // buttonLostSearch
            // 
            buttonLostSearch.BackColor = Color.FromArgb(114, 125, 113);
            buttonLostSearch.Font = new Font("Segoe UI", 10F);
            buttonLostSearch.ForeColor = Color.White;
            buttonLostSearch.Location = new Point(298, 446);
            buttonLostSearch.Name = "buttonLostSearch";
            buttonLostSearch.Size = new Size(108, 34);
            buttonLostSearch.TabIndex = 37;
            buttonLostSearch.Text = "Search";
            buttonLostSearch.UseVisualStyleBackColor = false;
            buttonLostSearch.Click += buttonLostSearch_Click;
            // 
            // boxLostAllSpecies
            // 
            boxLostAllSpecies.FormattingEnabled = true;
            boxLostAllSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
            boxLostAllSpecies.Location = new Point(113, 403);
            boxLostAllSpecies.Margin = new Padding(3, 2, 3, 2);
            boxLostAllSpecies.Name = "boxLostAllSpecies";
            boxLostAllSpecies.Size = new Size(133, 23);
            boxLostAllSpecies.TabIndex = 36;
            // 
            // boxLostAllGender
            // 
            boxLostAllGender.FormattingEnabled = true;
            boxLostAllGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
            boxLostAllGender.Location = new Point(113, 460);
            boxLostAllGender.Margin = new Padding(3, 2, 3, 2);
            boxLostAllGender.Name = "boxLostAllGender";
            boxLostAllGender.Size = new Size(133, 23);
            boxLostAllGender.TabIndex = 35;
            // 
            // lblLostAllGender
            // 
            lblLostAllGender.AutoSize = true;
            lblLostAllGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAllGender.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllGender.Location = new Point(32, 466);
            lblLostAllGender.Name = "lblLostAllGender";
            lblLostAllGender.Size = new Size(54, 15);
            lblLostAllGender.TabIndex = 34;
            lblLostAllGender.Text = "Gender*";
            // 
            // lblLostAllSpecies
            // 
            lblLostAllSpecies.AutoSize = true;
            lblLostAllSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAllSpecies.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllSpecies.Location = new Point(32, 409);
            lblLostAllSpecies.Name = "lblLostAllSpecies";
            lblLostAllSpecies.Size = new Size(54, 15);
            lblLostAllSpecies.TabIndex = 33;
            lblLostAllSpecies.Text = "Species*";
            // 
            // lblLostAllLocation
            // 
            lblLostAllLocation.AutoSize = true;
            lblLostAllLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAllLocation.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllLocation.Location = new Point(32, 356);
            lblLostAllLocation.Name = "lblLostAllLocation";
            lblLostAllLocation.Size = new Size(59, 15);
            lblLostAllLocation.TabIndex = 32;
            lblLostAllLocation.Text = "Location*";
            // 
            // lblDateFoundAll
            // 
            lblDateFoundAll.AutoSize = true;
            lblDateFoundAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateFoundAll.ForeColor = Color.FromArgb(109, 76, 61);
            lblDateFoundAll.Location = new Point(32, 292);
            lblDateFoundAll.Name = "lblDateFoundAll";
            lblDateFoundAll.Size = new Size(46, 30);
            lblDateFoundAll.TabIndex = 31;
            lblDateFoundAll.Text = " Date\r\nFound*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(109, 76, 61);
            label2.Location = new Point(32, 292);
            label2.Name = "label2";
            label2.Size = new Size(46, 30);
            label2.TabIndex = 31;
            label2.Text = " Date\r\nFound*";
            // 
            // lblLostAllBreed
            // 
            lblLostAllBreed.AutoSize = true;
            lblLostAllBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAllBreed.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllBreed.Location = new Point(32, 236);
            lblLostAllBreed.Name = "lblLostAllBreed";
            lblLostAllBreed.Size = new Size(41, 15);
            lblLostAllBreed.TabIndex = 30;
            lblLostAllBreed.Text = "Breed";
            // 
            // lblLostAllColour
            // 
            lblLostAllColour.AutoSize = true;
            lblLostAllColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAllColour.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllColour.Location = new Point(32, 182);
            lblLostAllColour.Name = "lblLostAllColour";
            lblLostAllColour.Size = new Size(48, 15);
            lblLostAllColour.TabIndex = 29;
            lblLostAllColour.Text = "Colour*";
            // 
            // lblLostAllAge
            // 
            lblLostAllAge.AutoSize = true;
            lblLostAllAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAllAge.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllAge.Location = new Point(32, 129);
            lblLostAllAge.Name = "lblLostAllAge";
            lblLostAllAge.Size = new Size(29, 15);
            lblLostAllAge.TabIndex = 28;
            lblLostAllAge.Text = "Age";
            // 
            // lblLostAllName
            // 
            lblLostAllName.AutoSize = true;
            lblLostAllName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLostAllName.ForeColor = Color.FromArgb(109, 76, 61);
            lblLostAllName.Location = new Point(32, 71);
            lblLostAllName.Name = "lblLostAllName";
            lblLostAllName.Size = new Size(40, 15);
            lblLostAllName.TabIndex = 27;
            lblLostAllName.Text = "Name";
            // 
            // txtLostAllLocation
            // 
            txtLostAllLocation.Location = new Point(113, 351);
            txtLostAllLocation.Name = "txtLostAllLocation";
            txtLostAllLocation.Size = new Size(134, 23);
            txtLostAllLocation.TabIndex = 26;
            // 
            // txtDateFoundAll
            // 
            txtDateFoundAll.Location = new Point(113, 292);
            txtDateFoundAll.Name = "txtDateFoundAll";
            txtDateFoundAll.Size = new Size(134, 23);
            txtDateFoundAll.TabIndex = 25;
            txtDateFoundAll.TextChanged += textBox8_TextChanged;
            // 
            // txtLostAllBreed
            // 
            txtLostAllBreed.Location = new Point(113, 231);
            txtLostAllBreed.Name = "txtLostAllBreed";
            txtLostAllBreed.Size = new Size(134, 23);
            txtLostAllBreed.TabIndex = 24;
            // 
            // txtLostAllColour
            // 
            txtLostAllColour.Location = new Point(113, 176);
            txtLostAllColour.Name = "txtLostAllColour";
            txtLostAllColour.Size = new Size(134, 23);
            txtLostAllColour.TabIndex = 23;
            // 
            // txtLostAllAge
            // 
            txtLostAllAge.Location = new Point(113, 124);
            txtLostAllAge.Name = "txtLostAllAge";
            txtLostAllAge.Size = new Size(134, 23);
            txtLostAllAge.TabIndex = 22;
            // 
            // txtLostAllName
            // 
            txtLostAllName.Location = new Point(113, 66);
            txtLostAllName.Name = "txtLostAllName";
            txtLostAllName.Size = new Size(134, 23);
            txtLostAllName.TabIndex = 21;
            // 
            // foundAllTab
            // 
            foundAllTab.BackColor = Color.AntiqueWhite;
            foundAllTab.Controls.Add(buttonMarkLost);
            foundAllTab.Controls.Add(buttonViewAllFound);
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
            foundAllTab.Location = new Point(4, 24);
            foundAllTab.Name = "foundAllTab";
            foundAllTab.Size = new Size(971, 493);
            foundAllTab.TabIndex = 2;
            foundAllTab.Text = "View found animals";
            // 
            // buttonMarkLost
            // 
            buttonMarkLost.BackColor = Color.FromArgb(114, 125, 113);
            buttonMarkLost.Font = new Font("Segoe UI", 10F);
            buttonMarkLost.ForeColor = Color.White;
            buttonMarkLost.Location = new Point(560, 446);
            buttonMarkLost.Name = "buttonMarkLost";
            buttonMarkLost.Size = new Size(108, 34);
            buttonMarkLost.TabIndex = 61;
            buttonMarkLost.Text = "Mark as lost";
            buttonMarkLost.UseVisualStyleBackColor = false;
            buttonMarkLost.Click += buttonMarkLost_Click;
            // 
            // buttonViewAllFound
            // 
            buttonViewAllFound.BackColor = Color.FromArgb(114, 125, 113);
            buttonViewAllFound.Font = new Font("Segoe UI", 10F);
            buttonViewAllFound.ForeColor = Color.White;
            buttonViewAllFound.Location = new Point(829, 447);
            buttonViewAllFound.Name = "buttonViewAllFound";
            buttonViewAllFound.Size = new Size(108, 34);
            buttonViewAllFound.TabIndex = 60;
            buttonViewAllFound.Text = "View all";
            buttonViewAllFound.UseVisualStyleBackColor = false;
            buttonViewAllFound.Click += buttonViewAllFound_Click;
            // 
            // dataGridViewFoundAll
            // 
            dataGridViewFoundAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoundAll.Location = new Point(300, 66);
            dataGridViewFoundAll.Name = "dataGridViewFoundAll";
            dataGridViewFoundAll.RowHeadersWidth = 51;
            dataGridViewFoundAll.Size = new Size(637, 358);
            dataGridViewFoundAll.TabIndex = 40;
            dataGridViewFoundAll.CellContentClick += dataGridViewFoundAll_CellContentClick;
            // 
            // lblFoundAllTitle
            // 
            lblFoundAllTitle.AutoSize = true;
            lblFoundAllTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
            lblFoundAllTitle.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllTitle.Location = new Point(532, 16);
            lblFoundAllTitle.Name = "lblFoundAllTitle";
            lblFoundAllTitle.Size = new Size(161, 50);
            lblFoundAllTitle.TabIndex = 59;
            lblFoundAllTitle.Text = "Found Pets";
            // 
            // buttonFoundSearch
            // 
            buttonFoundSearch.BackColor = Color.FromArgb(114, 125, 113);
            buttonFoundSearch.Font = new Font("Segoe UI", 10F);
            buttonFoundSearch.ForeColor = Color.White;
            buttonFoundSearch.Location = new Point(300, 446);
            buttonFoundSearch.Name = "buttonFoundSearch";
            buttonFoundSearch.Size = new Size(108, 34);
            buttonFoundSearch.TabIndex = 58;
            buttonFoundSearch.Text = "Search";
            buttonFoundSearch.UseVisualStyleBackColor = false;
            buttonFoundSearch.Click += buttonFoundSearch_Click;
            // 
            // boxFoundAllSpecies
            // 
            boxFoundAllSpecies.FormattingEnabled = true;
            boxFoundAllSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
            boxFoundAllSpecies.Location = new Point(116, 403);
            boxFoundAllSpecies.Margin = new Padding(3, 2, 3, 2);
            boxFoundAllSpecies.Name = "boxFoundAllSpecies";
            boxFoundAllSpecies.Size = new Size(133, 23);
            boxFoundAllSpecies.TabIndex = 57;
            // 
            // boxFoundAllGender
            // 
            boxFoundAllGender.FormattingEnabled = true;
            boxFoundAllGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
            boxFoundAllGender.Location = new Point(116, 460);
            boxFoundAllGender.Margin = new Padding(3, 2, 3, 2);
            boxFoundAllGender.Name = "boxFoundAllGender";
            boxFoundAllGender.Size = new Size(133, 23);
            boxFoundAllGender.TabIndex = 56;
            // 
            // lblFoundAllGender
            // 
            lblFoundAllGender.AutoSize = true;
            lblFoundAllGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAllGender.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllGender.Location = new Point(35, 466);
            lblFoundAllGender.Name = "lblFoundAllGender";
            lblFoundAllGender.Size = new Size(54, 15);
            lblFoundAllGender.TabIndex = 55;
            lblFoundAllGender.Text = "Gender*";
            // 
            // lblFoundAllSpecies
            // 
            lblFoundAllSpecies.AutoSize = true;
            lblFoundAllSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAllSpecies.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllSpecies.Location = new Point(35, 409);
            lblFoundAllSpecies.Name = "lblFoundAllSpecies";
            lblFoundAllSpecies.Size = new Size(54, 15);
            lblFoundAllSpecies.TabIndex = 54;
            lblFoundAllSpecies.Text = "Species*";
            // 
            // lblFoundAllLocation
            // 
            lblFoundAllLocation.AutoSize = true;
            lblFoundAllLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAllLocation.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllLocation.Location = new Point(35, 356);
            lblFoundAllLocation.Name = "lblFoundAllLocation";
            lblFoundAllLocation.Size = new Size(59, 15);
            lblFoundAllLocation.TabIndex = 53;
            lblFoundAllLocation.Text = "Location*";
            // 
            // lblDateLostAll
            // 
            lblDateLostAll.AutoSize = true;
            lblDateLostAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateLostAll.ForeColor = Color.FromArgb(109, 76, 61);
            lblDateLostAll.Location = new Point(35, 298);
            lblDateLostAll.Name = "lblDateLostAll";
            lblDateLostAll.Size = new Size(65, 15);
            lblDateLostAll.TabIndex = 52;
            lblDateLostAll.Text = "Date Lost*\r\n";
            // 
            // lblFoundAllBreed
            // 
            lblFoundAllBreed.AutoSize = true;
            lblFoundAllBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAllBreed.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllBreed.Location = new Point(35, 236);
            lblFoundAllBreed.Name = "lblFoundAllBreed";
            lblFoundAllBreed.Size = new Size(41, 15);
            lblFoundAllBreed.TabIndex = 50;
            lblFoundAllBreed.Text = "Breed";
            // 
            // lblFoundAllColour
            // 
            lblFoundAllColour.AutoSize = true;
            lblFoundAllColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAllColour.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllColour.Location = new Point(35, 182);
            lblFoundAllColour.Name = "lblFoundAllColour";
            lblFoundAllColour.Size = new Size(48, 15);
            lblFoundAllColour.TabIndex = 49;
            lblFoundAllColour.Text = "Colour*";
            // 
            // lblFoundAllAge
            // 
            lblFoundAllAge.AutoSize = true;
            lblFoundAllAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAllAge.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllAge.Location = new Point(35, 129);
            lblFoundAllAge.Name = "lblFoundAllAge";
            lblFoundAllAge.Size = new Size(29, 15);
            lblFoundAllAge.TabIndex = 48;
            lblFoundAllAge.Text = "Age";
            // 
            // lblFoundAllName
            // 
            lblFoundAllName.AutoSize = true;
            lblFoundAllName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAllName.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAllName.Location = new Point(35, 71);
            lblFoundAllName.Name = "lblFoundAllName";
            lblFoundAllName.Size = new Size(45, 15);
            lblFoundAllName.TabIndex = 47;
            lblFoundAllName.Text = "Name*";
            // 
            // txtFoundAllLocation
            // 
            txtFoundAllLocation.Location = new Point(116, 351);
            txtFoundAllLocation.Name = "txtFoundAllLocation";
            txtFoundAllLocation.Size = new Size(134, 23);
            txtFoundAllLocation.TabIndex = 46;
            // 
            // txtDateLostAll
            // 
            txtDateLostAll.Location = new Point(116, 292);
            txtDateLostAll.Name = "txtDateLostAll";
            txtDateLostAll.Size = new Size(134, 23);
            txtDateLostAll.TabIndex = 45;
            // 
            // txtFoundAllBreed
            // 
            txtFoundAllBreed.Location = new Point(116, 231);
            txtFoundAllBreed.Name = "txtFoundAllBreed";
            txtFoundAllBreed.Size = new Size(134, 23);
            txtFoundAllBreed.TabIndex = 44;
            // 
            // txtFoundAllColour
            // 
            txtFoundAllColour.Location = new Point(116, 176);
            txtFoundAllColour.Name = "txtFoundAllColour";
            txtFoundAllColour.Size = new Size(134, 23);
            txtFoundAllColour.TabIndex = 43;
            // 
            // txtFoundAllAge
            // 
            txtFoundAllAge.Location = new Point(116, 124);
            txtFoundAllAge.Name = "txtFoundAllAge";
            txtFoundAllAge.Size = new Size(134, 23);
            txtFoundAllAge.TabIndex = 42;
            // 
            // txtFoundAllName
            // 
            txtFoundAllName.Location = new Point(116, 66);
            txtFoundAllName.Name = "txtFoundAllName";
            txtFoundAllName.Size = new Size(134, 23);
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
            foundTab.Location = new Point(4, 24);
            foundTab.Name = "foundTab";
            foundTab.Size = new Size(971, 493);
            foundTab.TabIndex = 3;
            foundTab.Text = "Add a found animal";
            // 
            // lblDateFound
            // 
            lblDateFound.AutoSize = true;
            lblDateFound.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateFound.ForeColor = Color.FromArgb(109, 76, 61);
            lblDateFound.Location = new Point(35, 344);
            lblDateFound.Name = "lblDateFound";
            lblDateFound.Size = new Size(46, 30);
            lblDateFound.TabIndex = 49;
            lblDateFound.Text = " Date\r\nFound*";
            // 
            // txtDateFound
            // 
            txtDateFound.Location = new Point(116, 344);
            txtDateFound.Name = "txtDateFound";
            txtDateFound.Size = new Size(134, 23);
            txtDateFound.TabIndex = 48;
            // 
            // boxFoundSpecies
            // 
            boxFoundSpecies.FormattingEnabled = true;
            boxFoundSpecies.Items.AddRange(new object[] { "Cat", "Dog", "Rabbit", "Parrot", "Hamster", "Guinea Pig", "Other" });
            boxFoundSpecies.Location = new Point(424, 98);
            boxFoundSpecies.Margin = new Padding(3, 2, 3, 2);
            boxFoundSpecies.Name = "boxFoundSpecies";
            boxFoundSpecies.Size = new Size(133, 23);
            boxFoundSpecies.TabIndex = 47;
            // 
            // boxFoundGender
            // 
            boxFoundGender.FormattingEnabled = true;
            boxFoundGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
            boxFoundGender.Location = new Point(424, 161);
            boxFoundGender.Margin = new Padding(3, 2, 3, 2);
            boxFoundGender.Name = "boxFoundGender";
            boxFoundGender.Size = new Size(133, 23);
            boxFoundGender.TabIndex = 46;
            // 
            // buttonImageFound
            // 
            buttonImageFound.BackColor = Color.FromArgb(114, 125, 113);
            buttonImageFound.Font = new Font("Segoe UI", 10F);
            buttonImageFound.ForeColor = Color.White;
            buttonImageFound.Location = new Point(724, 98);
            buttonImageFound.Name = "buttonImageFound";
            buttonImageFound.Size = new Size(177, 43);
            buttonImageFound.TabIndex = 45;
            buttonImageFound.Text = "Upload an image";
            buttonImageFound.UseVisualStyleBackColor = false;
            buttonImageFound.Click += buttonImageFound_Click;
            // 
            // pictureBoxFound
            // 
            pictureBoxFound.Location = new Point(678, 161);
            pictureBoxFound.Name = "pictureBoxFound";
            pictureBoxFound.Size = new Size(259, 269);
            pictureBoxFound.TabIndex = 44;
            pictureBoxFound.TabStop = false;
            // 
            // buttonSaveFound
            // 
            buttonSaveFound.BackColor = Color.FromArgb(114, 125, 113);
            buttonSaveFound.Font = new Font("Segoe UI", 10F);
            buttonSaveFound.ForeColor = Color.White;
            buttonSaveFound.Location = new Point(758, 442);
            buttonSaveFound.Name = "buttonSaveFound";
            buttonSaveFound.Size = new Size(108, 34);
            buttonSaveFound.TabIndex = 43;
            buttonSaveFound.Text = "Save";
            buttonSaveFound.UseVisualStyleBackColor = false;
            buttonSaveFound.Click += buttonSaveFound_Click;
            // 
            // lblFoundDesc
            // 
            lblFoundDesc.AutoSize = true;
            lblFoundDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundDesc.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundDesc.Location = new Point(315, 229);
            lblFoundDesc.Name = "lblFoundDesc";
            lblFoundDesc.Size = new Size(71, 15);
            lblFoundDesc.TabIndex = 42;
            lblFoundDesc.Text = "Description";
            // 
            // lblFoundGender
            // 
            lblFoundGender.AutoSize = true;
            lblFoundGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundGender.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundGender.Location = new Point(315, 167);
            lblFoundGender.Name = "lblFoundGender";
            lblFoundGender.Size = new Size(54, 15);
            lblFoundGender.TabIndex = 41;
            lblFoundGender.Text = "Gender*";
            // 
            // lblFoundSpecies
            // 
            lblFoundSpecies.AutoSize = true;
            lblFoundSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundSpecies.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundSpecies.Location = new Point(315, 101);
            lblFoundSpecies.Name = "lblFoundSpecies";
            lblFoundSpecies.Size = new Size(54, 15);
            lblFoundSpecies.TabIndex = 40;
            lblFoundSpecies.Text = "Species*";
            // 
            // lblFoundLocation
            // 
            lblFoundLocation.AutoSize = true;
            lblFoundLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundLocation.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundLocation.Location = new Point(35, 416);
            lblFoundLocation.Name = "lblFoundLocation";
            lblFoundLocation.Size = new Size(59, 15);
            lblFoundLocation.TabIndex = 39;
            lblFoundLocation.Text = "Location*";
            // 
            // lblFoundBreed
            // 
            lblFoundBreed.AutoSize = true;
            lblFoundBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundBreed.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundBreed.Location = new Point(35, 286);
            lblFoundBreed.Name = "lblFoundBreed";
            lblFoundBreed.Size = new Size(41, 15);
            lblFoundBreed.TabIndex = 37;
            lblFoundBreed.Text = "Breed";
            // 
            // lblFoundColour
            // 
            lblFoundColour.AutoSize = true;
            lblFoundColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundColour.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundColour.Location = new Point(35, 229);
            lblFoundColour.Name = "lblFoundColour";
            lblFoundColour.Size = new Size(48, 15);
            lblFoundColour.TabIndex = 36;
            lblFoundColour.Text = "Colour*";
            // 
            // lblFoundAge
            // 
            lblFoundAge.AutoSize = true;
            lblFoundAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundAge.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundAge.Location = new Point(35, 167);
            lblFoundAge.Name = "lblFoundAge";
            lblFoundAge.Size = new Size(29, 15);
            lblFoundAge.TabIndex = 35;
            lblFoundAge.Text = "Age";
            // 
            // lblFoundName
            // 
            lblFoundName.AutoSize = true;
            lblFoundName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoundName.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundName.Location = new Point(35, 104);
            lblFoundName.Name = "lblFoundName";
            lblFoundName.Size = new Size(40, 15);
            lblFoundName.TabIndex = 34;
            lblFoundName.Text = "Name";
            // 
            // lblFoundTitle
            // 
            lblFoundTitle.AutoSize = true;
            lblFoundTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold);
            lblFoundTitle.ForeColor = Color.FromArgb(109, 76, 61);
            lblFoundTitle.Location = new Point(315, 20);
            lblFoundTitle.Name = "lblFoundTitle";
            lblFoundTitle.Size = new Size(314, 50);
            lblFoundTitle.TabIndex = 33;
            lblFoundTitle.Text = "Have you found a pet?";
            // 
            // txtFoundDesc
            // 
            txtFoundDesc.Location = new Point(315, 260);
            txtFoundDesc.Multiline = true;
            txtFoundDesc.Name = "txtFoundDesc";
            txtFoundDesc.Size = new Size(305, 172);
            txtFoundDesc.TabIndex = 32;
            // 
            // txtFoundLocation
            // 
            txtFoundLocation.Location = new Point(116, 410);
            txtFoundLocation.Name = "txtFoundLocation";
            txtFoundLocation.Size = new Size(134, 23);
            txtFoundLocation.TabIndex = 31;
            // 
            // txtFoundBreed
            // 
            txtFoundBreed.Location = new Point(116, 281);
            txtFoundBreed.Name = "txtFoundBreed";
            txtFoundBreed.Size = new Size(134, 23);
            txtFoundBreed.TabIndex = 29;
            // 
            // txtFoundColour
            // 
            txtFoundColour.Location = new Point(116, 224);
            txtFoundColour.Name = "txtFoundColour";
            txtFoundColour.Size = new Size(134, 23);
            txtFoundColour.TabIndex = 28;
            // 
            // txtFoundAge
            // 
            txtFoundAge.Location = new Point(116, 162);
            txtFoundAge.Name = "txtFoundAge";
            txtFoundAge.Size = new Size(134, 23);
            txtFoundAge.TabIndex = 27;
            // 
            // txtFoundName
            // 
            txtFoundName.Location = new Point(116, 99);
            txtFoundName.Name = "txtFoundName";
            txtFoundName.Size = new Size(134, 23);
            txtFoundName.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 513);
            Controls.Add(Tab);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button buttonViewAllLost;
        private Button buttonViewAllFound;
        private Button buttonMarkFound;
        private Button buttonMarkLost;
    }
}
