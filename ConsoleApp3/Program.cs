using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Apple { Taste = "sweet", Water = 20, VitaminA = 40 };
            Fruit banana = new Banana { Taste = "semi-sweet", Water = 20, VitaminB = 20 };
            Fruit orange= new Orange{ Taste = "sour", Water = 20, VitaminC = 140 };


            Fruit[] fruits = new Fruit[]{apple,banana,orange };
            //Fruit[] fruits1 = { apple, banana, orange };

            foreach(var fruit in fruits)
            {
                Console.WriteLine($"Taste:{fruit.Taste}\n Fruit kind{fruit.GetType()}\n");
            }  




        }
    }
}