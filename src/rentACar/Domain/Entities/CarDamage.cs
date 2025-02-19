﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CarDamage:Entity
    {
        public int CarId { get; set; }
        public string DamageInfo { get; set; }
        public virtual Car Car { get; set; }
        public CarDamage()
        {
           
        }
        public CarDamage(int id,int carId, string damageInfo):this()
        {
            Id = id;
            CarId = carId;
            DamageInfo = damageInfo;
        }

      
    }
}
