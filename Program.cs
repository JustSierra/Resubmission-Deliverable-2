using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                Console.Write("What is the message?");

                var input = Console.ReadLine();

                var allCaps = input.ToUpper();

                string message = string.Empty;
                //string unicodeValue = string.Empty;
                var checksum = 0;

                foreach (char x in allCaps)
                {
                    message += ((int)x) - 64 + "-"; 
                    //unicodeValue += ((int)x);
                    checksum += ((int)x);

                }
                Console.WriteLine("Your encoded message is " + message);

                Console.WriteLine("Message checksum is " + checksum);


                Console.ReadLine();



            }



        }
    }
}

