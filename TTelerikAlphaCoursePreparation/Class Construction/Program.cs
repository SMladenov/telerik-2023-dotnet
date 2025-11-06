using System;

namespace Class_Construction
{
    public class Person //public - access modifier, Person - name
    {
        private bool isAlive; //Field

        public Person(string name, bool isAlive) //Constructor
        {
            this.Name = name;
            this.isAlive = isAlive;
        }

        public string Name { get; set; } //Property

        public void SayName() //Method
        {
            Console.WriteLine($"My name is {this.Name}");
        }
    }

    //Access Modifiers - who can access what, restrict the access to them from outer sources, supports the OOP principle "encapsulation"
    //can be public, private (v ramkite na classa), internal (default top level for Class accessible from the current assembly, the current VS project), protected
    //word "this" refers to the current object in the Class

    //Constructor - basically tova e pak method, koito nqma otpred void ili return type, izvikva se ot obekt v naprimer Main Method-a
    //compile-time and runtime - 

    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Pesho");

            person.name;
        }
    }
}
