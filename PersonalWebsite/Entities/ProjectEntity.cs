using PersonalWebsite.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Entities
{
    public class ProjectEntity : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public ProjectType ProjectType { get; set; }
        public Guid ReferenceUid { get; set; }
    }
}
