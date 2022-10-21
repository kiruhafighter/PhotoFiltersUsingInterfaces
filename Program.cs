using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFiltersUsingInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilterHandler filterHandler = new FilterHandler();
            var resize = new Resize();
            filterHandler.Add(resize);
            filterHandler.Add(new BlackAndWhiteFilter());
            filterHandler.Add(new DeleteRedEyesEffect());
            filterHandler.Remove(resize);
            var photoProcessing = new PhotoProcessing();
            photoProcessing.Start("path", filterHandler);

        }
    }
}
