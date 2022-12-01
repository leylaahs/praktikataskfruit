using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal abstract class Fruit
    {
        public int Water { get; set; }
        public string Taste { get; set; }
        public abstract void Smell();
       
       
    }
    
}
