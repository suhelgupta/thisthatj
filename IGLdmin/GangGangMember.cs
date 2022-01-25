using System;
using System.Collections.Generic;
using System.Text;

namespace Transition.Entities
{
    public class GangGangMember: BaseEntity
    {
		//[Parent]
		public virtual Gang Gang { get; set; }
		public long GangID { get; set; }
		public virtual GangMember GangMember { get; set; }
		public long GangMemberID { get; set; }

	}
}
