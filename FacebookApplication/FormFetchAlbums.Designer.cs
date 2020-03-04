namespace FacebookApplication
{
   public partial class FormFetchAlbums
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label imageSmallLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFetchAlbums));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPicturesAlbum = new System.Windows.Forms.Panel();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.imageSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewPicturesFromAlbum = new System.Windows.Forms.ListView();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.comboBoxChooseFilter = new System.Windows.Forms.ComboBox();
            countLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            imageSmallLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.panelPicturesAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countLabel.Location = new System.Drawing.Point(166, 121);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(125, 19);
            countLabel.TabIndex = 0;
            countLabel.Text = "Number of Photos:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.Location = new System.Drawing.Point(166, 51);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(93, 19);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // imageSmallLabel
            // 
            imageSmallLabel.AutoSize = true;
            imageSmallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageSmallLabel.Location = new System.Drawing.Point(31, 17);
            imageSmallLabel.Name = "imageSmallLabel";
            imageSmallLabel.Size = new System.Drawing.Size(81, 15);
            imageSmallLabel.TabIndex = 6;
            imageSmallLabel.Text = "Album photo:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkLabel.Location = new System.Drawing.Point(6, 161);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(32, 15);
            linkLabel.TabIndex = 8;
            linkLabel.Text = "Link:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(166, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 19);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(167, 89);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBoxAlbums);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxAlbums";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxAlbums.DataSource = this.albumsBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 17;
            this.listBoxAlbums.Location = new System.Drawing.Point(5, 20);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(251, 412);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // panelPicturesAlbum
            // 
            this.panelPicturesAlbum.BackColor = System.Drawing.SystemColors.Menu;
            this.panelPicturesAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicturesAlbum.Controls.Add(descriptionLabel);
            this.panelPicturesAlbum.Controls.Add(this.descriptionLabel1);
            this.panelPicturesAlbum.Controls.Add(nameLabel);
            this.panelPicturesAlbum.Controls.Add(this.nameTextBox);
            this.panelPicturesAlbum.Controls.Add(countLabel);
            this.panelPicturesAlbum.Controls.Add(this.countLabel1);
            this.panelPicturesAlbum.Controls.Add(createdTimeLabel);
            this.panelPicturesAlbum.Controls.Add(this.createdTimeLabel1);
            this.panelPicturesAlbum.Controls.Add(imageSmallLabel);
            this.panelPicturesAlbum.Controls.Add(this.imageSmallPictureBox);
            this.panelPicturesAlbum.Controls.Add(linkLabel);
            this.panelPicturesAlbum.Controls.Add(this.linkLinkLabel);
            this.panelPicturesAlbum.Location = new System.Drawing.Point(297, 189);
            this.panelPicturesAlbum.Name = "panelPicturesAlbum";
            this.panelPicturesAlbum.Size = new System.Drawing.Size(583, 195);
            this.panelPicturesAlbum.TabIndex = 1;
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Description", true));
            this.descriptionLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(297, 90);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(100, 23);
            this.descriptionLabel1.TabIndex = 12;
            this.descriptionLabel1.Text = "label1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(300, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 23);
            this.nameTextBox.TabIndex = 11;
            // 
            // countLabel1
            // 
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Count", true));
            this.countLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel1.Location = new System.Drawing.Point(297, 123);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(100, 23);
            this.countLabel1.TabIndex = 1;
            this.countLabel1.Text = "label1";
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTimeLabel1.Location = new System.Drawing.Point(297, 53);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 3;
            this.createdTimeLabel1.Text = "label1";
            // 
            // imageSmallPictureBox
            // 
            this.imageSmallPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageSmallPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumsBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox.Location = new System.Drawing.Point(19, 40);
            this.imageSmallPictureBox.Name = "imageSmallPictureBox";
            this.imageSmallPictureBox.Size = new System.Drawing.Size(109, 106);
            this.imageSmallPictureBox.TabIndex = 7;
            this.imageSmallPictureBox.TabStop = false;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.AutoSize = true;
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Link", true));
            this.linkLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLinkLabel.Location = new System.Drawing.Point(35, 161);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(60, 15);
            this.linkLinkLabel.TabIndex = 9;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.albumsBindingSource;
            // 
            // listViewPicturesFromAlbum
            // 
            this.listViewPicturesFromAlbum.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewPicturesFromAlbum.HideSelection = false;
            this.listViewPicturesFromAlbum.Location = new System.Drawing.Point(297, 415);
            this.listViewPicturesFromAlbum.MultiSelect = false;
            this.listViewPicturesFromAlbum.Name = "listViewPicturesFromAlbum";
            this.listViewPicturesFromAlbum.Size = new System.Drawing.Size(583, 210);
            this.listViewPicturesFromAlbum.TabIndex = 2;
            this.listViewPicturesFromAlbum.UseCompatibleStateImageBehavior = false;
            this.listViewPicturesFromAlbum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPicturesFromAlbum_MouseDoubleClick);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Image = global::FacebookApplication.Properties.Resources.oneplus_camera_gallery2;
            this.pictureBoxBackground.Location = new System.Drawing.Point(91, 2);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(714, 328);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 3;
            this.pictureBoxBackground.TabStop = false;
            // 
            // comboBoxChooseFilter
            // 
            this.comboBoxChooseFilter.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxChooseFilter.FormattingEnabled = true;
            this.comboBoxChooseFilter.Items.AddRange(new object[] {
            "All",
            "Photos I tagged in",
            "Photos that one or more people were tagged in ",
            "Photos with likes",
            "Photos with comments"});
            this.comboBoxChooseFilter.Location = new System.Drawing.Point(488, 388);
            this.comboBoxChooseFilter.Name = "comboBoxChooseFilter";
            this.comboBoxChooseFilter.Size = new System.Drawing.Size(245, 21);
            this.comboBoxChooseFilter.TabIndex = 4;
            this.comboBoxChooseFilter.Text = "Select a Filter";
            this.comboBoxChooseFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseFilter_SelectedIndexChanged);
            // 
            // FormFetchAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookApplication.Properties.Resources.oneplus_camera_gallery3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 633);
            this.Controls.Add(this.comboBoxChooseFilter);
            this.Controls.Add(this.listViewPicturesFromAlbum);
            this.Controls.Add(this.panelPicturesAlbum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFetchAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albums";
            this.Load += new System.EventHandler(this.FormFetchAlbums_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.panelPicturesAlbum.ResumeLayout(false);
            this.panelPicturesAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Panel panelPicturesAlbum;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.PictureBox imageSmallPictureBox;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private System.Windows.Forms.ListView listViewPicturesFromAlbum;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.ComboBox comboBoxChooseFilter;
    }
}