using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPlan.Models.Models
{
    public class Developer
    {
        public int Id { get; set; }


        [Required]
        [StringLength(23, MinimumLength = 3)]
        public string Given { get; set; }

        [Required]
        [StringLength(23, MinimumLength = 3)]
        public string Family { get; set; }

        [Required]
        [StringLength(23, MinimumLength = 3)]
        public string GraduationTerm { get; set; }

        [Required]
        [StringLength(23, MinimumLength = 3)]
        public string DesiredPosition { get; set; }

        [Required]
        [StringLength(23, MinimumLength = 3)]
        public string Skills { get; set; }

        public int Rating { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

    }
}
