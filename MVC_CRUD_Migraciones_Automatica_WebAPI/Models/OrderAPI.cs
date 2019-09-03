using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica_WebAPI.Models
{
    // composicion de una orden
    // 
    public class OrderAPI
    {
        public int OrderID { get; set; }
        public DateTime DateOrder { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
    }
}