using System;

namespace Properties
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _PassMark = 35;

        // AUTOIMPLEMENTED PROPERTIES
        //private string _city;
        //private string _email;
        //private int _age 
        public string City { get; set; }
        public string Email { set; }
        public int Age { get; }

        public int Id  // 1
        {
            set // 2
            {
                if (value <= 0) // 4
                {
                    throw new Exception("Id cannot be 0 or a negative number");
                }
                this._id = value; // 4
            }
            get // 2
            {
                return this._id; // 5
            }
        }

        public string Name {
        set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty!");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }
        public int Passmark {
        get
            {
                return this._PassMark;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Student C1 = new Student();
            C1.Id = 101; // 3
            C1.Name = "Stefan";


            Console.WriteLine($"ID = {C1.Id}\n"); // 5
            Console.WriteLine($"Name = {C1.Name}\n");
            Console.WriteLine($"Passmark = {C1.Passmark}");
            Console.ReadKey();
        }
    }
}