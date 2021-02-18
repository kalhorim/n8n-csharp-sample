using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp.Models
{
    public class WfResponse<T> 
    {
        public Headers headers { get; set; }
        public T body { get; set; }
    }
}
