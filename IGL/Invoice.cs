using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
// Should there be a link to the utility company?
public class Invoice : BaseEntity
{
		public virtual CallOff CallOff { get; set; }
		public long CallOffID { get; set; }
		[LookupGroup(typeof(IGLUtilityType))]
		public virtual Lookup UtilityType { get; set; }
		public long UtilityTypeLID { get; set; }
		public decimal Amount { get; set; }
		[LookupGroup(typeof(IGLInvoiceStatus))]
		public virtual Lookup InvoiceStatus { get; set; }
		public long InvoiceStatusLID { get; set; }
		public string InvoiceNumber { get; set; }
}
}
