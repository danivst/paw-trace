using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PawTrace
{
	public partial class Form1 : Form
	{
		private bool placeHolderActive = false;

		private LostAnimalController lostAnimalController = new LostAnimalController();
		private FoundAnimalController foundAnimalController = new FoundAnimalController();
		private LocationController locationController = new LocationController();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ClearTextBoxesLost()
		{
			txtLostName.Text = "";
			txtLostAge.Text = "";
			txtLostColour.Text = "";
			txtLostBreed.Text = "";
			txtDateLost.Text = "";
			txtLostLocation.Text = "";
			txtLostDesc.Text = "Write a description...";
			txtLostDesc.ForeColor = Color.Gray;
			placeHolderActive = true;
			pictureBoxLost.Image = null;
		}
		private void ClearTextBoxesLostAll()
		{
			txtLostName.Text = "";
			txtLostAge.Text = "";
			txtLostColour.Text = "";
			txtLostBreed.Text = "";
			txtDateLost.Text = "";
			txtLostLocation.Text = "";
		}

		private void ClearTextBoxesFound()
		{
			txtLostName.Text = "";
			txtLostAge.Text = "";
			txtLostColour.Text = "";
			txtLostBreed.Text = "";
			txtDateLost.Text = "";
			txtLostLocation.Text = "";
			txtLostDesc.Text = "Write a description...";
			txtLostDesc.ForeColor = Color.Gray;
			placeHolderActive = true;
			pictureBoxLost.Image = null;
		}

		private void ClearTextBoxesFoundAll()
		{
			txtLostName.Text = "";
			txtLostAge.Text = "";
			txtLostColour.Text = "";
			txtLostBreed.Text = "";
			txtDateLost.Text = "";
			txtLostLocation.Text = "";
		}

		private void txtLostDesc_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtLostDesc.Text))
			{
				txtLostDesc.Text = "Write a description...";
				txtLostDesc.ForeColor = Color.Gray;
				placeHolderActive = true;
			}
		}

		private void txtLostDesc_KeyDown(object sender, KeyEventArgs e)
		{
			if (placeHolderActive)
			{
				txtLostDesc.Clear();
				txtLostDesc.ForeColor = Color.Black;
				placeHolderActive = false;
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblLostColour_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void lostTab_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void boxLostGender_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectGender = boxLostGender.SelectedItem.ToString();
			if (selectGender == "Male")
			{
				lostTab.BackColor = Color.LightBlue;
			} else if (selectGender == "Female")
			{
				lostTab.BackColor = Color.MistyRose;
			} else
			{
				lostTab.BackColor = Color.AntiqueWhite;
			}
		}

		private void buttonSaveLost_Click(object sender, EventArgs e)
		{
			var name = txtLostName.Text;
			var age = 0;
			int.TryParse(txtLostAge.Text, out age);
			var color = txtLostColour.Text;
			var breed = txtLostBreed.Text;
			var dateAddLost = txtDateLost.Text;
			DateOnly dateLost;
			if (!DateOnly.TryParseExact(dateAddLost, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateLost))
			{
				throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
			}
			var locationToAdd = txtLostLocation.Text;
			var speciesToAdd = boxLostSpecies.Text;
			var genderToAdd = boxLostGender.Text;
			var desc = txtLostDesc.Text;

			PetType species = PetType.Other;
			if (speciesToAdd == "Cat")
			{
				species = PetType.Cat;
			} else if (speciesToAdd == "Dog")
			{
				species = PetType.Dog;
			} else if (speciesToAdd == "Rabbit")
			{
				species = PetType.Rabbit;
			} else if (speciesToAdd == "Parrot")
			{
				species = PetType.Parrot;
			} else if (speciesToAdd == "Hamster")
			{
				species = PetType.Hamster;
			} else if (speciesToAdd == "Guinea Pig")
			{
				species = PetType.GuineaPig;
			} else if (speciesToAdd == "Other")
			{
				species = PetType.Other;
			}

			Gender gender = Gender.Castrated;
			if (genderToAdd == "Female")
			{
				gender = Gender.Female;
			} else if (genderToAdd == "Male")
			{
				gender = Gender.Male;
			} else if (genderToAdd == "Castrated")
			{
				gender = Gender.Castrated;
			}

			string[] locationArr = locationToAdd.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < locationToAdd.Length; i++)
			{
				locationArr[i] = locationArr[i].Trim();
			}

			byte[] imageBytes = null;

			if (pictureBoxLost.Image != null)
			{
				imageBytes = ImageToByteArray(pictureBoxLost.Image);
			}

			var location = locationController.GetOrAdd(locationArr[0], locationArr[1]);

			LostAnimal lostAnimal = new LostAnimal
			{
				Name = name,
				Age = age,
				Color = color,
				Breed = breed,
				DateLost = dateLost,
				LocationId = location.Id,
				Species = species,
				Gender = gender,
				Description = desc,
				Image = imageBytes
			};

			lostAnimalController.Add(lostAnimal);
			ClearTextBoxesLost();
		}

		private void buttonLostImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Select an image";
				openFileDialog.Filter = "(*.jpg;*.jpeg;*.png;*.bmp;*.mp4)|*.JPG;*.JPEG;*.PNG;*.BMP;*.MP4";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBoxLost.Image = Image.FromFile(openFileDialog.FileName);
					pictureBoxLost.SizeMode = PictureBoxSizeMode.StretchImage;
					ImageToByteArray(pictureBoxLost.Image);
				}
			}
		}

		private byte[] ImageToByteArray(Image image)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				return ms.ToArray();
			}
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			// TAB 1
			ClearTextBoxesLost();
			txtLostDesc.Text = "Write a description...";
			txtLostDesc.ForeColor = Color.Gray;
			placeHolderActive = true;
			txtLostDesc.KeyDown += txtLostDesc_KeyDown;
			txtLostDesc.Leave += txtLostDesc_Leave;

			// TAB 2
			LoadDataLost();
			ClearTextBoxesLostAll();

			// TAB 3
			LoadDataFound();
			ClearTextBoxesFoundAll();

			// TAB 4
			ClearTextBoxesFound();
			txtLostDesc.Text = "Write a description...";
			txtLostDesc.ForeColor = Color.Gray;
			placeHolderActive = true;
			txtLostDesc.KeyDown += txtLostDesc_KeyDown;
			txtLostDesc.Leave += txtLostDesc_Leave;
		}

		private void dataGridViewLostAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void LoadDataLost()
		{
			using (SqlConnection conn = new SqlConnection(Configuration.connectionString))
			{
				string query = "SELECT * FROM LostAnimals";
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				DataTable table = new DataTable();
				adapter.Fill(table);
				dataGridViewLostAll.DataSource = table;
			}
		}

		private void LoadDataFound()
		{
			using (SqlConnection conn = new SqlConnection(Configuration.connectionString))
			{
				string query = "SELECT * FROM FoundAnimals";
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				DataTable table = new DataTable();
				adapter.Fill(table);
				dataGridViewFoundAll.DataSource = table;
			}
		}

		private void buttonLostSearch_Click(object sender, EventArgs e)
		{
			// Collect inputs
			string name = txtLostName.Text.Trim();
			string color = txtLostColour.Text.Trim();
			string breed = txtLostBreed.Text.Trim();
			string locationInput = txtLostLocation.Text.Trim(); // e.g., "City, Country"
			string dateFoundStr = txtDateFound.Text.Trim(); // e.g., "dd/MM/yyyy"
			int genderSelected = boxLostGender.SelectedIndex; // 0: Female, 1: Male, 2: Castrated
			int speciesSelected = boxLostSpecies.SelectedIndex; // 0: Cat, 1: Dog, etc.
			var age = 0;
			int.TryParse(txtLostAge.Text, out age);

			// Parse date
			DateOnly dateFound;
			bool dateParsed = DateOnly.TryParseExact(dateFoundStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFound);
			if (!dateParsed && !string.IsNullOrEmpty(dateFoundStr))
			{
				MessageBox.Show("Invalid date format. Please use dd/MM/yyyy");
				return;
			}

			// Parse location
			string city = "";
			string country = "";
			if (!string.IsNullOrEmpty(locationInput))
			{
				var parts = locationInput.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
				if (parts.Length >= 2)
				{
					city = parts[0];
					country = parts[1];
				}
			}

			// Build your filter logic
			var filteredAnimals = new List<LostAnimal>();

			foreach (var animal in lostAnimalController.GetAll()) // Or fetch from DB
			{
				// Gender check
				bool genderMatch = false;
				switch (genderSelected)
				{
					case 0: genderMatch = animal.Gender == Gender.Female; break;
					case 1: genderMatch = animal.Gender == Gender.Male; break;
					case 2: genderMatch = animal.Gender == Gender.Castrated; break;
				}

				// Species check
				bool speciesMatch = false;
				switch (speciesSelected)
				{
					case 0: speciesMatch = animal.Species == PetType.Cat; break;
					case 1: speciesMatch = animal.Species == PetType.Dog; break;
					// add other cases
				}

				// Apply filters
				bool match = true;

				if (!string.IsNullOrEmpty(name))
					match &= animal.Name == name;

				if (!string.IsNullOrEmpty(color))
					match &= animal.Color == color;

				if (breed != "-")
					match &= animal.Breed == breed;

				if (age > 0)
					match &= animal.Age == age;

				if (dateParsed)
					match &= animal.DateLost <= dateFound;

				// Location match
				var location = locationController.GetOrAdd(city, country);
				match &= animal.LocationId == location.Id;

				// Gender & species
				match &= genderMatch && speciesMatch;

				if (match)
					filteredAnimals.Add(animal);
			}

			// Display in DataGridView
			dataGridViewLostAll.DataSource = filteredAnimals;
		}
	}
}
