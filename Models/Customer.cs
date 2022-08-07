using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Vidly.Models
{
    [ValidateAntiForgeryToken]
    public class Customer
    {
        
        [Required]
        [StringLength(100)]
            public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public int CustomerId { get; set; }

        public bool IsSubscribedNewsLetter { get; set; }


        [Display(Name = "Membership Type")]
        public byte MembershipTypeIds { get; set; }

        [Min18YearsIfAMember]
        public DateTime Birthdate { get; set; }

        [Required]
        public short SignupFee { get; set; }

        [Required]
        public byte DurationInMonths { get; set; }

        [Required]
        public byte DiscountRate { get; set; }
    }
    }
 