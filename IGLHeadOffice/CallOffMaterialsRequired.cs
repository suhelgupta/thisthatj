using System;
using System.Collections.Generic;
using System.Text;

namespace Transition.Entities.EntityClasses.IGLHeadOffice
{
    public class CallOffMaterialsRequired
    {
        [Parent]
        public virtual IGL_Project Project { get; set; }
        public long ProjectID { get; set; }
    }
}
