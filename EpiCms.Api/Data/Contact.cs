using System;
using System.ComponentModel.DataAnnotations;

namespace EpiCms.Api.Data
{
    public class Contact
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime? InActivatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Contact()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            IsActive = true;
        }
    }
}
