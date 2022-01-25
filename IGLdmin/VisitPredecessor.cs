using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class VisitPredecessor : BaseEntity
{
		[Parent]
		public virtual Visit Visit { get; set; }
		public long VisitID { get; set; }
		public virtual Visit PredecessorVisit { get; set; }
		public long PredecessorVisitID { get; set; }
}
}
