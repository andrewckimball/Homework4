using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework4.Models
{
    //Model for submitting restaurant recommendations
    public class RestaurantSubmit
    {
        public string InputName { get; set; }

        public string InputRestaurantName { get; set; }

        public string InputFavDish { get; set; }

        //Setting up contstraints for the phone number input
        [RegularExpression(@"^\(?([0-9]{3})\)?[- ]([0-9]{3})[-]([0-9]{4})$", ErrorMessage = "Please input a valid phone number (i.e. (xxx) xxx-xxxx)")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string InputPhone { get; set; }

    }
}

