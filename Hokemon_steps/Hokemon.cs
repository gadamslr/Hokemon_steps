using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_steps
{
    class Hokemon
    {
        // VARIABLES a.k.a ATTRIBUTES inside a class can also be refered to as FIELDS
        private string name; // field
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defence;

        // public, private are ACCESS MODIFIERS, which are used to set the access level/visibility for classes, fields, methods and properties.

        public string Name // property is a combination of a field and method notice field name 
        {
            get { return name; }
            set { name = value; }
        }
        public int Health // property is a combination of a field and method notice field name 
        {
            get { return health; }
            set { health = value; }
        }
        public Hokemon() // This is a CONSTRUCTOR method for a class in C#
        {
            provide_name();
            max_health = random_int_generator(50, 100);
            health = random_int_generator(50, 100);
            attack = random_int_generator(50, 100);
            speed = random_int_generator(50, 100);
            defence = random_int_generator(50, 100);
        }
        public void get_details()
        {
            Console.WriteLine("Name: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefense: {5}\n\n", name, health, max_health, attack, speed, defence);
        }

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            Name = Console.ReadLine();
        }

        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

        public void about() //Provides some detail about a Hokemon
        {
            Console.WriteLine("I am a mystical species known as Hokemon.");
        }
    }
}
