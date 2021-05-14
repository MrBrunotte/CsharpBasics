using System;

namespace Properties
{
    public class Student
    {
        private int _Id;
        private string _Name;
        private int _PassMark = 35;

        public void SetId(int Id)
        {
            if (Id<=0)
            {
                throw new Exception("Id cannot be 0 or a negative number");
            }
            this._Id = Id;
        }
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty!");
            }
            this._Name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
        public int GetId()
        {
            return this._Id;
        }
        public int GetPassMark()
        {
            return this._PassMark;
        }
    }
    class Program
    {
        static void Main()
        {
            Student C1 = new Student();
            C1.SetId(101);
            C1.SetName("Stefan");
            

            Console.WriteLine($"ID = {C1.GetId()}\n" +
                              $"Name = {C1.GetName()}\n" +
                              $"PassMark = {C1.GetPassMark()}");
            Console.ReadKey();
        }
    }
}
