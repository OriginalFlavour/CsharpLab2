using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string list = "she said her name Billie Jean";
            string[] reverse = list.Split(' ');
            
                for (int i = 5; i > 0; i--)
            {

                Console.WriteLine(reverse[i]);
            }


            Console.ReadKey();

      

            
        }
    }
}