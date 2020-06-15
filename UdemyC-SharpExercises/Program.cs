using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

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

            //Console.WriteLine("Please enter a name");
            //string name = Console.ReadLine();
            //string name2 = " ";

            //if(name != null)
            //{
            //    Console.WriteLine($"{name} likes your post.");
            //    Console.WriteLine("Please enter a name");
            //    name2 = Console.ReadLine();

            //    Console.WriteLine($"{name} and {name2} like your post");
            //}

            //int count = 0;

            //while(name != null && name2 != null)
            //{
            //    Console.WriteLine("Please enter a name");
            //    string moreNames = Console.ReadLine();
            //    if (moreNames != null)
            //    {
            //        count = count + 1;
            //        Console.WriteLine($"{name}, {name2} and {count} others like your post");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            Program p = new Program();
            //p.Facebook();
            p.BackwardsName();
        }

        public List<string> Facebook()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Please enter your name");
            names.Add(Console.ReadLine());

            Console.WriteLine($"{names[0]} likes your post");
            
            return names;

        }

        public string BackwardsName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            string[] arrName = new string[name.Length];

            Array.Reverse(arrName);

            foreach(var letter in arrName)
            {
                Console.Write(letter + " ");
            }
            return name; 
        }
    }
}
