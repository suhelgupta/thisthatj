using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class GangMember : BaseEntity
{
		//public virtual Gang Gang { get; set; }
		//public long GangID { get; set; }
		public string FirstName { get; set; }
		public string Surname { get; set; }
		public string StaffNumber { get; set; }

		//public virtual ICollection<GangGangMember> GangGangMembers { get; set; }

		public virtual ICollection<GangMemberQualification> Qualifications { get; set; }
}
}
