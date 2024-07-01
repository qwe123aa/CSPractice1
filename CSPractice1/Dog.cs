using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Dog:Animal
    {
        public string Color;
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}
