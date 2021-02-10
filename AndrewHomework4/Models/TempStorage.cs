using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework4.Models
{
    public class TempStorage
    {
        //Stores the list in order to print it out in the 'Results' view
        private static List<RestaurantSubmit> applications = new List<RestaurantSubmit>();

        public static IEnumerable<RestaurantSubmit> Applications => applications;

        public static void AddApplication(RestaurantSubmit application)
        {
            applications.Add(application);
        }
    }
}
