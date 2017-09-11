using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using VideoApp.Models;
        
namespace VideoApp.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribrdToNewsletter { get; set; }
        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }


        public DateTime? BirthDay { get; set; }
    }
}