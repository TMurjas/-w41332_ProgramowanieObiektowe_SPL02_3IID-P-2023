using lab3.myClass;
namespace lab3

{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<shape> myShape=new List<shape>();

            myShape.Add(new circle(1));
            myShape.Add(new triangle(1));
            myShape.Add(new rectangle(1));

            foreach (var item in myShape)
            {
                item.Draw();
            }


           
        }
    }
}
