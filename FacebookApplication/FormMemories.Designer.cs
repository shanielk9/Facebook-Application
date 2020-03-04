namespace FacebookApplication
{
    public partial class FormMemories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemories));
            this.labelFirstDate = new System.Windows.Forms.Label();
            this.lableEndDate = new System.Windows.Forms.Label();
            this.checkBoxOneDay = new System.Windows.Forms.CheckBox();
            this.buttonFetchMemories = new System.Windows.Forms.Button();
            this.pictureBoxCoverForm = new System.Windows.Forms.PictureBox();
            this.groupBoxMemoriesDate = new System.Windows.Forms.GroupBox();
            this.labelMemoriesOptions = new System.Windows.Forms.Label();
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.listBoxMemoriesList = new System.Windows.Forms.ListBox();
            this.listViewMemoriesPhotos = new System.Windows.Forms.ListView();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverForm)).BeginInit();
            this.groupBoxMemoriesDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirstDate
            // 
            this.labelFirstDate.AutoSize = true;
            this.labelFirstDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstDate.Location = new System.Drawing.Point(29, 26);
            this.labelFirstDate.Name = "labelFirstDate";
            this.labelFirstDate.Size = new System.Drawing.Size(134, 21);
            this.labelFirstDate.TabIndex = 0;
            this.labelFirstDate.Text = "Choose start date:";
            // 
            // lableEndDate
            // 
            this.lableEndDate.AutoSize = true;
            this.lableEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableEndDate.Location = new System.Drawing.Point(29, 86);
            this.lableEndDate.Name = "lableEndDate";
            this.lableEndDate.Size = new System.Drawing.Size(129, 21);
            this.lableEndDate.TabIndex = 7;
            this.lableEndDate.Text = "Choose end date:";
            // 
            // checkBoxOneDay
            // 
            this.checkBoxOneDay.AutoSize = true;
            this.checkBoxOneDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOneDay.Location = new System.Drawing.Point(47, 113);
            this.checkBoxOneDay.Name = "checkBoxOneDay";
            this.checkBoxOneDay.Size = new System.Drawing.Size(107, 23);
            this.checkBoxOneDay.TabIndex = 10;
            this.checkBoxOneDay.Text = "only one day";
            this.checkBoxOneDay.UseVisualStyleBackColor = true;
            this.checkBoxOneDay.CheckedChanged += new System.EventHandler(this.checkBoxOneDay_CheckedChanged);
            // 
            // buttonFetchMemories
            // 
            this.buttonFetchMemories.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonFetchMemories.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchMemories.Image = global::FacebookApplication.Properties.Resources.find_icon;
            this.buttonFetchMemories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFetchMemories.Location = new System.Drawing.Point(32, 417);
            this.buttonFetchMemories.Name = "buttonFetchMemories";
            this.buttonFetchMemories.Size = new System.Drawing.Size(185, 45);
            this.buttonFetchMemories.TabIndex = 11;
            this.buttonFetchMemories.Text = "Fetch!";
            this.buttonFetchMemories.UseVisualStyleBackColor = false;
            this.buttonFetchMemories.Click += new System.EventHandler(this.buttonFetchMemories_Click);
            // 
            // pictureBoxCoverForm
            // 
            this.pictureBoxCoverForm.Image = global::FacebookApplication.Properties.Resources.memories;
            this.pictureBoxCoverForm.Location = new System.Drawing.Point(249, 5);
            this.pictureBoxCoverForm.Name = "pictureBoxCoverForm";
            this.pictureBoxCoverForm.Size = new System.Drawing.Size(550, 192);
            this.pictureBoxCoverForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverForm.TabIndex = 12;
            this.pictureBoxCoverForm.TabStop = false;
            // 
            // groupBoxMemoriesDate
            // 
            this.groupBoxMemoriesDate.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxMemoriesDate.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxMemoriesDate.Controls.Add(this.checkBoxOneDay);
            this.groupBoxMemoriesDate.Controls.Add(this.lableEndDate);
            this.groupBoxMemoriesDate.Controls.Add(this.labelFirstDate);
            this.groupBoxMemoriesDate.Location = new System.Drawing.Point(15, 12);
            this.groupBoxMemoriesDate.Name = "groupBoxMemoriesDate";
            this.groupBoxMemoriesDate.Size = new System.Drawing.Size(216, 189);
            this.groupBoxMemoriesDate.TabIndex = 13;
            this.groupBoxMemoriesDate.TabStop = false;
            this.groupBoxMemoriesDate.Text = "z";
            // 
            // labelMemoriesOptions
            // 
            this.labelMemoriesOptions.AutoSize = true;
            this.labelMemoriesOptions.BackColor = System.Drawing.SystemColors.Menu;
            this.labelMemoriesOptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMemoriesOptions.Location = new System.Drawing.Point(35, 235);
            this.labelMemoriesOptions.Name = "labelMemoriesOptions";
            this.labelMemoriesOptions.Size = new System.Drawing.Size(180, 25);
            this.labelMemoriesOptions.TabIndex = 4;
            this.labelMemoriesOptions.Text = "Choose what to see:";
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Items.AddRange(new object[] {
            "All",
            "Posts",
            "Photos",
            "Events",
            "Friends",
            "Groups"});
            this.checkedListBoxOptions.Location = new System.Drawing.Point(35, 267);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(182, 144);
            this.checkedListBoxOptions.TabIndex = 6;
            this.checkedListBoxOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxOptions_ItemCheck);
            // 
            // listBoxMemoriesList
            // 
            this.listBoxMemoriesList.FormattingEnabled = true;
            this.listBoxMemoriesList.Location = new System.Drawing.Point(249, 203);
            this.listBoxMemoriesList.Name = "listBoxMemoriesList";
            this.listBoxMemoriesList.Size = new System.Drawing.Size(266, 277);
            this.listBoxMemoriesList.TabIndex = 14;
            // 
            // listViewMemoriesPhotos
            // 
            this.listViewMemoriesPhotos.HideSelection = false;
            this.listViewMemoriesPhotos.Location = new System.Drawing.Point(519, 202);
            this.listViewMemoriesPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewMemoriesPhotos.Name = "listViewMemoriesPhotos";
            this.listViewMemoriesPhotos.Size = new System.Drawing.Size(281, 278);
            this.listViewMemoriesPhotos.TabIndex = 15;
            this.listViewMemoriesPhotos.UseCompatibleStateImageBehavior = false;
            this.listViewMemoriesPhotos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMemoriesPhotos_DoubleClick);
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnToMenu.ForeColor = System.Drawing.Color.White;
            this.buttonReturnToMenu.Location = new System.Drawing.Point(730, 13);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(60, 27);
            this.buttonReturnToMenu.TabIndex = 13;
            this.buttonReturnToMenu.Text = "Return";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(10, 59);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 11;
            this.dateTimePickerStartDate.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(10, 142);
            this.dateTimePickerEndDate.MaxDate = new System.DateTime(2019, 12, 2, 22, 9, 42, 0);
            this.dateTimePickerEndDate.MinDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 12;
            this.dateTimePickerEndDate.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // MemoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacebookApplication.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.ClientSize = new System.Drawing.Size(812, 491);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.listViewMemoriesPhotos);
            this.Controls.Add(this.listBoxMemoriesList);
            this.Controls.Add(this.groupBoxMemoriesDate);
            this.Controls.Add(this.pictureBoxCoverForm);
            this.Controls.Add(this.buttonFetchMemories);
            this.Controls.Add(this.checkedListBoxOptions);
            this.Controls.Add(this.labelMemoriesOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MemoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The memories searcher";
            this.Load += new System.EventHandler(this.MemoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverForm)).EndInit();
            this.groupBoxMemoriesDate.ResumeLayout(false);
            this.groupBoxMemoriesDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstDate;
        private System.Windows.Forms.Label lableEndDate;
        private System.Windows.Forms.CheckBox checkBoxOneDay;
        private System.Windows.Forms.Button buttonFetchMemories;
        private System.Windows.Forms.PictureBox pictureBoxCoverForm;
        private System.Windows.Forms.GroupBox groupBoxMemoriesDate;
        private System.Windows.Forms.Label labelMemoriesOptions;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.ListBox listBoxMemoriesList;
        private System.Windows.Forms.ListView listViewMemoriesPhotos;
        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
    }
}