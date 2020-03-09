using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScholarshipHub.Models
{
    public class Offer
    {
        public OrganizationOffer organizationOffer { get; set; }
        public UniversityOffer universityOffer { get; set; }
        
    }
}