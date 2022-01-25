using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
//Should this link to materials table??
public class ProjectMaterialsRequired : BaseEntity
{
		[Parent]
		public virtual IGL_Project Project { get; set; }
		public long ProjectID { get; set; }
		public string Description { get; set; }
		//Better name quantity??
		public decimal Length { get; set; }
}
}
