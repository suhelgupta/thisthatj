using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class UtilityCompanyExcludedVisitType : BaseEntity
{
		[Parent]
		public virtual UtilityCompany UtilityCompany { get; set; }
		public long UtilityCompanyID { get; set; }
		[LookupGroup(typeof(IGLVisitType))]
		public virtual Lookup VisitType { get; set; }
		public long VisitTypeLID { get; set; }
		public string Description { get; set; }
}
}
