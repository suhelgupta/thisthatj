using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
    public class Gang : BaseEntity
    {
        public Gang()
        {
            Members = new List<GangGangMember>();
        }

        public string Reference { get; set; }
        public string Description { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public long VehicleID { get; set; }

        //[MultiSelect(MultiSelectType.MS_AssignUnassign)]
        public virtual ICollection<GangGangMember> Members { get; set; }

        [NotMapped]
        [MultiSelect(MultiSelectType.MS_AssignUnassign)]
        public virtual IEnumerable<GangMember> GangMemberMS => Members.Select(i => i.GangMember);

    }
}
