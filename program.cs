using System;

namespace Steam_Key_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#######################################");
            Console.WriteLine("#                                     #");
            Console.WriteLine("#    Steam Key Generator by Berikai   #");
            Console.WriteLine("#                                     #");
            Console.WriteLine("#######################################");
            inputF();
        }

        static void inputF() {
            Console.WriteLine("");
            Console.Write("Please type the amount of key to be generated: ");
            try
            {
                double amount = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Keys:");
                for (int i = 0; i < amount; i++) {
                    Console.WriteLine(keyGenerator());
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("Error...:" + e.Message + " Please type a number.");
                inputF();
            }
        }

        static String keyGenerator() {
            String theKey = "";
            for (int i = 0; i < 5; i++) {
                theKey += charGenerator();
            }
            theKey += "-";
            for (int i = 0; i < 5; i++)
            {
                theKey += charGenerator();
            }
            theKey += "-";
            for (int i = 0; i < 5; i++)
            {
                theKey += charGenerator();
            }
            return theKey;
        }

        static char charGenerator() {
            String map = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random rand = new Random();
            int num = rand.Next(0, map.Length - 1);
            return map[num];
        }
    }
}
