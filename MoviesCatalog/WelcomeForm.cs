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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        // invokes the MovieCatalog form
        private void btnMovies_Click(object sender, EventArgs e)
        {
            MovieCatalog frm = new MovieCatalog();
            frm.Show();
        }

    }
}
