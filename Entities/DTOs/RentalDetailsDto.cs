﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailsDto:IDto
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }      
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
