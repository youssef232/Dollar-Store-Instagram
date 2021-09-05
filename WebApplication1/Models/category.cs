namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("category")]
    public partial class category
    {
        public int categoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string categoryName { get; set; }

        [Required]
        public string categoryAbout { get; set; }
    }
}
