using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public partial class FormMemories : Form
    {
        private FacebookAppDataManager m_DataManager;
        private MemoriesSearch m_MemoriesSearch;
        private FormFacebookApplication m_FbAppFormToReturn;

        public FormMemories(FacebookAppDataManager i_DataManager, FormFacebookApplication i_FbAppFormToReturn)
        {
            InitializeComponent();
            m_DataManager = i_DataManager;
            m_MemoriesSearch = new MemoriesSearch();
            m_FbAppFormToReturn = i_FbAppFormToReturn;
        }

        private void MemoriesForm_Load(object sender, EventArgs e)
        {
            listViewMemoriesPhotos.View = View.LargeIcon;
            listViewMemoriesPhotos.Columns.Add("Photos:", 400);
        }

        private void checkBoxOneDay_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxOneDay.Checked)
            {
                dateTimePickerEndDate.Enabled = true;
            }
            else
            {
                dateTimePickerEndDate.Enabled = false;
            }
        }

        private void checkedListBoxOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 1; i < checkedListBoxOptions.Items.Count; ++i)
                    {
                        checkedListBoxOptions.SetItemCheckState(i, CheckState.Indeterminate);
                    }
                }
                else
                {
                    for (int i = 1; i < checkedListBoxOptions.Items.Count; ++i)
                    {
                        checkedListBoxOptions.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }

        private bool checkIfMemoriesTypeSelected()
        {
            bool isSelected = false;

            if (checkedListBoxOptions.CheckedItems.Count > 0)
            {
                isSelected = true;
            }

            return isSelected;
        }

        private bool checkIfAllSettingMemoriesAreSelected()
        {
            bool isSelected = true;
            string msgError = string.Format("Please fix the following:\n");

            if (!dateTimePickerStartDate.Checked)
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please enter start date!\n");
            }

            if (checkBoxOneDay.CheckState == CheckState.Unchecked && !dateTimePickerEndDate.Checked)
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please enter end date,\nor select one day range\n");
            }

            if (!checkIfMemoriesTypeSelected())
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please Choose type of memory to fetch\n");
            }

            if (dateTimePickerEndDate.Value.Date < dateTimePickerStartDate.Value.Date)
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please Choose chronological time!\n");
            }

            if (!isSelected)
            {
                MessageBox.Show(msgError);
            }

            return isSelected;
        }

        private void buttonFetchMemories_Click(object sender, EventArgs e)
        {
            listBoxMemoriesList.Items.Clear();
            listViewMemoriesPhotos.Items.Clear();

            if (checkIfAllSettingMemoriesAreSelected())
            {
                List<int> choosenOption = getCheckedItemFromListBox(checkedListBoxOptions);
                foreach (int i in choosenOption)
                {
                    if (i != 0)
                    {
                        divideMemoriesByGroups(i);
                    }
                }
            }
        }

        private void addTitleToListBox(string i_Title)
        {
            listBoxMemoriesList.Items.Add(i_Title);
        }

        private void divideMemoriesByGroups(int i_IndexToShowInList)
        {
            FacebookObjectCollection<FacebookObjectWrapper> ItemsToShow = new FacebookObjectCollection<FacebookObjectWrapper>();
            List<Image> ListOfImagesToShow = new List<Image>();
            ImageList imagesListToListBox = new ImageList();
            imagesListToListBox.ImageSize = new Size(80, 80);
            bool isCheck = checkBoxOneDay.CheckState == CheckState.Checked;
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate;

            if (!isCheck)
            {
                endDate = dateTimePickerEndDate.Value.Date;
            }
            else
            {
                endDate = startDate;
            }

            ItemsToShow.Clear();
            ListOfImagesToShow.Clear();
            imagesListToListBox.Images.Clear();

            try
            {
                switch (i_IndexToShowInList)
                {
                    case 1: ////posts
                        addTitleToListBox("Posts:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfPosts(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_DataManager.UserPostsList);
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                    case 2: ////photos
                        ListOfImagesToShow = m_MemoriesSearch.GetMemoriesOfPhotos(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_DataManager.UserPhotos);
                        addPhotosToMemoriesListView(ListOfImagesToShow, imagesListToListBox);
                        break;
                    case 3: ////events
                        addTitleToListBox("Events:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfEvents(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_DataManager.UserEvents);
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                    case 4: ////friends
                        addTitleToListBox("Friends:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfFriends(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_DataManager.UserFriends);
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                    case 5: ////groups
                        addTitleToListBox("Groups:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfGroups(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_DataManager.UserGroups);
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                }
            }
            catch(Exception e)
            {
                addTitleToListBox(e.Message);
            }
        }

        private void addItemsToMemoriesList(FacebookObjectCollection<FacebookObjectWrapper> i_ItemsToAddToList)
        {
            MemoriesItemsCollection memoriesItemsCollection = new MemoriesItemsCollection(i_ItemsToAddToList);
            IEnumerator<string> iterator = memoriesItemsCollection.GetEnumerator();

            while(iterator.MoveNext())
            {
                listBoxMemoriesList.Items.Add(iterator.Current);
            }
        }

        private void addPhotosToMemoriesListView(List<Image> i_PhotosToAddList, ImageList i_ImageList)
        {
            foreach (Image image in i_PhotosToAddList)
            {
                i_ImageList.Images.Add(image);
            }

            listViewMemoriesPhotos.LargeImageList = i_ImageList;

            for (int i = 0; i < i_ImageList.Images.Count; i++)
            {
                listViewMemoriesPhotos.Items.Add(string.Empty, i);
            }
        }

        private List<int> getCheckedItemFromListBox(CheckedListBox i_BoxToCheck)
        {
            List<int> listToReturn = new List<int>();

            foreach (int item in i_BoxToCheck.CheckedIndices)
            {
                listToReturn.Add(item);
            }

            return listToReturn;
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            m_FbAppFormToReturn.Show();
        }

        private void listViewMemoriesPhotos_DoubleClick(object sender, MouseEventArgs e)
        {
            showPictureInBiggerForm();  
        }

        private void showPictureInBiggerForm()
        {
            FormMemoryPicture memoryPictureForm = new FormMemoryPicture();
            var item = listViewMemoriesPhotos.SelectedItems[0];
            Image selectedImage = listViewMemoriesPhotos.SelectedItems[0].ImageList.Images[item.ImageIndex];

            memoryPictureForm.PictureBoxMemory.Image = selectedImage;
            memoryPictureForm.ShowDialog();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEndDate.MinDate = dateTimePickerStartDate.Value.Date;
        }
    }
}
