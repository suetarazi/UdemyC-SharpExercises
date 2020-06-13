using Microsoft.VisualBasic;
using System;

namespace UdemyC_SharpExercises
{
    class Program
    {
        //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a name");
            string name = Console.ReadLine();
            string name2 = " ";

            if(name != null)
            {
                Console.WriteLine($"{name} likes your post.");
                Console.WriteLine("Please enter a name");
                name2 = Console.ReadLine();

                Console.WriteLine($"{name} and {name2} like your post");
            }
            
            int count = 0;
            
            while(name != null && name2 != null)
            {
                Console.WriteLine("Please enter a name");
                string moreNames = Console.ReadLine();
                if (moreNames != null)
                {
                    count = count + 1;
                    Console.WriteLine($"{name}, {name2} and {count} others like your post");
                }
                else
                {
                    break;
                }
            }

        }
    }
}
