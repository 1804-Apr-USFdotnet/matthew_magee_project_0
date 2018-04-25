using Library.Helpers;
using NLog;

namespace RestaurantProject0
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            var user = new RestaurantController();
            user.InitialStartup();
        }
    }
}
