using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
    public class IGL_Project : BaseEntity
    {
        // String?
        public long ProjectNumber { get; set; }
        public virtual Developer Developer { get; set; }
        public long DeveloperID { get; set; }
        public virtual Address SiteAddress { get; set; }
        public string WaterDesign { get; set; }
        public DateTime DateCreated { get; set; }
        public long Plots { get; set; }
        public long Visits { get; set; }

        public virtual ICollection<ProjectMaterialsRequired> Materials { get; set; }
        public virtual ICollection<ProjectOffSite> OffSites { get; set; }
        public virtual ICollection<ProjectUtilityCompany> UtilityCompanies { get; set; }

    }
}
