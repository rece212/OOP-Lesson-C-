using System;
using System.Collections.Generic;
using System.Text;

namespace prjLesson2C_PROG6221
{
    public class Cats : Pets
    {
        private String colour;
        public Cats(string name, string description, string breed,String Colour) 
            : base(name, description, breed, "Cats")
        {
            this.colour = Colour;
        }

        public String ToString()
        {
            return base.ToString() +"\nThe colour of our cat is "+this.colour;
        }

    }
}
