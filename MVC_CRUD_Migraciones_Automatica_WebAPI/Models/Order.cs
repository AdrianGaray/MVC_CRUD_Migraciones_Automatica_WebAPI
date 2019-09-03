using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica_WebAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime DateOrder { get; set; }
        public int CustomerID { get; set; }
        public OrderStatus OrderStatus { get; set; }

        // por tener propiedades virtuales, se pone JsonIgnore, porque de esta manera se puede serializar. Si no tira error
        [JsonIgnore]
        public virtual Customer Customer { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}