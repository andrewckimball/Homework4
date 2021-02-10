using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework4.Models
{
    //Model for the index.html page - showing the recommended restaurants for provo
    public class Restaurants
    {
        //Read only property - set when the object is built and does not change afterwards
        public Restaurants(int ranking)
        {
            Rank = ranking;
        }

        //Setting attributes
        public int Rank { get; }  //removing setter
        public string Name { get; set; }
        public string FavDish { get; set; } 
        public string Address { get; set; }
        public string Phone { get; set; }
        public string WebLink { get; set; } = "Coming soon";

        public static Restaurants[] GetRestaurants()
        {
            //Setting up the model and passing in the 'int ranking'
            Restaurants r1 = new Restaurants(1)
            {
                Name = "El Mexsal",
                FavDish = "Popusa",
                Address = "35 S 200 W, Provo, UT 84601",
                Phone = "(801) 812-3848",
                WebLink = "http://www.elmexsalrestaurant.com/"
            };

            Restaurants r2 = new Restaurants(2)
            {
                Name = "Cubby's",
                FavDish = "Pork Sandwich",
                Address = "1258 N State St, Provo, UT 84604",
                Phone = "(801) 919-3023",
                WebLink = "https://cubbys.co/"
            };

            Restaurants r3 = new Restaurants(3)
            {
                Name = "Pho Plus",
                FavDish = "Banh Mi",
                Address = "68 W Center St, Provo, UT 84601",
                Phone = "(801) 377-8808"
                //missing weblink - model handles this on line 22 above
            };

            Restaurants r4 = new Restaurants(4)
            {
                Name = "Tommy's Burgers",
                FavDish = "Pastrami Burger",
                Address = "401 W 100 N, Provo, UT 84601",
                Phone = "(801) 374-9733"
                //missing weblink - model handles this on line 22 above

            };

            Restaurants r5 = new Restaurants(5)
            {
                Name = "Don Joaquin Street Tacos",
                FavDish = null, //this null is handled in the controller
                Address = "150 W 1230 N St, Provo, UT 84604",
                Phone = "(801) 400-2894",
                WebLink = "https://stdonjoaquin.com/"
            };

            //Returning info to the array
            return new Restaurants[] { r1, r2, r3, r4, r5 };
        }

    }
}