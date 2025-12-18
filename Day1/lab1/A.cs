using System;
//Given the radius of a circle, calculate the area using: Area = π × r × r


namespace Area
{
    public class A
    {
        public float Radius { get; set;}
        public void Print()
        {
            float a=Convert.ToSingle(Console.ReadLine());
            Radius=a;
            const float pi=3.14f;
            Console.WriteLine(a*pi*a);

        }

    }
}