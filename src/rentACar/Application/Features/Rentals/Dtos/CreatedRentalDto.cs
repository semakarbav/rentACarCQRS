﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rentals.Dtos
{
    public class CreatedRentalDto
    {
        public int Id { get; set; }
        public string CarModelBrandName { get; set; }
        public string CarModelName { get; set; }
        public string CarColorName { get; set; }
        public short CarModelYear { get; set; }
        public string CarPlate { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerMail { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int RentedKilometer { get; set; }
        public int ReturnedKilometer { get; set; }
    }
}
