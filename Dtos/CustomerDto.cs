using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;
namespace Vidly2.Dtos
{
    public class CustomerDto
    {
     
            [Required]
            [StringLength(100)]
            public string FirstName { get; set; }

            [Required]
            [StringLength(100)]
            public string LastName { get; set; }

        public int CustomerId { get; set; }

        public bool IsSubscribedNewsLetter { get; set; }

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