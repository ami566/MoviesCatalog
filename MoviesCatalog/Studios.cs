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
    //za enable kogato sa editva studio da se napravi metod ?
    public partial class Studios : Form
    {
        private StudioBusiness studioBusiness = new StudioBusiness();
        private MovieBusiness movieBusiness = new MovieBusiness();
        public List<Movie> MyList = new List<Movie>();
           
        private readonly MovieCatalog frm1;
        public Studios(MovieCatalog frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        public Studios()
        {
            InitializeComponent();
        }

        private void Studios_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            this.dataGridView1.Columns[2].Visible = false;
            dataGridView1.ClearSelection();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = studioBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FillListView()
        {
            listView1.Clear();
            foreach (var item in MyList)
            {
                listView1.Items.Add(item.Title);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (listView1.Items.Count > 0)
                {
                    MessageBox.Show("The studio cannot be deleted because there are movies connected to it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                    var item = dataGridView1.SelectedRows[0].Cells;
                    var id = int.Parse(item[0].Value.ToString());
                    studioBusiness.Delete(id);
                    UpdateGrid();
                   ResetSelect();
                label1.Text = "*Studio*'s movies";
                lblInfo.Visible = true;
            }
        }
        private void ResetSelect()
        {
            dataGridView1.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNewStudio.Text=="")
            {
                MessageBox.Show("The studio name cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            Studio stud = new Studio();
            stud.Name = txtNewStudio.Text;
            studioBusiness.Add(stud);
            UpdateGrid();
            txtNewStudio.Text = "";
            ResetSelect();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int studioId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                List<Movie> allMovies = movieBusiness.GetAll();
                MyList.Clear();
                foreach (var item in allMovies)
                {
                    if (item.StudioMId == studioId)
                    {
                        MyList.Add(item);
                    }
                }
                label1.Visible = true;
                label1.Text = $"{dataGridView1.CurrentRow.Cells[1].Value}'s movies";
                FillListView();
                lblInfo.Visible = false;

            }
            catch (Exception ex) { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int studioId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Studio studio = studioBusiness.Get(studioId);
            lblStudio.Text = "Change studio name:";
            txtNewStudio.Text = studio.Name;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            
            btnAdd.Enabled = false;
            dataGridView1.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int studioId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Studio studio = studioBusiness.Get(studioId);
            studio.Name = txtNewStudio.Text;
            studioBusiness.Update(studio);
            UpdateGrid();
            btnSave.Visible = false;
            btnEdit.Visible = true;
            txtNewStudio.Text = "";
            lblStudio.Text = "Enter studio:";
            
            btnAdd.Enabled = true;
            dataGridView1.Enabled = true;
            btnDelete.Enabled = true;

        }
    }
}
