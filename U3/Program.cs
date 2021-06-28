using System;

namespace U3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  Person Person1 = new Person();

                PersonHandler P1 = new();
                Person P2 = P1.CreatePerson(30,"Per","Persson",175,75);
                Console.WriteLine(P2.Age);

               // int age, string fname, string lname, double height, double weight
                // Console.WriteLine("Hello World!");
                //Console.WriteLine(Person1.Age);
            }
            catch (Exception)
            {

                throw new ArgumentException("failed!");
            }


            Horse Palle = new(5, 4, 8, 10);

            string pallesound = Palle.DoSound("Nehheee");     //DoSound("Nehheee");
            Console.WriteLine(pallesound);


        }

       
        
    }
 

}



