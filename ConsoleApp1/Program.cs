using System;
using CMS.UI.Models;
using CMS.UI.Models.obj;
using training_1.CMS.UI.Models;
using System.IO; //includes file write read


//namespace = start of class
namespace ConsoleApp1
{
    //naming class
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        //start method main:
        static void Main(string[] args)
        {
            student student = new student();

            Console.WriteLine("hello world");

            Console.WriteLine("hello niklas");

            var a = 5;
            var b = 6;

            Swap(ref a, ref b);

            Console.WriteLine($"we swap this function a = {a} and b = {b}");


            // fast way to add values because of constructors.
            Car ford = new Car("ford", 1992, "red");
            Car audi = new Car("audi", 2000, "blue");

            audi.Model = "ford";

            Console.WriteLine("the color of ford is: " + ford.color);
            Console.WriteLine("the model of audi is " + audi.Model);

            course math = new course("Matematik", 10);

            Console.WriteLine("the ects of " + math.courseName + " and the ects is: " + math.courseECTS);

            // We define the class "course" property here and print it. 
            math.getRandomString = "hej med jer !";
            Console.WriteLine(math.getRandomString);

            Console.WriteLine(audi.Model + " and " + audi.brand);

            //Polymorpism:
            //hi
            Animal myAnimal = new Animal();
            Animal myPig = new pig();

            //This showcases that the pig class also can use animal methods


            myAnimal.animalSound();
            myPig.animalSound();


            //Usage of our abstract and jetplane classes
            JetPlane myJet = new JetPlane();
            myJet.MotorStart();
            myJet.StopMotor();
            myJet.Wing();

            //Usage of Enums
            EnumClass myvar = EnumClass.Low;
            Console.WriteLine(myvar);
            
            //write to text
            string writeText = "hello World";
            for (int i = 0; i < writeText.Length; i++)
            {
                System.IO.File.WriteAllText(@"C:\Users\45535\Desktop\RAWDATA\C#\training_1\training_1\CMS.UI.Models\Data\Text1.txt", writeText);
                string readLine =
                    File.ReadAllText(
                        @"C:\Users\45535\Desktop\RAWDATA\C#\training_1\training_1\CMS.UI.Models\Data\Text1.txt");
                Console.WriteLine(readLine);
            }
            //try catch with exception
            try
            {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            //Adding numbers
            int x = 5;
            int y = 6;
            int sum = x + y;
            Console.WriteLine(sum); // Print the sum of x + y
        }
    }
}
