using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3
{
    class PersonHandler
    {

        public void SetAge(Person pers, int age) 
        {
            
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            
            int intheight = Convert.ToInt32(height);
            int intweight = Convert.ToInt32(weight);

            Person Pers1 = new Person();

            Pers1.Age = age;
            Pers1.FName = fname;
            Pers1.LName = lname;
            Pers1.Height = intheight;
            Pers1.Weight = intweight;
            return Pers1;

        }

    }
}
