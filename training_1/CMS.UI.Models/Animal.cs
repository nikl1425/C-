using System;

namespace training_1.CMS.UI.Models

// Showcasing polymorphism
//Polymorphism = a class can inherit multiple method...

{
    public class Animal
    {
        //The virtual keyword makes so the method can be overwrite
        public virtual void animalSound()
        {
            Console.WriteLine("animal sound");
        }
    }
}