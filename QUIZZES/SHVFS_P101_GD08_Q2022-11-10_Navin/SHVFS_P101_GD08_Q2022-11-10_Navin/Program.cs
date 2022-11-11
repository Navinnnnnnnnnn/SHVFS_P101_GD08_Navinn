using System;
using System.Security.Cryptography.X509Certificates;

namespace guessing
{

    class guess
    {

        public static void Main(string[] args)
        {
            string name, reply;
            int i = 0;
            

            string[] words = { "apple", "banana", "cat", "dog", "eye", "food" };
            Random rand = new Random();
            int word = rand.Next(words.Length);
            Console.WriteLine("Hi! Welcome to the word guessing game!\n" +
                                  "Now,Enter your name pleeeeeeeeeeease!");
           
            name = Console.ReadLine();
           
            Console.WriteLine($"Hi!{name},nice to meet you!Now,Let's start the game!");
         
            Console.WriteLine("The words are apple, banana, cat, dog, eye, food.");

            reply = Console.ReadLine();
     
                while (reply != words[word])
                {
                    Console.WriteLine("Wrong");
                    Console.WriteLine("Try again");
                    reply = Console.ReadLine();
                    Console.Clear();
                    i = i + 1;
                   
                    
                }
            Console.WriteLine("Nice guessing!You're awesome!!!!!!!!!\n" +


                $"   You have tried  {i}  times! ");   
               
             
                

            





        }
    }
}

   
