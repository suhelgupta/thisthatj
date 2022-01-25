using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class VisitForm : BaseEntity
{
		[Parent]
		public virtual Visit Visit { get; set; }
		public long VisitID { get; set; }
		//What is this linking to?
		public long FormID { get; set; }
}
}
