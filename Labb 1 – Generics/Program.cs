using System.Runtime.CompilerServices;

namespace Labb_1___Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BoxCollection boxes = new BoxCollection();
            boxes.Add(new Box(1, 75, 80));
            boxes.Add(new Box(2, 53, 33));
            boxes.Add(new Box(3, 77, 100));
            boxes.Add(new Box(4, 45, 87));


            boxes.Add(new Box(1, 75, 80)); //adds a copy of a object to check if an object already exists
            boxes.Add(new Box(80, 1, 75)); //adds a object that has the same volume as another


            boxes.Remove(new Box(4, 45, 87)); // To remove from collection


            Display(boxes); //Foreach every object in collection


            if (boxes.Contains(new Box(3, 77, 100)))
            {
                Console.WriteLine($"The box was found");
            }
            else
            {
                Console.WriteLine("The box was not found");
            }

        }

        public static void Display(BoxCollection boxes)
        {
            foreach (var box in boxes)
            {
                Console.WriteLine(box.height + " " + box.length + " " + box.width);
            }
        }


    }
}