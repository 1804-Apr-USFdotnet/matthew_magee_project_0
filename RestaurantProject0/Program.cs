using Library.Helpers;

namespace RestaurantProject0
{
    class Program
    {
        static void Main(string[] args)
        {

            RestaurantController user = new RestaurantController();
            user.InitialStartup();
        }
    }
}
