using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        public string FullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
