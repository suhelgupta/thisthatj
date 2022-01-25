using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class Material : BaseEntity
{
		public string Description { get; set; }
		[LookupGroup(typeof(IGLUnit))]
		public virtual Lookup Unit { get; set; }
		public long UnitLID { get; set; }
		public decimal Quantity { get; set; }
}
}
