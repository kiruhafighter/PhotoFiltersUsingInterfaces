using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    public interface IFilterable
    {
        void Filter(Photo photo);
    }
}
