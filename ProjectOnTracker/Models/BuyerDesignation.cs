﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOnTracker.Models
{
    public class BuyerDesignation
    {
       [Key] public int ID { get; set; }
        public string designation { get; set; }
    }
}