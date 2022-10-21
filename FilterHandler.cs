using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    public class FilterHandler : IActioning
    {
        private readonly IList<IFilterable> filterables;

        public FilterHandler()
        {
            filterables = new List<IFilterable>();
        }

        public void Add(IFilterable filter)
        {
            filterables.Add(filter);
        }

        public void Remove(IFilterable filter)
        {
            filterables.Remove(filter);
        }

        public IEnumerable<IFilterable> GetAll()
        {
            return filterables;
        }

    }
}
