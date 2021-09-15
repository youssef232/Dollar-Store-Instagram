namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("post")]
    public partial class post
    {
        [Required]
        [StringLength(50)]
        public string writerUsername { get; set; }

        [Required]
        public string postContent { get; set; }

        public int postID { get; set; }

        [Required]
        [StringLength(50)]
        public string categoryName { get; set; }

        public string photo { get; set; }
        public DateTime date {  get; set; }

        public virtual category category { get; set; }
    }
}
