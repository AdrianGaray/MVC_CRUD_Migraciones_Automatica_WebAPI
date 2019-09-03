using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica_WebAPI.Models
{
    public class Category
    {
        [Key]
        public int CategotyID { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Category Description")]
        public string Description { get; set; }
    }
}