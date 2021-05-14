using System;

namespace StaticAndInstanceClassMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine($"Area: {Area1}");
            
            Circle C2 = new Circle(5);
            float Area2 = C2.CalculateArea();
            Console.WriteLine($"Area: {Area2}");

            Console.ReadKey();
        }
    }
    class Circle
    {
        float _Pi = 3.141f;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return this._Pi * this._Radius * this._Radius;
        }
    }
}
