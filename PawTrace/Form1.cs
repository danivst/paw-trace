using System.Windows.Forms;

namespace PawTrace
{
	public partial class Form1 : Form
	{
		private bool placeHolderActive = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void UpdateGrid()
		{

		}

		private void ClearTextBoxes()
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
				}
			}
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			UpdateGrid();
			ClearTextBoxes();
			txtLostLocation.Text = "";
			txtLostDesc.Text = "Write a description...";
			txtLostDesc.ForeColor = Color.Gray;
			placeHolderActive = true;
			txtLostDesc.KeyDown += txtLostDesc_KeyDown;
			txtLostDesc.Leave += txtLostDesc_Leave;
		}
	}
}
