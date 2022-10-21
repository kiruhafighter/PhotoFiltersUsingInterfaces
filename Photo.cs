using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            Photo photo = new Photo();
            Console.WriteLine("Photo loaded");
            return photo;
        }

        public void Save()
        {
            Console.WriteLine("Photo saved");
        }
    }
}
