using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    public class DeleteRedEyesEffect : IFilterable
    {
        public void Filter(Photo photo)
        {
            Console.WriteLine("Red eyes effect deleted from photo");
        }
    }
}
