using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.zad2
{
    internal interface IVehicle
    {
        int maxSpeed { get; set; }
        void start()
        { Console.WriteLine("start"); }
        void stop();
    }

    public class car : IVehicle
    {
        public int maxSpeed { get; set; }

        public void stop()
        {
            throw new Exception("text chamulec");
        }
        public void start()
        {
            throw new NotImplementedException();
        }
    }

    public class bike : IVehicle
    {
        public int maxSpeed { get; set; }

        public void stop()
        {
            throw new Exception("text chamulec");
        }
        public void start()
        {
            if (maxSpeed < 0)
                throw new NotImplementedException();
            else
                Console.WriteLine("Abc");
        }
    }

}
