using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Orange:Fruit
    {
        
        public int VitaminC { get; set; }

        public override void Smell()
        {
            Console.WriteLine("Smell like an orange");
        }
    }

}
