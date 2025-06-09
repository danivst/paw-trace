namespace Proekt
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
			FindTab = new TabControl();
			lostTab = new TabPage();
			buttonSave = new Button();
			pictureBox = new PictureBox();
			buttonImage = new Button();
			labelLostLocation = new Label();
			txtLostLocation = new TextBox();
			labelLostDesc = new Label();
			txtBoxDesc = new TextBox();
			txtLostDateLost = new TextBox();
			labelLostDate = new Label();
			labelLostBreed = new Label();
			labelLostColour = new Label();
			labelLostAge = new Label();
			labelLostGender = new Label();
			labelLostType = new Label();
			boxGender = new ComboBox();
			txtLostBreed = new TextBox();
			lostTitle = new Label();
			labelLostName = new Label();
			txtLostAge = new TextBox();
			txtLostName = new TextBox();
			txtLostColour = new TextBox();
			boxType = new ComboBox();
			foundTab = new TabPage();
			label1 = new Label();
			comboBox2 = new ComboBox();
			comboBox1 = new ComboBox();
			textBox13 = new TextBox();
			textBox12 = new TextBox();
			textBox11 = new TextBox();
			textBox10 = new TextBox();
			textBox9 = new TextBox();
			textBox8 = new TextBox();
			buttonSearch = new Button();
			labelFoundGender = new Label();
			label5 = new Label();
			labelFoundBreed = new Label();
			labelFoundColour = new Label();
			labelFoundAge = new Label();
			labelFoundName = new Label();
			buttonFound = new Button();
			foundTitle = new Label();
			FindTab.SuspendLayout();
			lostTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			foundTab.SuspendLayout();
			SuspendLayout();
			// 
			// FindTab
			// 
			FindTab.Controls.Add(lostTab);
			FindTab.Controls.Add(foundTab);
			FindTab.Location = new Point(-1, -3);
			FindTab.Name = "FindTab";
			FindTab.SelectedIndex = 0;
			FindTab.Size = new Size(972, 597);
			FindTab.TabIndex = 0;
			// 
			// lostTab
			// 
			lostTab.BackColor = Color.AntiqueWhite;
			lostTab.Controls.Add(buttonSave);
			lostTab.Controls.Add(pictureBox);
			lostTab.Controls.Add(buttonImage);
			lostTab.Controls.Add(labelLostLocation);
			lostTab.Controls.Add(txtLostLocation);
			lostTab.Controls.Add(labelLostDesc);
			lostTab.Controls.Add(txtBoxDesc);
			lostTab.Controls.Add(txtLostDateLost);
			lostTab.Controls.Add(labelLostDate);
			lostTab.Controls.Add(labelLostBreed);
			lostTab.Controls.Add(labelLostColour);
			lostTab.Controls.Add(labelLostAge);
			lostTab.Controls.Add(labelLostGender);
			lostTab.Controls.Add(labelLostType);
			lostTab.Controls.Add(boxGender);
			lostTab.Controls.Add(txtLostBreed);
			lostTab.Controls.Add(lostTitle);
			lostTab.Controls.Add(labelLostName);
			lostTab.Controls.Add(txtLostAge);
			lostTab.Controls.Add(txtLostName);
			lostTab.Controls.Add(txtLostColour);
			lostTab.Controls.Add(boxType);
			lostTab.Location = new Point(4, 29);
			lostTab.Name = "lostTab";
			lostTab.Padding = new Padding(3);
			lostTab.Size = new Size(964, 564);
			lostTab.TabIndex = 0;
			lostTab.Text = "Lost Pets";
			lostTab.Click += lostTab_Click;
			// 
			// buttonSave
			// 
			buttonSave.BackColor = Color.FromArgb(114, 125, 113);
			buttonSave.Font = new Font("Segoe UI", 10F);
			buttonSave.ForeColor = Color.White;
			buttonSave.Location = new Point(732, 496);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(113, 38);
			buttonSave.TabIndex = 21;
			buttonSave.Text = "Save";
			buttonSave.UseVisualStyleBackColor = false;
			buttonSave.Visible = false;
			buttonSave.Click += buttonSave_Click;
			// 
			// pictureBox
			// 
			pictureBox.Location = new Point(642, 196);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(292, 277);
			pictureBox.TabIndex = 20;
			pictureBox.TabStop = false;
			// 
			// buttonImage
			// 
			buttonImage.BackColor = Color.FromArgb(114, 125, 113);
			buttonImage.FlatAppearance.BorderColor = Color.FromArgb(231, 90, 124);
			buttonImage.Font = new Font("Segoe UI", 10F);
			buttonImage.ForeColor = Color.White;
			buttonImage.Location = new Point(698, 119);
			buttonImage.Name = "buttonImage";
			buttonImage.Size = new Size(179, 42);
			buttonImage.TabIndex = 19;
			buttonImage.Text = "Upload an image";
			buttonImage.UseVisualStyleBackColor = false;
			buttonImage.Click += buttonImage_Click;
			// 
			// labelLostLocation
			// 
			labelLostLocation.AutoSize = true;
			labelLostLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostLocation.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostLocation.Location = new Point(23, 514);
			labelLostLocation.Name = "labelLostLocation";
			labelLostLocation.Size = new Size(69, 20);
			labelLostLocation.TabIndex = 18;
			labelLostLocation.Text = "Location";
			// 
			// txtLostLocation
			// 
			txtLostLocation.Location = new Point(121, 507);
			txtLostLocation.Name = "txtLostLocation";
			txtLostLocation.Size = new Size(125, 27);
			txtLostLocation.TabIndex = 17;
			// 
			// labelLostDesc
			// 
			labelLostDesc.AutoSize = true;
			labelLostDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostDesc.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostDesc.Location = new Point(304, 272);
			labelLostDesc.Name = "labelLostDesc";
			labelLostDesc.Size = new Size(100, 20);
			labelLostDesc.TabIndex = 16;
			labelLostDesc.Text = "Description*:";
			// 
			// txtBoxDesc
			// 
			txtBoxDesc.Location = new Point(304, 311);
			txtBoxDesc.Multiline = true;
			txtBoxDesc.Name = "txtBoxDesc";
			txtBoxDesc.Size = new Size(278, 223);
			txtBoxDesc.TabIndex = 15;
			// 
			// txtLostDateLost
			// 
			txtLostDateLost.Location = new Point(121, 429);
			txtLostDateLost.Name = "txtLostDateLost";
			txtLostDateLost.Size = new Size(125, 27);
			txtLostDateLost.TabIndex = 14;
			// 
			// labelLostDate
			// 
			labelLostDate.AutoSize = true;
			labelLostDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostDate.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostDate.Location = new Point(23, 436);
			labelLostDate.Name = "labelLostDate";
			labelLostDate.Size = new Size(76, 20);
			labelLostDate.TabIndex = 13;
			labelLostDate.Text = "Date Lost";
			// 
			// labelLostBreed
			// 
			labelLostBreed.AutoSize = true;
			labelLostBreed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostBreed.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostBreed.Location = new Point(24, 354);
			labelLostBreed.Name = "labelLostBreed";
			labelLostBreed.Size = new Size(57, 20);
			labelLostBreed.TabIndex = 12;
			labelLostBreed.Text = "Breed*";
			// 
			// labelLostColour
			// 
			labelLostColour.AutoSize = true;
			labelLostColour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostColour.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostColour.Location = new Point(23, 279);
			labelLostColour.Name = "labelLostColour";
			labelLostColour.Size = new Size(55, 20);
			labelLostColour.TabIndex = 11;
			labelLostColour.Text = "Colour";
			// 
			// labelLostAge
			// 
			labelLostAge.AutoSize = true;
			labelLostAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostAge.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostAge.Location = new Point(24, 204);
			labelLostAge.Name = "labelLostAge";
			labelLostAge.Size = new Size(44, 20);
			labelLostAge.TabIndex = 10;
			labelLostAge.Text = "Age*";
			// 
			// labelLostGender
			// 
			labelLostGender.AutoSize = true;
			labelLostGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostGender.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostGender.Location = new Point(304, 204);
			labelLostGender.Name = "labelLostGender";
			labelLostGender.Size = new Size(60, 20);
			labelLostGender.TabIndex = 9;
			labelLostGender.Text = "Gender";
			// 
			// labelLostType
			// 
			labelLostType.AutoSize = true;
			labelLostType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			labelLostType.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostType.Location = new Point(304, 127);
			labelLostType.Name = "labelLostType";
			labelLostType.Size = new Size(42, 20);
			labelLostType.TabIndex = 8;
			labelLostType.Text = "Type";
			// 
			// boxGender
			// 
			boxGender.FormattingEnabled = true;
			boxGender.Items.AddRange(new object[] { "Female", "Male", "Castrated" });
			boxGender.Location = new Point(388, 196);
			boxGender.Name = "boxGender";
			boxGender.Size = new Size(151, 28);
			boxGender.TabIndex = 7;
			boxGender.SelectedIndexChanged += boxGender_SelectedIndexChanged;
			// 
			// txtLostBreed
			// 
			txtLostBreed.Location = new Point(121, 347);
			txtLostBreed.Name = "txtLostBreed";
			txtLostBreed.Size = new Size(125, 27);
			txtLostBreed.TabIndex = 6;
			// 
			// lostTitle
			// 
			lostTitle.AutoSize = true;
			lostTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lostTitle.ForeColor = Color.FromArgb(109, 76, 61);
			lostTitle.Location = new Point(278, 32);
			lostTitle.Name = "lostTitle";
			lostTitle.Size = new Size(409, 63);
			lostTitle.TabIndex = 5;
			lostTitle.Text = "Have you lost your pet?";
			// 
			// labelLostName
			// 
			labelLostName.AutoSize = true;
			labelLostName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			labelLostName.ForeColor = Color.FromArgb(109, 76, 61);
			labelLostName.Location = new Point(23, 127);
			labelLostName.Name = "labelLostName";
			labelLostName.Size = new Size(51, 20);
			labelLostName.TabIndex = 4;
			labelLostName.Text = "Name";
			// 
			// txtLostAge
			// 
			txtLostAge.Location = new Point(121, 197);
			txtLostAge.Name = "txtLostAge";
			txtLostAge.Size = new Size(125, 27);
			txtLostAge.TabIndex = 3;
			// 
			// txtLostName
			// 
			txtLostName.Location = new Point(121, 120);
			txtLostName.Name = "txtLostName";
			txtLostName.Size = new Size(125, 27);
			txtLostName.TabIndex = 2;
			// 
			// txtLostColour
			// 
			txtLostColour.Location = new Point(121, 272);
			txtLostColour.Name = "txtLostColour";
			txtLostColour.Size = new Size(125, 27);
			txtLostColour.TabIndex = 1;
			// 
			// boxType
			// 
			boxType.FormattingEnabled = true;
			boxType.Items.AddRange(new object[] { "Cat", "Dog", "Bunny", "Hamster", "Guinea Pig" });
			boxType.Location = new Point(388, 119);
			boxType.Name = "boxType";
			boxType.Size = new Size(151, 28);
			boxType.TabIndex = 0;
			// 
			// foundTab
			// 
			foundTab.BackColor = Color.AntiqueWhite;
			foundTab.Controls.Add(label1);
			foundTab.Controls.Add(comboBox2);
			foundTab.Controls.Add(comboBox1);
			foundTab.Controls.Add(textBox13);
			foundTab.Controls.Add(textBox12);
			foundTab.Controls.Add(textBox11);
			foundTab.Controls.Add(textBox10);
			foundTab.Controls.Add(textBox9);
			foundTab.Controls.Add(textBox8);
			foundTab.Controls.Add(buttonSearch);
			foundTab.Controls.Add(labelFoundGender);
			foundTab.Controls.Add(label5);
			foundTab.Controls.Add(labelFoundBreed);
			foundTab.Controls.Add(labelFoundColour);
			foundTab.Controls.Add(labelFoundAge);
			foundTab.Controls.Add(labelFoundName);
			foundTab.Controls.Add(buttonFound);
			foundTab.Controls.Add(foundTitle);
			foundTab.Location = new Point(4, 29);
			foundTab.Name = "foundTab";
			foundTab.Padding = new Padding(3);
			foundTab.Size = new Size(964, 564);
			foundTab.TabIndex = 1;
			foundTab.Text = "Find Pets";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(28, 272);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 26;
			label1.Text = "label1";
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(137, 487);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(151, 28);
			comboBox2.TabIndex = 25;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(137, 435);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 24;
			// 
			// textBox13
			// 
			textBox13.Location = new Point(137, 381);
			textBox13.Name = "textBox13";
			textBox13.Size = new Size(151, 27);
			textBox13.TabIndex = 20;
			// 
			// textBox12
			// 
			textBox12.Location = new Point(137, 324);
			textBox12.Name = "textBox12";
			textBox12.Size = new Size(151, 27);
			textBox12.TabIndex = 19;
			// 
			// textBox11
			// 
			textBox11.Location = new Point(137, 265);
			textBox11.Name = "textBox11";
			textBox11.Size = new Size(151, 27);
			textBox11.TabIndex = 18;
			// 
			// textBox10
			// 
			textBox10.Location = new Point(137, 213);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(151, 27);
			textBox10.TabIndex = 17;
			// 
			// textBox9
			// 
			textBox9.Location = new Point(137, 162);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(151, 27);
			textBox9.TabIndex = 16;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(137, 110);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(151, 27);
			textBox8.TabIndex = 15;
			// 
			// buttonSearch
			// 
			buttonSearch.Location = new Point(321, 479);
			buttonSearch.Name = "buttonSearch";
			buttonSearch.Size = new Size(103, 36);
			buttonSearch.TabIndex = 14;
			buttonSearch.Text = "Search";
			buttonSearch.UseVisualStyleBackColor = true;
			buttonSearch.Click += button1_Click;
			// 
			// labelFoundGender
			// 
			labelFoundGender.AutoSize = true;
			labelFoundGender.Location = new Point(28, 495);
			labelFoundGender.Name = "labelFoundGender";
			labelFoundGender.Size = new Size(57, 20);
			labelFoundGender.TabIndex = 13;
			labelFoundGender.Text = "Gender";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 331);
			label5.Name = "label5";
			label5.Size = new Size(86, 20);
			label5.TabIndex = 12;
			label5.Text = "Date Found";
			// 
			// labelFoundBreed
			// 
			labelFoundBreed.AutoSize = true;
			labelFoundBreed.Location = new Point(28, 272);
			labelFoundBreed.Name = "labelFoundBreed";
			labelFoundBreed.Size = new Size(0, 20);
			labelFoundBreed.TabIndex = 11;
			// 
			// labelFoundColour
			// 
			labelFoundColour.AutoSize = true;
			labelFoundColour.Location = new Point(28, 220);
			labelFoundColour.Name = "labelFoundColour";
			labelFoundColour.Size = new Size(53, 20);
			labelFoundColour.TabIndex = 10;
			labelFoundColour.Text = "Colour";
			// 
			// labelFoundAge
			// 
			labelFoundAge.AutoSize = true;
			labelFoundAge.Location = new Point(28, 169);
			labelFoundAge.Name = "labelFoundAge";
			labelFoundAge.Size = new Size(36, 20);
			labelFoundAge.TabIndex = 9;
			labelFoundAge.Text = "Age";
			// 
			// labelFoundName
			// 
			labelFoundName.AutoSize = true;
			labelFoundName.Location = new Point(28, 117);
			labelFoundName.Name = "labelFoundName";
			labelFoundName.Size = new Size(49, 20);
			labelFoundName.TabIndex = 8;
			labelFoundName.Text = "Name";
			// 
			// buttonFound
			// 
			buttonFound.BackColor = Color.AntiqueWhite;
			buttonFound.FlatAppearance.BorderColor = Color.White;
			buttonFound.FlatAppearance.BorderSize = 50;
			buttonFound.Font = new Font("Gill Sans MT Condensed", 20F, FontStyle.Underline);
			buttonFound.Location = new Point(617, 26);
			buttonFound.Name = "buttonFound";
			buttonFound.Size = new Size(207, 49);
			buttonFound.TabIndex = 7;
			buttonFound.Text = "I found a pet";
			buttonFound.UseVisualStyleBackColor = false;
			// 
			// foundTitle
			// 
			foundTitle.AutoSize = true;
			foundTitle.Font = new Font("Gill Sans MT Condensed", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
			foundTitle.ForeColor = Color.FromArgb(109, 76, 61);
			foundTitle.Location = new Point(163, 14);
			foundTitle.Name = "foundTitle";
			foundTitle.Size = new Size(448, 63);
			foundTitle.TabIndex = 6;
			foundTitle.Text = "Have you seen these pets?";
			foundTitle.Click += label2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(971, 594);
			Controls.Add(FindTab);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			FindTab.ResumeLayout(false);
			lostTab.ResumeLayout(false);
			lostTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			foundTab.ResumeLayout(false);
			foundTab.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl FindTab;
		private TabPage lostTab;
		private TabPage foundTab;
		private ComboBox boxType;
		private TextBox txtLostAge;
		private TextBox txtLostName;
		private TextBox txtLostColour;
		private Label lostTitle;
		private Label labelLostName;
		private ComboBox boxGender;
		private TextBox txtLostBreed;
		private Label labelLostDesc;
		private TextBox txtBoxDesc;
		private TextBox txtLostDateLost;
		private Label labelLostDate;
		private Label labelLostBreed;
		private Label labelLostColour;
		private Label labelLostAge;
		private Label labelLostGender;
		private Label labelLostType;
		private TextBox txtLostLocation;
		private Label labelLostLocation;
		private PictureBox pictureBox;
		private Button buttonImage;
		private Button buttonSave;
		private Label foundTitle;
		private ListView listView1;
		private Button buttonFound;
		private Label label5;
		private Label labelFoundBreed;
		private Label labelFoundColour;
		private Label labelFoundAge;
		private Label labelFoundName;
		private Label label7;
		private Label label6;
		private TextBox textBox13;
		private TextBox textBox12;
		private TextBox textBox11;
		private TextBox textBox10;
		private TextBox textBox9;
		private TextBox textBox8;
		private Button buttonSearch;
		private Label labelFoundGender;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
		private Label label1;
		private PictureBox pictureBox1;
	}
}
