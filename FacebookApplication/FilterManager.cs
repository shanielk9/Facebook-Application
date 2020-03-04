using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public static class FilterManager
    {
        public static FacebookObjectCollection<Photo> Filter(Album i_PhotosToFilter, Func<Photo, bool> i_FilterMethod)
        {
            FacebookObjectCollection<Photo> ListOfFilteredPhotos = new FacebookObjectCollection<Photo>();
            try
            {
                foreach (Photo photo in i_PhotosToFilter.Photos)
                {
                    if (i_FilterMethod.Invoke(photo))
                    {
                        ListOfFilteredPhotos.Add(photo);
                    }
                }
            }
            catch
            {
                throw;
            }

            return ListOfFilteredPhotos;
        }
    }
}
