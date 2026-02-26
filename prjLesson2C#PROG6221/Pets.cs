using System;
using System.Collections.Generic;
using System.Text;

namespace prjLesson2C_PROG6221
{
    public class Pets// Parents
    {
        private string Name;
        private string Description;
        private string Breed;
        private string Type;

        public Pets(string name,
            string description, string breed,
            string type)
        {
            Name = name;
            Description = description;
            Breed = breed;
            Type = type;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Type: {Type}");
        }
        public string ToString()
        {
            return "Name of your animal is :" + Name +
                "\nDescription " + Description + "\nBreed " + Breed
            +"\nType " + Type;
        }
    }
}
