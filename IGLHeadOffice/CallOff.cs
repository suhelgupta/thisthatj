using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class CallOff : BaseEntity
{
		public string CallOffNumber { get; set; }
		//Should be singular??
		public string Specifications { get; set; }
		[LookupGroup(typeof(IGLCallOffType))]
		public virtual Lookup CallOffType { get; set; }
		public long CallOffTypeLID { get; set; }
		//Should be LID or other link?
		public string RequestedBy { get; set; }
		public DateTime DateRequested { get; set; }
		public DateTime DateOfWorks { get; set; }
		[LookupGroup(typeof(IGLCallOffStatus))]
		public virtual Lookup Status { get; set; }
		public long StatusLID { get; set; }
		public virtual IGL_Project Project { get; set; }
		public long ProjectID { get; set; }
	
}
}
