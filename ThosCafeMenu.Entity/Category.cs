using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThosCafeMenu.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public int PARENTCATEGORYID { get; set; }
        
        [Required]
        public string CATEGORYNAME { get; set; } = String.Empty;
        public bool ISDELETED { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEUSERID { get; set; } = String.Empty;

    }
}
