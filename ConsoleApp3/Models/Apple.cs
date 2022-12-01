using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Apple:Fruit
    {
       //int VitaminA;
        public int VitaminA { get; set; }

        public override void Smell()
        {
            Console.WriteLine("Smell like an apple");
        }
    }
}
