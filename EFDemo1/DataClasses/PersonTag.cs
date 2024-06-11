using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1.DataClasses
{
    public class PersonTag
    {
        public int FK_PersonId { get; set; }
        public int FK_TagId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
