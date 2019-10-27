//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLCONSOLEAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Details
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
        public Order_Details()
        {
                
        }
       
        public Order_Details(int _Oid, int _Pid, decimal _uniteprice, short _quantity, float _discount)
        {
            OrderID = _Oid;
            ProductID = _Pid;
            UnitPrice = _uniteprice;
            Quantity = _quantity;
            Discount = _discount;
            List<Products> ProductList = new List<Products>();
        }
    }
}
