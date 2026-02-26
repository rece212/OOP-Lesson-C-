using System;
using System.Collections.Generic;
using System.Text;

namespace prjLesson2C_PROG6221
{
    public class Brids : Pets
    {
        private Boolean Bite=false;
        private String colour;
        public Brids(string name, string description, string breed,Boolean Bite, 
            String Colour) : 
            base(name, description, breed, "Bird")
        {
            this.Bite=Bite;
            this.colour=Colour;
        }

        public String ToString()
        {
            String BiteTips = "";
            if (this.Bite == true)
            {
                BiteTips = "Your hands will be covered in blll";
            }
            else
            {
                BiteTips = "They do not bite";
            }


            return base.ToString() + "\nThe colour of our bird is " + this.colour +
                "\n When it comes to biting : " + BiteTips;
        }
    }
}
