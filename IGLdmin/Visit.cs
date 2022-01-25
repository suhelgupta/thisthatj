using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
// Link to utility co? 
public class Visit : BaseEntity
{
		[LookupGroup(typeof(IGLCallOffType))]
		public virtual Lookup CallOffType { get; set; }
		public long CallOffTypeLID { get; set; }
		[LookupGroup(typeof(IGLUtilityType))]
		public virtual Lookup UtilityType { get; set; }
		public long UtilityTypeLID { get; set; }
		public string VisitName { get; set; }
		public virtual Workflow StartWorkflow { get; set; }
		public long? StartWorkflowID { get; set; }
		public virtual Workflow CompletionWorkflow { get; set; }
		public long? CompletionWorkflowID { get; set; }

		[InverseProperty(nameof(VisitPredecessor.PredecessorVisit))]
		public virtual ICollection<VisitPredecessor> Predecessors { get; set; }

		public virtual ICollection<VisitQualification> RequiredQualifications { get; set; }

		public virtual ICollection<VisitForm> Forms { get; set; }

		public virtual ICollection<VisitRiskAssessment> RiskAssessments { get; set; }

		public virtual ICollection<VisitUtility> Utilities { get; set; }
}
}
