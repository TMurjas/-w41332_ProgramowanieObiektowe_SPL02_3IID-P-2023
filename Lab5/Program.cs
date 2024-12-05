using lab5.myClass;
using Lab5.zad2;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<shape> myShape = new List<shape>();

            myShape.Add(new circle(1));
            myShape.Add(new triangle(1));
            myShape.Add(new rectangle(1));

            foreach (var item in myShape)
            {
                item.CalulateArea();
            }

            MyClass AAA= new MyClass();

            AAA.ToShortDateString();



        }
    }
}
