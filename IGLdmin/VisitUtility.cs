using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class VisitUtility : BaseEntity
{
		[Parent]
		public virtual Visit Visit { get; set; }
		public long VisitID { get; set; }
		[LookupGroup(typeof(IGLUtilityType))]
		public virtual Lookup UtilityType { get; set; }
		public long UtilityTypeLID { get; set; }
}
}
