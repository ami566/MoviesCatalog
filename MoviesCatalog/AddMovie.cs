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
        private readonly MovieCatalog frm1;
        private StudioBusiness studioBusiness = new StudioBusiness();
    
        public AddMovie(MovieCatalog frm)
        {
            InitializeComponent();

            frm1 = frm;
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
                }


        }
        private MovieBusiness movieBusiness = new MovieBusiness();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            int year = 0;
            int.TryParse(txtYear.Text, out year);
            var genre = txtGenre.Text;
            var rating = txtRating.Text;
            var director = txtDirector.Text;
            var image = pictureBox1.Image;
            if (image==null)
            {
                MessageBox.Show($"Insert an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var studioName = comboBox1.Text.ToString();

            var makeStudio = true;
            List<Studio> studios = studioBusiness.GetAll();
            foreach (var item in studios)
            {
                if (item.Name == studioName)
                {
                    makeStudio = false;
                }
            }

            if (makeStudio)
            {

                Studio stud = new Studio();
                stud.Name = studioName;

                studioBusiness.Add(stud);
                studios.Add(stud);
            }

            Movie movie = new Movie();
           
            movie.Title = title;
            movie.Image = ConvertImageToBinary(image);
            movie.Year = year;
            movie.Genre = genre;
            movie.Rating = rating;
            movie.Director = director;

            var studioId = 0;

            foreach (var item in studios)
            {
                if (item.Name == studioName)
                {
                    studioId = item.Id;
                }
            }
            movie.StudioMId = studioId;

            movieBusiness.Add(movie);
            frm1.UpdateListView();
            this.Close();
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
        public void FillComboBox()
        {
            List<Studio> studios = studioBusiness.GetAll();
            foreach (var item in studios)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
            label1.Visible = false;
        }
    }
}
