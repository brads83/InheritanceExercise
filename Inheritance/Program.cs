using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            // Create a class Animal
            // Create a class Bird
            // Create a class Reptile

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird = new Bird();
            bird.Feathers = "Brown";
            bird.Wings = "Large";
            bird.Beak = "Sharp";
            bird.Call = "Shrieks";
            Console.WriteLine($"This bird is {bird.Feathers} with {bird.Wings} wings, a {bird.Beak} beak, and {bird.Call}! ");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var reptile = new Reptile();
            reptile.Scales = "Horny";
            reptile.Eggs = "Twenty or more";
            reptile.Shell = "No";
            reptile.ColdBlooded = "Yes";
            Console.WriteLine("Characteristics of an alligator:");
            Console.WriteLine($"Scales: {reptile.Scales} Eggs: {reptile.Eggs} Shell: {reptile.Shell} ColdBlooded: {reptile.ColdBlooded} ");
        }
    }
}
