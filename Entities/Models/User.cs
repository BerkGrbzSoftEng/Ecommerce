using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class User:IEntity
    {
    
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string MobilePhone { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(32)]
        public string  PasswordHash { get; set; }
        public DateTime RegisteredAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> LastLogin { get; set; }
        public Nullable<DateTime> LastLogout { get; set; }
        [StringLength(15)]
        public string Phone1 { get; set; }
        [StringLength(15)]
        public string Phone2 { get; set; }
        public byte[] ProfilePicture { get; set; }
        [StringLength(100)]
        public string ProfilePicturePath { get; set; }
        public Nullable<DateTime> BirthDate { get; set; }
        public bool Activated { get; set; }
        [StringLength(20)]
        public string VerificationCode { get; set; }
        [StringLength(50)]
        public string IPAddress { get; set; }
 
    }
}
