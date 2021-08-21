using System;
using System.Collections.Generic;
using Practice1.Interfaces;
using Practice1.Service;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<IMoveable>();
            
            IMoveable person = new Human();
            IMoveable car = new Car();
            list.Add(person);
            list.Add(car);

            foreach (var obj in list)
            {
                obj.Move();
            }
            
        }
    }
}
