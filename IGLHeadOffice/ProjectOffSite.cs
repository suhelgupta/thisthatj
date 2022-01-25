using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
    //What is this??
    public class ProjectOffSite : BaseEntity
    {
        public string Name { get; set; }
        public long Quantity { get; set; }
        public string HighwaysInformation { get; set; }
        [Parent]
        public virtual IGL_Project Project { get; set; }
        public long ProjectID { get; set; }
    }
}
