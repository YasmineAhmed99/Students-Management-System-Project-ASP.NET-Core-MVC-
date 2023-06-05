
#nullable disable
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace StudentsSystem.Models
{

    public partial class Students
    {
        public int Id { get; set; }

        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter a valid name, Alphabets only")]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
      
        public bool? IsEnrolled { get; set; }
    }


   

}