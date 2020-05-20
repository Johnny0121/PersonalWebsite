using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Entities.WorkExperience
{
    public class WorkExperienceEntity : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Organisation { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
