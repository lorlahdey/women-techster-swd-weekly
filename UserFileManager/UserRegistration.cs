using System;
using System.Collections.Generic;
// using QueueManagement;
// using UserFileManager;

namespace UserFileManager
{
    public class UserRegistration
    {
        public static string Fullname;
        public static string Email;
        public static string PhoneNumber;
        public static string BestColor;

        // getting the users details
        public static string EnrollUser()
        {
            // Console.Write("\n--------------------------------------------------\n");
            // Console.Write("\n\nWelcome Esteem User :\n");
            System.Console.WriteLine("Enter your Fullname :");
            Fullname = Console.ReadLine();
            System.Console.WriteLine("Enter your Email:");
            Email = Console.ReadLine();
            System.Console.WriteLine("Enter your PhoneNumber:");
            PhoneNumber =Console.ReadLine();
            System.Console.WriteLine("What is your Best Color:");
            BestColor = Console.ReadLine();

            return $"{Fullname}, {Email}, {PhoneNumber} ,{BestColor}";
            // System.Console.WriteLine($"{Fullname}, {Email},{PhoneNumber} ,{BestColor}");
        }

        // public static void AddToQueue()
        // {
        //     UsersQueue<string> myQueue = new UsersQueue<string>();
        //     var name = myQueue.Enqueue(EnrollUser());
        //     // myQueue.Print();
        //     // System.Console.WriteLine(name);
        //     System.Console.WriteLine("lolade");
            

        //     FileManager.CreateFile();
        // }
        
    }
}