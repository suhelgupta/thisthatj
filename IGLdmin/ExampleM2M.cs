using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Transition.Entities
{
    public class ExampleM2M : BaseEntity
    {
        public ExampleM2M()
        {
            ExampleM2MExampleM2MChild = new List<ExampleM2MExampleM2MChild>();
        }

        public string TestShortString { get; set; }



        public string TestInt { get; set; }



        public string TestShortInt { get; set; }



        public string TestPercent { get; set; }



        [MultiSelect(MultiSelectType.MS_AssignUnassign)]
        public virtual ICollection<ExampleM2MExampleM2MChild> ExampleM2MExampleM2MChild { get; set; }



        [NotMapped]
        public virtual IEnumerable<ExampleM2MChild> ExampleM2MChildMS => ExampleM2MExampleM2MChild.Select(i => i.ExampleM2MChild);


    }
}
