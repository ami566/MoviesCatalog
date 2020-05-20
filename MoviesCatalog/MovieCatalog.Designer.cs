namespace MoviesCatalog
{
    partial class MovieCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieCatalog));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnStudios = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.listViewMovies = new System.Windows.Forms.ListView();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblStudio = new System.Windows.Forms.Label();
            this.lblTtl = new System.Windows.Forms.Label();
            this.lblYr = new System.Windows.Forms.Label();
            this.lblGnr = new System.Windows.Forms.Label();
            this.lblRtng = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblStd = new System.Windows.Forms.Label();
            this.txtTtl = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGnr = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStaticId = new System.Windows.Forms.Label();
            this.txtStd = new System.Windows.Forms.ComboBox();
            this.txtRtng = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(167, 463);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.AliceBlue;
            this.btnInsert.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(47, 463);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 32);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Add movie";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnStudios
            // 
            this.btnStudios.BackColor = System.Drawing.Color.AliceBlue;
            this.btnStudios.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudios.Location = new System.Drawing.Point(869, 471);
            this.btnStudios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudios.Name = "btnStudios";
            this.btnStudios.Size = new System.Drawing.Size(100, 32);
            this.btnStudios.TabIndex = 39;
            this.btnStudios.Text = "Studios";
            this.btnStudios.UseVisualStyleBackColor = false;
            this.btnStudios.Click += new System.EventHandler(this.btnStudios_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(534, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(202, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(316, 30);
            this.txtSearch.TabIndex = 48;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReset.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(637, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 32);
            this.btnReset.TabIndex = 50;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listViewMovies
            // 
            this.listViewMovies.BackColor = System.Drawing.Color.LightCyan;
            this.listViewMovies.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMovies.GridLines = true;
            this.listViewMovies.HideSelection = false;
            this.listViewMovies.Location = new System.Drawing.Point(58, 116);
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.Size = new System.Drawing.Size(197, 310);
            this.listViewMovies.TabIndex = 51;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.View = System.Windows.Forms.View.List;
            this.listViewMovies.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.Location = new System.Drawing.Point(463, 305);
            this.btnSaveUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnSaveUpdate.TabIndex = 88;
            this.btnSaveUpdate.Text = "Save";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Visible = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEdit.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(463, 305);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex = 87;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.lblTitle.Location = new System.Drawing.Point(37, 76);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 23);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.lblYear.Location = new System.Drawing.Point(37, 119);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 23);
            this.lblYear.TabIndex = 69;
            this.lblYear.Text = "Year";
            this.lblYear.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.lblGenre.Location = new System.Drawing.Point(37, 160);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(67, 23);
            this.lblGenre.TabIndex = 70;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Visible = false;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.lblRating.Location = new System.Drawing.Point(37, 204);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(69, 23);
            this.lblRating.TabIndex = 71;
            this.lblRating.Text = "Rating";
            this.lblRating.Visible = false;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.lblDirector.Location = new System.Drawing.Point(37, 249);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(82, 23);
            this.lblDirector.TabIndex = 72;
            this.lblDirector.Text = "Director";
            this.lblDirector.Visible = false;
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.lblStudio.Location = new System.Drawing.Point(39, 293);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(67, 23);
            this.lblStudio.TabIndex = 73;
            this.lblStudio.Text = "Studio";
            this.lblStudio.Visible = false;
            // 
            // lblTtl
            // 
            this.lblTtl.AutoSize = true;
            this.lblTtl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtl.Location = new System.Drawing.Point(164, 77);
            this.lblTtl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTtl.Name = "lblTtl";
            this.lblTtl.Size = new System.Drawing.Size(65, 22);
            this.lblTtl.TabIndex = 76;
            this.lblTtl.Text = "label1";
            this.lblTtl.Visible = false;
            // 
            // lblYr
            // 
            this.lblYr.AutoSize = true;
            this.lblYr.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYr.Location = new System.Drawing.Point(164, 120);
            this.lblYr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYr.Name = "lblYr";
            this.lblYr.Size = new System.Drawing.Size(65, 22);
            this.lblYr.TabIndex = 77;
            this.lblYr.Text = "label1";
            this.lblYr.Visible = false;
            // 
            // lblGnr
            // 
            this.lblGnr.AutoSize = true;
            this.lblGnr.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGnr.Location = new System.Drawing.Point(164, 163);
            this.lblGnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGnr.Name = "lblGnr";
            this.lblGnr.Size = new System.Drawing.Size(65, 22);
            this.lblGnr.TabIndex = 78;
            this.lblGnr.Text = "label1";
            this.lblGnr.Visible = false;
            // 
            // lblRtng
            // 
            this.lblRtng.AutoSize = true;
            this.lblRtng.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtng.Location = new System.Drawing.Point(164, 205);
            this.lblRtng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRtng.Name = "lblRtng";
            this.lblRtng.Size = new System.Drawing.Size(65, 22);
            this.lblRtng.TabIndex = 79;
            this.lblRtng.Text = "label1";
            this.lblRtng.Visible = false;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.Location = new System.Drawing.Point(164, 250);
            this.lblDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(65, 22);
            this.lblDir.TabIndex = 80;
            this.lblDir.Text = "label1";
            this.lblDir.Visible = false;
            // 
            // lblStd
            // 
            this.lblStd.AutoSize = true;
            this.lblStd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStd.Location = new System.Drawing.Point(164, 294);
            this.lblStd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStd.Name = "lblStd";
            this.lblStd.Size = new System.Drawing.Size(65, 22);
            this.lblStd.TabIndex = 81;
            this.lblStd.Text = "label1";
            this.lblStd.Visible = false;
            // 
            // txtTtl
            // 
            this.txtTtl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtl.Location = new System.Drawing.Point(143, 74);
            this.txtTtl.Margin = new System.Windows.Forms.Padding(4);
            this.txtTtl.Name = "txtTtl";
            this.txtTtl.Size = new System.Drawing.Size(169, 30);
            this.txtTtl.TabIndex = 67;
            this.txtTtl.Visible = false;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(143, 117);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(169, 30);
            this.txtYear.TabIndex = 66;
            this.txtYear.Visible = false;
            // 
            // txtGnr
            // 
            this.txtGnr.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGnr.Location = new System.Drawing.Point(143, 160);
            this.txtGnr.Margin = new System.Windows.Forms.Padding(4);
            this.txtGnr.Name = "txtGnr";
            this.txtGnr.Size = new System.Drawing.Size(169, 30);
            this.txtGnr.TabIndex = 74;
            this.txtGnr.Visible = false;
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(143, 247);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(169, 30);
            this.txtDir.TabIndex = 75;
            this.txtDir.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(164, 28);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(65, 22);
            this.lblId.TabIndex = 82;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // lblStaticId
            // 
            this.lblStaticId.AutoSize = true;
            this.lblStaticId.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.lblStaticId.Location = new System.Drawing.Point(37, 27);
            this.lblStaticId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticId.Name = "lblStaticId";
            this.lblStaticId.Size = new System.Drawing.Size(28, 23);
            this.lblStaticId.TabIndex = 83;
            this.lblStaticId.Text = "ID";
            this.lblStaticId.Visible = false;
            // 
            // txtStd
            // 
            this.txtStd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStd.FormattingEnabled = true;
            this.txtStd.Location = new System.Drawing.Point(143, 291);
            this.txtStd.Name = "txtStd";
            this.txtStd.Size = new System.Drawing.Size(169, 29);
            this.txtStd.TabIndex = 84;
            this.txtStd.Visible = false;
            // 
            // txtRtng
            // 
            this.txtRtng.BackColor = System.Drawing.SystemColors.Window;
            this.txtRtng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRtng.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtng.FormattingEnabled = true;
            this.txtRtng.Items.AddRange(new object[] {
            "No Rating",
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.txtRtng.Location = new System.Drawing.Point(143, 202);
            this.txtRtng.Name = "txtRtng";
            this.txtRtng.Size = new System.Drawing.Size(169, 29);
            this.txtRtng.TabIndex = 85;
            this.txtRtng.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(383, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtRtng);
            this.panel1.Controls.Add(this.txtStd);
            this.panel1.Controls.Add(this.btnSaveUpdate);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lblStaticId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Controls.Add(this.txtGnr);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtTtl);
            this.panel1.Controls.Add(this.lblStd);
            this.panel1.Controls.Add(this.lblDir);
            this.panel1.Controls.Add(this.lblRtng);
            this.panel1.Controls.Add(this.lblGnr);
            this.panel1.Controls.Add(this.lblYr);
            this.panel1.Controls.Add(this.lblTtl);
            this.panel1.Controls.Add(this.lblStudio);
            this.panel1.Controls.Add(this.lblDirector);
            this.panel1.Controls.Add(this.lblRating);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(359, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 354);
            this.panel1.TabIndex = 89;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(139, 317);
            this.lblInfo.MaximumSize = new System.Drawing.Size(400, 100);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(332, 20);
            this.lblInfo.TabIndex = 92;
            this.lblInfo.Text = "Info about the selected movie will appear here.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(125, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(362, 317);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 92;
            this.logo.TabStop = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "All",
            "Id",
            "Title",
            "Year",
            "Genre",
            "Director",
            "Rating"});
            this.cmbSearch.Location = new System.Drawing.Point(84, 24);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(112, 30);
            this.cmbSearch.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Movies";
            // 
            // MovieCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1034, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewMovies);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnStudios);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieCatalog";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.MovieCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnStudios;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView listViewMovies;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblStudio;
        public System.Windows.Forms.Label lblTtl;
        public System.Windows.Forms.Label lblYr;
        public System.Windows.Forms.Label lblGnr;
        public System.Windows.Forms.Label lblRtng;
        public System.Windows.Forms.Label lblDir;
        public System.Windows.Forms.Label lblStd;
        public System.Windows.Forms.TextBox txtTtl;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtGnr;
        public System.Windows.Forms.TextBox txtDir;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStaticId;
        private System.Windows.Forms.ComboBox txtStd;
        private System.Windows.Forms.ComboBox txtRtng;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblInfo;
    }
}

