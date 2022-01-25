using System;
using System.Collections.Generic;
using System.Text;

namespace Transition.Entities
{
    public class ExampleM2MExampleM2MChild : BaseEntity
    {
        public long ExampleM2MID { get; set; }
        public virtual ExampleM2M ExampleM2M { get; set; }



        public long ExampleM2MChildID { get; set; }
        public virtual ExampleM2MChild ExampleM2MChild { get; set; }
    }
}
