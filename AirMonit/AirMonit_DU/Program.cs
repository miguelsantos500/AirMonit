using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AirMonit_DU
{
    class Program
    {
        static void Main(string[] args)
        {
            AirSensorNodeDll.AirSensorNodeDll  dll= new AirSensorNodeDll.AirSensorNodeDll();
            dll.Initialize(Anymethod, 2000);

        }

        private static void Anymethod(string message)
        {
            string[] words = message.Split(';');

            foreach (string str in words)
                Console.WriteLine(str);
        }
    }
}
