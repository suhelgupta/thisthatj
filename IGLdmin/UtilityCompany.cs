using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
    public class UtilityCompany : BaseEntity
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public string ContactName { get; set; }
        // Is this the right type??
        public string ContactPhoneNumber { get; set; }
        public virtual Address Address { get; set; }
        public long? AddressID { get; set; }
        public string UtilityCode { get; set; }
        [LookupGroup(typeof(IGLUtilityType))]
        public virtual Lookup UtilityType { get; set; }
        public long UtilityTypeLID { get; set; }

        public virtual ICollection<UtilityCompanyExcludedVisitType> ExcludedVisitTypes { get; set; }
    }
}
