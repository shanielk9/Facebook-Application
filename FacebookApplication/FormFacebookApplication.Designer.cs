namespace FacebookApplication
{
    public partial class FormFacebookApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebookApplication));
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.listBoxTimeline = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.textBoxSearchFriend = new System.Windows.Forms.TextBox();
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.buttonBasicInfo = new System.Windows.Forms.Button();
            this.groupBoxTimeline = new System.Windows.Forms.GroupBox();
            this.buttonTimeline = new System.Windows.Forms.Button();
            this.groupBoxFriendsList = new System.Windows.Forms.GroupBox();
            this.buttonFriendsList = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.groupBoxCreatePost = new System.Windows.Forms.GroupBox();
            this.tabControlPostItems = new System.Windows.Forms.TabControl();
            this.Status = new System.Windows.Forms.TabPage();
            this.Photo = new System.Windows.Forms.TabPage();
            this.textBoxPhotoTitle = new System.Windows.Forms.TextBox();
            this.labelPhotoTitle = new System.Windows.Forms.Label();
            this.labelPhotoPath = new System.Windows.Forms.Label();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.TabPage();
            this.textBoxLinkTitle = new System.Windows.Forms.TextBox();
            this.labelLinkTitle = new System.Windows.Forms.Label();
            this.textBoxLinkPath = new System.Windows.Forms.TextBox();
            this.labelLinkPath = new System.Windows.Forms.Label();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonMemories = new System.Windows.Forms.Button();
            this.UserPicbox = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoverBackground = new System.Windows.Forms.PictureBox();
            this.buttonFriendshipTest = new System.Windows.Forms.Button();
            this.groupBoxBasicInfo.SuspendLayout();
            this.groupBoxTimeline.SuspendLayout();
            this.groupBoxFriendsList.SuspendLayout();
            this.groupBoxCreatePost.SuspendLayout();
            this.tabControlPostItems.SuspendLayout();
            this.Status.SuspendLayout();
            this.Photo.SuspendLayout();
            this.Link.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(8, 34);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(247, 69);
            this.listBoxInfo.TabIndex = 2;
            // 
            // listBoxTimeline
            // 
            this.listBoxTimeline.FormattingEnabled = true;
            this.listBoxTimeline.ItemHeight = 15;
            this.listBoxTimeline.Location = new System.Drawing.Point(7, 41);
            this.listBoxTimeline.Name = "listBoxTimeline";
            this.listBoxTimeline.Size = new System.Drawing.Size(403, 169);
            this.listBoxTimeline.TabIndex = 7;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(6, 65);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(249, 147);
            this.listBoxFriends.TabIndex = 11;
            // 
            // textBoxSearchFriend
            // 
            this.textBoxSearchFriend.Location = new System.Drawing.Point(6, 33);
            this.textBoxSearchFriend.Name = "textBoxSearchFriend";
            this.textBoxSearchFriend.Size = new System.Drawing.Size(249, 22);
            this.textBoxSearchFriend.TabIndex = 12;
            this.textBoxSearchFriend.Text = "Search friend...";
            this.textBoxSearchFriend.Click += new System.EventHandler(this.textBoxSearchFriend_Click);
            this.textBoxSearchFriend.TextChanged += new System.EventHandler(this.textBoxSearchFriend_TextChanged);
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.listBoxInfo);
            this.groupBoxBasicInfo.Controls.Add(this.buttonBasicInfo);
            this.groupBoxBasicInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(33, 238);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(261, 135);
            this.groupBoxBasicInfo.TabIndex = 13;
            this.groupBoxBasicInfo.TabStop = false;
            // 
            // buttonBasicInfo
            // 
            this.buttonBasicInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBasicInfo.Image = global::FacebookApplication.Properties.Resources.Actions_help_about_icon;
            this.buttonBasicInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBasicInfo.Location = new System.Drawing.Point(6, 0);
            this.buttonBasicInfo.Name = "buttonBasicInfo";
            this.buttonBasicInfo.Size = new System.Drawing.Size(133, 30);
            this.buttonBasicInfo.TabIndex = 20;
            this.buttonBasicInfo.Text = "Basic information:";
            this.buttonBasicInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBasicInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimeline
            // 
            this.groupBoxTimeline.Controls.Add(this.listBoxTimeline);
            this.groupBoxTimeline.Controls.Add(this.buttonTimeline);
            this.groupBoxTimeline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTimeline.Location = new System.Drawing.Point(324, 379);
            this.groupBoxTimeline.Name = "groupBoxTimeline";
            this.groupBoxTimeline.Size = new System.Drawing.Size(416, 235);
            this.groupBoxTimeline.TabIndex = 15;
            this.groupBoxTimeline.TabStop = false;
            // 
            // buttonTimeline
            // 
            this.buttonTimeline.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeline.Image = global::FacebookApplication.Properties.Resources.Apps_Google_Chrome_App_List_icon;
            this.buttonTimeline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimeline.Location = new System.Drawing.Point(6, 0);
            this.buttonTimeline.Name = "buttonTimeline";
            this.buttonTimeline.Size = new System.Drawing.Size(88, 30);
            this.buttonTimeline.TabIndex = 22;
            this.buttonTimeline.Text = "Timeline:";
            this.buttonTimeline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTimeline.UseVisualStyleBackColor = true;
            // 
            // groupBoxFriendsList
            // 
            this.groupBoxFriendsList.Controls.Add(this.textBoxSearchFriend);
            this.groupBoxFriendsList.Controls.Add(this.listBoxFriends);
            this.groupBoxFriendsList.Controls.Add(this.buttonFriendsList);
            this.groupBoxFriendsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFriendsList.Location = new System.Drawing.Point(33, 379);
            this.groupBoxFriendsList.Name = "groupBoxFriendsList";
            this.groupBoxFriendsList.Size = new System.Drawing.Size(261, 235);
            this.groupBoxFriendsList.TabIndex = 16;
            this.groupBoxFriendsList.TabStop = false;
            // 
            // buttonFriendsList
            // 
            this.buttonFriendsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendsList.Image = global::FacebookApplication.Properties.Resources.Users_icon;
            this.buttonFriendsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriendsList.Location = new System.Drawing.Point(8, 0);
            this.buttonFriendsList.Name = "buttonFriendsList";
            this.buttonFriendsList.Size = new System.Drawing.Size(98, 28);
            this.buttonFriendsList.TabIndex = 23;
            this.buttonFriendsList.Text = "Friends list:";
            this.buttonFriendsList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFriendsList.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Firebrick;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(744, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(68, 32);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(188, 187);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(65, 25);
            this.labelUserName.TabIndex = 24;
            this.labelUserName.Text = "label1";
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPost.Enabled = false;
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(326, 99);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(84, 29);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(7, 5);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(298, 80);
            this.textBoxPost.TabIndex = 5;
            this.textBoxPost.Text = "What\'s on your mind?";
            this.textBoxPost.Click += new System.EventHandler(this.textBoxPost_Click);
            // 
            // groupBoxCreatePost
            // 
            this.groupBoxCreatePost.Controls.Add(this.tabControlPostItems);
            this.groupBoxCreatePost.Controls.Add(this.buttonPost);
            this.groupBoxCreatePost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCreatePost.Location = new System.Drawing.Point(324, 238);
            this.groupBoxCreatePost.Name = "groupBoxCreatePost";
            this.groupBoxCreatePost.Size = new System.Drawing.Size(416, 135);
            this.groupBoxCreatePost.TabIndex = 14;
            this.groupBoxCreatePost.TabStop = false;
            // 
            // tabControlPostItems
            // 
            this.tabControlPostItems.Controls.Add(this.Status);
            this.tabControlPostItems.Controls.Add(this.Photo);
            this.tabControlPostItems.Controls.Add(this.Link);
            this.tabControlPostItems.Enabled = false;
            this.tabControlPostItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPostItems.ImageList = this.imageListIcons;
            this.tabControlPostItems.Location = new System.Drawing.Point(6, 9);
            this.tabControlPostItems.Name = "tabControlPostItems";
            this.tabControlPostItems.SelectedIndex = 0;
            this.tabControlPostItems.Size = new System.Drawing.Size(320, 120);
            this.tabControlPostItems.TabIndex = 24;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.textBoxPost);
            this.Status.ImageIndex = 0;
            this.Status.Location = new System.Drawing.Point(4, 26);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(312, 90);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // Photo
            // 
            this.Photo.Controls.Add(this.textBoxPhotoTitle);
            this.Photo.Controls.Add(this.labelPhotoTitle);
            this.Photo.Controls.Add(this.labelPhotoPath);
            this.Photo.Controls.Add(this.buttonUploadPhoto);
            this.Photo.ImageIndex = 1;
            this.Photo.Location = new System.Drawing.Point(4, 26);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(312, 90);
            this.Photo.TabIndex = 1;
            this.Photo.Text = "Photo";
            this.Photo.UseVisualStyleBackColor = true;
            // 
            // textBoxPhotoTitle
            // 
            this.textBoxPhotoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhotoTitle.Location = new System.Drawing.Point(51, 12);
            this.textBoxPhotoTitle.Name = "textBoxPhotoTitle";
            this.textBoxPhotoTitle.Size = new System.Drawing.Size(246, 23);
            this.textBoxPhotoTitle.TabIndex = 3;
            this.textBoxPhotoTitle.Text = "Enter title for your photo...";
            this.textBoxPhotoTitle.Click += new System.EventHandler(this.textBoxPhotoTitle_Click);
            // 
            // labelPhotoTitle
            // 
            this.labelPhotoTitle.AutoSize = true;
            this.labelPhotoTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoTitle.Location = new System.Drawing.Point(10, 13);
            this.labelPhotoTitle.Name = "labelPhotoTitle";
            this.labelPhotoTitle.Size = new System.Drawing.Size(39, 17);
            this.labelPhotoTitle.TabIndex = 2;
            this.labelPhotoTitle.Text = "Title :";
            // 
            // labelPhotoPath
            // 
            this.labelPhotoPath.AutoSize = true;
            this.labelPhotoPath.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoPath.Location = new System.Drawing.Point(108, 63);
            this.labelPhotoPath.Name = "labelPhotoPath";
            this.labelPhotoPath.Size = new System.Drawing.Size(16, 13);
            this.labelPhotoPath.TabIndex = 1;
            this.labelPhotoPath.Text = "...";
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadPhoto.Location = new System.Drawing.Point(8, 50);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(100, 28);
            this.buttonUploadPhoto.TabIndex = 0;
            this.buttonUploadPhoto.Text = "Upload Photo";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // Link
            // 
            this.Link.Controls.Add(this.textBoxLinkTitle);
            this.Link.Controls.Add(this.labelLinkTitle);
            this.Link.Controls.Add(this.textBoxLinkPath);
            this.Link.Controls.Add(this.labelLinkPath);
            this.Link.ImageIndex = 2;
            this.Link.Location = new System.Drawing.Point(4, 26);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(312, 90);
            this.Link.TabIndex = 2;
            this.Link.Text = "Link";
            this.Link.UseVisualStyleBackColor = true;
            // 
            // textBoxLinkTitle
            // 
            this.textBoxLinkTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinkTitle.Location = new System.Drawing.Point(57, 16);
            this.textBoxLinkTitle.Name = "textBoxLinkTitle";
            this.textBoxLinkTitle.Size = new System.Drawing.Size(232, 23);
            this.textBoxLinkTitle.TabIndex = 5;
            this.textBoxLinkTitle.Text = "Enter title for your link...";
            this.textBoxLinkTitle.Click += new System.EventHandler(this.textBoxLinkTitle_Click);
            // 
            // labelLinkTitle
            // 
            this.labelLinkTitle.AutoSize = true;
            this.labelLinkTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinkTitle.Location = new System.Drawing.Point(15, 19);
            this.labelLinkTitle.Name = "labelLinkTitle";
            this.labelLinkTitle.Size = new System.Drawing.Size(36, 15);
            this.labelLinkTitle.TabIndex = 4;
            this.labelLinkTitle.Text = "Title :";
            // 
            // textBoxLinkPath
            // 
            this.textBoxLinkPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinkPath.Location = new System.Drawing.Point(80, 49);
            this.textBoxLinkPath.Name = "textBoxLinkPath";
            this.textBoxLinkPath.Size = new System.Drawing.Size(209, 23);
            this.textBoxLinkPath.TabIndex = 1;
            this.textBoxLinkPath.Text = "Enter your link..";
            this.textBoxLinkPath.Click += new System.EventHandler(this.textBoxLinkPath_Click);
            // 
            // labelLinkPath
            // 
            this.labelLinkPath.AutoSize = true;
            this.labelLinkPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinkPath.Location = new System.Drawing.Point(15, 52);
            this.labelLinkPath.Name = "labelLinkPath";
            this.labelLinkPath.Size = new System.Drawing.Size(59, 15);
            this.labelLinkPath.TabIndex = 0;
            this.labelLinkPath.Text = "Link Path:";
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "pen-icon (1).png");
            this.imageListIcons.Images.SetKeyName(1, "My-Pictures-icon.png");
            this.imageListIcons.Images.SetKeyName(2, "link-icon.png");
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Enabled = false;
            this.buttonAlbums.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbums.Image = global::FacebookApplication.Properties.Resources.Images_icon;
            this.buttonAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.Location = new System.Drawing.Point(564, 180);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(132, 43);
            this.buttonAlbums.TabIndex = 22;
            this.buttonAlbums.Text = "Fetch Albums";
            this.buttonAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonMemories
            // 
            this.buttonMemories.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMemories.BackgroundImage = global::FacebookApplication.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.buttonMemories.Enabled = false;
            this.buttonMemories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemories.ForeColor = System.Drawing.Color.White;
            this.buttonMemories.Image = global::FacebookApplication.Properties.Resources.Event_search_icon;
            this.buttonMemories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMemories.Location = new System.Drawing.Point(539, 27);
            this.buttonMemories.Name = "buttonMemories";
            this.buttonMemories.Size = new System.Drawing.Size(184, 67);
            this.buttonMemories.TabIndex = 19;
            this.buttonMemories.Text = "Search Memories\r\n";
            this.buttonMemories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMemories.UseVisualStyleBackColor = false;
            this.buttonMemories.Click += new System.EventHandler(this.buttonMemories_Click);
            // 
            // UserPicbox
            // 
            this.UserPicbox.Location = new System.Drawing.Point(62, 95);
            this.UserPicbox.Name = "UserPicbox";
            this.UserPicbox.Size = new System.Drawing.Size(120, 122);
            this.UserPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicbox.TabIndex = 0;
            this.UserPicbox.TabStop = false;
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(41, 21);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(486, 161);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 1;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // pictureBoxCoverBackground
            // 
            this.pictureBoxCoverBackground.BackgroundImage = global::FacebookApplication.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.pictureBoxCoverBackground.Location = new System.Drawing.Point(33, 12);
            this.pictureBoxCoverBackground.Name = "pictureBoxCoverBackground";
            this.pictureBoxCoverBackground.Size = new System.Drawing.Size(707, 220);
            this.pictureBoxCoverBackground.TabIndex = 26;
            this.pictureBoxCoverBackground.TabStop = false;
            // 
            // buttonFriendshipTest
            // 
            this.buttonFriendshipTest.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonFriendshipTest.BackgroundImage = global::FacebookApplication.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.buttonFriendshipTest.Enabled = false;
            this.buttonFriendshipTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFriendshipTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendshipTest.ForeColor = System.Drawing.Color.White;
            this.buttonFriendshipTest.Image = global::FacebookApplication.Properties.Resources.friends_icon;
            this.buttonFriendshipTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriendshipTest.Location = new System.Drawing.Point(539, 100);
            this.buttonFriendshipTest.Name = "buttonFriendshipTest";
            this.buttonFriendshipTest.Size = new System.Drawing.Size(184, 67);
            this.buttonFriendshipTest.TabIndex = 27;
            this.buttonFriendshipTest.Text = "Friendship Test";
            this.buttonFriendshipTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFriendshipTest.UseVisualStyleBackColor = false;
            this.buttonFriendshipTest.Click += new System.EventHandler(this.buttonFriendshipTest_Click);
            // 
            // FormFacebookApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(820, 632);
            this.Controls.Add(this.buttonFriendshipTest);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonMemories);
            this.Controls.Add(this.groupBoxFriendsList);
            this.Controls.Add(this.groupBoxTimeline);
            this.Controls.Add(this.groupBoxBasicInfo);
            this.Controls.Add(this.groupBoxCreatePost);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.UserPicbox);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Controls.Add(this.pictureBoxCoverBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFacebookApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.FacebookApplicationForm_Load);
            this.groupBoxBasicInfo.ResumeLayout(false);
            this.groupBoxTimeline.ResumeLayout(false);
            this.groupBoxFriendsList.ResumeLayout(false);
            this.groupBoxFriendsList.PerformLayout();
            this.groupBoxCreatePost.ResumeLayout(false);
            this.tabControlPostItems.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.Photo.ResumeLayout(false);
            this.Photo.PerformLayout();
            this.Link.ResumeLayout(false);
            this.Link.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserPicbox;
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxTimeline;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TextBox textBoxSearchFriend;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.GroupBox groupBoxTimeline;
        private System.Windows.Forms.GroupBox groupBoxFriendsList;
        private System.Windows.Forms.Button buttonMemories;
        private System.Windows.Forms.Button buttonBasicInfo;
        private System.Windows.Forms.Button buttonTimeline;
        private System.Windows.Forms.Button buttonFriendsList;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxCoverBackground;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.GroupBox groupBoxCreatePost;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.TabControl tabControlPostItems;
        private System.Windows.Forms.TabPage Status;
        private System.Windows.Forms.TabPage Photo;
        private System.Windows.Forms.TextBox textBoxPhotoTitle;
        private System.Windows.Forms.Label labelPhotoTitle;
        private System.Windows.Forms.Label labelPhotoPath;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private System.Windows.Forms.TabPage Link;
        private System.Windows.Forms.TextBox textBoxLinkPath;
        private System.Windows.Forms.Label labelLinkPath;
        private System.Windows.Forms.TextBox textBoxLinkTitle;
        private System.Windows.Forms.Label labelLinkTitle;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Button buttonFriendshipTest;
    }
}