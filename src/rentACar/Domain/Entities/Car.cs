﻿using Core.Persistence.Repositories;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car : Entity
    {
        public Car()
        {
            Rentals = new HashSet<Rental>();
            CarDamages = new HashSet<CarDamage>();

        }

        public Car(int id, int colorId,int cityId, int modelId, string plate, short modelYear, CarState carState, int findexScore) : this()
        {
            Id = id;
            CityId = cityId;
            ColorId = colorId;
            ModelId = modelId;
            Plate = plate;
            ModelYear = modelYear;
            CarState = carState;
            FindexScore = findexScore;
        }

        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public int CityId { get; set; }
        public string Plate { get; set; }
        public short ModelYear { get; set; }
        public int FindexScore { get; set; }
        public int Kilometer { get; set; }

        public CarState CarState { get; set; }
        public virtual Color Color { get; set; }
        public virtual Model Model { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual ICollection<CarDamage> CarDamages { get; set; }

    }
}
