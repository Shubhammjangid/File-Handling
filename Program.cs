using System;
using System.IO;

namespace FileHandling{
    internal class Program
    {

        static string Path = @"C:\\Users\\harsh jangid\\Desktop\\.Net\\File\\Example.txt";
        static void Main(string[] args)
        {
          
         int x, y, z;
            Console.WriteLine("Enter number 1 ?");
            x  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 ?");
            y = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (y % 2 > 0)
                {
                    // File.Create(Path);
                    TextWriter tw = new StreamWriter(Path);
                    tw.WriteLine("divisor cannot be odd number");
                    tw.Close();
                }
                z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception one)
            {
                Console.WriteLine(one.Message);
            }
            Console.WriteLine("End of the program");
         
          
        }
    }
}
       
 