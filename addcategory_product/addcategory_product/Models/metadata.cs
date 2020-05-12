using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using addcategory_product.viewmodels;
namespace addcategory_product.Models
{

    [MetadataType(typeof(categoryviewmodel))]
    public partial class tbl_category
    {
    }

    [MetadataType(typeof(productviewmodel))]
    public partial class product
    {
    }
}