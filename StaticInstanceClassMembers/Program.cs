using System;

namespace StaticInstanceClassMembers
{  
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine($"Area: {Area1}");

            Circle C2 = new Circle(7);

           // C1.Print();
            Circle.Print();

            float Area2 = C2.CalculateArea();
            Console.WriteLine($"Area: {Area2}");

            Console.ReadKey();
        }
    }
    class Circle
    {
        static float _Pi;
        int _Radius;

        static Circle()
        {
            Circle._Pi = 3.141f;
        }

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public static void Print()
        {
            //
        }
        public float CalculateArea()
        {
            return _Pi * this._Radius * this._Radius;
        }

    }
}
