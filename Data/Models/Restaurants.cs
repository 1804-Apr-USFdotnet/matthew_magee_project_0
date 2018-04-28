﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Restaurants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Address + " " + ZipCode + " " + PhoneNumber;
        }
        
    }
}
