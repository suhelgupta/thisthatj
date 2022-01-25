using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class GangMemberQualification : BaseEntity
{
		public virtual Qualification Qualification { get; set; }
		public long QualificationID { get; set; }
		[Parent]
		public virtual GangMember GangMember { get; set; }
		public long GangMemberID { get; set; }
}
}
