using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethod
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplepartialMethod Invoked");
        }
        public void PublicMethod()
        {
            Console.WriteLine("Public method invoked");
            //SamplePartialMethod();
            Console.ReadKey();
        }
    }
}
