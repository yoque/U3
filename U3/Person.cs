using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;


        public int Age
        {
            get => age;
            set
            {
                if (value > 0) age = value;
                else
                    throw new ArgumentException("age must not be blank");
            }
        }  //throw new ArgumentException("");

        public string FName
        {
            get => fName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length > 1 & value.Length < 11)
                        fName = value;
                }

                else
                    throw new ArgumentException("fName must not be blank");
            }
        }


        public string LName
        {
            get => lName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length > 2 & value.Length < 16)
                        lName = value;
                }

                else
                    throw new ArgumentException("lName must not be blank");
            }

        }


       // public int Height { get; set; }
        //public int Weight { get; set; }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { height = value; }
        }
    }
}
