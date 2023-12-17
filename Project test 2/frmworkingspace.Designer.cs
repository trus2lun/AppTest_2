namespace Project_test_2
{
    partial class frmworkingspace
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvListbook = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txbShelf = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbEpisode = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.txbGenre = new System.Windows.Forms.TextBox();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.ckbSearchbytitle = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListbook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(592, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvListbook
            // 
            this.dgvListbook.AllowUserToAddRows = false;
            this.dgvListbook.AllowUserToDeleteRows = false;
            this.dgvListbook.AllowUserToOrderColumns = true;
            this.dgvListbook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListbook.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListbook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListbook.Location = new System.Drawing.Point(0, 189);
            this.dgvListbook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListbook.MultiSelect = false;
            this.dgvListbook.Name = "dgvListbook";
            this.dgvListbook.ReadOnly = true;
            this.dgvListbook.RowHeadersWidth = 51;
            this.dgvListbook.RowTemplate.Height = 24;
            this.dgvListbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListbook.Size = new System.Drawing.Size(749, 204);
            this.dgvListbook.TabIndex = 3;
            this.dgvListbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListbook_CellClick);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(657, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(66, 29);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txbShelf
            // 
            this.txbShelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbShelf.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbShelf.Location = new System.Drawing.Point(272, 147);
            this.txbShelf.Name = "txbShelf";
            this.txbShelf.Size = new System.Drawing.Size(41, 22);
            this.txbShelf.TabIndex = 13;
            // 
            // txbQuantity
            // 
            this.txbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantity.Location = new System.Drawing.Point(67, 145);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(28, 22);
            this.txbQuantity.TabIndex = 14;
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelf.Location = new System.Drawing.Point(225, 149);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(36, 15);
            this.lblShelf.TabIndex = 5;
            this.lblShelf.Text = "Shelf";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(6, 147);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 15);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // txbPrice
            // 
            this.txbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(272, 105);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(86, 22);
            this.txbPrice.TabIndex = 15;
            // 
            // txbEpisode
            // 
            this.txbEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEpisode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEpisode.Location = new System.Drawing.Point(67, 103);
            this.txbEpisode.Name = "txbEpisode";
            this.txbEpisode.Size = new System.Drawing.Size(28, 22);
            this.txbEpisode.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(224, 107);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 15);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisode.Location = new System.Drawing.Point(13, 105);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(48, 15);
            this.lblEpisode.TabIndex = 8;
            this.lblEpisode.Text = "Episode";
            // 
            // txbGenre
            // 
            this.txbGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGenre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenre.Location = new System.Drawing.Point(272, 59);
            this.txbGenre.Name = "txbGenre";
            this.txbGenre.Size = new System.Drawing.Size(182, 22);
            this.txbGenre.TabIndex = 17;
            // 
            // txbAuthor
            // 
            this.txbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAuthor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthor.Location = new System.Drawing.Point(67, 57);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(147, 22);
            this.txbAuthor.TabIndex = 18;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(220, 59);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(41, 15);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(15, 59);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 15);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Author";
            // 
            // txbID
            // 
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(272, 14);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(30, 22);
            this.txbID.TabIndex = 19;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(241, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 15);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // txbTitle
            // 
            this.txbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitle.Location = new System.Drawing.Point(67, 14);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(147, 22);
            this.txbTitle.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(28, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 15);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(507, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(507, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(507, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(507, 58);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ckbSearchbytitle
            // 
            this.ckbSearchbytitle.AutoSize = true;
            this.ckbSearchbytitle.Location = new System.Drawing.Point(495, 22);
            this.ckbSearchbytitle.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSearchbytitle.Name = "ckbSearchbytitle";
            this.ckbSearchbytitle.Size = new System.Drawing.Size(93, 17);
            this.ckbSearchbytitle.TabIndex = 25;
            this.ckbSearchbytitle.Text = "Search by title";
            this.ckbSearchbytitle.UseVisualStyleBackColor = true;
            this.ckbSearchbytitle.CheckedChanged += new System.EventHandler(this.ckbSearchbytitle_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(592, 59);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 22);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmworkingspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(749, 393);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ckbSearchbytitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txbShelf);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lblShelf);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbEpisode);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.txbGenre);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvListbook);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmworkingspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmworkingspace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmworkingspace_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmworkingspace_FormClosed);
            this.Load += new System.EventHandler(this.frmworkingspace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvListbook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txbShelf;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbEpisode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEpisode;
        private System.Windows.Forms.TextBox txbGenre;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckBox ckbSearchbytitle;
        private System.Windows.Forms.Button btnRefresh;
    }
}