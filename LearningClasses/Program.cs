using System;
using System.Linq;
using System.Reflection;

namespace LearningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings from datorium!");
            Console.WriteLine("This is  the entry point");
            //creating first person as a human
            Human person = new Human();
            person.Name = "Genghis";
            person.Surname = "Khan";
            person.Age = (decimal)25.3;
            person.Height = (decimal)176;

            person.Introduce();
            person.Talk();
            person.Say("Now i will use my brain to calculate");
            person.CalculateSum(11, 123);
            person.Calculate(6, "*", 11);
            
            //creating another person as a human
            Human anotherPerson = new Human();
            anotherPerson.Name = "Nick";
            anotherPerson.Surname = "Bright";

            anotherPerson.Introduce();
            anotherPerson.Talk();
            anotherPerson.Say("Bing Bong commit die");
            anotherPerson.CalculateSum(11, 23);

        }
    }

    class Human
    {
        public string Name;
        public string Surname;
        public decimal Age;
        public decimal Height;

        public void Talk()
        {
            Console.WriteLine("I am talking...");
        }

        public void Say(string message)
        {
            Console.WriteLine(message);
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + this.Name);
        }

        public void CalculateSum(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine(firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + sum.ToString());
        }

        public void Calculate(double firstNumber, string operation,  double secondNumber)
        {
            double answer;
            if(operation == "+")
            {
                answer = firstNumber + secondNumber;
            }
            else if(operation == "-")
            {
                answer = firstNumber - secondNumber;
            }
            else if(operation == "*")
            {
                answer = firstNumber * secondNumber;
            }
            else if(operation == "/")
            {
                answer = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Unknown operation.");
                return;
            }

            Console.WriteLine(firstNumber.ToString() + operation + secondNumber.ToString() + "=" + answer.ToString());
        }
    }
}
