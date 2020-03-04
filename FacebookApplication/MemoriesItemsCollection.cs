using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class MemoriesItemsCollection : IEnumerable
    {
        private readonly ICollection<FacebookObjectWrapper> r_CollectionFacebookObject;
        
        public MemoriesItemsCollection(ICollection<FacebookObjectWrapper> i_CollectionFacebookObject)
        {
            r_CollectionFacebookObject = i_CollectionFacebookObject;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (FacebookObjectWrapper obj in r_CollectionFacebookObject)
            {
                yield return obj.ToString();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (from obj in r_CollectionFacebookObject select obj.ToString()).GetEnumerator();
        }
    }
}
