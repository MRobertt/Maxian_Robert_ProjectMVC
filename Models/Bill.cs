﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Maxian_Robert_ProjectMVC.Models
{
    public class Bill
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public decimal Total { get; set; }
        public decimal NumarFactura { get; set; }
        public Customer Customer { get; set; }

    }
}
