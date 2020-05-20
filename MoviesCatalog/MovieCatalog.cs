using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;
using Data.Model;

// dali da sloja logoto i label-a v metod ?
// za delete i reset butonite ima neshta se povtarqt, moje da se napravi metod ?

namespace MoviesCatalog
{
    public partial class MovieCatalog : Form
    {
        private MovieBusiness movieBusiness = new MovieBusiness();
        private MovieStudioContext movieStudioContext = new MovieStudioContext();
        private StudioBusiness studioBusiness = new StudioBusiness();
        public MovieCatalog()
        {
            InitializeComponent();
        }

        private void MovieCatalog_Load(object sender, EventArgs e)
        {
            UpdateListView();
            cmbSearch.Text = "All";
        }

        public void UpdateListView()
        {
            listViewMovies.Items.Clear();
            foreach (var movie in movieBusiness.GetAll())
            {
                ListViewItem item = new ListViewItem();
                item.Text = movie.Title;
                item.Tag = movie;
                listViewMovies.Items.Add(item);
            }
        }
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            // invokes the AddMovie form
            AddMovie frm = new AddMovie(this);
            frm.Show();
        }
        private void btnStudios_Click(object sender, EventArgs e)
        {
            // invokes the Studios form
            Studios frm = new Studios(this);
            frm.Show();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count > 0)
            {
                // gets and deletes the selected movie
                Movie movieToDelete = (Movie)listViewMovies.SelectedItems[0].Tag;
                movieBusiness.Delete(movieToDelete.Id);
                
                UpdateListView();

                // hides the info for the movie and goes back to the start form view
                NonEditableLabelsVisibility(false);
                LabelsVisibility(false);
                btnEdit.Visible = false;
                btnSaveUpdate.Visible = false;
                pictureBox1.Visible = false;
                lblId.Visible = false;
                logo.Visible = true;
                lblInfo.Visible = true;
            }
        }
          
       
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchedItem = txtSearch.Text;

            // returns nothing if the search textbox is empty
            if (searchedItem =="")
            {
                return;
            }

            listViewMovies.Clear();

            // creates list for the movies that meet the searched requirements
            List<Movie> searchedMovies = new List<Movie>();

            // searchs for movies by the chosen criteria in the cmbSearch combobox
            // and if there are found movies, they are added to the searchedMovies list 
            switch (cmbSearch.Text)
            {
                case "Id":
                    searchedMovies = movieStudioContext.Movies.Where(a => a.Id.ToString() == searchedItem).ToList();
                    break;
                case "Title":
                    searchedMovies = movieStudioContext.Movies.Where(a => a.Title.Contains(searchedItem)).ToList();
                    break;
                case "Year":
                    searchedMovies = movieStudioContext.Movies.Where(a => a.Year.ToString() == searchedItem).ToList();
                    break;
                case "Genre":
                    searchedMovies = movieStudioContext.Movies.Where(a => a.Genre == searchedItem).ToList();
                    break;
                case "Director":
                    searchedMovies = movieStudioContext.Movies.Where(a => a.Director == searchedItem).ToList();
                    break;
                case "Rating":
                    searchedMovies = movieStudioContext.Movies.Where(a => a.Rating == searchedItem).ToList();
                    break;
                    // searchs by all categories combined
                case "All":
                    searchedMovies = movieStudioContext.Movies.Where(a => (a.Title.Contains(searchedItem)) ||
            (a.Director.Contains(searchedItem)) || ((a.Year.ToString() == searchedItem)) || ((a.Genre == searchedItem)) ||
            ((a.Id.ToString() == searchedItem)))
            .ToList();
                    break;
            }
            
            // makes ListViewItem from every movie in the searchedMovies list
            // then adds it to listView1
            foreach (var movie in searchedMovies)
            {
                ListViewItem item = new ListViewItem();
                item.Text = movie.Title;
                item.Tag = movie;
                listViewMovies.Items.Add(item);
            }

            // shows message if none of the movies meet the requirements
            if (listViewMovies.Items.Count == 0)
            {
                MessageBox.Show("0 results were found!", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset_Click(sender, e);
                return;
            }

            // shows the info for the first item in the listViewMovies
            GetMovieInfo((Movie)listViewMovies.Items[0].Tag);
                 
        }

        // hides the info gotten from the search action
        // goes back to the start form view
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbSearch.Text = "All";
            UpdateListView();
            NonEditableLabelsVisibility(false);
            LabelsVisibility(false);
            btnEdit.Visible = false;
            pictureBox1.Visible = false;
            lblId.Visible = false;
            logo.Visible = true;
            lblInfo.Visible = true;
        }

        // fills the labels and the textBoxes with info of the selected movie
        private void FillLabelsAndTextBoxes(Movie selectedMovie)
        {
            lblId.Text = selectedMovie.Id.ToString();
            lblTtl.Text = selectedMovie.Title.ToString();
            lblYr.Text = selectedMovie.Year.ToString();
            lblGnr.Text = selectedMovie.Genre.ToString();
            lblRtng.Text = selectedMovie.Rating.ToString();
            lblDir.Text = selectedMovie.Director.ToString();
            lblStd.Text = studioBusiness.Get(int.Parse(selectedMovie.StudioMId.ToString())).Name;
            pictureBox1.Image = ByteArrayToImage(selectedMovie.Image);

            txtTtl.Text = lblTtl.Text;
            txtYear.Text = lblYr.Text;
            txtGnr.Text = lblGnr.Text;
            txtRtng.Text = lblRtng.Text;
            txtDir.Text = lblDir.Text;
            txtStd.Text = lblStd.Text;

            lblId.Visible = true;
            LabelsVisibility(true);
            NonEditableLabelsVisibility(true);
        }

        // shows detailed info for a specific movie
        private void GetMovieInfo(Movie movie)
        {
            FillLabelsAndTextBoxes(movie);
            btnEdit.Visible = true;
            pictureBox1.Visible = true;
            logo.Visible = false;
            lblInfo.Visible = false;
        }

        // shows the info for the selected movie
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedMovie = (Movie)listViewMovies.SelectedItems[0].Tag;
                GetMovieInfo(selectedMovie);
            }
            catch (Exception ex) { }
        }

        // allows to edit the movie info by changing the labels to textboxes
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            TextBoxesVisibility(true);
            LabelsVisibility(false);
            pictureBox1.Enabled = true;
            btnEdit.Visible = false;
            btnSaveUpdate.Visible = true;
            FormEnabled(false);
            FillStudioComboBox();

        }

        // fills the studio comboBox with the studio names from studios table
        public void FillStudioComboBox()
        {
            List<Studio> studios = studioBusiness.GetAll();
            foreach (var item in studios)
            {
                txtStd.Items.Add(item.Name);
            }
        }

        // enables or disables the form by enabling or disabling the listViewMovies and the buttons enable option
        private void FormEnabled(bool enableOption)
        {
            listViewMovies.Enabled = enableOption;
            btnDelete.Enabled = enableOption;
            btnInsert.Enabled = enableOption;
            btnSearch.Enabled = enableOption;
            btnReset.Enabled = enableOption;
            btnStudios.Enabled = enableOption;
            cmbSearch.Enabled = enableOption;
            txtSearch.Enabled = enableOption;
        }

        // returns the movie after edit
        private Movie GetEditedMovie()
        {
            Movie movie = new Movie();

            var title = txtTtl.Text;
            int year = 0;
            int.TryParse(txtYear.Text, out year);
            var genre = txtGnr.Text;
            var rating = txtRtng.Text;
            var director = txtDir.Text;
            var studioName = txtStd.Text;

            byte[] img = ConvertImageToBinary(pictureBox1.Image);

            int studioId = 0;
            List<Studio> studios = studioBusiness.GetAll();

            // finds the studioId by its name
            foreach (var item in studios)
            {
                if (item.Name == studioName)
                {
                    studioId = item.Id;
                }               
            }

            // creates and adds new studio in the database 
            // if studio with the given name is not found
            if (studioId == 0)
            {
                Studio stud = new Studio();
                stud.Name = studioName;
                studioBusiness.Add(stud);
                studios.Add(stud);
                studioId = stud.Id;
            }

            movie.Id = int.Parse(lblId.Text);
            movie.StudioMId = studioId;
            movie.Image = img;
            movie.Title = title;
            movie.Year = year;
            movie.Genre = genre;
            movie.Rating = rating;
            movie.Director = director;
            return movie;
        }

        // converts the image to a binary code, byte array
        public byte[] ConvertImageToBinary(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        // converts the binary code, the byte array, to image
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            // gets the movie from the database
            Movie movie = movieBusiness.Get(int.Parse(lblId.Text));

            // changes the movie's info with the edited one's
            Movie editedMovie = GetEditedMovie();
            
            // updates the database
            movieBusiness.Update(editedMovie);
            
            UpdateListView();

            // hides the textBoxes and the Save button
            // shows the labels with the info of the updated movie
            GetMovieInfo(editedMovie);
            TextBoxesVisibility(false);

            btnSaveUpdate.Visible = false;

            // makes the pictureBox noteditable again
            pictureBox1.Enabled = false;
            // the form is accessible again
            FormEnabled(true);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // opens file dialog that requires to add an image
            OpenFileDialog opnfd = new OpenFileDialog();

            // filters with images with the given formats
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            
            // pictureBox1 gets the chosen image if there is one
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        // changes the visibility of the labels
        private void LabelsVisibility(bool visibilityOption)
        {
            lblTtl.Visible = visibilityOption;
            lblYr.Visible = visibilityOption;
            lblStd.Visible = visibilityOption;
            lblDir.Visible = visibilityOption;
            lblRtng.Visible = visibilityOption;
            lblGnr.Visible = visibilityOption;
        }

        // changes the visibility of the textboxes
        private void TextBoxesVisibility(bool visibilityOption)
        {
            txtTtl.Visible = visibilityOption;
            txtYear.Visible = visibilityOption;
            txtStd.Visible = visibilityOption;
            txtRtng.Visible = visibilityOption;
            txtGnr.Visible = visibilityOption;
            txtDir.Visible = visibilityOption;
        }

        // changes the visibility of the static labels
        private void NonEditableLabelsVisibility(bool visibilityOption)
        {
            lblStaticId.Visible = visibilityOption;
            lblTitle.Visible = visibilityOption;
            lblYear.Visible = visibilityOption;
            lblGenre.Visible = visibilityOption;
            lblDirector.Visible = visibilityOption;
            lblRating.Visible = visibilityOption;
            lblStudio.Visible = visibilityOption;
        }
    }
}
