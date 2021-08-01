using System;
using System.Collections.Generic;
using QueueManagement;
using UserFileManager;

namespace UserAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // string begin =Console.ReadLine();

            bool startApp = true;
            while (startApp)
            {
                Console.Write("\n\nWelcome Esteem User :\n");

                Console.WriteLine("Enter: ");
                Console.WriteLine("1 to Enroll a User");
                Console.WriteLine("2 to Remove a User");
                Console.WriteLine("3 to Get all User Info");
                Console.WriteLine("4 to clear the screen");
                Console.WriteLine("0 to exit");
                UsersQueue<string> myQueue = new UsersQueue<string>();
                string begin =Console.ReadLine();
                
                switch (begin)
                {
                    case "1":
                        try
                        {
                            FileManager.CreateFile();// create the user details file, add details to file as it enrolls the user 

                            // UsersQueue<string> myQueue = new UsersQueue<string>();
                            // myQueue.Enqueue(FileManager.GetUserDetails());//expecting to be able to add the content of the file into the queue
                            // myQueue.Print();

                            // myQueue.Enqueue(FileManager.CreateFile());//expected to read the user details added to read the
                            // myQueue.Enqueue(UserRegistration.EnrollUser());// expected to enqueue the user as they enroll


                            // myQueue.Print();
                            Console.ReadKey();
                            Console.Clear();

                        }
                        
                        catch (Exception e) 
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        try
                        {
                            // UsersQueue<string> myQueue = new UsersQueue<string>();
                            myQueue.Dequeue();
                            // myQueue.Print();
                            Console.ReadKey();
                            // Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "3":
                        try
                        {
                            FileManager.GetUserDetails(); // get user details from file

                            // myQueue.Print();// expected user detail should output user details from the queue
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    
                    case "4":
                        Console.Clear();
                        break;
                    case "0":
                        startApp = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
