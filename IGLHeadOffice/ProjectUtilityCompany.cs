using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class ProjectUtilityCompany : BaseEntity
{
		[Parent]
		public virtual IGL_Project Project { get; set; }
		public long ProjectID { get; set; }
		public virtual UtilityCompany UtilityCompany { get; set; }
		public long UtilityCompanyID { get; set; }
}
}
