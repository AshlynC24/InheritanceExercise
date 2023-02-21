using System;
using System.Collections;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.HowManyLegs = 2;
            myBird.SquakSound = "Caack Caack";
            myBird.Breed = "Pelican";
            myBird.CanFly = true;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var myReptile = new Reptile();
            myReptile.HowManySpotsOrScale = 200;
            myReptile.Breed = "Lizzard";
            myReptile.MakesNoise = "Ribit Ribit";

            var myAnimals = new List<Animal>() { myBird, myReptile };

            foreach(var Animal in myAnimals)// we do a foreach loop to go through each member of our classes that we specified
            {
                Console.WriteLine("=========================");
             
                Console.WriteLine($"Age:{Animal.Age}");
                Console.WriteLine($"Type of Animal: {Animal.Breed}");


            }
        }
    }
}
