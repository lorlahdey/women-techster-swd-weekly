using System;
using System.IO;
// using System.Collections.Generic;
// using QueueManagement;
// using UserFileManager;


namespace UserFileManager
{
    public class FileManager
    {
        //creating the text file to write to while making it globally accessible field
        public static string path = @"../UserFileManager/UserDetails.txt";
        public static void CreateFile()
        {
           //creating the text file to write to
            // string path = @"../UserFileManager/UserDetails.txt";
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);

            }


            // writting to the created file
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                //trying to let the created file append the items enqueued
                // UsersQueue<string> myQueue = new UsersQueue<string>();
                // var name = myQueue.Enqueue(UserRegistration.EnrollUser());
                // streamWriter.WriteLine(name);
                
                // expected to print/store the enrolled user on the queue to the user detail file
                // streamWriter.WriteLine(myQueue.Print());

                // this adds the user details upon enrolling the user
                streamWriter.WriteLine(UserRegistration.EnrollUser());
            }

        }

        //reading and getting the datas in the vreated file
        public static void GetUserDetails()
        {
            using (StreamReader streamReader = File.OpenText(path))
            {
                var read = streamReader.ReadToEnd();
                read = read.TrimEnd();
                var users = read.Split(Environment.NewLine);
                var last = users[^1];
                foreach (var item in users)
                {
                    var user = item.Split(',');
                     System.Console.WriteLine(item);
                    
                }
            }
        }
    }
}