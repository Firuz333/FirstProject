using System;
using Practice1.Interfaces;

namespace Practice1.Service
{
    public class Human:IMoveable
    {
        public void Move()
        {
            Console.WriteLine("I am Moving");
        }
        
        
        public void Eat()
        {
            Console.WriteLine("I am Eat");
        }
        
        

    }
}