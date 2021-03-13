using System;
using System.Globalization;

namespace Task8
{
    public class Reader
    {
        public static CultureInfo ReadCulture()
        {
            
            
            Console.WriteLine("Choose language: ru-Russian, en-English, fr-French and etc.");
            CultureInfo culture;
            Console.WriteLine("Enter culture:");
            while (true)
            {
                string inputCulture = Console.ReadLine();
                try
                {
                    culture = CultureInfo.CreateSpecificCulture(inputCulture);
                    return culture;
                }
                catch (CultureNotFoundException)
                {
                    Console.WriteLine("Wrong format, enter the correct cultute.");
                }
            }
        }
        static void Main(string[] args)
        {
            CultureInfo culture = ReadCulture();
            DateTime someDate = new DateTime();
            for (int index = 0; index < 12; index++)
            {
                Console.WriteLine(someDate.AddMonths(index).ToString("MMMM", culture));
            }
        }
    

    
    }


}




