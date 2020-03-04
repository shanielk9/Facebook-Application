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
    public partial class FormFetchAlbums : Form
    {
        private const string k_ErrorMessage = "Error while fetching photos :(\nPlease try again later";
        private FacebookAppDataManager m_DataManager;
        private ImageList m_ListOfImages;
        private Album m_CurrentDisplayAlbum;

        public FormFetchAlbums(FacebookAppDataManager i_DataManager)
        {
            InitializeComponent();
            m_DataManager = i_DataManager;
            m_ListOfImages = new ImageList();
            m_ListOfImages.ImageSize = new Size(64, 64);
            m_ListOfImages.ColorDepth = ColorDepth.Depth32Bit;
            fetchAlbums();
        }

        private void FormFetchAlbums_Load(object sender, EventArgs e)
        {
            listViewPicturesFromAlbum.View = View.LargeIcon;
            listViewPicturesFromAlbum.Columns.Add("Photos:", 400);
        }

        private void fetchAlbums()
        {
            albumsBindingSource.DataSource = m_DataManager.LoggedInUser.Albums;
        }

        private void fetchPhotos(Album i_AlbumToFetch)
        {
            m_CurrentDisplayAlbum = i_AlbumToFetch;

            try
            {
                if (i_AlbumToFetch.Count > 0)
                {
                    displayPhotosOnScreen(i_AlbumToFetch.Photos);
                }
            }
            catch
            {
                listViewPicturesFromAlbum.Items.Add(string.Empty);
            }
        }

        private void displayPhotosOnScreen(FacebookObjectCollection<Photo> i_PhotosTiDispaly)
        {
            m_ListOfImages.Images.Clear();
            listViewPicturesFromAlbum.Items.Clear();

            foreach (Photo photo in i_PhotosTiDispaly)
            {
                m_ListOfImages.Images.Add(photo.ImageNormal);
            }

            listViewPicturesFromAlbum.LargeImageList = m_ListOfImages;

            for (int i = 0; i < m_ListOfImages.Images.Count; i++)
            {
                listViewPicturesFromAlbum.Items.Add(string.Empty, i);
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChooseFilter.SelectedIndex = -1;
            fetchPhotos(listBoxAlbums.SelectedItem as Album);
        }

        private void listViewPicturesFromAlbum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showPictureInBiggerForm();
        }

        private void showPictureInBiggerForm()
        {
            FormMemoryPicture memoryPictureForm = new FormMemoryPicture();
            var item = listViewPicturesFromAlbum.SelectedItems[0];
            Image selectedImage = listViewPicturesFromAlbum.SelectedItems[0].ImageList.Images[item.ImageIndex];

            memoryPictureForm.PictureBoxMemory.Image = selectedImage;
            memoryPictureForm.ShowDialog();
        }

        private void comboBoxChooseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxChooseFilter.SelectedIndex)
                {
                    case -1:
                    case 0:
                        displayPhotosOnScreen(FilterManager.Filter(m_CurrentDisplayAlbum, Photo => true));
                        break;
                    case 1:
                        displayPhotosOnScreen(FilterManager.Filter(m_CurrentDisplayAlbum, Photo => m_DataManager.LoggedInUser.PhotosTaggedIn.Contains(Photo)));
                        break;
                    case 2:
                        displayPhotosOnScreen(FilterManager.Filter(m_CurrentDisplayAlbum, Photo => Photo.Tags.Count > 0));
                        break;
                    case 3:
                        displayPhotosOnScreen(FilterManager.Filter(m_CurrentDisplayAlbum, Photo => Photo.LikedBy.Count > 0));
                        break;
                    case 4:
                        displayPhotosOnScreen(FilterManager.Filter(m_CurrentDisplayAlbum, Photo => Photo.Comments.Count > 0));
                        break;
                    default:
                        displayPhotosOnScreen(FilterManager.Filter(m_CurrentDisplayAlbum, Photo => true));
                        break;
                }
            }
            catch
            {
                MessageBox.Show(k_ErrorMessage);
            }
        }
    }
}
