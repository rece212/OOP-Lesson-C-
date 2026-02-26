using System;
using System.Collections.Generic;
using System.Text;

namespace prjLesson2C_PROG6221
{
    class Dogs : Pets//Pet is the parents( aka BASE) and Dog is the child
    {
        private Boolean Ears=false;
        public Dogs(string name, string description, string breed,Boolean Ears) :
            base(name, description, breed, "Dog")
        {
            this.Ears=Ears;
        }

        public String ToString()
        {
            if (Ears == false)
            {
                return base.ToString() + "\nthey don't use their ears";
            }
            else
            {
                return base.ToString() + "\nHas ears and will come when called";
            }
           
            
        }
    }
}
