using System;
using Practice1.Interfaces;

namespace Practice1.Service
{
    public class Car:IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Hello I am car and I move ");
        }
        
        public void Start()
        {
            Console.WriteLine("Hello I am car and I move ");
        }
    }
}