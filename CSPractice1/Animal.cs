using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Animal
    {
        public int Age;

        public Animal() { } 

        public void Eat()
        {
            Console.WriteLine("먹는다");
        }
        public void Sleep() { Console.WriteLine("잔다"); }

        internal Dog Bark()
        {
            throw new NotImplementedException();
        }
    }
}
