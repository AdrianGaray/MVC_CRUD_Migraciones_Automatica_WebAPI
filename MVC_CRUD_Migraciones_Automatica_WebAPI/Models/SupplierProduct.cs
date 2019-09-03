﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica_WebAPI.Models
{
    public class SupplierProduct
    {
        [Key]
        public int SupplierProductID { get; set; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Product Product { get; set; }
    }
}