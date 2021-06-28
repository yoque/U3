using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3
{
    public class Wolf : Animal
    {

        public int Packpeckingorder { get; set; }
        public Wolf(int name, int weight, int Age, int packpeckingorder) : base(name, weight, Age)
        {
            int Packpeckingorder = packpeckingorder;



        }


    }
}
