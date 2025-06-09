namespace Proekt
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
			UpdateGrid();
			ClearTextBoxes();
			txtLostLocation.Text = "";
			txtBoxDesc.Text = "Write a description...";
			txtBoxDesc.ForeColor = Color.Gray;
			placeHolderActive = true;
			txtBoxDesc.KeyDown += txtBoxDesc_KeyDown;
			txtBoxDesc.Leave += txtBoxDesc_Leave;
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
			txtLostDateLost.Text = "";
			txtLostLocation.Text = "";
			txtBoxDesc.Text = "Write a description...";
			txtBoxDesc.ForeColor = Color.Gray;
			placeHolderActive = true;
		}

		private void txtBoxDesc_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtBoxDesc.Text))
			{
				txtBoxDesc.Text = "Write a description...";
				txtBoxDesc.ForeColor = Color.Gray;
				placeHolderActive = true;
			}
		}

		private void txtBoxDesc_KeyDown(object sender, KeyEventArgs e)
		{
			if (placeHolderActive)
			{
				txtBoxDesc.Clear();
				txtBoxDesc.ForeColor = Color.Black;
				placeHolderActive = false;
			}
		}

		private void boxGender_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectGender = boxGender.SelectedItem.ToString();
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

		private void lostTab_Click(object sender, EventArgs e)
		{

		}

		private void buttonImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Select an image";
				openFileDialog.Filter = "(*.jpg;*.jpeg;*.png;*.bmp;*.mp4)|*.JPG;*.JPEG;*.PNG;*.BMP;*.MP4";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBox.Image = Image.FromFile(openFileDialog.FileName);
					pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				}
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			
		}

		private void RefreshDataView()
		{
			
		}
	}
}
