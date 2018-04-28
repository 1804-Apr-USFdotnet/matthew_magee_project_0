using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        string GetAllByRating();

        List<T> GetAllByName();

        T Search(string searchString);

        string Details(string restaurant);

        string Reviews(string restaurant);

        string TopThreeRestaurants();

        void Update(int restaurantId, string name);

        void Delete(int restaurantId);

        void Insert(string name, string address, int zipcode, string phoneNumebr);

    }
}
