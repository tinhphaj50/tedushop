using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abtract
{
    public abstract class Auditable 
    {
       public DateTime? CreateDate { get; set; }
        [MaxLength(256)]
       public string CreateBy { get; set; }
       public DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
       public string UpdateBy { get; set; }
       public string MetaKeyWord { get; set; }
       public string MetaDescription { get; set; }
       public bool Status { get; set; }
    }
}