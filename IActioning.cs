using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    public interface IActioning
    {
        void Add(IFilterable filter);
        void Remove(IFilterable filter);
        IEnumerable<IFilterable> GetAll();
    }
}
