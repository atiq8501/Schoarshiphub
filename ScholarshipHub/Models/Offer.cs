using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScholarshipHub.Models
{
    public class Offer
    {
        public List<OrganizationOffer> organizationOffer = new List<OrganizationOffer>();
        public List<UniversityOffer> universityOffer = new List<UniversityOffer>();
        
    }
}