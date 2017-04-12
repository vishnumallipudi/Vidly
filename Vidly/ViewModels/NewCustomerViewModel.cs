using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        //this view model is used for passing a data to the view
        //this view model is used to combine more data from different classes
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        //if you want to add some more properties other than the existing properties for a new customer add here
    }
}