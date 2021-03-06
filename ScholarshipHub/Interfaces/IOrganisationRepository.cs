﻿using ScholarshipHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipHub.Interfaces
{
    interface IOrganisationRepository:IRepository<Organisation>
    {
        Organisation GetOrganisation(string username);
        void UpdatePersonal(Organisation organisation);

    }
}
