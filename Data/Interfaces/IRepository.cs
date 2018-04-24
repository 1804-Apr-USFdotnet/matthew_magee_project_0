using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> Search(string searchString);

        string Details(string restaurant);

        string Reviews(string restaurant);

        string TopThreeRestaurants();

    }
}
