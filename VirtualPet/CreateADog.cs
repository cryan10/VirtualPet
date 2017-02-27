using System;

public class CreateADog
{
    //Creation of fields
    string name;
    string breed;
    string coloring;
    int weight;
    string height;
    int age;

    //Creation of properties

    //Creation of dog's name property
    public string DogName {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
    
    //Creation of dog's breed property
    public string DogBreed {
        get
        {
            return breed;
        }

        set
        {
            breed = value;
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

    //creation of dog's weight property
    public int DogWeight
    {
        get
        {
            return weight;
        }

        set
        {
            weight = value;
            if (weight <= 0)
            {
                weight = 1;
            }
        }
    }

    //Creation of dog's height property
    public string DogHeight
    {
        get
        {
            return height;
        }

        set
        {
            height = value;
            if (height != "little" || height != "big")
            {
                height = "little";
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

}

//need 3 methods (eat, sleep, waste, playfetch, snuggle)

public string BuildADog()
{
    if (height == "little")
    {
        Console.WriteLine("This is a cute little pup! Here's what they look like: ");

        //figure out how to put picture thing in code.
    }

    else
    {
        Console.WriteLine("Wow, what a big dog! Here's what they look like: ");
        //Needs picture
    }
}

