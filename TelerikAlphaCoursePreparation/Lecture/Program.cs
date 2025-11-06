using System;

namespace Lecture
{
    internal class Program
    {


        //class
        //Class can have state and can (behavior)
        class Person
        {
            //Model the person
            public string name; //State of the object or Fields
            public int age; //State of the object or Fields
            int phone; //State of the object or Fields

            //Behavior
            void Sayname() { Console.WriteLine($"Hey, I am {name} and i am {age} years old."); }
            void SayContacts() { Console.WriteLine($"You can contact me at {phone}"); }
            //Behavior
            //Method
            public string Speak()
            {
                return $"Hello I'm {name}";
            }

        }

        static void Main(string[] args)
        {

            //Syntax for Object
            var point = new

            {
                x = 10,
                y = 15
            };

            Console.WriteLine($"{point.x}, {point.y}");

            //Obejct without Shablon, without Class, they stay anonymous
            var person1 = new

            {
                name = "John",
                age = 30
            };
            Console.WriteLine($"{person1.name}, {person1.age}");

            //Second syntaxis for Creating Object based on Class (Person) in this scenario
            var person2 = new Person

            {
                name = "Pesho",
                age = 3
            };
            Console.WriteLine($"{person2.name}, {person2.age}");

            //Creating Object based on Class (Person) in this scenario
            var person3 = new Person();
            {
                person3.name = "Titi";
                person3.age = 32;
                person3.Speak();
            }
            Console.WriteLine($"{person3.name}, {person3.age}, {person3.Speak()}");
        }
    }
}
