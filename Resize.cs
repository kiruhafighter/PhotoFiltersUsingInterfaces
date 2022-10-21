using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    public class Resize : IFilterable
    {
        public void Filter(Photo photo)
        {
            Console.WriteLine("Photo resized");
        }
    }
}
