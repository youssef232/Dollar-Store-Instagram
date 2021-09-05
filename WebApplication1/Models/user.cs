namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [Required]
        [Display(Name = "first name")]
        [StringLength(50)]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "last name")]
        [StringLength(50)]
        public string lastName { get; set; }

        [Key]
        [StringLength(50)]

        public string username { get; set; }

        public int phone { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        
        public string password { get; set; }
        [NotMapped]
        [Required]
        [StringLength(50)]
        [Display(Name ="confirm password")]
        public string confirmPassword { get; set; }

        [Column(TypeName = "date")]
        [Display(Name ="date of birth")]
        public DateTime dataOfBirth { get; set; }
    }
}
