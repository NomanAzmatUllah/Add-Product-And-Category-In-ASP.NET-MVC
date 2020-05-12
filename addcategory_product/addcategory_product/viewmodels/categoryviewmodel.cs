using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace addcategory_product.viewmodels
{
    public class categoryviewmodel
    {

        public int cat_id { get; set; }

        [Required(ErrorMessage ="Required")]
        public string cat_name { get; set; }
    }
}