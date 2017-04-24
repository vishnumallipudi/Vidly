using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class customerDto
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "PLease Enter Customers name")]
        [StringLength(255)]
        public String Name { get; set; }



        public bool IsSubscribedToNewsletter { get; set; }




        public MembershipTypeDto MembershipType { get; set; }


        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMember]
        
        public DateTime? Birthday { get; set; }
    }
}