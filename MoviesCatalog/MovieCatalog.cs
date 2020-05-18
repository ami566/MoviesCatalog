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
// za dellete i reset butonite ima neshta se povtarqt, moje da se napravi metod ?

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
        public void UpdateListView()
        {
            listView1.Items.Clear();
            foreach (var movie in movieBusiness.GetAll())
            {
                ListViewItem item = new ListViewItem();
                item.Text = movie.Title;
                item.Tag = movie;
                listView1.Items.Add(item);
            }
        }
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            AddMovie frm = new AddMovie(this);
            frm.Show();
        }
        private void btnStudios_Click(object sender, EventArgs e)
        {
            Studios frm = new Studios(this);
            frm.Show();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Movie movieToDelete = (Movie)listView1.SelectedItems[0].Tag;
                movieBusiness.Delete(movieToDelete.Id);
                UpdateListView();
                listView1.Enabled = true;
                StaticLabelsVisibility(false);
                LabelsVisibility(false);
                btnEdit.Visible = false;
                btnSaveUpdate.Visible = false;
                pictureBox1.Visible = false;
                lblId.Visible = false;
                logo.Visible = true;
                lblInfo.Visible = true;
            }
        }

        private void MovieCatalog_Load(object sender, EventArgs e)
        {
            UpdateListView();
            cmbSearch.Text = "All";
        }
       
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (text =="")
            {
                return;
            }

            listView1.Clear();

            List<Movie> movies = new List<Movie>();

            switch (cmbSearch.Text)
            {
                case "Id":
                    movies = movieStudioContext.Movies.Where(a => a.Id.ToString() == text).ToList();
                    break;
                case "Title":
                    movies = movieStudioContext.Movies.Where(a => a.Title.Contains(text)).ToList();
                    break;
                case "Year":
                    movies = movieStudioContext.Movies.Where(a => a.Year.ToString() == text).ToList();
                    break;
                case "Genre":
                    movies = movieStudioContext.Movies.Where(a => a.Genre == text).ToList();
                    break;
                case "Director":
                    movies = movieStudioContext.Movies.Where(a => a.Director == text).ToList();
                    break;
                case "Rating":
                    movies = movieStudioContext.Movies.Where(a => a.Rating == text).ToList();
                    break;
                case "All":
                    movies = movieStudioContext.Movies.Where(a => (a.Title.Contains(text)) ||
            (a.Director.Contains(text)) || ((a.Year.ToString() == text)) || ((a.Genre == text)) ||
            ((a.Id.ToString() == text)))
            .ToList();
                    break;
            }
            

            foreach (var movie in movies)
            {
                ListViewItem item = new ListViewItem();
                item.Text = movie.Title;
                item.Tag = movie;
                listView1.Items.Add(item);
            }

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("0 results were found!", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset_Click(sender, e);
                return;
            }

            GetMovieInfo((Movie)listView1.Items[0].Tag, true);
                 
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbSearch.Text = "All";
            UpdateListView();
            StaticLabelsVisibility(false);
            LabelsVisibility(false);
            btnEdit.Visible = false;
            pictureBox1.Visible = false;
            lblId.Visible = false;
            logo.Visible = true;
            lblInfo.Visible = true;
        }

        private void FillLabels(Movie selectedMovie)
        {
            lblId.Text = selectedMovie.Id.ToString();
            lblTtl.Text = selectedMovie.Title.ToString();
            lblYr.Text = selectedMovie.Year.ToString();
            lblGnr.Text = selectedMovie.Genre.ToString();
            lblRtng.Text = selectedMovie.Rating.ToString();
            lblDir.Text = selectedMovie.Director.ToString();
            lblStd.Text = studioBusiness.Get(int.Parse(selectedMovie.StudioMId.ToString())).Name;
            pictureBox1.Image = byteArrayToImage(selectedMovie.Image);

            txtTtl.Text = lblTtl.Text;
            txtYear.Text = lblYr.Text;
            txtGnr.Text = lblGnr.Text;
            txtRtng.Text = lblRtng.Text;
            txtDir.Text = lblDir.Text;
            txtStd.Text = lblStd.Text;

            lblId.Visible = true;
            LabelsVisibility(true);
            StaticLabelsVisibility(true);
            
            
        }
        private void GetMovieInfo(Movie movie, bool a)
        {
            FillLabels(movie);
            btnEdit.Visible = a;
            pictureBox1.Visible = a;
            logo.Visible = false;
            lblInfo.Visible = false;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedMovie = (Movie)listView1.SelectedItems[0].Tag;
                GetMovieInfo(selectedMovie, true);
            }
            catch (Exception ex) { }
        }
        public void FillComboBox()
        {
            List<Studio> studios = studioBusiness.GetAll();
            foreach (var item in studios)
            {
                txtStd.Items.Add(item.Name);
            }
        }
      
       

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            TextBoxesVisibility(true);
            LabelsVisibility(false);
            pictureBox1.Enabled = true;
            btnEdit.Visible = false;
            btnSaveUpdate.Visible = true;
            FormEnabled(false);
            FillComboBox();

        }

        private void FormEnabled(bool a)
        {
            listView1.Enabled = a;
            btnDelete.Enabled = a;
            btnInsert.Enabled = a;
            btnSearch.Enabled = a;
            btnReset.Enabled = a;
            btnStudios.Enabled = a;
            cmbSearch.Enabled = a;
            txtSearch.Enabled = a;
        }

        private Movie GetEditedMovie()
        {
            Movie movie = new Movie();
            movie.Id = int.Parse(lblId.Text);

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
            foreach (var item in studios)
            {
                if (item.Name == studioName)
                {
                    studioId = item.Id;
                }               
            }

            if (studioId == 0)
            {
                Studio stud = new Studio();
                stud.Name = studioName;
                studioBusiness.Add(stud);
                studios.Add(stud);
                studioId = stud.Id;
            }
            movie.StudioMId = studioId;
            movie.Image = img;
            movie.Title = title;
            movie.Year = year;
            movie.Genre = genre;
            movie.Rating = rating;
            movie.Director = director;
            return movie;
        }
        public byte[] ConvertImageToBinary(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            Movie movie = movieBusiness.Get(int.Parse(lblId.Text));
            Movie editedMovie = GetEditedMovie();
            movieBusiness.Update(editedMovie);
            UpdateListView();

            GetMovieInfo(editedMovie, true);
            TextBoxesVisibility(false);
            pictureBox1.Enabled = false;
            btnSaveUpdate.Visible = false;
            FormEnabled(true);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);

            }
        }
        private void LabelsVisibility(bool a)
        {
            lblTtl.Visible = a;
            lblYr.Visible = a;
            lblStd.Visible = a;
            lblDir.Visible = a;
            lblRtng.Visible = a;
            lblGnr.Visible = a;
        }
        private void TextBoxesVisibility(bool a)
        {
            txtTtl.Visible = a;
            txtYear.Visible = a;
            txtStd.Visible = a;
            txtRtng.Visible = a;
            txtGnr.Visible = a;
            txtDir.Visible = a;
        }

        private void StaticLabelsVisibility(bool a)
        {
            lblStaticId.Visible = a;
            lblTitle.Visible = a;
            lblYear.Visible = a;
            lblGenre.Visible = a;
            lblDirector.Visible = a;
            lblRating.Visible = a;
            lblStudio.Visible = a;
        }
    }
}
