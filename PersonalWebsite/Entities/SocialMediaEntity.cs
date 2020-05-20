using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Entities
{
    public class SocialMediaEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}
