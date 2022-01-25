using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class CallOffVisit : BaseEntity
{
		[Parent]
		public virtual CallOff CallOff { get; set; }
		public long CallOffID { get; set; }
		public virtual Visit Visit { get; set; }
		public long VisitID { get; set; }
		public virtual Gang Gang { get; set; }
		public long GangID { get; set; }
		public DateTime ScheduleDate { get; set; }
		public long Duration { get; set; }
}
}
