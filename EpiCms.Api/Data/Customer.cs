using System;
using System.ComponentModel.DataAnnotations;

namespace EpiCms.Api.Data
{
    public class Customer
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public DateTime? InActivatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Customer()
        {
            Id = Guid.NewGuid();
            IsActive = true;
            CreatedDate = DateTime.UtcNow;
        }

    }
}
