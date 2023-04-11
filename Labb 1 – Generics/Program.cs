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
            boxes.Add(new Box(1, 75, 80)); //addar ett likadant objekt som i början för att se om addmetoden hittar felet.

            boxes.Remove(new Box(4, 45, 87));

            foreach (var box in boxes)
            {
                Console.WriteLine(box.height + " " + box.length + " " + box.width);
            }

            if (boxes.Contains(new Box(3, 77, 100)))
            {
                Console.WriteLine("lådan hittades");
            } 
            else
            {
                Console.WriteLine("lådan hittades inte");
            }

            

        }
    }
}