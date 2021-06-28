namespace U3
{
    public class Horse : Animal  
    {
        //public int Name { get; set; }
        //public int Weight { get; set; }
        //public int Age { get; set; }
        public int Speed { get; set; }
        public Horse (int name, int weight, int Age,int speed) : base(name, weight, Age)
        {
            int Speed = speed;



        }
    }
    






}
