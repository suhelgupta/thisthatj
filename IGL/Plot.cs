using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class Plot : BaseEntity
{
		public virtual CallOff CallOff { get; set; }
		public long CallOffID { get; set; }
		public string PlotNumberFrom { get; set; }
		public string? PlotNumberTo { get; set; }
}
}
