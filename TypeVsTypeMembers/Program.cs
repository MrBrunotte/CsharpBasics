using System;

namespace TypeVsTypeMembers
{
   public class Customer
    {
        #region Fields
        // three private fields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion

        #region Properties
        // three public properites
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Methods
        // one method
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        #endregion

        Customer C1 = new Customer();
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
