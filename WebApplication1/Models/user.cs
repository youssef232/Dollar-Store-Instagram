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
        [StringLength(50)]
        [Display(Name ="First Name")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string lastName { get; set; }

        [Key]
        [StringLength(50)]
        [Display(Name ="Username")]
        public string username { get; set; }
        [Display(Name ="Phone Number")]
        public int phone { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Email")]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Passward")]
        public string password { get; set; }
        [NotMapped]
        [Display(Name = "confirm password")]
        [Compare("password", ErrorMessage = "password not match")]
        public string confirmPassword { get; set; }
        public DateTime dateOfBirth { get; set; }

        [Required]
        public string userPhoto { get; set; }
    }
}
