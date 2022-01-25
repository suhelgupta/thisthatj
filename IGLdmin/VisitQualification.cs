using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class VisitQualification : BaseEntity
{
		[Parent]
		public virtual Visit Visit { get; set; }
		public long VisitID { get; set; }
		//Should there be link to qualification table?
		[LookupGroup(typeof(IGLQualification))]
		public virtual Lookup Qualification { get; set; }
		public long QualificationLID { get; set; }
}
}
