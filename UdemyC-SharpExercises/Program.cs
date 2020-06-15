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
            Program p = new Program();
            //p.Facebook();
            //p.Facebook2();
            //p.BackwardsName();
            //p.FiveUniqueNumbers();
            p.ListOfFive();
        }


        public void Facebook2()
        {
            Console.WriteLine("Please enter a name");
            string name = Console.ReadLine();
            string name2 = " ";

            if (name != null)
            {
                Console.WriteLine($"{name} likes your post.");
                Console.WriteLine("Please enter a name");
                name2 = Console.ReadLine();

                Console.WriteLine($"{name} and {name2} like your post");
            }

            int count = 0;

            while (name != null && name2 != null)
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
        public void Facebook()
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter your name");
                string input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else
                    names.Add(input);

                if (names.Count == 2)
                {
                    Console.WriteLine($"{names[0]} and {names[1]} like your post");
                }
                else if (names.Count == 1)
                {
                    Console.WriteLine($"{names[0]} likes your post");
                }
                else if (names.Count > 2)
                {
                    Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
                }
                else
                    Console.WriteLine();

            }

        }

        /// <summary>
        /// Ask the user to input their name; greet them with their name; return their name reversed.
        /// </summary>
        public void BackwardsName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            char[] arrName = name.ToCharArray();
            
            Console.WriteLine("Hi! Nice to meet you ");

            foreach(char c in arrName)
            {
                Console.WriteLine($"{c}");
            }


            Array.Reverse(arrName);

            Console.WriteLine("Your name in reverse is: ");
            foreach(char letter in arrName)
            {
               Console.WriteLine("{0}", letter);
            }
            Console.WriteLine(); 
        }

        public List<int> FiveUniqueNumbers()
        {
            List<int> inputList = new List<int>();

            while(inputList.Count < 5)
            {
                Console.WriteLine("Please enter a number");
                //string number = Console.ReadLine();
                int number = Convert.ToInt32(Console.ReadLine());

                if (inputList.Contains(number))
                {
                    Console.WriteLine("Sorry, please choose a number you have not previously chosen");
                }
                else
                {
                    inputList.Add(number);
                    inputList.Sort();
                }
            }

            foreach (int i in inputList)
            {
                Console.WriteLine(i);
            }
                return inputList;
        }
    
        public void ListOfFive()
        {
            List<int> userList = new List<int>();
            Console.WriteLine("Please enter a list of numbers separated by commas");
            string inputList = Console.ReadLine();
            inputList.Split();
            Console.WriteLine($"your split list is: {inputList}");

            foreach(int i in inputList)
            {
                userList.Add(i);
                Console.WriteLine($"i'm in the foreach loop mom! {i}");
            }

            if(userList.Count >= 5)
            {
                userList.Sort();
                Console.WriteLine($"The smallest three values are {userList[0]}, {userList[1]}, {userList[2]}.");
            }
            else if (userList.Count < 5)
            {
                Console.WriteLine("Please enter a longer list next time");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

        }
    }
}
