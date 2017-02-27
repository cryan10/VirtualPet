using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating dog

            Console.WriteLine("Everyone loves a dog! Let's create and care for your dream dog!");

            CreateADog dog = new CreateADog();

            Console.WriteLine("First, what do you want to name your dog?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are they?");
            string age = Console.ReadLine();

            Console.WriteLine("Tell me what your dog looks like. What color is your dog?");
            string color = Console.ReadLine();

            Console.WriteLine("Is your dog large or teeny tiny? Please type \"big\" or \"little\" to indicate their size");
               string size = Console.ReadLine();

            size.ToLower();

            Console.WriteLine("Meet {0}!", name);

            if (size == "big")
            {
                dog.BuildABigDog();
            }

            else
            {
                dog.BuildASmallDog();
            }

            Console.WriteLine();
            Console.WriteLine("Remember, {0} is {1} and is {2} years old.", name, color, age);

           
            
            //Asking dog a question
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now that you know what your dog looks like, it's time to bond! Ask your dog a yes or no question: ");
            dog.GettingToKnowYou();



            //Asking dog's status
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Let's see what your dog needs. Please type \"status\" ");
            string status = Console.ReadLine();
            status.ToLower();

            if (status == "status")
            {
                dog.TakeCareOfDog();
            }

            else
            {
                Console.WriteLine("I don't understand what you're saying. Please try again and enter \"status\" to check on your dog's needs");
                status = Console.ReadLine();
                status.ToLower();
                    if (status == "status")
                {
                    dog.TakeCareOfDog();
                }
                else
                {
                    Console.WriteLine("You aren't following directions. Neglect has killed your dog, you terrible pet owner.");
                    return;
                }
            }



        }
    }
}
