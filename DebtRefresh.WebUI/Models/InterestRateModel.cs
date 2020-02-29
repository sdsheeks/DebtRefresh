﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtRefresh.WebUI.Interfaces;

namespace DebtRefresh.WebUI.Models
{
    public class InterestRateModel
    {
        public float InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
