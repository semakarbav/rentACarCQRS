﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.ExternalServices
{
    public class FakePosService
    {
        public bool GetPayment(string cardHolder,string cardNo,string Date,string cVV)
        {
            if(cardNo.Length == 16 && cVV.Length == 3)
            {
                return true;
            }

            return false;
        }
    }
}
