using System;

public class CreateADog
{
    //Creation of fields
    string name;
    string coloring;
    string size;
    int age;
    int status;

    //Creation of properties
    //Creation of dog's name property
    public string DogName
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    //Creation of dog's coloring property
    public string DogColoring
    {
        get
        {
            return coloring;
        }

        set
        {
            coloring = value;
        }
    }


    //Creation of dog's size property
    public string DogSize
    {
        get
        {
            return size;
        }

        set
        {
            size = value;
            if (size != "little" || size != "big")
            {
                size = "little";
            }
        }
    }

    //Creation of dog's age property
    public int DogAge
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
            if (age <= 0)
            {
                age = 1;
            }
        }
    }


    //Creation of dog's health/need status property
    public int Status
    {
        get
        {
            return status;
        }

        set
        {
            status = value;
        }
    }



    //creation of small dog
    public string BuildASmallDog()
    {
        //picture of dog
        Console.WriteLine("This is a cute little pup! Here's what they look like: ");
        Console.WriteLine("    .--.__  ");
        Console.WriteLine("    | ; '__P  ");
        Console.WriteLine("    '.; \\");
        Console.WriteLine("     | .)  ");
        Console.WriteLine("     ';.L  ");

        return size;
    }
    
    //creation of big dog
    public string BuildABigDog()
    {
        Console.WriteLine("Wow, what a big dog! Here's what they look like: ");

        //picture of dog
        Console.WriteLine("   _ ");
        Console.WriteLine("  _V.- o ");
        Console.WriteLine(" / |`-' ");
        Console.WriteLine("(7_\\\")");

        return size;
    }


    //asking dog a yes or no question to bond
    public void GettingToKnowYou()
    {
        string question = Console.ReadLine();
        int questionLength = question.Length;

        if (questionLength <= 20 && questionLength > 1)
            {
                Console.WriteLine("Woof woof! (Yes!)");
                return;
            }

        else
            {
                Console.WriteLine("Woof. (Nope.)");
                return;
            }
            
        }


    //checking to see if dog needs anything to stay healthy and happy
    public void TakeCareOfDog()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 80);

        if (randomNumber < 20)
        {
            Console.WriteLine("Your dog is hungry! Would you like to feed it? Type \"yes\" or \"no\"");
            string answer = Console.ReadLine();
            answer.ToLower();

            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("You fed them! Dog's current status: :)");
            }

            else
            {
                Console.WriteLine("I'm sorry, but that is not the way to treat a pet. We have called the animal shelter to find them a new owner.");
            }

        }

        else if (randomNumber < 40)
        {
            Console.WriteLine("Your dog needs to use the bathroom! Would you like to take them outside? Type \"yes\" or \"no\"");
            string answer = Console.ReadLine();
            answer.ToLower();

            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("They went to the bathroom. Dog's current status: :)");
            }

            else
            {
                Console.WriteLine("I'm sorry, but that is not the way to treat a pet. We have called the animal shelter to find them a new owner.");
            }
        }

        else if (randomNumber < 60)
        {
            Console.WriteLine("Your dog wants to play! Would you like to play with them? Type \"yes\" or \"no\"");
            string answer = Console.ReadLine();
            answer.ToLower();

            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("Time to play! Dog's current status: :)");
            }

            else
            {
                Console.WriteLine("I'm sorry, but that is not the way to treat a pet. We have called the animal shelter to find them a new owner.");
            }
        }

        else
        {
            Console.WriteLine("Looks like your dog is happy and healthy at this time!");
        }

        }

    }