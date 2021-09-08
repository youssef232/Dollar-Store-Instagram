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
        [Required(ErrorMessage ="*")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        
        public string firstName { get; set; }

        [Required(ErrorMessage ="*")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string lastName { get; set; }

        [Key]
        [StringLength(50)]
        [Display(Name = "Username")]

        public string username { get; set; }
        [Display(Name = "Phone")]

        public int phone { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Email")]
        [RegularExpression(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$", ErrorMessage ="invailid email")]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        
        public string password { get; set; }
        [NotMapped]
        [Required]
        [StringLength(50)]
        [Compare("password", ErrorMessage ="password don't match")]
        [Display(Name ="Confirm Password")]
        public string confirmPassword { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name ="Date of Birth")]
        public DateTime dateOfBirth { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Profile Picture")]
        public string userPhoto { get; set; }
    }
}
