using System;

namespace PublicAccessorsInternal_ProtectedClassLibrary
{
    public class PubAccIntProClass
    {
       protected internal int ID = 101;
    }
    public class PubAccIntProClass2
    {
        public void SampleMethod()
        {
            PubAccIntProClass Instance1 = new PubAccIntProClass();
            Console.WriteLine(Instance1.ID);

        }
    }
}
