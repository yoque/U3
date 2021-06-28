using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3
{
    class Wolfman : Wolf   // : IPerson
    {
        public int Packpeckingorder { get; set; }
        public Wolfman(int name, int weight, int Age, int packpeckingorder) : base(name, weight, Age, packpeckingorder)
        {
            int Packpeckingorder = packpeckingorder;



        }
    }
}
