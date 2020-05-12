using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace addcategory_product.viewmodels
{
    public class productviewmodel
    {
        public int pro_id { get; set; }

        [Required(ErrorMessage ="Required")]
        public string pro_name { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> c_date { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Mod_date { get; set; }
        [Required(ErrorMessage = "Required")]
        public string pro_description { get; set; }
        public string pro_image { get; set; }

        [Required(ErrorMessage = "Required")]
        public Nullable<int> quanitity { get; set; }

        [Required(ErrorMessage = "Required")]
        public Nullable<int> price { get; set; }

        [Display(Name ="Select Category")]
        public Nullable<int> fk_tbl_category { get; set; }
    }
}