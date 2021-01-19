using System;

namespace Hokemon_steps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon!");

            Hokemon hoke01 = new Hokemon();

            hoke01.get_details();

            Hokemon hoke02 = new Hokemon();

            hoke02.get_details();

            hoke01.about(); // Invoking the about method for hoke01
            hoke02.about(); // Invoking the about method for hoke02

            Halor halorHoke01 = new Halor();  // INHERITED Halor-Hokemon
            halorHoke01.get_details();


        }
    }
}
