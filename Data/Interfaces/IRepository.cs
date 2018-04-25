using System.Collections.Generic;

namespace Library
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetAllByRating();

        IEnumerable<T> GetAllByName();

        IEnumerable<T> Search(string searchString);

        string Details (string restaurant);

        string Reviews(string restaurant);

        string TopThreeRestaurants();

    }
}
