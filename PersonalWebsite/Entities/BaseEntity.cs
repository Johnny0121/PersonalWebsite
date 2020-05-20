using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Uid = Guid.NewGuid();

            DateTime _Now = DateTime.Now;
            CreatedTimestamp = _Now;
            AmendedTimestamp = _Now;
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public Guid Uid { get; set; }
        [Required]
        public DateTime CreatedTimestamp { get; set; }
        [Required]
        public DateTime AmendedTimestamp { get; set; }
    }
}
