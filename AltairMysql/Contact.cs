using System;
using System.ComponentModel.DataAnnotations;

namespace DemoDbMulti.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [EmailAddress, MaxLength(150)]
        public string? EmailAddress { get; set; }

        [Phone, MaxLength(20)]
        public string? PhoneNumber { get; set; }
    }
}
