using lab5.myClass;
using Lab5.zad_przy;
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

            myClassHelper.screate(5);
            car mycar= new car();
            try

            {
                mycar.start();
                mycar.stop();

            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
