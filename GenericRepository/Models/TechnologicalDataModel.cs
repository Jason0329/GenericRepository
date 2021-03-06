﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepository.Models
{
    public class TechnologicalDataModel
    {
        public int ID { get; set; }
        public int Company { get; set; }
        public DateTime Date { get; set; }
        public double OpenPrice { get; set; }
        public double HighestPrice { get; set; }
        public double LowestPrice { get; set; }
        public double ClosePrice { get; set; }
        public double ReturnOnInvestment { get; set; }
        public double Yield { get; set; }
        public double Volume { get; set; }
    }
}