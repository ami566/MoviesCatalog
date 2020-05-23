using Data.Model;
using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace MoviesCatalog
{
    public partial class AddMovie : Form
    {
        private readonly MovieCatalog frmMovieCatalog;
        private StudioBusiness studioBusiness = new StudioBusiness();
        private MovieBusiness movieBusiness = new MovieBusiness();

        public AddMovie(MovieCatalog frm)
        {
            InitializeComponent();

            frmMovieCatalog = frm;
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            FillStudioComboBox();
        }

        // converts image to binary code, byte array
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        
        // inserts the data from the textBoxes to the database in the tables movies and studios
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // declares variables for the info from the textboxes
            var title = txtTitle.Text;
            int year = 0;
            int.TryParse(txtYear.Text, out year);
            var genre = txtGenre.Text;
            var rating = txtRating.Text;
            var director = txtDirector.Text;
            var image = pictureBox1.Image;
            var studioName = cmbStudio.Text.ToString();
            
            // throws error message if there is no image chosen in the picture box
            if (image==null)
            {
                MessageBox.Show($"Insert an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // throws error message if typed year is not in int format 
            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show($"Insert valid year!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // gets all the items from the table "studios"
            List<Studio> studios = studioBusiness.GetAll();
            // checks if the studio in the text box exists in the database
            var makeStudio = true;
            foreach (var item in studios)
            {
                if (item.Name == studioName)
                {
                    makeStudio = false;
                }
            }

            // makes new studio if the studio doesn't exist 
            if (makeStudio)
            {
                Studio stud = new Studio();
                stud.Name = studioName;

                // inserts the studio in the database
                studioBusiness.Add(stud);
                studios.Add(stud);
            }

            
            Movie movie = new Movie();

           // sets the movie's properties
            movie.Title = title;
            movie.Image = ConvertImageToBinary(image);
            movie.Year = year;
            movie.Genre = genre;
            movie.Rating = rating;
            movie.Director = director;

            var studioId = 0;

            // finds the studioId by its name
            foreach (var item in studios)
            {
                if (item.Name == studioName)
                {
                    studioId = item.Id;
                }
            }
            movie.StudioMId = studioId;

            // adds the new movie into the database
            movieBusiness.Add(movie);

            // updates the list view in the main form
            frmMovieCatalog.UpdateListView();

            // closes the form
            this.Close();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // hides the label with th epicture info
            lblPicture.Visible = false;

            // opens file dialog that requires to add an image
            OpenFileDialog opnfd = new OpenFileDialog();

            // filters with images with the given formats
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            // pictureBox1 gets the chosen image if there is one
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                // sets the image of the pictureBox by making the chosen image in the Bitmap variable
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
          
        }

        // fills the studio comboBox with the studio names from studios table
        public void FillStudioComboBox()
        {
            List<Studio> studios = studioBusiness.GetAll();
            foreach (var item in studios)
            {
                cmbStudio.Items.Add(item.Name);
            }
        }
      
        // invokes the pictureBox1_Click method if clicked on the label
        // hides the label
        private void lblPicture_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
            lblPicture.Visible = false;
        }
    }
}
