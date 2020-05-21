using Business;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesCatalog
{
   
    public partial class Studios : Form
    {
        private StudioBusiness studioBusiness = new StudioBusiness();
        private MovieBusiness movieBusiness = new MovieBusiness();

        // creates list of movies from a specific studio
        public List<Movie> MyMovieList = new List<Movie>();
           
        private readonly MovieCatalog frmMovieCatalog;

        public Studios(MovieCatalog frm)
        {
            InitializeComponent();
            frmMovieCatalog = frm;
        }

        public Studios()
        {
            InitializeComponent();
        }

        // enables the dataGridView
        private void ResetSelect()
        {
            dataGridView1.Enabled = true;
        }

        private void Studios_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            // hides the third column of the table 
            this.dataGridView1.Columns[2].Visible = false;

           // clears the current selection by unselecting all selected cells
            dataGridView1.ClearSelection();
        }

        private void UpdateGrid()
        {
            // gets the information for the dataGridView from the database
            dataGridView1.DataSource = studioBusiness.GetAll();

            dataGridView1.ReadOnly = true;

            // selects all the rows, all the data, from the table
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // gets the selected studio's id from the dataGridView's first cell/ ID cell
                int studioId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                // gets all the items from the database's table "movies"
                List<Movie> allMovies = movieBusiness.GetAll();
                
                // deletes all the items in the MyMovieList
                MyMovieList.Clear();
                
                // finds the movies with the same studio(M)Id as the selected studio's id and adds them to the MyMovieList
                foreach (var item in allMovies)
                {
                    if (item.StudioMId == studioId)
                    {
                        MyMovieList.Add(item);
                    }
                }

                // changes the label's text with the selected studio's name
                lblStudioMovies.Text = $"{dataGridView1.CurrentRow.Cells[1].Value}'s movies";

                FillListView();
                lblInfo.Visible = false;

            }
            catch (Exception ex) { }
        }

        private void FillListView()
        {
            // clears all the previous items in the listView
            listViewMovies.Clear();
            
            // adds all the items' titles from the list to the listView
            foreach (var item in MyMovieList)
            {
                listViewMovies.Items.Add(item.Title);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // shows error message if the wanted studio to delete has movie connected to it
                if (listViewMovies.Items.Count > 0)
                {
                    MessageBox.Show("The studio cannot be deleted because there are movies connected to it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                // gets the info of the selected studio 
                var studioToDelete = dataGridView1.SelectedRows[0].Cells;

                // gets the id of the studio
                var id = int.Parse(studioToDelete[0].Value.ToString());

                // deletes the selected studio from the database
                studioBusiness.Delete(id);

                UpdateGrid();
                ResetSelect();

                lblStudioMovies.Text = "*Studio*'s movies";
                lblInfo.Visible = true;
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // shows error message if the textBox txtNewStudio is empty
            if (txtNewStudio.Text=="")
            {
                MessageBox.Show("The studio name cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // makes new studio with the info from the textBox
            Studio stud = new Studio();
            stud.Name = txtNewStudio.Text;

            // adds the new studio to the database
            studioBusiness.Add(stud);

            UpdateGrid();
            ResetSelect();

            txtNewStudio.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblStudio.Text = "Change studio name:";

            // gets the id of the selected studio/row of the database
            int studioId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            // gets the studio info from the database
            Studio studio = studioBusiness.Get(studioId);
            
            // fills the texBox with the name of the studio from the database
            txtNewStudio.Text = studio.Name;

            btnEdit.Visible = false;
            btnSave.Visible = true;

            FormEnabled(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // gets the id of the selected studio/row of the database
            int studioId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            // gets the studio info from the database
            Studio studio = studioBusiness.Get(studioId);

            // changes the studio name with the text from the textBox
            studio.Name = txtNewStudio.Text;
            
            // updates the database
            studioBusiness.Update(studio);

            UpdateGrid();

            btnSave.Visible = false;
            btnEdit.Visible = true;

            txtNewStudio.Text = "";
            lblStudio.Text = "Enter studio:";

            FormEnabled(true);
        }

        // enables or disables the form by enabling or disabling the dataGridView and the buttons enable option
        private void FormEnabled(bool enabledOption)
        {
            btnAdd.Enabled = enabledOption;
            dataGridView1.Enabled = enabledOption;
            btnDelete.Enabled = enabledOption;
        }
    }
}
