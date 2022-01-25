using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Transition.Core.Common;
using Transition.Core.Domain;
using Transition.Entities.Enums.Lookups;

namespace Transition.Entities
{
public class Vehicle : BaseEntity
{
		public string VehicleRegistration { get; set; }
		public string Description { get; set; }
		public string RiskAssessment { get; set; }
}
}
