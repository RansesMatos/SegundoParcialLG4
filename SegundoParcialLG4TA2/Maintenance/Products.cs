﻿using SegundoParcialLG4TA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int  SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
