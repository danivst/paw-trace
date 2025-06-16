using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
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

            dataGridViewLostAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLostAll.MultiSelect = false;
            dataGridViewLostAll.RowHeadersVisible = true;

            dataGridViewLostAll.SelectionChanged += dataGridViewLostAll_SelectionChanged;
            dataGridViewLostAll.CellClick += dataGridViewLostAll_CellClick;

            dataGridViewFoundAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFoundAll.MultiSelect = false;
            dataGridViewFoundAll.RowHeadersVisible = true;

            dataGridViewFoundAll.SelectionChanged += dataGridViewFoundAll_SelectionChanged;
            dataGridViewFoundAll.CellClick += dataGridViewFoundAll_CellClick;
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
            buttonViewAllLost.Visible = false;
            buttonMarkLost.Visible = false;

            // TAB 3
            LoadDataFound();
            ClearTextBoxesFoundAll();
            buttonViewAllFound.Visible = false;
            buttonMarkFound.Visible = false;

            // TAB 4
            ClearTextBoxesFound();
            txtLostDesc.Text = "Write a description...";
            txtLostDesc.ForeColor = Color.Gray;
            placeHolderActive = true;
            txtLostDesc.KeyDown += txtLostDesc_KeyDown;
            txtLostDesc.Leave += txtLostDesc_Leave;
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
            boxLostSpecies.Text = "";
            boxLostGender.Text = "";
            lostTab.BackColor = Color.AntiqueWhite;
        }

        private void ClearTextBoxesLostAll()
        {
            txtLostAllName.Text = "";
            txtLostAllAge.Text = "";
            txtLostAllColour.Text = "";
            txtLostAllBreed.Text = "";
            txtDateFoundAll.Text = "";
            txtLostAllLocation.Text = "";
            boxLostAllSpecies.Text = "";
            boxLostAllGender.Text = "";
        }

        private void ClearTextBoxesFound()
        {
            txtFoundName.Text = "";
            txtFoundAge.Text = "";
            txtFoundColour.Text = "";
            txtFoundBreed.Text = "";
            txtDateFound.Text = "";
            txtFoundLocation.Text = "";
            txtFoundDesc.Text = "Write a description...";
            txtFoundDesc.ForeColor = Color.Gray;
            placeHolderActive = true;
            pictureBoxFound.Image = null;
            boxFoundSpecies.Text = "";
            boxFoundGender.Text = "";
            lostTab.BackColor = Color.AntiqueWhite;
        }

        private void ClearTextBoxesFoundAll()
        {
            txtFoundAllName.Text = "";
            txtFoundAllAge.Text = "";
            txtFoundAllColour.Text = "";
            txtFoundAllBreed.Text = "";
            txtDateLostAll.Text = "";
            txtFoundAllLocation.Text = "";
            boxFoundAllSpecies.Text = "";
            boxFoundAllGender.Text = "";
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

        private void boxLostGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectGender = boxLostGender.SelectedItem.ToString();
            if (selectGender == "Male")
            {
                lostTab.BackColor = Color.LightBlue;
            }
            else if (selectGender == "Female")
            {
                lostTab.BackColor = Color.MistyRose;
            }
            else
            {
                lostTab.BackColor = Color.AntiqueWhite;
            }
        }

        private void boxFoundGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectGender = boxFoundGender.SelectedItem.ToString();
            if (selectGender == "Male")
            {
                foundTab.BackColor = Color.LightBlue;
            }
            else if (selectGender == "Female")
            {
                foundTab.BackColor = Color.MistyRose;
            }
            else
            {
                foundTab.BackColor = Color.AntiqueWhite;
            }
        }

        private void ResetSelectFound()
        {
            dataGridViewFoundAll.ClearSelection();
        }

        private void ResetSelectLost()
        {
            dataGridViewLostAll.ClearSelection();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ShowImagePopup(Image img)
        {
            Size popupSize = new Size(300, 300);

            Form popup = new Form
            {
                StartPosition = FormStartPosition.Manual,
                Size = popupSize,
                FormBorderStyle = FormBorderStyle.None,
                TopMost = true
            };

            int centerX = this.Location.X + (this.Width - popup.Width) / 2;
            int centerY = this.Location.Y + (this.Height - popup.Height) / 2;
            popup.Location = new Point(centerX, centerY);

            PictureBox pb = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = img
            };

            popup.Controls.Add(pb);

            popup.Deactivate += (s, e) => popup.Close();

            popup.Show();
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

        private void dataGridViewLostAll_SelectionChanged(object sender, EventArgs e)
        {
            buttonMarkFound.Visible = dataGridViewLostAll.SelectedRows.Count > 0;
        }

        private void dataGridViewLostAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewLostAll.ClearSelection();
                dataGridViewLostAll.Rows[e.RowIndex].Selected = true;

                var animal = dataGridViewLostAll.SelectedRows[0].Cells;
                int id = int.Parse(animal[0].Value.ToString());

                if (lostAnimalController.Get(id).Image == null)
                {
                    return;
                }

                Image image;
                using (MemoryStream ms = new MemoryStream(lostAnimalController.Get(id).Image))
                {
                    image = Image.FromStream(ms);
                }

                ShowImagePopup(image);
            }
        }

        private void dataGridViewFoundAll_SelectionChanged(object sender, EventArgs e)
        {
            buttonMarkLost.Visible = dataGridViewFoundAll.SelectedRows.Count > 0;
        }

        private void dataGridViewFoundAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewFoundAll.ClearSelection();
                dataGridViewFoundAll.Rows[e.RowIndex].Selected = true;

                var animal = dataGridViewFoundAll.SelectedRows[0].Cells;
                int id = int.Parse(animal[0].Value.ToString());

                if (foundAnimalController.Get(id).Image == null)
                {
                    return;
                }

                Image image;
                using (MemoryStream ms = new MemoryStream(foundAnimalController.Get(id).Image))
                {
                    image = Image.FromStream(ms);
                }

                ShowImagePopup(image);
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

            if (desc == "Write a description...")
            {
                desc = "-";
            }

            PetType species = PetType.Other;
            switch (speciesToAdd)
            {
                case "Cat":
                    species = PetType.Cat;
                    break;
                case "Dog":
                    species = PetType.Dog;
                    break;
                case "Rabbit":
                    species = PetType.Rabbit;
                    break;
                case "Parrot":
                    species = PetType.Parrot;
                    break;
                case "Hamster":
                    species = PetType.Hamster;
                    break;
                case "Guinea Pig":
                    species = PetType.GuineaPig;
                    break;
                case "Other":
                    species = PetType.Other;
                    break;
            }

            Gender gender = Gender.Castrated;
            switch (genderToAdd)
            {
                case "Female":
                    gender = Gender.Female;
                    break;
                case "Male":
                    gender = Gender.Male;
                    break;
                case "Castrated":
                    gender = Gender.Castrated;
                    break;
            }

            string[] locationArr = locationToAdd.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < locationArr.Length; i++)
            {
                locationArr[i] = locationArr[i].Trim();
            }

            var location = locationController.GetOrAdd(locationArr[0], locationArr[1]);

            LostAnimal lostAnimal = new LostAnimal
            {
                Name = name,
                Color = color,
                DateLost = dateLost,
                LocationId = location.Id,
                Species = species,
                Gender = gender
            };

            byte[] imageBytes = null;

            if (pictureBoxLost.Image != null)
            {
                imageBytes = ImageToByteArray(pictureBoxLost.Image);
                lostAnimal.Image = imageBytes;
            }

            if (desc != "Write a description...")
            {
                lostAnimal.Description = desc;
            }

            if (breed != "")
            {
                lostAnimal.Breed = breed;
            }

            if (age != 0)
            {
                lostAnimal.Age = age;
            }

            lostAnimalController.Add(lostAnimal);
            ClearTextBoxesLost();
            LoadDataLost();
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

        private void buttonLostSearch_Click(object sender, EventArgs e)
        {
            using (var db = new ProjectContext())
            {
                string name = txtLostAllName.Text.ToLower();
                string breed = txtLostAllBreed.Text.ToLower();
                string color = txtLostAllColour.Text.ToLower();
                string genderStr = boxLostAllGender.Text;
                string speciesStr = boxLostAllSpecies.Text;
                string ageStr = txtLostAllAge.Text;
                string dateStr = txtDateFoundAll.Text;

                bool hasAge = int.TryParse(ageStr, out int age);
                bool hasDate = DateOnly.TryParse(dateStr, out var inputDate);

                Gender? gender = Enum.TryParse<Gender>(genderStr, out var g) ? g : (Gender?)null;
                PetType? species = Enum.TryParse<PetType>(speciesStr, out var s) ? s : (PetType?)null;

                var query = db.LostAnimals.AsQueryable();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    query = query.Where(a => a.Name.ToLower().Contains(name));
                }

                if (!string.IsNullOrWhiteSpace(breed))
                {
                    query = query.Where(a => a.Breed.ToLower().Contains(breed));
                }

                if (hasAge)
                {
                    query = query.Where(a => a.Age == age);
                }

                query = query.Where(a => a.Color.ToLower().Contains(color));
                query = query.Where(a => a.Gender == gender.Value);
                query = query.Where(a => a.Species == species.Value);
                query = query.Where(a => a.DateLost <= inputDate);

                var results = query.ToList();
                dataGridViewLostAll.DataSource = results;

                ClearTextBoxesLostAll();
                buttonViewAllLost.Visible = true;
            }
        }

        private void buttonSaveFound_Click(object sender, EventArgs e)
        {
            var name = txtFoundName.Text;
            var age = 0;
            int.TryParse(txtFoundAge.Text, out age);
            var color = txtFoundColour.Text;
            var breed = txtFoundBreed.Text;
            var dateAddFound = txtDateFound.Text;
            DateOnly dateFound;
            if (!DateOnly.TryParseExact(dateAddFound, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFound))
            {
                throw new FormatException("Invalid date format. Expected format: dd/MM/yyyy.");
            }
            var locationToAdd = txtFoundLocation.Text;
            var speciesToAdd = boxFoundSpecies.Text;
            var genderToAdd = boxFoundGender.Text;
            var desc = txtLostDesc.Text;

            PetType species = PetType.Other;
            switch (speciesToAdd)
            {
                case "Cat":
                    species = PetType.Cat;
                    break;
                case "Dog":
                    species = PetType.Dog;
                    break;
                case "Rabbit":
                    species = PetType.Rabbit;
                    break;
                case "Parrot":
                    species = PetType.Parrot;
                    break;
                case "Hamster":
                    species = PetType.Hamster;
                    break;
                case "Guinea Pig":
                    species = PetType.GuineaPig;
                    break;
                case "Other":
                    species = PetType.Other;
                    break;
            }

            Gender gender = Gender.Castrated;
            switch (genderToAdd)
            {
                case "Female":
                    gender = Gender.Female;
                    break;
                case "Male":
                    gender = Gender.Male;
                    break;
                case "Castrated":
                    gender = Gender.Castrated;
                    break;
            }

            string[] locationArr = locationToAdd.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < locationArr.Length; i++)
            {
                locationArr[i] = locationArr[i].Trim();
            }

            var location = locationController.GetOrAdd(locationArr[0], locationArr[1]);

            FoundAnimal foundAnimal = new FoundAnimal
            {
                Color = color,
                DateFound = dateFound,
                LocationId = location.Id,
                Species = species,
                Gender = gender
            };

            byte[] imageBytes = null;

            if (pictureBoxFound.Image != null)
            {
                imageBytes = ImageToByteArray(pictureBoxFound.Image);
                foundAnimal.Image = imageBytes;
            }

            if (desc != "Write a description...")
            {
                foundAnimal.Description = desc;
            }

            if (breed != "")
            {
                foundAnimal.Breed = breed;
            }

            if (name != "")
            {
                foundAnimal.Name = name;
            }

            if (age != 0)
            {
                foundAnimal.Age = age;
            }

            foundAnimalController.Add(foundAnimal);
            ClearTextBoxesFound();
            LoadDataFound();
        }

        private void buttonFoundSearch_Click(object sender, EventArgs e)
        {
            using (var db = new ProjectContext())
            {
                string name = txtFoundAllName.Text.ToLower();
                string breed = txtFoundAllBreed.Text.ToLower();
                string color = txtFoundAllColour.Text.ToLower();
                string genderStr = boxFoundAllGender.Text;
                string speciesStr = boxFoundAllSpecies.Text;
                string ageStr = txtFoundAllAge.Text;
                string dateStr = txtDateLostAll.Text;

                bool hasAge = int.TryParse(ageStr, out int age);
                bool hasDate = DateOnly.TryParse(dateStr, out var inputDate);

                Gender? gender = Enum.TryParse<Gender>(genderStr, out var g) ? g : (Gender?)null;
                PetType? species = Enum.TryParse<PetType>(speciesStr, out var s) ? s : (PetType?)null;

                var query = db.FoundAnimals.AsQueryable();

                if (!string.IsNullOrWhiteSpace(breed))
                {
                    query = query.Where(a => a.Breed.ToLower().Contains(breed));
                }

                if (hasAge)
                {
                    query = query.Where(a => a.Age == age);
                }

                query = query.Where(a => a.Color.ToLower().Contains(color));
                query = query.Where(a => a.Gender == gender.Value);
                query = query.Where(a => a.Species == species.Value);
                query = query.Where(a => a.DateFound >= inputDate);

                var results = query.ToList();
                dataGridViewFoundAll.DataSource = results;

                ClearTextBoxesFoundAll();
                buttonViewAllFound.Visible = true;
            }
        }

        private void buttonMarkLost_Click(object sender, EventArgs e)
        {
            if (dataGridViewFoundAll.SelectedRows.Count > 0)
            {
                var animal = dataGridViewFoundAll.SelectedRows[0].Cells;
                int id = int.Parse(animal[0].Value.ToString());

                FoundAnimal animalToDelete = foundAnimalController.Get(id);

                int locationToDelete = animalToDelete.LocationId;

                foundAnimalController.Delete(id);

                bool locationIsUsed = foundAnimalController.GetAll().Any(a => a.LocationId.Equals(locationToDelete));
                if (!locationIsUsed)
                {
                    locationController.Delete(locationToDelete);
                }

                LoadDataFound();
                ResetSelectFound();
                buttonMarkLost.Visible = false;
            }
        }

        private void buttonMarkFound_Click(object sender, EventArgs e)
        {
            if (dataGridViewLostAll.SelectedRows.Count > 0)
            {
                var animal = dataGridViewLostAll.SelectedRows[0].Cells;
                int id = int.Parse(animal[0].Value.ToString());

                LostAnimal animalToDelete = lostAnimalController.Get(id);

                int locationToDelete = animalToDelete.LocationId;

                lostAnimalController.Delete(id);

                bool locationIsUsed = lostAnimalController.GetAll().Any(a => a.LocationId.Equals(locationToDelete));
                if (!locationIsUsed)
                {
                    locationController.Delete(locationToDelete);
                }

                LoadDataLost();
                ResetSelectLost();
                buttonMarkFound.Visible = false;
            }
        }

        private void buttonImageFound_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "(*.jpg;*.jpeg;*.png;*.bmp;*.mp4)|*.JPG;*.JPEG;*.PNG;*.BMP;*.MP4";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFound.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBoxFound.SizeMode = PictureBoxSizeMode.StretchImage;
                    ImageToByteArray(pictureBoxFound.Image);
                }
            }
        }

        private void buttonViewAllFound_Click(object sender, EventArgs e)
        {
            LoadDataFound();
        }

        private void buttonViewAllLost_Click(object sender, EventArgs e)
        {
            LoadDataLost();
        }

        private void dataGridViewFoundAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridViewLostAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
