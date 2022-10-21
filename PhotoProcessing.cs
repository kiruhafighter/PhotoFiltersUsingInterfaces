using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    public class PhotoProcessing
    {
        public void Start(string path , FilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            
            foreach(IFilterable filter in filterHandler.GetAll())
            {
                filter.Filter(photo);
            }
            photo.Save();
        }
    }
}
