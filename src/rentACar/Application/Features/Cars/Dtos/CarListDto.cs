﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Dtos
{
    public class CarListDto
    {
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string Plate { get; set; }
        public short ModelYear { get; set; }
    }
}
