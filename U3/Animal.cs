using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3
{
    public abstract class Animal
    {
        public Animal(int name, int weight, int Age)
        { }
        public int Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }


        public string DoSound(string sound)
        {
            string Sound = sound;
            Console.WriteLine($"sounds like: {sound}");
            return sound;
        }
    }
    public class Zoo 
    {
        
        //Horse Palle = new(5,4,8,10);

        //Animal pallesound = Palle.DoSound("ne");     //DoSound("Nehheee");

    }

    //public interface Person
    //{
    //    string Talk(string sentence);
    //}




}
